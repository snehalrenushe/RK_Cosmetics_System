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
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.cb_Distributor_Name = new System.Windows.Forms.ComboBox();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.tb_Selling_Price = new System.Windows.Forms.TextBox();
            this.tb_Stock = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Selling_Price = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.Warn_Selling_Price = new System.Windows.Forms.Label();
            this.gb_Product_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Product_Details.Controls.Add(this.Warn_Selling_Price);
            this.gb_Product_Details.Controls.Add(this.dtp_Date);
            this.gb_Product_Details.Controls.Add(this.lbl_Date);
            this.gb_Product_Details.Controls.Add(this.tb_Product_Name);
            this.gb_Product_Details.Controls.Add(this.cb_Distributor_Name);
            this.gb_Product_Details.Controls.Add(this.cb_Brand_Name);
            this.gb_Product_Details.Controls.Add(this.tb_Selling_Price);
            this.gb_Product_Details.Controls.Add(this.tb_Stock);
            this.gb_Product_Details.Controls.Add(this.tb_Description);
            this.gb_Product_Details.Controls.Add(this.lbl_Description);
            this.gb_Product_Details.Controls.Add(this.tb_GST);
            this.gb_Product_Details.Controls.Add(this.lbl_GST);
            this.gb_Product_Details.Controls.Add(this.lbl_Stock);
            this.gb_Product_Details.Controls.Add(this.tb_Purchase_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Purchase_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Selling_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Distributor_Name);
            this.gb_Product_Details.Controls.Add(this.tb_Product_ID);
            this.gb_Product_Details.Controls.Add(this.lbl_Brand_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_ID);
            this.gb_Product_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Details.Location = new System.Drawing.Point(85, 109);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(1765, 613);
            this.gb_Product_Details.TabIndex = 2;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Product Details";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtp_Date.Location = new System.Drawing.Point(1349, 49);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(301, 39);
            this.dtp_Date.TabIndex = 6;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(995, 62);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(77, 36);
            this.lbl_Date.TabIndex = 37;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tb_Product_Name.Location = new System.Drawing.Point(444, 257);
            this.tb_Product_Name.MaxLength = 20;
            this.tb_Product_Name.Multiline = true;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(301, 40);
            this.tb_Product_Name.TabIndex = 3;
            // 
            // cb_Distributor_Name
            // 
            this.cb_Distributor_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cb_Distributor_Name.FormattingEnabled = true;
            this.cb_Distributor_Name.Location = new System.Drawing.Point(1348, 258);
            this.cb_Distributor_Name.Name = "cb_Distributor_Name";
            this.cb_Distributor_Name.Size = new System.Drawing.Size(301, 39);
            this.cb_Distributor_Name.TabIndex = 8;
            this.cb_Distributor_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Distributor_Name_SelectedIndexChanged);
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Location = new System.Drawing.Point(445, 156);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(301, 39);
            this.cb_Brand_Name.TabIndex = 2;
            // 
            // tb_Selling_Price
            // 
            this.tb_Selling_Price.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tb_Selling_Price.Location = new System.Drawing.Point(444, 450);
            this.tb_Selling_Price.MaxLength = 10;
            this.tb_Selling_Price.Multiline = true;
            this.tb_Selling_Price.Name = "tb_Selling_Price";
            this.tb_Selling_Price.Size = new System.Drawing.Size(301, 40);
            this.tb_Selling_Price.TabIndex = 5;
            this.tb_Selling_Price.TabIndexChanged += new System.EventHandler(this.tb_Selling_Price_TabIndexChanged);
            this.tb_Selling_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.tb_Selling_Price.MouseLeave += new System.EventHandler(this.tb_Selling_Price_MouseLeave);
            // 
            // tb_Stock
            // 
            this.tb_Stock.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tb_Stock.Location = new System.Drawing.Point(1348, 146);
            this.tb_Stock.MaxLength = 10;
            this.tb_Stock.Multiline = true;
            this.tb_Stock.Name = "tb_Stock";
            this.tb_Stock.Size = new System.Drawing.Size(301, 40);
            this.tb_Stock.TabIndex = 7;
            this.tb_Stock.Text = "0";
            this.tb_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tb_Description.Location = new System.Drawing.Point(1351, 446);
            this.tb_Description.MaxLength = 10;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(301, 97);
            this.tb_Description.TabIndex = 10;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.Pink;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Description.Location = new System.Drawing.Point(995, 455);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(167, 36);
            this.lbl_Description.TabIndex = 35;
            this.lbl_Description.Text = "Description";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tb_GST.Location = new System.Drawing.Point(1350, 349);
            this.tb_GST.MaxLength = 10;
            this.tb_GST.Multiline = true;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(301, 40);
            this.tb_GST.TabIndex = 9;
            this.tb_GST.MouseLeave += new System.EventHandler(this.tb_GST_MouseLeave);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.BackColor = System.Drawing.Color.Pink;
            this.lbl_GST.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_GST.Location = new System.Drawing.Point(995, 355);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(68, 36);
            this.lbl_GST.TabIndex = 32;
            this.lbl_GST.Text = "GST";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.BackColor = System.Drawing.Color.Pink;
            this.lbl_Stock.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Stock.Location = new System.Drawing.Point(995, 152);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(88, 36);
            this.lbl_Stock.TabIndex = 27;
            this.lbl_Stock.Text = "Stock";
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tb_Purchase_Price.Location = new System.Drawing.Point(444, 353);
            this.tb_Purchase_Price.MaxLength = 10;
            this.tb_Purchase_Price.Multiline = true;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(301, 40);
            this.tb_Purchase_Price.TabIndex = 4;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.BackColor = System.Drawing.Color.Pink;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(135, 357);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(208, 36);
            this.lbl_Purchase_Price.TabIndex = 24;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_Name.Location = new System.Drawing.Point(135, 261);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(208, 36);
            this.lbl_Product_Name.TabIndex = 23;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Selling_Price
            // 
            this.lbl_Selling_Price.AutoSize = true;
            this.lbl_Selling_Price.BackColor = System.Drawing.Color.Pink;
            this.lbl_Selling_Price.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selling_Price.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Selling_Price.Location = new System.Drawing.Point(135, 454);
            this.lbl_Selling_Price.Name = "lbl_Selling_Price";
            this.lbl_Selling_Price.Size = new System.Drawing.Size(176, 36);
            this.lbl_Selling_Price.TabIndex = 22;
            this.lbl_Selling_Price.Text = "Selling Price";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(995, 257);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(246, 36);
            this.lbl_Distributor_Name.TabIndex = 17;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tb_Product_ID.Location = new System.Drawing.Point(445, 65);
            this.tb_Product_ID.MaxLength = 15;
            this.tb_Product_ID.Multiline = true;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(301, 40);
            this.tb_Product_ID.TabIndex = 1;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(135, 159);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(182, 36);
            this.lbl_Brand_Name.TabIndex = 16;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_ID.Location = new System.Drawing.Point(135, 62);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(157, 36);
            this.lbl_Product_ID.TabIndex = 15;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(608, 784);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(149, 51);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(1224, 784);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 51);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Warn_Selling_Price
            // 
            this.Warn_Selling_Price.AutoSize = true;
            this.Warn_Selling_Price.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warn_Selling_Price.ForeColor = System.Drawing.Color.Red;
            this.Warn_Selling_Price.Location = new System.Drawing.Point(677, 493);
            this.Warn_Selling_Price.Name = "Warn_Selling_Price";
            this.Warn_Selling_Price.Size = new System.Drawing.Size(84, 21);
            this.Warn_Selling_Price.TabIndex = 38;
            this.Warn_Selling_Price.Text = "Required";
            this.Warn_Selling_Price.Visible = false;
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 882);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Product_Details);
            this.Name = "frm_Add_New_Product";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.ComboBox cb_Distributor_Name;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.TextBox tb_Selling_Price;
        private System.Windows.Forms.TextBox tb_Stock;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Selling_Price;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label Warn_Selling_Price;
    }
}