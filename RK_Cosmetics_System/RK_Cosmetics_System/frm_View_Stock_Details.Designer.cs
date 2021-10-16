namespace RK_Cosmetics_System
{
    partial class frm_View_Stock_Details
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
            this.pnl_View_Stock_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.cb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Product_Details = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_View_Stock_Details.SuspendLayout();
            this.gb_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_Stock_Details
            // 
            this.pnl_View_Stock_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_View_Stock_Details.Controls.Add(this.btn_Search);
            this.pnl_View_Stock_Details.Controls.Add(this.lbl_Brand_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.cb_Product_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.cb_Brand_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.lbl_Product_Name);
            this.pnl_View_Stock_Details.Location = new System.Drawing.Point(232, 133);
            this.pnl_View_Stock_Details.Name = "pnl_View_Stock_Details";
            this.pnl_View_Stock_Details.Size = new System.Drawing.Size(1351, 222);
            this.pnl_View_Stock_Details.TabIndex = 46;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(970, 88);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 56);
            this.btn_Search.TabIndex = 45;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(206, 43);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(182, 36);
            this.lbl_Brand_Name.TabIndex = 16;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // cb_Product_Name
            // 
            this.cb_Product_Name.FormattingEnabled = true;
            this.cb_Product_Name.Location = new System.Drawing.Point(478, 137);
            this.cb_Product_Name.Name = "cb_Product_Name";
            this.cb_Product_Name.Size = new System.Drawing.Size(301, 28);
            this.cb_Product_Name.TabIndex = 44;
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Location = new System.Drawing.Point(478, 49);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(301, 28);
            this.cb_Brand_Name.TabIndex = 42;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Product_Name.Location = new System.Drawing.Point(206, 137);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(208, 36);
            this.lbl_Product_Name.TabIndex = 23;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Stock_Details.Controls.Add(this.dgv_View_Product_Details);
            this.gb_Stock_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Stock_Details.Location = new System.Drawing.Point(76, 390);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(1765, 448);
            this.gb_Stock_Details.TabIndex = 47;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "Stock Details";
            // 
            // dgv_View_Product_Details
            // 
            this.dgv_View_Product_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Product_Details.Location = new System.Drawing.Point(77, 53);
            this.dgv_View_Product_Details.Name = "dgv_View_Product_Details";
            this.dgv_View_Product_Details.RowTemplate.Height = 28;
            this.dgv_View_Product_Details.Size = new System.Drawing.Size(1611, 337);
            this.dgv_View_Product_Details.TabIndex = 30;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(822, 854);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 51);
            this.btn_Refresh.TabIndex = 48;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // frm_View_Stock_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1841, 973);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Stock_Details);
            this.Controls.Add(this.pnl_View_Stock_Details);
            this.Name = "frm_View_Stock_Details";
            this.Text = "View Stock Details";
            this.pnl_View_Stock_Details.ResumeLayout(false);
            this.pnl_View_Stock_Details.PerformLayout();
            this.gb_Stock_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Stock_Details;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.ComboBox cb_Product_Name;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.DataGridView dgv_View_Product_Details;
        private System.Windows.Forms.Button btn_Refresh;
    }
}