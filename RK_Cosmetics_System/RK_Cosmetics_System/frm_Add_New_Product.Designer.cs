namespace RK_Cosmetics_System
{
    partial class frm_Add_New_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.pnl_Product_Back = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Distributor_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_Selling_Price = new System.Windows.Forms.TextBox();
            this.lbl_For_Date = new System.Windows.Forms.Label();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Selling_Price = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.tb_Stock = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.pnl_Product_Back.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(794, 18);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(484, 60);
            this.lbl_Add_New_Product.TabIndex = 0;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // pnl_Product_Back
            // 
            this.pnl_Product_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Product_Back.Controls.Add(this.btn_Refresh);
            this.pnl_Product_Back.Controls.Add(this.btn_Save);
            this.pnl_Product_Back.Controls.Add(this.tableLayoutPanel4);
            this.pnl_Product_Back.Controls.Add(this.tableLayoutPanel2);
            this.pnl_Product_Back.Controls.Add(this.tableLayoutPanel3);
            this.pnl_Product_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Product_Back.ForeColor = System.Drawing.Color.White;
            this.pnl_Product_Back.Location = new System.Drawing.Point(114, 90);
            this.pnl_Product_Back.Name = "pnl_Product_Back";
            this.pnl_Product_Back.Size = new System.Drawing.Size(1712, 790);
            this.pnl_Product_Back.TabIndex = 1;
            this.pnl_Product_Back.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Product_Back_Paint);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1002, 662);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 54);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(558, 662);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 54);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.57351F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.42649F));
            this.tableLayoutPanel4.Controls.Add(this.cb_Distributor_Name, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Description, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Distributor_Name, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tb_Description, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(476, 440);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91304F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.08696F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(959, 184);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // cb_Distributor_Name
            // 
            this.cb_Distributor_Name.BackColor = System.Drawing.SystemColors.Menu;
            this.cb_Distributor_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Distributor_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Distributor_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cb_Distributor_Name.FormattingEnabled = true;
            this.cb_Distributor_Name.Location = new System.Drawing.Point(3, 46);
            this.cb_Distributor_Name.Name = "cb_Distributor_Name";
            this.cb_Distributor_Name.Size = new System.Drawing.Size(299, 40);
            this.cb_Distributor_Name.TabIndex = 9;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.White;
            this.lbl_Description.Location = new System.Drawing.Point(487, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(147, 28);
            this.lbl_Description.TabIndex = 4;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(3, 0);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(211, 28);
            this.lbl_Distributor_Name.TabIndex = 0;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // tb_Description
            // 
            this.tb_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Description.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Description.Location = new System.Drawing.Point(487, 46);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(299, 134);
            this.tb_Description.TabIndex = 5;
            this.tb_Description.Text = "Ex..kaljdsk";
            this.tb_Description.Click += new System.EventHandler(this.tb_Description_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.42826F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.57174F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 421F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Purchase_Price, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Selling_Price, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_For_Date, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Purchase_Price, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Selling_Price, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Date, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(232, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1354, 125);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(3, 0);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(190, 28);
            this.lbl_Purchase_Price.TabIndex = 4;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // tb_Selling_Price
            // 
            this.tb_Selling_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Selling_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Selling_Price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Selling_Price.Location = new System.Drawing.Point(473, 42);
            this.tb_Selling_Price.Multiline = true;
            this.tb_Selling_Price.Name = "tb_Selling_Price";
            this.tb_Selling_Price.Size = new System.Drawing.Size(299, 41);
            this.tb_Selling_Price.TabIndex = 7;
            this.tb_Selling_Price.Text = "Ex.1500 Rs.";
            this.tb_Selling_Price.Click += new System.EventHandler(this.tb_Selling_Price_Click);
            // 
            // lbl_For_Date
            // 
            this.lbl_For_Date.AutoSize = true;
            this.lbl_For_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lbl_For_Date.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_For_Date.Location = new System.Drawing.Point(935, 39);
            this.lbl_For_Date.Name = "lbl_For_Date";
            this.lbl_For_Date.Padding = new System.Windows.Forms.Padding(8);
            this.lbl_For_Date.Size = new System.Drawing.Size(99, 44);
            this.lbl_For_Date.TabIndex = 13;
            this.lbl_For_Date.Text = "label1";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Purchase_Price.Location = new System.Drawing.Point(3, 42);
            this.tb_Purchase_Price.Multiline = true;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(299, 41);
            this.tb_Purchase_Price.TabIndex = 5;
            this.tb_Purchase_Price.Text = "Ex.1200 Rs.";
            this.tb_Purchase_Price.Click += new System.EventHandler(this.tb_Purchase_Price_Click);
            // 
            // lbl_Selling_Price
            // 
            this.lbl_Selling_Price.AutoSize = true;
            this.lbl_Selling_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selling_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Selling_Price.Location = new System.Drawing.Point(473, 0);
            this.lbl_Selling_Price.Name = "lbl_Selling_Price";
            this.lbl_Selling_Price.Size = new System.Drawing.Size(160, 28);
            this.lbl_Selling_Price.TabIndex = 6;
            this.lbl_Selling_Price.Text = "Selling Price";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(935, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(66, 28);
            this.lbl_Date.TabIndex = 8;
            this.lbl_Date.Text = "Date";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.36496F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.63504F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_GST, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Stock, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_GST, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Stock, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(476, 309);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(959, 125);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.ForeColor = System.Drawing.Color.White;
            this.lbl_GST.Location = new System.Drawing.Point(485, 0);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(62, 28);
            this.lbl_GST.TabIndex = 4;
            this.lbl_GST.Text = "GST";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.ForeColor = System.Drawing.Color.White;
            this.lbl_Stock.Location = new System.Drawing.Point(3, 0);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(78, 28);
            this.lbl_Stock.TabIndex = 0;
            this.lbl_Stock.Text = "Stock";
            // 
            // tb_GST
            // 
            this.tb_GST.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_GST.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_GST.Location = new System.Drawing.Point(485, 42);
            this.tb_GST.Multiline = true;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(299, 41);
            this.tb_GST.TabIndex = 5;
            this.tb_GST.Text = "Ex.3 %";
            this.tb_GST.Click += new System.EventHandler(this.tb_GST_Click);
            // 
            // tb_Stock
            // 
            this.tb_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Stock.Location = new System.Drawing.Point(3, 42);
            this.tb_Stock.Multiline = true;
            this.tb_Stock.Name = "tb_Stock";
            this.tb_Stock.Size = new System.Drawing.Size(299, 41);
            this.tb_Stock.TabIndex = 6;
            this.tb_Stock.Text = "Ex.2";
            this.tb_Stock.Click += new System.EventHandler(this.tb_Stock_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.48129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.51871F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Product_ID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Product_ID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Brand_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Product_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Product_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_Brand_Name, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(232, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 125);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Product_ID.Location = new System.Drawing.Point(934, 42);
            this.tb_Product_ID.Multiline = true;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(299, 41);
            this.tb_Product_ID.TabIndex = 7;
            this.tb_Product_ID.Text = "Ex.101";
            this.tb_Product_ID.Click += new System.EventHandler(this.tb_Product_ID_Click);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_ID.Location = new System.Drawing.Point(934, 0);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(136, 28);
            this.lbl_Product_ID.TabIndex = 6;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(473, 0);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(156, 28);
            this.lbl_Brand_Name.TabIndex = 4;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_Name.Location = new System.Drawing.Point(3, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(177, 28);
            this.lbl_Product_Name.TabIndex = 0;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Product_Name.Location = new System.Drawing.Point(3, 42);
            this.tb_Product_Name.Multiline = true;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(299, 41);
            this.tb_Product_Name.TabIndex = 3;
            this.tb_Product_Name.Text = "Ex.Foundation\r\n";
            this.tb_Product_Name.Click += new System.EventHandler(this.tb_Product_Name_Click);
            this.tb_Product_Name.TextChanged += new System.EventHandler(this.tb_Product_Name_TextChanged);
            this.tb_Product_Name.Enter += new System.EventHandler(this.tb_Product_Name_Enter);
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.BackColor = System.Drawing.Color.White;
            this.cb_Brand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Brand_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Brand_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cb_Brand_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Items.AddRange(new object[] {
            "kjh",
            "klj",
            "kj",
            "iu"});
            this.cb_Brand_Name.Location = new System.Drawing.Point(473, 42);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(299, 40);
            this.cb_Brand_Name.TabIndex = 8;
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnl_Product_Back);
            this.Controls.Add(this.lbl_Add_New_Product);
            this.Name = "frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_New_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.pnl_Product_Back.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Product;
        private System.Windows.Forms.Panel pnl_Product_Back;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.TextBox tb_Selling_Price;
        private System.Windows.Forms.Label lbl_Selling_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.TextBox tb_Stock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cb_Distributor_Name;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_For_Date;

    }
}