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
            this.gb_Brand_Details = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_View_Brand_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Brand_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_Not_In_Use = new System.Windows.Forms.RadioButton();
            this.rb_In_Use = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.gb_Brand_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Brand_Details)).BeginInit();
            this.pnl_Brand_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Brand_Details
            // 
            this.gb_Brand_Details.Controls.Add(this.button1);
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
            this.btn_Refresh.Location = new System.Drawing.Point(859, 695);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(0, 21);
            this.btn_Refresh.TabIndex = 30;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // dgv_View_Brand_Details
            // 
            this.dgv_View_Brand_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Brand_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Brand_Details.Location = new System.Drawing.Point(46, 206);
            this.dgv_View_Brand_Details.Name = "dgv_View_Brand_Details";
            this.dgv_View_Brand_Details.RowTemplate.Height = 28;
            this.dgv_View_Brand_Details.Size = new System.Drawing.Size(1341, 457);
            this.dgv_View_Brand_Details.TabIndex = 29;
            // 
            // pnl_Brand_Details
            // 
            this.pnl_Brand_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Brand_Details.Controls.Add(this.rb_Not_In_Use);
            this.pnl_Brand_Details.Controls.Add(this.rb_In_Use);
            this.pnl_Brand_Details.Controls.Add(this.lbl_Status);
            this.pnl_Brand_Details.Controls.Add(this.btn_Search);
            this.pnl_Brand_Details.Location = new System.Drawing.Point(138, 44);
            this.pnl_Brand_Details.Name = "pnl_Brand_Details";
            this.pnl_Brand_Details.Size = new System.Drawing.Size(1249, 100);
            this.pnl_Brand_Details.TabIndex = 0;
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
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(732, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 31;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rb_Not_In_Use
            // 
            this.rb_Not_In_Use.AutoSize = true;
            this.rb_Not_In_Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_Not_In_Use.Location = new System.Drawing.Point(661, 36);
            this.rb_Not_In_Use.Name = "rb_Not_In_Use";
            this.rb_Not_In_Use.Size = new System.Drawing.Size(140, 30);
            this.rb_Not_In_Use.TabIndex = 51;
            this.rb_Not_In_Use.TabStop = true;
            this.rb_Not_In_Use.Text = "Not In Use\r\n";
            this.rb_Not_In_Use.UseVisualStyleBackColor = true;
            // 
            // rb_In_Use
            // 
            this.rb_In_Use.AutoSize = true;
            this.rb_In_Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_In_Use.Location = new System.Drawing.Point(500, 36);
            this.rb_In_Use.Name = "rb_In_Use";
            this.rb_In_Use.Size = new System.Drawing.Size(100, 30);
            this.rb_In_Use.TabIndex = 50;
            this.rb_In_Use.TabStop = true;
            this.rb_In_Use.Text = "In Use";
            this.rb_In_Use.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Pink;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Status.Location = new System.Drawing.Point(292, 36);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(96, 36);
            this.lbl_Status.TabIndex = 49;
            this.lbl_Status.Text = "Status";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_Not_In_Use;
        private System.Windows.Forms.RadioButton rb_In_Use;
        private System.Windows.Forms.Label lbl_Status;
    }
}