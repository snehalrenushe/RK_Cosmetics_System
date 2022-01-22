namespace RK_Cosmetics_System
{
    partial class frm_View_Brand_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Brand_Details = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_View_Brand_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Brand_Details = new System.Windows.Forms.Panel();
            this.Warn_Brand_ID = new System.Windows.Forms.Label();
            this.tb_Brand_ID = new System.Windows.Forms.TextBox();
            this.lbl_Brand_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Brand_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Brand_Details)).BeginInit();
            this.pnl_Brand_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Brand_Details
            // 
            this.gb_Brand_Details.Controls.Add(this.btn_Refresh);
            this.gb_Brand_Details.Controls.Add(this.dgv_View_Brand_Details);
            this.gb_Brand_Details.Controls.Add(this.pnl_Brand_Details);
            this.gb_Brand_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Brand_Details.Location = new System.Drawing.Point(233, 115);
            this.gb_Brand_Details.Name = "gb_Brand_Details";
            this.gb_Brand_Details.Size = new System.Drawing.Size(1458, 759);
            this.gb_Brand_Details.TabIndex = 2;
            this.gb_Brand_Details.TabStop = false;
            this.gb_Brand_Details.Text = "Brand Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(684, 669);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(175, 58);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_View_Brand_Details
            // 
            this.dgv_View_Brand_Details.AllowUserToAddRows = false;
            this.dgv_View_Brand_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Brand_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Brand_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Brand_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Brand_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Brand_Details.Location = new System.Drawing.Point(46, 206);
            this.dgv_View_Brand_Details.Name = "dgv_View_Brand_Details";
            this.dgv_View_Brand_Details.ReadOnly = true;
            this.dgv_View_Brand_Details.RowTemplate.Height = 28;
            this.dgv_View_Brand_Details.Size = new System.Drawing.Size(1341, 457);
            this.dgv_View_Brand_Details.TabIndex = 29;
            // 
            // pnl_Brand_Details
            // 
            this.pnl_Brand_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Brand_Details.Controls.Add(this.Warn_Brand_ID);
            this.pnl_Brand_Details.Controls.Add(this.tb_Brand_ID);
            this.pnl_Brand_Details.Controls.Add(this.lbl_Brand_ID);
            this.pnl_Brand_Details.Controls.Add(this.btn_Search);
            this.pnl_Brand_Details.Location = new System.Drawing.Point(138, 44);
            this.pnl_Brand_Details.Name = "pnl_Brand_Details";
            this.pnl_Brand_Details.Size = new System.Drawing.Size(1249, 100);
            this.pnl_Brand_Details.TabIndex = 0;
            // 
            // Warn_Brand_ID
            // 
            this.Warn_Brand_ID.AutoSize = true;
            this.Warn_Brand_ID.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warn_Brand_ID.ForeColor = System.Drawing.Color.Red;
            this.Warn_Brand_ID.Location = new System.Drawing.Point(713, 71);
            this.Warn_Brand_ID.Name = "Warn_Brand_ID";
            this.Warn_Brand_ID.Size = new System.Drawing.Size(84, 21);
            this.Warn_Brand_ID.TabIndex = 62;
            this.Warn_Brand_ID.Text = "Required";
            this.Warn_Brand_ID.Visible = false;
            // 
            // tb_Brand_ID
            // 
            this.tb_Brand_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_ID.Location = new System.Drawing.Point(561, 28);
            this.tb_Brand_ID.MaxLength = 15;
            this.tb_Brand_ID.Multiline = true;
            this.tb_Brand_ID.Name = "tb_Brand_ID";
            this.tb_Brand_ID.Size = new System.Drawing.Size(301, 40);
            this.tb_Brand_ID.TabIndex = 1;
            this.tb_Brand_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Brand_ID
            // 
            this.lbl_Brand_ID.AutoSize = true;
            this.lbl_Brand_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_ID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_ID.Location = new System.Drawing.Point(251, 25);
            this.lbl_Brand_ID.Name = "lbl_Brand_ID";
            this.lbl_Brand_ID.Size = new System.Drawing.Size(131, 36);
            this.lbl_Brand_ID.TabIndex = 30;
            this.lbl_Brand_ID.Text = "Brand ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(942, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 56);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_View_Brand_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 1029);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Brand_Details);
            this.Name = "frm_View_Brand_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Brand Details";
            this.Load += new System.EventHandler(this.frm_View_Brand_Details_Load);
            this.gb_Brand_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Brand_Details)).EndInit();
            this.pnl_Brand_Details.ResumeLayout(false);
            this.pnl_Brand_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Brand_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_Brand_Details;
        private System.Windows.Forms.Panel pnl_Brand_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Brand_ID;
        private System.Windows.Forms.Label lbl_Brand_ID;
        private System.Windows.Forms.Label Warn_Brand_ID;
    }
}