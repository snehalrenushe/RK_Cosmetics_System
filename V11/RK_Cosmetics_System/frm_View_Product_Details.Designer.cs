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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Product_Details = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RK_Cosmetics_SystemDataSet5 = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet5();
            this.pnl_Product_Details = new System.Windows.Forms.Panel();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.product_DetailsTableAdapter = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet5TableAdapters.Product_DetailsTableAdapter();
            this.gb_Product_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet5)).BeginInit();
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
            this.dgv_View_Product_Details.AllowUserToAddRows = false;
            this.dgv_View_Product_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Product_Details.AutoGenerateColumns = false;
            this.dgv_View_Product_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Product_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Product_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Product_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.gSTDataGridViewTextBoxColumn});
            this.dgv_View_Product_Details.DataSource = this.productDetailsBindingSource;
            this.dgv_View_Product_Details.Location = new System.Drawing.Point(60, 184);
            this.dgv_View_Product_Details.Name = "dgv_View_Product_Details";
            this.dgv_View_Product_Details.ReadOnly = true;
            this.dgv_View_Product_Details.RowTemplate.Height = 28;
            this.dgv_View_Product_Details.Size = new System.Drawing.Size(1611, 477);
            this.dgv_View_Product_Details.TabIndex = 29;
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
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gSTDataGridViewTextBoxColumn
            // 
            this.gSTDataGridViewTextBoxColumn.DataPropertyName = "GST";
            this.gSTDataGridViewTextBoxColumn.HeaderText = "GST";
            this.gSTDataGridViewTextBoxColumn.Name = "gSTDataGridViewTextBoxColumn";
            this.gSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataMember = "Product_Details";
            this.productDetailsBindingSource.DataSource = this.dB_RK_Cosmetics_SystemDataSet5;
            // 
            // dB_RK_Cosmetics_SystemDataSet5
            // 
            this.dB_RK_Cosmetics_SystemDataSet5.DataSetName = "DB_RK_Cosmetics_SystemDataSet5";
            this.dB_RK_Cosmetics_SystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Product_Details
            // 
            this.pnl_Product_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Product_Details.Controls.Add(this.cb_Brand_Name);
            this.pnl_Product_Details.Controls.Add(this.lbl_Brand_Name);
            this.pnl_Product_Details.Controls.Add(this.btn_Search);
            this.pnl_Product_Details.Location = new System.Drawing.Point(228, 44);
            this.pnl_Product_Details.Name = "pnl_Product_Details";
            this.pnl_Product_Details.Size = new System.Drawing.Size(1351, 102);
            this.pnl_Product_Details.TabIndex = 0;
            this.pnl_Product_Details.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Product_Details_Paint);
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Location = new System.Drawing.Point(469, 35);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(301, 39);
            this.cb_Brand_Name.TabIndex = 1;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(159, 34);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(182, 36);
            this.lbl_Brand_Name.TabIndex = 34;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(946, 22);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 59);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(912, 813);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 51);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // product_DetailsTableAdapter
            // 
            this.product_DetailsTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.frm_View_Product_Details_Load);
            this.gb_Product_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Product_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet5)).EndInit();
            this.pnl_Product_Details.ResumeLayout(false);
            this.pnl_Product_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.DataGridView dgv_View_Product_Details;
        private System.Windows.Forms.Panel pnl_Product_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private DB_RK_Cosmetics_SystemDataSet5 dB_RK_Cosmetics_SystemDataSet5;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private DB_RK_Cosmetics_SystemDataSet5TableAdapters.Product_DetailsTableAdapter product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTDataGridViewTextBoxColumn;
    }
}