namespace RK_Cosmetics_System
{
    partial class frm_View_Expences_Details
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
            this.gb_Expences_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Expences_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Customer_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_To_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Date = new System.Windows.Forms.Label();
            this.dtp_From_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_From_Date = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dB_RK_Cosmetics_SystemDataSet4 = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet4();
            this.expencesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expences_DetailsTableAdapter = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet4TableAdapters.Expences_DetailsTableAdapter();
            this.expencesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expencesDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Expences_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Expences_Details)).BeginInit();
            this.pnl_Customer_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Expences_Details
            // 
            this.gb_Expences_Details.Controls.Add(this.btn_Refresh);
            this.gb_Expences_Details.Controls.Add(this.pnl_Customer_Details);
            this.gb_Expences_Details.Controls.Add(this.dgv_View_Expences_Details);
            this.gb_Expences_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Expences_Details.Location = new System.Drawing.Point(69, 148);
            this.gb_Expences_Details.Name = "gb_Expences_Details";
            this.gb_Expences_Details.Size = new System.Drawing.Size(1862, 695);
            this.gb_Expences_Details.TabIndex = 4;
            this.gb_Expences_Details.TabStop = false;
            this.gb_Expences_Details.Text = "Expences Details";
            // 
            // dgv_View_Expences_Details
            // 
            this.dgv_View_Expences_Details.AllowUserToAddRows = false;
            this.dgv_View_Expences_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Expences_Details.AutoGenerateColumns = false;
            this.dgv_View_Expences_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Expences_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Expences_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Expences_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Expences_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expencesIdDataGridViewTextBoxColumn,
            this.expencesDetailsDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paidByDataGridViewTextBoxColumn});
            this.dgv_View_Expences_Details.DataSource = this.expencesDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Expences_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Expences_Details.Location = new System.Drawing.Point(29, 226);
            this.dgv_View_Expences_Details.Name = "dgv_View_Expences_Details";
            this.dgv_View_Expences_Details.ReadOnly = true;
            this.dgv_View_Expences_Details.RowTemplate.Height = 28;
            this.dgv_View_Expences_Details.Size = new System.Drawing.Size(1797, 375);
            this.dgv_View_Expences_Details.TabIndex = 31;
            // 
            // pnl_Customer_Details
            // 
            this.pnl_Customer_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Customer_Details.Controls.Add(this.btn_Search);
            this.pnl_Customer_Details.Controls.Add(this.dtp_To_Date);
            this.pnl_Customer_Details.Controls.Add(this.lbl_To_Date);
            this.pnl_Customer_Details.Controls.Add(this.dtp_From_Date);
            this.pnl_Customer_Details.Controls.Add(this.lbl_From_Date);
            this.pnl_Customer_Details.Location = new System.Drawing.Point(178, 67);
            this.pnl_Customer_Details.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Customer_Details.Name = "pnl_Customer_Details";
            this.pnl_Customer_Details.Size = new System.Drawing.Size(1582, 114);
            this.pnl_Customer_Details.TabIndex = 32;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1404, 24);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(160, 65);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_To_Date
            // 
            this.dtp_To_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To_Date.Location = new System.Drawing.Point(988, 31);
            this.dtp_To_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_To_Date.Name = "dtp_To_Date";
            this.dtp_To_Date.Size = new System.Drawing.Size(360, 50);
            this.dtp_To_Date.TabIndex = 2;
            // 
            // lbl_To_Date
            // 
            this.lbl_To_Date.AutoSize = true;
            this.lbl_To_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_To_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_To_Date.Location = new System.Drawing.Point(812, 35);
            this.lbl_To_Date.Name = "lbl_To_Date";
            this.lbl_To_Date.Size = new System.Drawing.Size(155, 46);
            this.lbl_To_Date.TabIndex = 10;
            this.lbl_To_Date.Text = "To Date";
            // 
            // dtp_From_Date
            // 
            this.dtp_From_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From_Date.Location = new System.Drawing.Point(246, 35);
            this.dtp_From_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_From_Date.Name = "dtp_From_Date";
            this.dtp_From_Date.Size = new System.Drawing.Size(360, 50);
            this.dtp_From_Date.TabIndex = 1;
            // 
            // lbl_From_Date
            // 
            this.lbl_From_Date.AutoSize = true;
            this.lbl_From_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_From_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_From_Date.Location = new System.Drawing.Point(36, 35);
            this.lbl_From_Date.Name = "lbl_From_Date";
            this.lbl_From_Date.Size = new System.Drawing.Size(201, 46);
            this.lbl_From_Date.TabIndex = 8;
            this.lbl_From_Date.Text = "From Date";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(806, 608);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(160, 65);
            this.btn_Refresh.TabIndex = 33;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dB_RK_Cosmetics_SystemDataSet4
            // 
            this.dB_RK_Cosmetics_SystemDataSet4.DataSetName = "DB_RK_Cosmetics_SystemDataSet4";
            this.dB_RK_Cosmetics_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expencesDetailsBindingSource
            // 
            this.expencesDetailsBindingSource.DataMember = "Expences_Details";
            this.expencesDetailsBindingSource.DataSource = this.dB_RK_Cosmetics_SystemDataSet4;
            // 
            // expences_DetailsTableAdapter
            // 
            this.expences_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // expencesIdDataGridViewTextBoxColumn
            // 
            this.expencesIdDataGridViewTextBoxColumn.DataPropertyName = "Expences_Id";
            this.expencesIdDataGridViewTextBoxColumn.HeaderText = "Expences_Id";
            this.expencesIdDataGridViewTextBoxColumn.Name = "expencesIdDataGridViewTextBoxColumn";
            this.expencesIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expencesDetailsDataGridViewTextBoxColumn
            // 
            this.expencesDetailsDataGridViewTextBoxColumn.DataPropertyName = "Expences_Details";
            this.expencesDetailsDataGridViewTextBoxColumn.HeaderText = "Expences_Details";
            this.expencesDetailsDataGridViewTextBoxColumn.Name = "expencesDetailsDataGridViewTextBoxColumn";
            this.expencesDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidByDataGridViewTextBoxColumn
            // 
            this.paidByDataGridViewTextBoxColumn.DataPropertyName = "Paid_By";
            this.paidByDataGridViewTextBoxColumn.HeaderText = "Paid_By";
            this.paidByDataGridViewTextBoxColumn.Name = "paidByDataGridViewTextBoxColumn";
            this.paidByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Expences_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1804, 883);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Expences_Details);
            this.Name = "frm_View_Expences_Details";
            this.Text = "View Expences Details";
            this.Load += new System.EventHandler(this.frm_View_Expences_Details_Load);
            this.gb_Expences_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Expences_Details)).EndInit();
            this.pnl_Customer_Details.ResumeLayout(false);
            this.pnl_Customer_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Expences_Details;
        private System.Windows.Forms.Panel pnl_Customer_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_To_Date;
        private System.Windows.Forms.Label lbl_To_Date;
        private System.Windows.Forms.DateTimePicker dtp_From_Date;
        private System.Windows.Forms.Label lbl_From_Date;
        private System.Windows.Forms.DataGridView dgv_View_Expences_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private DB_RK_Cosmetics_SystemDataSet4 dB_RK_Cosmetics_SystemDataSet4;
        private System.Windows.Forms.BindingSource expencesDetailsBindingSource;
        private DB_RK_Cosmetics_SystemDataSet4TableAdapters.Expences_DetailsTableAdapter expences_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expencesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expencesDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidByDataGridViewTextBoxColumn;
    }
}