namespace RK_Cosmetics_System
{
    partial class frm_Add_Stock
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
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.tb_New_Stock_Added = new System.Windows.Forms.TextBox();
            this.tb_Currect_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Currect_Stock_Quantity = new System.Windows.Forms.Label();
            this.lbl_New_Stock_Added = new System.Windows.Forms.Label();
            this.pnl_Stock_Details = new System.Windows.Forms.Panel();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.cb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.gb_Stock_Details.SuspendLayout();
            this.pnl_Stock_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Stock_Details.Controls.Add(this.tb_New_Stock_Added);
            this.gb_Stock_Details.Controls.Add(this.tb_Currect_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.lbl_Currect_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.lbl_New_Stock_Added);
            this.gb_Stock_Details.Controls.Add(this.pnl_Stock_Details);
            this.gb_Stock_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Stock_Details.Location = new System.Drawing.Point(63, 123);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(1765, 543);
            this.gb_Stock_Details.TabIndex = 3;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "Stock Details";
            // 
            // tb_New_Stock_Added
            // 
            this.tb_New_Stock_Added.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_New_Stock_Added.Location = new System.Drawing.Point(980, 466);
            this.tb_New_Stock_Added.MaxLength = 15;
            this.tb_New_Stock_Added.Multiline = true;
            this.tb_New_Stock_Added.Name = "tb_New_Stock_Added";
            this.tb_New_Stock_Added.Size = new System.Drawing.Size(301, 40);
            this.tb_New_Stock_Added.TabIndex = 6;
            this.tb_New_Stock_Added.Text = "0";
            // 
            // tb_Currect_Stock_Quantity
            // 
            this.tb_Currect_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Currect_Stock_Quantity.Location = new System.Drawing.Point(980, 375);
            this.tb_Currect_Stock_Quantity.MaxLength = 15;
            this.tb_Currect_Stock_Quantity.Multiline = true;
            this.tb_Currect_Stock_Quantity.Name = "tb_Currect_Stock_Quantity";
            this.tb_Currect_Stock_Quantity.Size = new System.Drawing.Size(301, 40);
            this.tb_Currect_Stock_Quantity.TabIndex = 5;
            // 
            // lbl_Currect_Stock_Quantity
            // 
            this.lbl_Currect_Stock_Quantity.AutoSize = true;
            this.lbl_Currect_Stock_Quantity.BackColor = System.Drawing.Color.Pink;
            this.lbl_Currect_Stock_Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currect_Stock_Quantity.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Currect_Stock_Quantity.Location = new System.Drawing.Point(539, 375);
            this.lbl_Currect_Stock_Quantity.Name = "lbl_Currect_Stock_Quantity";
            this.lbl_Currect_Stock_Quantity.Size = new System.Drawing.Size(316, 36);
            this.lbl_Currect_Stock_Quantity.TabIndex = 47;
            this.lbl_Currect_Stock_Quantity.Text = "Currect Stock Quantity";
            // 
            // lbl_New_Stock_Added
            // 
            this.lbl_New_Stock_Added.AutoSize = true;
            this.lbl_New_Stock_Added.BackColor = System.Drawing.Color.Pink;
            this.lbl_New_Stock_Added.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Stock_Added.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_New_Stock_Added.Location = new System.Drawing.Point(539, 470);
            this.lbl_New_Stock_Added.Name = "lbl_New_Stock_Added";
            this.lbl_New_Stock_Added.Size = new System.Drawing.Size(255, 36);
            this.lbl_New_Stock_Added.TabIndex = 46;
            this.lbl_New_Stock_Added.Text = "New Stock Added";
            // 
            // pnl_Stock_Details
            // 
            this.pnl_Stock_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Stock_Details.Controls.Add(this.lbl_Brand_Name);
            this.pnl_Stock_Details.Controls.Add(this.cb_Product_Name);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Product_ID);
            this.pnl_Stock_Details.Controls.Add(this.cb_Brand_Name);
            this.pnl_Stock_Details.Controls.Add(this.tb_Product_ID);
            this.pnl_Stock_Details.Controls.Add(this.dtp_Date);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Product_Name);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Date);
            this.pnl_Stock_Details.Location = new System.Drawing.Point(217, 59);
            this.pnl_Stock_Details.Name = "pnl_Stock_Details";
            this.pnl_Stock_Details.Size = new System.Drawing.Size(1351, 264);
            this.pnl_Stock_Details.TabIndex = 45;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(34, 51);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(182, 36);
            this.lbl_Brand_Name.TabIndex = 16;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // cb_Product_Name
            // 
            this.cb_Product_Name.Enabled = false;
            this.cb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Product_Name.FormattingEnabled = true;
            this.cb_Product_Name.Location = new System.Drawing.Point(306, 166);
            this.cb_Product_Name.MaxLength = 30;
            this.cb_Product_Name.Name = "cb_Product_Name";
            this.cb_Product_Name.Size = new System.Drawing.Size(301, 37);
            this.cb_Product_Name.TabIndex = 2;
            this.cb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Product_Name_SelectedIndexChanged);
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_ID.Location = new System.Drawing.Point(754, 166);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(157, 36);
            this.lbl_Product_ID.TabIndex = 15;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Location = new System.Drawing.Point(306, 57);
            this.cb_Brand_Name.MaxLength = 30;
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(301, 37);
            this.cb_Brand_Name.TabIndex = 1;
            this.cb_Brand_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Brand_Name_SelectedIndexChanged);
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Product_ID.Location = new System.Drawing.Point(992, 159);
            this.tb_Product_ID.MaxLength = 15;
            this.tb_Product_ID.Multiline = true;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(301, 40);
            this.tb_Product_ID.TabIndex = 4;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_Date.Location = new System.Drawing.Point(992, 58);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(301, 35);
            this.dtp_Date.TabIndex = 3;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_Name.Location = new System.Drawing.Point(34, 166);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(208, 36);
            this.lbl_Product_Name.TabIndex = 23;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(754, 63);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(77, 36);
            this.lbl_Date.TabIndex = 29;
            this.lbl_Date.Text = "Date";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(1224, 727);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 51);
            this.btn_Refresh.TabIndex = 35;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Yellow;
            this.btn_Submit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(608, 727);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(149, 51);
            this.btn_Submit.TabIndex = 34;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1921, 832);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.gb_Stock_Details);
            this.Name = "frm_Add_Stock";
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.gb_Stock_Details.ResumeLayout(false);
            this.gb_Stock_Details.PerformLayout();
            this.pnl_Stock_Details.ResumeLayout(false);
            this.pnl_Stock_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.ComboBox cb_Product_Name;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Panel pnl_Stock_Details;
        private System.Windows.Forms.TextBox tb_New_Stock_Added;
        private System.Windows.Forms.TextBox tb_Currect_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Currect_Stock_Quantity;
        private System.Windows.Forms.Label lbl_New_Stock_Added;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
    }
}