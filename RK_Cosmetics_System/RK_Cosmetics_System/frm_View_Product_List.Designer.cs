namespace RK_Cosmetics_System
{
    partial class frm_View_Product_List
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
            this.lbl_View_Product_List = new System.Windows.Forms.Label();
            this.pnl_View_Product_Back = new System.Windows.Forms.Panel();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.pnl_View_Product_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_View_Product_List
            // 
            this.lbl_View_Product_List.AutoSize = true;
            this.lbl_View_Product_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_View_Product_List.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Product_List.Location = new System.Drawing.Point(719, 40);
            this.lbl_View_Product_List.Name = "lbl_View_Product_List";
            this.lbl_View_Product_List.Size = new System.Drawing.Size(484, 60);
            this.lbl_View_Product_List.TabIndex = 1;
            this.lbl_View_Product_List.Text = "View Product List";
            // 
            // pnl_View_Product_Back
            // 
            this.pnl_View_Product_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_View_Product_Back.Controls.Add(this.dgv_Product_List);
            this.pnl_View_Product_Back.Controls.Add(this.btn_Refresh);
            this.pnl_View_Product_Back.Controls.Add(this.btn_Search);
            this.pnl_View_Product_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_View_Product_Back.Location = new System.Drawing.Point(106, 130);
            this.pnl_View_Product_Back.Name = "pnl_View_Product_Back";
            this.pnl_View_Product_Back.Size = new System.Drawing.Size(1712, 717);
            this.pnl_View_Product_Back.TabIndex = 2;
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(228, 167);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowTemplate.Height = 28;
            this.dgv_Product_List.Size = new System.Drawing.Size(1252, 428);
            this.dgv_Product_List.TabIndex = 12;
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
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1266, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 54);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.48129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 415F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Brand_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Brand_Name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(301, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.27907F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 69);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(3, 0);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(210, 37);
            this.lbl_Brand_Name.TabIndex = 4;
            this.lbl_Brand_Name.Text = "Brand Name";
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
            this.cb_Brand_Name.Location = new System.Drawing.Point(438, 3);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(299, 40);
            this.cb_Brand_Name.TabIndex = 8;
            // 
            // frm_View_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnl_View_Product_Back);
            this.Controls.Add(this.lbl_View_Product_List);
            this.Name = "frm_View_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Product List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Product_List_Load);
            this.pnl_View_Product_Back.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Product_List;
        private System.Windows.Forms.Panel pnl_View_Product_Back;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.DataGridView dgv_Product_List;
    }
}