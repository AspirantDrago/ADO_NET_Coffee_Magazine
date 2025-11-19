namespace ADO_NET_Coffee_Magazine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewAll = new DataGridView();
            tabPage2 = new TabPage();
            dataGridViewTypes = new DataGridView();
            tabPage3 = new TabPage();
            dataGridViewArabica = new DataGridView();
            tabPage4 = new TabPage();
            dataGridViewRobusta = new DataGridView();
            tabPage5 = new TabPage();
            dataGridViewBlends = new DataGridView();
            tabPage6 = new TabPage();
            dataGridViewEnding = new DataGridView();
            tabPage7 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            textCountWithMaxCostPrice = new TextBox();
            textCountWithMinCostPrice = new TextBox();
            textMiddleCostPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textMaxCostPrice = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textMinCostPrice = new TextBox();
            btnConnect = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArabica).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRobusta).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBlends).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnding).BeginInit();
            tabPage7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1011, 452);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewAll);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(849, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Все виды";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Dock = DockStyle.Fill;
            dataGridViewAll.Location = new Point(3, 4);
            dataGridViewAll.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.RowHeadersWidth = 51;
            dataGridViewAll.Size = new Size(843, 411);
            dataGridViewAll.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewTypes);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(849, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сорта";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(3, 4);
            dataGridViewTypes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.RowHeadersWidth = 51;
            dataGridViewTypes.Size = new Size(843, 411);
            dataGridViewTypes.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewArabica);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(849, 419);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Арабика";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArabica
            // 
            dataGridViewArabica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArabica.Dock = DockStyle.Fill;
            dataGridViewArabica.Location = new Point(0, 0);
            dataGridViewArabica.Margin = new Padding(3, 4, 3, 4);
            dataGridViewArabica.Name = "dataGridViewArabica";
            dataGridViewArabica.RowHeadersWidth = 51;
            dataGridViewArabica.Size = new Size(849, 419);
            dataGridViewArabica.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridViewRobusta);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(849, 419);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Робуста";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRobusta
            // 
            dataGridViewRobusta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRobusta.Dock = DockStyle.Fill;
            dataGridViewRobusta.Location = new Point(0, 0);
            dataGridViewRobusta.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRobusta.Name = "dataGridViewRobusta";
            dataGridViewRobusta.RowHeadersWidth = 51;
            dataGridViewRobusta.Size = new Size(849, 419);
            dataGridViewRobusta.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridViewBlends);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(849, 419);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Купажи/бленды";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBlends
            // 
            dataGridViewBlends.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBlends.Dock = DockStyle.Fill;
            dataGridViewBlends.Location = new Point(0, 0);
            dataGridViewBlends.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBlends.Name = "dataGridViewBlends";
            dataGridViewBlends.RowHeadersWidth = 51;
            dataGridViewBlends.Size = new Size(849, 419);
            dataGridViewBlends.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dataGridViewEnding);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(849, 419);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Заканчиваются";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEnding
            // 
            dataGridViewEnding.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnding.Dock = DockStyle.Fill;
            dataGridViewEnding.Location = new Point(0, 0);
            dataGridViewEnding.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEnding.Name = "dataGridViewEnding";
            dataGridViewEnding.RowHeadersWidth = 51;
            dataGridViewEnding.Size = new Size(849, 419);
            dataGridViewEnding.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(tableLayoutPanel1);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(3, 4, 3, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1003, 419);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Статистика";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textCountWithMaxCostPrice, 1, 5);
            tableLayoutPanel1.Controls.Add(textCountWithMinCostPrice, 1, 4);
            tableLayoutPanel1.Controls.Add(textMiddleCostPrice, 1, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(textMaxCostPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(textMinCostPrice, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1003, 419);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textCountWithMaxCostPrice
            // 
            textCountWithMaxCostPrice.Dock = DockStyle.Top;
            textCountWithMaxCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textCountWithMaxCostPrice.Location = new Point(504, 193);
            textCountWithMaxCostPrice.Name = "textCountWithMaxCostPrice";
            textCountWithMaxCostPrice.ReadOnly = true;
            textCountWithMaxCostPrice.Size = new Size(496, 34);
            textCountWithMaxCostPrice.TabIndex = 9;
            textCountWithMaxCostPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // textCountWithMinCostPrice
            // 
            textCountWithMinCostPrice.Dock = DockStyle.Top;
            textCountWithMinCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textCountWithMinCostPrice.Location = new Point(504, 143);
            textCountWithMinCostPrice.Name = "textCountWithMinCostPrice";
            textCountWithMinCostPrice.ReadOnly = true;
            textCountWithMinCostPrice.Size = new Size(496, 34);
            textCountWithMinCostPrice.TabIndex = 8;
            textCountWithMinCostPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // textMiddleCostPrice
            // 
            textMiddleCostPrice.Dock = DockStyle.Top;
            textMiddleCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textMiddleCostPrice.Location = new Point(504, 103);
            textMiddleCostPrice.Name = "textMiddleCostPrice";
            textMiddleCostPrice.ReadOnly = true;
            textMiddleCostPrice.Size = new Size(496, 34);
            textMiddleCostPrice.TabIndex = 7;
            textMiddleCostPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(10, 190);
            label5.Name = "label5";
            label5.Size = new Size(488, 50);
            label5.TabIndex = 6;
            label5.Text = "Количество сортов кофе, у которых себестоимость равна максимальной себестоимости";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(10, 140);
            label4.Name = "label4";
            label4.Size = new Size(488, 50);
            label4.TabIndex = 5;
            label4.Text = "Количество сортов кофе, у которых себестоимость равна минимальной себестоимости";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(246, 100);
            label3.Name = "label3";
            label3.Size = new Size(252, 40);
            label3.TabIndex = 4;
            label3.Text = "Средняя себестоимость кофе";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textMaxCostPrice
            // 
            textMaxCostPrice.Dock = DockStyle.Top;
            textMaxCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textMaxCostPrice.Location = new Point(504, 63);
            textMaxCostPrice.Name = "textMaxCostPrice";
            textMaxCostPrice.ReadOnly = true;
            textMaxCostPrice.Size = new Size(496, 34);
            textMaxCostPrice.TabIndex = 3;
            textMaxCostPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(195, 60);
            label2.Name = "label2";
            label2.Size = new Size(303, 40);
            label2.TabIndex = 2;
            label2.Text = "Максимальная себестоимость кофе";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(201, 20);
            label1.Name = "label1";
            label1.Size = new Size(297, 40);
            label1.TabIndex = 0;
            label1.Text = "Минимальная себестоимость кофе";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textMinCostPrice
            // 
            textMinCostPrice.Dock = DockStyle.Top;
            textMinCostPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textMinCostPrice.Location = new Point(504, 23);
            textMinCostPrice.Name = "textMinCostPrice";
            textMinCostPrice.ReadOnly = true;
            textMinCostPrice.Size = new Size(496, 34);
            textMinCostPrice.TabIndex = 1;
            textMinCostPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConnect.Location = new Point(873, -1);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(133, 31);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Подключиться";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 452);
            Controls.Add(btnConnect);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Магазин Кофе";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArabica).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRobusta).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBlends).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnding).EndInit();
            tabPage7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridViewAll;
        private TabPage tabPage2;
        private Button btnConnect;
        private DataGridView dataGridViewTypes;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private DataGridView dataGridViewArabica;
        private DataGridView dataGridViewRobusta;
        private DataGridView dataGridViewBlends;
        private DataGridView dataGridViewEnding;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textMinCostPrice;
        private Label label2;
        private TextBox textMaxCostPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textMiddleCostPrice;
        private TextBox textCountWithMinCostPrice;
        private TextBox textCountWithMaxCostPrice;
    }
}
