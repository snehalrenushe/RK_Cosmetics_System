namespace RK_Cosmetics_System
{
    partial class frm_Add_New_Customer
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
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.gb_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.dgv_Add_New_Customer = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_GST_Applied = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_GST_Applied = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Net_Weight = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Net_Weight = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.gb_Bill_Details = new System.Windows.Forms.GroupBox();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.tb_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Customer_Details.SuspendLayout();
            this.gb_Purchase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_New_Customer)).BeginInit();
            this.gb_Bill_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.Controls.Add(this.dtp_Date);
            this.gb_Customer_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Customer_Details.Controls.Add(this.lbl_Date);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.tb_Customer_ID);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_Name);
            this.gb_Customer_Details.Controls.Add(this.lbl_Customer_ID);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Customer_Details.Location = new System.Drawing.Point(67, 83);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(1765, 202);
            this.gb_Customer_Details.TabIndex = 0;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1353, 56);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(301, 39);
            this.dtp_Date.TabIndex = 3;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1353, 124);
            this.tb_Mobile_No.MaxLength = 15;
            this.tb_Mobile_No.Multiline = true;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(301, 44);
            this.tb_Mobile_No.TabIndex = 4;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Pink;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(1130, 129);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(157, 36);
            this.lbl_Mobile_No.TabIndex = 18;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(1130, 52);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(77, 36);
            this.lbl_Date.TabIndex = 17;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(441, 131);
            this.tb_Customer_Name.MaxLength = 10;
            this.tb_Customer_Name.Multiline = true;
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(301, 40);
            this.tb_Customer_Name.TabIndex = 14;
            this.tb_Customer_Name.Text = "2";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(441, 55);
            this.tb_Customer_ID.MaxLength = 15;
            this.tb_Customer_ID.Multiline = true;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(301, 40);
            this.tb_Customer_ID.TabIndex = 1;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(135, 129);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(233, 36);
            this.lbl_Customer_Name.TabIndex = 16;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Customer_ID.Location = new System.Drawing.Point(135, 52);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(182, 36);
            this.lbl_Customer_ID.TabIndex = 15;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // gb_Purchase_Details
            // 
            this.gb_Purchase_Details.Controls.Add(this.dgv_Add_New_Customer);
            this.gb_Purchase_Details.Controls.Add(this.btn_Add);
            this.gb_Purchase_Details.Controls.Add(this.cb_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.cb_Brand_Name);
            this.gb_Purchase_Details.Controls.Add(this.tb_Price);
            this.gb_Purchase_Details.Controls.Add(this.tb_GST_Applied);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Price);
            this.gb_Purchase_Details.Controls.Add(this.lbl_GST_Applied);
            this.gb_Purchase_Details.Controls.Add(this.tb_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.tb_Net_Weight);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Net_Weight);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Purchase_Details.Controls.Add(this.lbl_Brand_Name);
            this.gb_Purchase_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Purchase_Details.Location = new System.Drawing.Point(67, 291);
            this.gb_Purchase_Details.Name = "gb_Purchase_Details";
            this.gb_Purchase_Details.Size = new System.Drawing.Size(1765, 374);
            this.gb_Purchase_Details.TabIndex = 1;
            this.gb_Purchase_Details.TabStop = false;
            this.gb_Purchase_Details.Text = "Purchase Details";
            // 
            // dgv_Add_New_Customer
            // 
            this.dgv_Add_New_Customer.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_Add_New_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Add_New_Customer.Location = new System.Drawing.Point(891, 50);
            this.dgv_Add_New_Customer.Name = "dgv_Add_New_Customer";
            this.dgv_Add_New_Customer.RowTemplate.Height = 28;
            this.dgv_Add_New_Customer.Size = new System.Drawing.Size(850, 302);
            this.dgv_Add_New_Customer.TabIndex = 28;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.Yellow;
            this.btn_Add.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(735, 296);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 56);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // cb_Product_Name
            // 
            this.cb_Product_Name.FormattingEnabled = true;
            this.cb_Product_Name.Location = new System.Drawing.Point(399, 100);
            this.cb_Product_Name.Name = "cb_Product_Name";
            this.cb_Product_Name.Size = new System.Drawing.Size(301, 33);
            this.cb_Product_Name.TabIndex = 6;
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Location = new System.Drawing.Point(399, 50);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(301, 33);
            this.cb_Brand_Name.TabIndex = 5;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(399, 312);
            this.tb_Price.MaxLength = 10;
            this.tb_Price.Multiline = true;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(301, 40);
            this.tb_Price.TabIndex = 10;
            // 
            // tb_GST_Applied
            // 
            this.tb_GST_Applied.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST_Applied.Location = new System.Drawing.Point(399, 259);
            this.tb_GST_Applied.MaxLength = 15;
            this.tb_GST_Applied.Multiline = true;
            this.tb_GST_Applied.Name = "tb_GST_Applied";
            this.tb_GST_Applied.Size = new System.Drawing.Size(301, 40);
            this.tb_GST_Applied.TabIndex = 9;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.Pink;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Price.Location = new System.Drawing.Point(135, 307);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(80, 36);
            this.lbl_Price.TabIndex = 24;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_GST_Applied
            // 
            this.lbl_GST_Applied.AutoSize = true;
            this.lbl_GST_Applied.BackColor = System.Drawing.Color.Pink;
            this.lbl_GST_Applied.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST_Applied.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_GST_Applied.Location = new System.Drawing.Point(135, 254);
            this.lbl_GST_Applied.Name = "lbl_GST_Applied";
            this.lbl_GST_Applied.Size = new System.Drawing.Size(180, 36);
            this.lbl_GST_Applied.TabIndex = 23;
            this.lbl_GST_Applied.Text = "GST Applied";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(399, 206);
            this.tb_Quantity.MaxLength = 10;
            this.tb_Quantity.Multiline = true;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(301, 40);
            this.tb_Quantity.TabIndex = 8;
            // 
            // tb_Net_Weight
            // 
            this.tb_Net_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Net_Weight.Location = new System.Drawing.Point(399, 152);
            this.tb_Net_Weight.MaxLength = 15;
            this.tb_Net_Weight.Multiline = true;
            this.tb_Net_Weight.Name = "tb_Net_Weight";
            this.tb_Net_Weight.Size = new System.Drawing.Size(301, 40);
            this.tb_Net_Weight.TabIndex = 7;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Pink;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Quantity.Location = new System.Drawing.Point(135, 201);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(129, 36);
            this.lbl_Quantity.TabIndex = 20;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Net_Weight
            // 
            this.lbl_Net_Weight.AutoSize = true;
            this.lbl_Net_Weight.BackColor = System.Drawing.Color.Pink;
            this.lbl_Net_Weight.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Net_Weight.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Net_Weight.Location = new System.Drawing.Point(135, 147);
            this.lbl_Net_Weight.Name = "lbl_Net_Weight";
            this.lbl_Net_Weight.Size = new System.Drawing.Size(169, 36);
            this.lbl_Net_Weight.TabIndex = 19;
            this.lbl_Net_Weight.Text = "Net Weight";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_Name.Location = new System.Drawing.Point(135, 97);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(208, 36);
            this.lbl_Product_Name.TabIndex = 16;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(135, 44);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(182, 36);
            this.lbl_Brand_Name.TabIndex = 15;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // gb_Bill_Details
            // 
            this.gb_Bill_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Bill_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Bill_Details.Controls.Add(this.label2);
            this.gb_Bill_Details.Controls.Add(this.tb_Discount);
            this.gb_Bill_Details.Controls.Add(this.tb_Bill);
            this.gb_Bill_Details.Controls.Add(this.lbl_Discount);
            this.gb_Bill_Details.Controls.Add(this.lbl_Bill);
            this.gb_Bill_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Bill_Details.Location = new System.Drawing.Point(67, 671);
            this.gb_Bill_Details.Name = "gb_Bill_Details";
            this.gb_Bill_Details.Size = new System.Drawing.Size(1765, 130);
            this.gb_Bill_Details.TabIndex = 2;
            this.gb_Bill_Details.TabStop = false;
            this.gb_Bill_Details.Text = "Bill Details";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1440, 44);
            this.tb_Final_Bill.MaxLength = 15;
            this.tb_Final_Bill.Multiline = true;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(301, 44);
            this.tb_Final_Bill.TabIndex = 14;
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.BackColor = System.Drawing.Color.Pink;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(1287, 52);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(123, 36);
            this.lbl_Final_Bill.TabIndex = 18;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1125, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 17;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(835, 52);
            this.tb_Discount.MaxLength = 10;
            this.tb_Discount.Multiline = true;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(301, 40);
            this.tb_Discount.TabIndex = 13;
            // 
            // tb_Bill
            // 
            this.tb_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bill.Location = new System.Drawing.Point(214, 52);
            this.tb_Bill.MaxLength = 15;
            this.tb_Bill.Multiline = true;
            this.tb_Bill.Name = "tb_Bill";
            this.tb_Bill.Size = new System.Drawing.Size(301, 40);
            this.tb_Bill.TabIndex = 12;
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.BackColor = System.Drawing.Color.Pink;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Discount.Location = new System.Drawing.Point(675, 52);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(132, 36);
            this.lbl_Discount.TabIndex = 16;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.BackColor = System.Drawing.Color.Pink;
            this.lbl_Bill.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Bill.Location = new System.Drawing.Point(130, 56);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(54, 36);
            this.lbl_Bill.TabIndex = 15;
            this.lbl_Bill.Text = "Bill";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(237, 815);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 56);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(939, 815);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(151, 56);
            this.btn_Refresh.TabIndex = 16;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1804, 883);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Bill_Details);
            this.Controls.Add(this.gb_Purchase_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.Name = "frm_Add_New_Customer";
            this.Text = "Add New Customer";
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            this.gb_Purchase_Details.ResumeLayout(false);
            this.gb_Purchase_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_New_Customer)).EndInit();
            this.gb_Bill_Details.ResumeLayout(false);
            this.gb_Bill_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.GroupBox gb_Purchase_Details;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_GST_Applied;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_GST_Applied;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Net_Weight;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Net_Weight;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.ComboBox cb_Product_Name;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Add_New_Customer;
        private System.Windows.Forms.GroupBox gb_Bill_Details;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_Bill;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
    }
}