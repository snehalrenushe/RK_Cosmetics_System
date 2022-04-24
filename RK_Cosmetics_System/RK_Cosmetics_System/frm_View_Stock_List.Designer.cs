namespace RK_Cosmetics_System
{
    partial class frm_View_Stock_List
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
            this.pnl_View_Stock_Back = new System.Windows.Forms.Panel();
            this.dgv_Stock_List = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.lbl_View_Stock_List = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cb_Product_Name = new System.Windows.Forms.ComboBox();
            this.pnl_View_Stock_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_List)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_View_Stock_Back
            // 
            this.pnl_View_Stock_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_View_Stock_Back.Controls.Add(this.tableLayoutPanel2);
            this.pnl_View_Stock_Back.Controls.Add(this.dgv_Stock_List);
            this.pnl_View_Stock_Back.Controls.Add(this.btn_Refresh);
            this.pnl_View_Stock_Back.Controls.Add(this.btn_Search);
            this.pnl_View_Stock_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_View_Stock_Back.Location = new System.Drawing.Point(97, 106);
            this.pnl_View_Stock_Back.Name = "pnl_View_Stock_Back";
            this.pnl_View_Stock_Back.Size = new System.Drawing.Size(1712, 717);
            this.pnl_View_Stock_Back.TabIndex = 4;
            // 
            // dgv_Stock_List
            // 
            this.dgv_Stock_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock_List.Location = new System.Drawing.Point(228, 256);
            this.dgv_Stock_List.Name = "dgv_Stock_List";
            this.dgv_Stock_List.RowTemplate.Height = 28;
            this.dgv_Stock_List.Size = new System.Drawing.Size(1252, 339);
            this.dgv_Stock_List.TabIndex = 12;
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
            this.btn_Search.Location = new System.Drawing.Point(1277, 104);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Brand_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Brand_Name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(613, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.27907F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 57);
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
            this.cb_Brand_Name.Location = new System.Drawing.Point(277, 3);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(278, 40);
            this.cb_Brand_Name.TabIndex = 8;
            // 
            // lbl_View_Stock_List
            // 
            this.lbl_View_Stock_List.AutoSize = true;
            this.lbl_View_Stock_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_View_Stock_List.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Stock_List.Location = new System.Drawing.Point(743, 23);
            this.lbl_View_Stock_List.Name = "lbl_View_Stock_List";
            this.lbl_View_Stock_List.Size = new System.Drawing.Size(425, 60);
            this.lbl_View_Stock_List.TabIndex = 3;
            this.lbl_View_Stock_List.Text = "View Stock List";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.48129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Product_Name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cb_Product_Name, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(613, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.27907F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(558, 57);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_Name.Location = new System.Drawing.Point(3, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(238, 37);
            this.lbl_Product_Name.TabIndex = 4;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cb_Product_Name
            // 
            this.cb_Product_Name.BackColor = System.Drawing.Color.White;
            this.cb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Product_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cb_Product_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_Product_Name.FormattingEnabled = true;
            this.cb_Product_Name.Items.AddRange(new object[] {
            "kjh",
            "klj",
            "kj",
            "iu"});
            this.cb_Product_Name.Location = new System.Drawing.Point(277, 3);
            this.cb_Product_Name.Name = "cb_Product_Name";
            this.cb_Product_Name.Size = new System.Drawing.Size(278, 40);
            this.cb_Product_Name.TabIndex = 8;
            // 
            // frm_View_Stock_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnl_View_Stock_Back);
            this.Controls.Add(this.lbl_View_Stock_List);
            this.Name = "frm_View_Stock_List";
            this.Text = "View Stock List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Stock_List_Load);
            this.pnl_View_Stock_Back.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_List)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Stock_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cb_Product_Name;
        private System.Windows.Forms.DataGridView dgv_Stock_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.Label lbl_View_Stock_List;
    }
}