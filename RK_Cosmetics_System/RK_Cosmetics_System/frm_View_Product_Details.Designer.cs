namespace RK_Cosmetics_System
{
    partial class frm_View_Product_Details
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
            this.dgv_View_Product_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Product_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Product_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Details)).BeginInit();
            this.pnl_Product_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.Controls.Add(this.dgv_View_Product_Details);
            this.gb_Product_Details.Controls.Add(this.pnl_Product_Details);
            this.gb_Product_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Product_Details.Location = new System.Drawing.Point(109, 112);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(1762, 695);
            this.gb_Product_Details.TabIndex = 4;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Product Details";
            // 
            // dgv_View_Product_Details
            // 
            this.dgv_View_Product_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Product_Details.Location = new System.Drawing.Point(60, 204);
            this.dgv_View_Product_Details.Name = "dgv_View_Product_Details";
            this.dgv_View_Product_Details.RowTemplate.Height = 28;
            this.dgv_View_Product_Details.Size = new System.Drawing.Size(1611, 457);
            this.dgv_View_Product_Details.TabIndex = 29;
            // 
            // pnl_Product_Details
            // 
            this.pnl_Product_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Product_Details.Controls.Add(this.btn_Search);
            this.pnl_Product_Details.Controls.Add(this.lbl_Date);
            this.pnl_Product_Details.Controls.Add(this.dtp_Joining_Date);
            this.pnl_Product_Details.Location = new System.Drawing.Point(228, 44);
            this.pnl_Product_Details.Name = "pnl_Product_Details";
            this.pnl_Product_Details.Size = new System.Drawing.Size(1351, 100);
            this.pnl_Product_Details.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(954, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 56);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(172, 35);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(77, 36);
            this.lbl_Date.TabIndex = 15;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining_Date.Location = new System.Drawing.Point(294, 32);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(301, 39);
            this.dtp_Joining_Date.TabIndex = 21;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(912, 813);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 51);
            this.btn_Refresh.TabIndex = 32;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // frm_View_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1840, 880);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Product_Details);
            this.Name = "frm_View_Product_Details";
            this.Text = "View Product Details";
            this.gb_Product_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Details)).EndInit();
            this.pnl_Product_Details.ResumeLayout(false);
            this.pnl_Product_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.DataGridView dgv_View_Product_Details;
        private System.Windows.Forms.Panel pnl_Product_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
        private System.Windows.Forms.Button btn_Refresh;
    }
}