namespace RK_Cosmetics_System
{
    partial class frm_View_Distributor_Details
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
            this.gb_Distributor_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Distributor_Details = new System.Windows.Forms.DataGridView();
            this.distributorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieUpDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributorDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.dB_RK_Cosmetics_SystemDataSet4 = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet4();
            this.pnl_Distributor_Details = new System.Windows.Forms.Panel();
            this.tb_Distributor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Distributor_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            //this.distributor_DetailsTableAdapter = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet4TableAdapters.Distributor_DetailsTableAdapter();
            this.gb_Distributor_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Distributor_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorDetailsBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet4)).BeginInit();
            this.pnl_Distributor_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Distributor_Details
            // 
            this.gb_Distributor_Details.Controls.Add(this.dgv_View_Distributor_Details);
            this.gb_Distributor_Details.Controls.Add(this.pnl_Distributor_Details);
            this.gb_Distributor_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Distributor_Details.Location = new System.Drawing.Point(35, 86);
            this.gb_Distributor_Details.Name = "gb_Distributor_Details";
            this.gb_Distributor_Details.Size = new System.Drawing.Size(1862, 695);
            this.gb_Distributor_Details.TabIndex = 3;
            this.gb_Distributor_Details.TabStop = false;
            this.gb_Distributor_Details.Text = "Distributor Details";
            // 
            // dgv_View_Distributor_Details
            // 
            this.dgv_View_Distributor_Details.AllowUserToAddRows = false;
            this.dgv_View_Distributor_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Distributor_Details.AutoGenerateColumns = false;
            this.dgv_View_Distributor_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Distributor_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Distributor_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Distributor_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Distributor_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distributorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.registrationNoDataGridViewTextBoxColumn,
            this.tieUpDateDataGridViewTextBoxColumn,
            this.mobileNo1DataGridViewTextBoxColumn});
            this.dgv_View_Distributor_Details.DataSource = this.distributorDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Distributor_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Distributor_Details.Location = new System.Drawing.Point(35, 226);
            this.dgv_View_Distributor_Details.Name = "dgv_View_Distributor_Details";
            this.dgv_View_Distributor_Details.ReadOnly = true;
            this.dgv_View_Distributor_Details.RowTemplate.Height = 28;
            this.dgv_View_Distributor_Details.Size = new System.Drawing.Size(1797, 434);
            this.dgv_View_Distributor_Details.TabIndex = 31;
            // 
            // distributorIDDataGridViewTextBoxColumn
            // 
            this.distributorIDDataGridViewTextBoxColumn.DataPropertyName = "Distributor_ID";
            this.distributorIDDataGridViewTextBoxColumn.HeaderText = "Distributor_ID";
            this.distributorIDDataGridViewTextBoxColumn.Name = "distributorIDDataGridViewTextBoxColumn";
            this.distributorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationNoDataGridViewTextBoxColumn
            // 
            this.registrationNoDataGridViewTextBoxColumn.DataPropertyName = "Registration_No";
            this.registrationNoDataGridViewTextBoxColumn.HeaderText = "Registration_No";
            this.registrationNoDataGridViewTextBoxColumn.Name = "registrationNoDataGridViewTextBoxColumn";
            this.registrationNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tieUpDateDataGridViewTextBoxColumn
            // 
            this.tieUpDateDataGridViewTextBoxColumn.DataPropertyName = "Tie_Up_Date";
            this.tieUpDateDataGridViewTextBoxColumn.HeaderText = "Tie_Up_Date";
            this.tieUpDateDataGridViewTextBoxColumn.Name = "tieUpDateDataGridViewTextBoxColumn";
            this.tieUpDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNo1DataGridViewTextBoxColumn
            // 
            this.mobileNo1DataGridViewTextBoxColumn.DataPropertyName = "Mobile_No_1";
            this.mobileNo1DataGridViewTextBoxColumn.HeaderText = "Mobile_No_1";
            this.mobileNo1DataGridViewTextBoxColumn.Name = "mobileNo1DataGridViewTextBoxColumn";
            this.mobileNo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distributorDetailsBindingSource
            // 
            this.distributorDetailsBindingSource.DataMember = "Distributor_Details";
            //this.distributorDetailsBindingSource.DataSource = this.dB_RK_Cosmetics_SystemDataSet4;
            // 
            // dB_RK_Cosmetics_SystemDataSet4
            // 
            //this.dB_RK_Cosmetics_SystemDataSet4.DataSetName = "DB_RK_Cosmetics_SystemDataSet4";
            //this.dB_RK_Cosmetics_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Distributor_Details
            // 
            this.pnl_Distributor_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Distributor_Details.Controls.Add(this.tb_Distributor_ID);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Distributor_ID);
            this.pnl_Distributor_Details.Controls.Add(this.btn_Search);
            this.pnl_Distributor_Details.Location = new System.Drawing.Point(228, 44);
            this.pnl_Distributor_Details.Name = "pnl_Distributor_Details";
            this.pnl_Distributor_Details.Size = new System.Drawing.Size(1351, 100);
            this.pnl_Distributor_Details.TabIndex = 0;
            // 
            // tb_Distributor_ID
            // 
            this.tb_Distributor_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Distributor_ID.Location = new System.Drawing.Point(369, 37);
            this.tb_Distributor_ID.MaxLength = 15;
            this.tb_Distributor_ID.Multiline = true;
            this.tb_Distributor_ID.Name = "tb_Distributor_ID";
            this.tb_Distributor_ID.Size = new System.Drawing.Size(301, 40);
            this.tb_Distributor_ID.TabIndex = 31;
            this.tb_Distributor_ID.TextChanged += new System.EventHandler(this.tb_Distributor_ID_TextChanged);
            this.tb_Distributor_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Distributor_ID
            // 
            this.lbl_Distributor_ID.AutoSize = true;
            this.lbl_Distributor_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Distributor_ID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Distributor_ID.Location = new System.Drawing.Point(59, 34);
            this.lbl_Distributor_ID.Name = "lbl_Distributor_ID";
            this.lbl_Distributor_ID.Size = new System.Drawing.Size(195, 36);
            this.lbl_Distributor_ID.TabIndex = 32;
            this.lbl_Distributor_ID.Text = "Distributor ID";
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
            this.btn_Search.Location = new System.Drawing.Point(954, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 56);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(932, 817);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 51);
            this.btn_Refresh.TabIndex = 31;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // distributor_DetailsTableAdapter
            // 
            //this.distributor_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Distributor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1922, 883);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Distributor_Details);
            this.Name = "frm_View_Distributor_Details";
            this.Text = "View Distributor Details";
            this.Load += new System.EventHandler(this.frm_View_Distributor_Details_Load);
            this.gb_Distributor_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Distributor_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorDetailsBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet4)).EndInit();
            this.pnl_Distributor_Details.ResumeLayout(false);
            this.pnl_Distributor_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Distributor_Details;
        private System.Windows.Forms.Panel pnl_Distributor_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Distributor_ID;
        private System.Windows.Forms.Label lbl_Distributor_ID;
        private System.Windows.Forms.DataGridView dgv_View_Distributor_Details;
        //private DB_RK_Cosmetics_SystemDataSet4 dB_RK_Cosmetics_SystemDataSet4;
        private System.Windows.Forms.BindingSource distributorDetailsBindingSource;
        //private DB_RK_Cosmetics_SystemDataSet4TableAdapters.Distributor_DetailsTableAdapter distributor_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieUpDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo1DataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}