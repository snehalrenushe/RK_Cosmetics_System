namespace RK_Cosmetics_System
{
    partial class frm_View_Employee_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Employee_Details = new System.Windows.Forms.GroupBox();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RK_Cosmetics_SystemDataSet = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet();
            this.pnl_Employee_Details = new System.Windows.Forms.Panel();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.employee_DetailsTableAdapter = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.dgv_View_Employee_Details = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Employee_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet)).BeginInit();
            this.pnl_Employee_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Employee_Details
            // 
            this.gb_Employee_Details.Controls.Add(this.dgv_View_Employee_Details);
            this.gb_Employee_Details.Controls.Add(this.pnl_Employee_Details);
            this.gb_Employee_Details.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Employee_Details.Location = new System.Drawing.Point(104, 84);
            this.gb_Employee_Details.Name = "gb_Employee_Details";
            this.gb_Employee_Details.Size = new System.Drawing.Size(1762, 695);
            this.gb_Employee_Details.TabIndex = 2;
            this.gb_Employee_Details.TabStop = false;
            this.gb_Employee_Details.Text = "Employee Details";
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.dB_RK_Cosmetics_SystemDataSet;
            // 
            // dB_RK_Cosmetics_SystemDataSet
            // 
            this.dB_RK_Cosmetics_SystemDataSet.DataSetName = "DB_RK_Cosmetics_SystemDataSet";
            this.dB_RK_Cosmetics_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Employee_Details
            // 
            this.pnl_Employee_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Employee_Details.Controls.Add(this.tb_Employee_ID);
            this.pnl_Employee_Details.Controls.Add(this.lbl_Employee_ID);
            this.pnl_Employee_Details.Controls.Add(this.btn_Search);
            this.pnl_Employee_Details.Location = new System.Drawing.Point(228, 44);
            this.pnl_Employee_Details.Name = "pnl_Employee_Details";
            this.pnl_Employee_Details.Size = new System.Drawing.Size(1351, 100);
            this.pnl_Employee_Details.TabIndex = 0;
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(366, 37);
            this.tb_Employee_ID.MaxLength = 15;
            this.tb_Employee_ID.Multiline = true;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(301, 40);
            this.tb_Employee_ID.TabIndex = 29;
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Employee_ID.Location = new System.Drawing.Point(56, 34);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(157, 36);
            this.lbl_Employee_ID.TabIndex = 30;
            this.lbl_Employee_ID.Text = "Product ID";
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
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(873, 801);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 51);
            this.btn_Refresh.TabIndex = 30;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_View_Employee_Details
            // 
            this.dgv_View_Employee_Details.AllowUserToAddRows = false;
            this.dgv_View_Employee_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Employee_Details.AutoGenerateColumns = false;
            this.dgv_View_Employee_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Employee_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Employee_Details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Employee_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_View_Employee_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Employee_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.joiningDateDataGridViewTextBoxColumn,
            this.mobileNo1DataGridViewTextBoxColumn,
            this.mobileNo2DataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgv_View_Employee_Details.DataSource = this.employeeDetailsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Employee_Details.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_View_Employee_Details.Location = new System.Drawing.Point(93, 185);
            this.dgv_View_Employee_Details.Name = "dgv_View_Employee_Details";
            this.dgv_View_Employee_Details.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Employee_Details.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_View_Employee_Details.RowTemplate.Height = 28;
            this.dgv_View_Employee_Details.Size = new System.Drawing.Size(1611, 457);
            this.dgv_View_Employee_Details.TabIndex = 30;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // joiningDateDataGridViewTextBoxColumn
            // 
            this.joiningDateDataGridViewTextBoxColumn.DataPropertyName = "Joining_Date";
            this.joiningDateDataGridViewTextBoxColumn.HeaderText = "Joining_Date";
            this.joiningDateDataGridViewTextBoxColumn.Name = "joiningDateDataGridViewTextBoxColumn";
            this.joiningDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNo1DataGridViewTextBoxColumn
            // 
            this.mobileNo1DataGridViewTextBoxColumn.DataPropertyName = "Mobile_No_1";
            this.mobileNo1DataGridViewTextBoxColumn.HeaderText = "Mobile_No_1";
            this.mobileNo1DataGridViewTextBoxColumn.Name = "mobileNo1DataGridViewTextBoxColumn";
            this.mobileNo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNo2DataGridViewTextBoxColumn
            // 
            this.mobileNo2DataGridViewTextBoxColumn.DataPropertyName = "Mobile_No_2";
            this.mobileNo2DataGridViewTextBoxColumn.HeaderText = "Mobile_No_2";
            this.mobileNo2DataGridViewTextBoxColumn.Name = "mobileNo2DataGridViewTextBoxColumn";
            this.mobileNo2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 883);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Employee_Details);
            this.Name = "frm_View_Employee_Details";
            this.Text = "View Employee Details";
            this.Load += new System.EventHandler(this.frm_View_Employee_Details_Load);
            this.gb_Employee_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet)).EndInit();
            this.pnl_Employee_Details.ResumeLayout(false);
            this.pnl_Employee_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Employee_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel pnl_Employee_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private DB_RK_Cosmetics_SystemDataSet dB_RK_Cosmetics_SystemDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private DB_RK_Cosmetics_SystemDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView dgv_View_Employee_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}