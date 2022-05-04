namespace RK_Cosmetics_System
{
    partial class frm_Add_New_Brand
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
            this.lbl_Add_New_Brand = new System.Windows.Forms.Label();
            this.pnl_Brand_Back = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.pnl_Back_Status = new System.Windows.Forms.Panel();
            this.rb_Not_In_Use = new System.Windows.Forms.RadioButton();
            this.rb_In_Use = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Brand_ID = new System.Windows.Forms.Label();
            this.tb_Brand_ID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.tb_Brand_Name = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Brand_Back.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnl_Back_Status.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Brand
            // 
            this.lbl_Add_New_Brand.AutoSize = true;
            this.lbl_Add_New_Brand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Add_New_Brand.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_New_Brand.Location = new System.Drawing.Point(813, 26);
            this.lbl_Add_New_Brand.Name = "lbl_Add_New_Brand";
            this.lbl_Add_New_Brand.Size = new System.Drawing.Size(435, 60);
            this.lbl_Add_New_Brand.TabIndex = 7;
            this.lbl_Add_New_Brand.Text = "Add New Brand";
            // 
            // pnl_Brand_Back
            // 
            this.pnl_Brand_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Brand_Back.Controls.Add(this.tableLayoutPanel3);
            this.pnl_Brand_Back.Controls.Add(this.tableLayoutPanel2);
            this.pnl_Brand_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Brand_Back.Controls.Add(this.btn_Refresh);
            this.pnl_Brand_Back.Controls.Add(this.btn_Save);
            this.pnl_Brand_Back.ForeColor = System.Drawing.Color.White;
            this.pnl_Brand_Back.Location = new System.Drawing.Point(393, 123);
            this.pnl_Brand_Back.Name = "pnl_Brand_Back";
            this.pnl_Brand_Back.Size = new System.Drawing.Size(1233, 683);
            this.pnl_Brand_Back.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Status, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pnl_Back_Status, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(430, 353);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_Status.Location = new System.Drawing.Point(3, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(85, 28);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
            // 
            // pnl_Back_Status
            // 
            this.pnl_Back_Status.Controls.Add(this.rb_Not_In_Use);
            this.pnl_Back_Status.Controls.Add(this.rb_In_Use);
            this.pnl_Back_Status.Location = new System.Drawing.Point(3, 50);
            this.pnl_Back_Status.Name = "pnl_Back_Status";
            this.pnl_Back_Status.Size = new System.Drawing.Size(395, 52);
            this.pnl_Back_Status.TabIndex = 3;
            // 
            // rb_Not_In_Use
            // 
            this.rb_Not_In_Use.AutoSize = true;
            this.rb_Not_In_Use.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.rb_Not_In_Use.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rb_Not_In_Use.Location = new System.Drawing.Point(175, 5);
            this.rb_Not_In_Use.Name = "rb_Not_In_Use";
            this.rb_Not_In_Use.Size = new System.Drawing.Size(199, 36);
            this.rb_Not_In_Use.TabIndex = 0;
            this.rb_Not_In_Use.TabStop = true;
            this.rb_Not_In_Use.Text = "Not In Used";
            this.rb_Not_In_Use.UseVisualStyleBackColor = true;
            // 
            // rb_In_Use
            // 
            this.rb_In_Use.AutoSize = true;
            this.rb_In_Use.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.rb_In_Use.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rb_In_Use.Location = new System.Drawing.Point(25, 5);
            this.rb_In_Use.Name = "rb_In_Use";
            this.rb_In_Use.Size = new System.Drawing.Size(144, 36);
            this.rb_In_Use.TabIndex = 0;
            this.rb_In_Use.TabStop = true;
            this.rb_In_Use.Text = "In Used";
            this.rb_In_Use.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Brand_ID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Brand_ID, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(430, 198);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lbl_Brand_ID
            // 
            this.lbl_Brand_ID.AutoSize = true;
            this.lbl_Brand_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_Brand_ID.Location = new System.Drawing.Point(3, 0);
            this.lbl_Brand_ID.Name = "lbl_Brand_ID";
            this.lbl_Brand_ID.Size = new System.Drawing.Size(115, 28);
            this.lbl_Brand_ID.TabIndex = 0;
            this.lbl_Brand_ID.Text = "Brand ID";
            // 
            // tb_Brand_ID
            // 
            this.tb_Brand_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Brand_ID.Enabled = false;
            this.tb_Brand_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Brand_ID.Location = new System.Drawing.Point(3, 50);
            this.tb_Brand_ID.Multiline = true;
            this.tb_Brand_ID.Name = "tb_Brand_ID";
            this.tb_Brand_ID.Size = new System.Drawing.Size(395, 43);
            this.tb_Brand_ID.TabIndex = 2;
            this.tb_Brand_ID.Click += new System.EventHandler(this.tb_Brand_ID_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Brand_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Brand_Name, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(430, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(3, 0);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(156, 28);
            this.lbl_Brand_Name.TabIndex = 0;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // tb_Brand_Name
            // 
            this.tb_Brand_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Brand_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Brand_Name.Location = new System.Drawing.Point(3, 50);
            this.tb_Brand_Name.Multiline = true;
            this.tb_Brand_Name.Name = "tb_Brand_Name";
            this.tb_Brand_Name.Size = new System.Drawing.Size(395, 42);
            this.tb_Brand_Name.TabIndex = 1;
            this.tb_Brand_Name.Text = "Ex.Lakme";
            this.tb_Brand_Name.Click += new System.EventHandler(this.tb_Brand_Name_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(698, 549);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 54);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(430, 549);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 54);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lbl_Add_New_Brand);
            this.Controls.Add(this.pnl_Brand_Back);
            this.Name = "frm_Add_New_Brand";
            this.Text = "Add New Brand";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Brand_Load);
            this.pnl_Brand_Back.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnl_Back_Status.ResumeLayout(false);
            this.pnl_Back_Status.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Brand;
        private System.Windows.Forms.Panel pnl_Brand_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.TextBox tb_Brand_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Brand_ID;
        private System.Windows.Forms.TextBox tb_Brand_ID;
        private System.Windows.Forms.Panel pnl_Back_Status;
        private System.Windows.Forms.RadioButton rb_Not_In_Use;
        private System.Windows.Forms.RadioButton rb_In_Use;
    }
}