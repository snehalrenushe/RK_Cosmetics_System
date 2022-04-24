namespace RK_Cosmetics_System
{
    partial class frm_View_Expense_Details
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
            this.pnl_View_Expense_Back = new System.Windows.Forms.Panel();
            this.dgv_Expense_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_View_Expense_List = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnl_View_Expense_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_Expense_Back
            // 
            this.pnl_View_Expense_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_View_Expense_Back.Controls.Add(this.dateTimePicker1);
            this.pnl_View_Expense_Back.Controls.Add(this.lbl_Date);
            this.pnl_View_Expense_Back.Controls.Add(this.dgv_Expense_List);
            this.pnl_View_Expense_Back.Controls.Add(this.btn_Refresh);
            this.pnl_View_Expense_Back.Controls.Add(this.btn_Search);
            this.pnl_View_Expense_Back.Location = new System.Drawing.Point(157, 110);
            this.pnl_View_Expense_Back.Name = "pnl_View_Expense_Back";
            this.pnl_View_Expense_Back.Size = new System.Drawing.Size(1712, 717);
            this.pnl_View_Expense_Back.TabIndex = 4;
            // 
            // dgv_Expense_List
            // 
            this.dgv_Expense_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expense_List.Location = new System.Drawing.Point(228, 167);
            this.dgv_Expense_List.Name = "dgv_Expense_List";
            this.dgv_Expense_List.RowTemplate.Height = 28;
            this.dgv_Expense_List.Size = new System.Drawing.Size(1252, 428);
            this.dgv_Expense_List.TabIndex = 12;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(807, 624);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 54);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1176, 74);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 54);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_View_Expense_List
            // 
            this.lbl_View_Expense_List.AutoSize = true;
            this.lbl_View_Expense_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_View_Expense_List.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Expense_List.Location = new System.Drawing.Point(770, 20);
            this.lbl_View_Expense_List.Name = "lbl_View_Expense_List";
            this.lbl_View_Expense_List.Size = new System.Drawing.Size(498, 60);
            this.lbl_View_Expense_List.TabIndex = 3;
            this.lbl_View_Expense_List.Text = "View Expense List";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(397, 72);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(112, 46);
            this.lbl_Date.TabIndex = 13;
            this.lbl_Date.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.dateTimePicker1.Location = new System.Drawing.Point(666, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(353, 45);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // frm_View_Expense_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnl_View_Expense_Back);
            this.Controls.Add(this.lbl_View_Expense_List);
            this.Name = "frm_View_Expense_Details";
            this.Text = "View Expense Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Expense_Details_Load);
            this.pnl_View_Expense_Back.ResumeLayout(false);
            this.pnl_View_Expense_Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expense_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Expense_Back;
        private System.Windows.Forms.DataGridView dgv_Expense_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_View_Expense_List;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}