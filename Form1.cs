using Npgsql;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace ADO_NET_Coffee_Magazine
{
    public partial class Form1 : Form
    {
        private static String dbConnString = @"server=aspirantdrago.ru:6543;userid=postgres;password=koshka800;database=CoffeeMagazine";
        private static String query = @"
            SELECT
                coffees.id,
                coffees.name,
                countries.name AS country,
                types.name AS type,
                description,
                weight,
                ""costPrice""
            FROM coffees
            LEFT JOIN countries
                ON countries.id = coffees.""countryId""
            LEFT JOIN types
                ON types.id = coffees.""typeId"";
            --------------------------------------------------------------------------------------------
            SELECT id, name FROM Countries;
            --------------------------------------------------------------------------------------------
            SELECT
                Types.id AS id, 
                Types.name as name,
                COUNT(coffees.id) AS ""coffeeCount""   
            FROM Types
            LEFT JOIN coffees
                ON coffees.""typeId"" = Types.id
            GROUP BY Types.id
            ORDER BY Types.id;
            --------------------------------------------------------------------------------------------
            WITH maxCostPrice AS (
	            SELECT
		                MAX(""costPrice"") as ""Value""
	            FROM coffees
            ), minCostPrice AS (
	            SELECT
		                MIN(""costPrice"") as ""Value""
	            FROM coffees
            ), avgCostPrice AS (
	            SELECT
		                SUM(""costPrice"") / COUNT(*) as ""Value""
	            FROM coffees
            )
        
            SELECT
	            'Minimum cost price' AS ""Property"",
	            ""Value"", COUNT(*) AS ""Count""
            FROM minCostPrice
            JOIN coffees
	            ON minCostPrice.""Value"" = coffees.""costPrice""
            GROUP BY ""Value""

            UNION ALL

            SELECT
	            'Maximum cost price', ""Value"", COUNT(*)
            FROM maxCostPrice
            JOIN coffees
	            ON ""maxcostprice"".""Value"" = coffees.""costPrice""
            GROUP BY ""Value""

            UNION ALL

            SELECT
	            'Medium cost price', ""Value"", 0
            FROM avgCostPrice
        ";

        private DbProviderFactory dpf;
        private DbConnection conn;
        private DbDataAdapter adapter;
        private DbCommand cmd;
        private DbCommandBuilder cmdBilder;

        private DataViewManager dvm;

        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbProviderFactories.RegisterFactory("Npgsql", NpgsqlFactory.Instance);
            dpf = DbProviderFactories.GetFactory("Npgsql");
            conn = dpf.CreateConnection();
            conn.ConnectionString = dbConnString;

            cmd = conn.CreateCommand();
            cmd.CommandText = query;

            adapter = dpf.CreateDataAdapter();
            adapter.SelectCommand = cmd;

            var coffeeTM = adapter.TableMappings.Add("Table", "Coffees");
            coffeeTM.ColumnMappings.Add("id", "№");
            coffeeTM.ColumnMappings.Add("name", "Сорт");
            coffeeTM.ColumnMappings.Add("country", "Страна происхождения");
            coffeeTM.ColumnMappings.Add("type", "Вид кофе");
            coffeeTM.ColumnMappings.Add("description", "Описание");
            coffeeTM.ColumnMappings.Add("weight", "Количество грамм");
            coffeeTM.ColumnMappings.Add("costPrice", "Себестоимость");

            var countryTM = adapter.TableMappings.Add("Table1", "Countries");
            countryTM.ColumnMappings.Add("id", "№");
            countryTM.ColumnMappings.Add("name", "Страна");

            var typeTM = adapter.TableMappings.Add("Table2", "Types");
            typeTM.ColumnMappings.Add("id", "№");
            typeTM.ColumnMappings.Add("name", "Вид кофе");
            typeTM.ColumnMappings.Add("coffeeCount", "Количество сортов");

            adapter.TableMappings.Add("Table3", "CostPriceStats");

            cmdBilder = dpf.CreateCommandBuilder();
            cmdBilder.DataAdapter = adapter;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn?.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = null;
            dataGridViewArabica.DataSource = null;
            dataGridViewRobusta.DataSource = null;
            dataGridViewBlends.DataSource = null;
            dataGridViewEnding.DataSource = null;
            dataGridViewTypes.DataSource = null;
            textMinCostPrice.Clear();
            textMaxCostPrice.Clear();
            textMiddleCostPrice.Clear();
            textCountWithMinCostPrice.Clear();
            textCountWithMaxCostPrice.Clear();
            try
            {
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewAll.DataSource = ds.Tables["Coffees"];
                dataGridViewTypes.DataSource = ds.Tables["Types"];

                dvm = new DataViewManager(ds);

                dvm.DataViewSettings["Coffees"].RowFilter = "[Вид кофе] = 'арабика'";
                dataGridViewArabica.DataSource = dvm.CreateDataView(ds.Tables["Coffees"]);

                dvm.DataViewSettings["Coffees"].RowFilter = "[Вид кофе] = 'робуста'";
                dataGridViewRobusta.DataSource = dvm.CreateDataView(ds.Tables["Coffees"]);

                dvm.DataViewSettings["Coffees"].RowFilter = "[Вид кофе] = 'купаж/бленд'";
                dataGridViewBlends.DataSource = dvm.CreateDataView(ds.Tables["Coffees"]);

                dvm.DataViewSettings["Coffees"].RowFilter = "[Количество грамм] <= 200";
                dataGridViewEnding.DataSource = dvm.CreateDataView(ds.Tables["Coffees"]);

                textMinCostPrice.Text = ds.Tables["CostPriceStats"].Rows[0]["Value"].ToString();
                textMaxCostPrice.Text = ds.Tables["CostPriceStats"].Rows[1]["Value"].ToString();
                textMiddleCostPrice.Text = ds.Tables["CostPriceStats"].Rows[2]["Value"].ToString();
                textCountWithMinCostPrice.Text = ds.Tables["CostPriceStats"].Rows[0]["Count"].ToString();
                textCountWithMaxCostPrice.Text = ds.Tables["CostPriceStats"].Rows[1]["Count"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
