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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_View_Stock_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.cb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_View_Stock_Details = new System.Windows.Forms.DataGridView();
            //this.dB_RK_Cosmetics_SystemDataSet8 = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet8();
            this.stockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.stock_DetailsTableAdapter = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet8TableAdapters.Stock_DetailsTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newAddedStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_View_Stock_Details.SuspendLayout();
            this.gb_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).BeginInit();
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
            this.btn_Search.Enabled = false;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(970, 88);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 56);
            this.btn_Search.TabIndex = 45;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.cb_Product_Name.Enabled = false;
            this.cb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Product_Name.FormattingEnabled = true;
            this.cb_Product_Name.Location = new System.Drawing.Point(478, 137);
            this.cb_Product_Name.Name = "cb_Product_Name";
            this.cb_Product_Name.Size = new System.Drawing.Size(301, 37);
            this.cb_Product_Name.TabIndex = 44;
            this.cb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Product_Name_SelectedIndexChanged);
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Location = new System.Drawing.Point(478, 43);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(301, 37);
            this.cb_Brand_Name.TabIndex = 42;
            this.cb_Brand_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Brand_Name_SelectedIndexChanged);
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
            this.gb_Stock_Details.Controls.Add(this.dgv_View_Stock_Details);
            this.gb_Stock_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Stock_Details.Location = new System.Drawing.Point(76, 390);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(1765, 448);
            this.gb_Stock_Details.TabIndex = 47;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "Stock Details";
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
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_View_Stock_Details
            // 
            this.dgv_View_Stock_Details.AllowUserToAddRows = false;
            this.dgv_View_Stock_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Stock_Details.AutoGenerateColumns = false;
            this.dgv_View_Stock_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Stock_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Stock_Details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Stock_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Stock_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Stock_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.currentStockQuantityDataGridViewTextBoxColumn,
            this.newAddedStockDataGridViewTextBoxColumn});
            this.dgv_View_Stock_Details.DataSource = this.stockDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Stock_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Stock_Details.Location = new System.Drawing.Point(49, 68);
            this.dgv_View_Stock_Details.Name = "dgv_View_Stock_Details";
            this.dgv_View_Stock_Details.ReadOnly = true;
            this.dgv_View_Stock_Details.RowTemplate.Height = 28;
            this.dgv_View_Stock_Details.Size = new System.Drawing.Size(1680, 335);
            this.dgv_View_Stock_Details.TabIndex = 31;
            // 
            // dB_RK_Cosmetics_SystemDataSet8
            // 
            //this.dB_RK_Cosmetics_SystemDataSet8.DataSetName = "DB_RK_Cosmetics_SystemDataSet8";
            //this.dB_RK_Cosmetics_SystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockDetailsBindingSource
            // 
            //this.stockDetailsBindingSource.DataMember = "Stock_Details";
            //this.stockDetailsBindingSource.DataSource = this.dB_RK_Cosmetics_SystemDataSet8;
            // 
            // stock_DetailsTableAdapter
            // 
            //this.stock_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentStockQuantityDataGridViewTextBoxColumn
            // 
            this.currentStockQuantityDataGridViewTextBoxColumn.DataPropertyName = "Current_Stock_Quantity";
            this.currentStockQuantityDataGridViewTextBoxColumn.HeaderText = "Current_Stock_Quantity";
            this.currentStockQuantityDataGridViewTextBoxColumn.Name = "currentStockQuantityDataGridViewTextBoxColumn";
            this.currentStockQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newAddedStockDataGridViewTextBoxColumn
            // 
            this.newAddedStockDataGridViewTextBoxColumn.DataPropertyName = "New_Added_Stock";
            this.newAddedStockDataGridViewTextBoxColumn.HeaderText = "New_Added_Stock";
            this.newAddedStockDataGridViewTextBoxColumn.Name = "newAddedStockDataGridViewTextBoxColumn";
            this.newAddedStockDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.Load += new System.EventHandler(this.frm_View_Stock_Details_Load);
            this.pnl_View_Stock_Details.ResumeLayout(false);
            this.pnl_View_Stock_Details.PerformLayout();
            this.gb_Stock_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_Stock_Details;
        //private DB_RK_Cosmetics_SystemDataSet8 dB_RK_Cosmetics_SystemDataSet8;
        private System.Windows.Forms.BindingSource stockDetailsBindingSource;
        //private DB_RK_Cosmetics_SystemDataSet8TableAdapters.Stock_DetailsTableAdapter stock_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newAddedStockDataGridViewTextBoxColumn;
    }
}