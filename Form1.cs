using Npgsql;
using System.Configuration;
using System.Data.Common;

namespace ADO_NET_Coffee_Magazine
{
    public partial class Form1 : Form
    {
        private String dbConnString = @"server=aspirantdrago.ru:6543;userid=postgres;password=koshka800;database=CoffeeMagazine";
        private DbProviderFactory dpf;
        private DbConnection conn;

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
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn?.Close();
        }
    }
}
