namespace RK_Cosmetics_System
{
    partial class frm_Change_Password
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
            this.lbl_Change_Password = new System.Windows.Forms.Label();
            this.pnl_Change_Password_Back = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_New_Password = new System.Windows.Forms.Label();
            this.tb_New_Password = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Current_Password = new System.Windows.Forms.Label();
            this.tb_Current_Password = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cb_Username = new System.Windows.Forms.ComboBox();
            this.pnl_Change_Password_Back.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Change_Password
            // 
            this.lbl_Change_Password.AutoSize = true;
            this.lbl_Change_Password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Change_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Change_Password.Location = new System.Drawing.Point(758, 25);
            this.lbl_Change_Password.Name = "lbl_Change_Password";
            this.lbl_Change_Password.Size = new System.Drawing.Size(499, 60);
            this.lbl_Change_Password.TabIndex = 11;
            this.lbl_Change_Password.Text = "Change Password";
            // 
            // pnl_Change_Password_Back
            // 
            this.pnl_Change_Password_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Change_Password_Back.Controls.Add(this.tableLayoutPanel3);
            this.pnl_Change_Password_Back.Controls.Add(this.tableLayoutPanel2);
            this.pnl_Change_Password_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Change_Password_Back.Controls.Add(this.btn_Close);
            this.pnl_Change_Password_Back.Controls.Add(this.btn_Update);
            this.pnl_Change_Password_Back.ForeColor = System.Drawing.Color.White;
            this.pnl_Change_Password_Back.Location = new System.Drawing.Point(349, 114);
            this.pnl_Change_Password_Back.Name = "pnl_Change_Password_Back";
            this.pnl_Change_Password_Back.Size = new System.Drawing.Size(1233, 683);
            this.pnl_Change_Password_Back.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_New_Password, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_New_Password, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(430, 353);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lbl_New_Password
            // 
            this.lbl_New_Password.AutoSize = true;
            this.lbl_New_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_New_Password.Location = new System.Drawing.Point(3, 0);
            this.lbl_New_Password.Name = "lbl_New_Password";
            this.lbl_New_Password.Size = new System.Drawing.Size(186, 28);
            this.lbl_New_Password.TabIndex = 0;
            this.lbl_New_Password.Text = "New Password";
            // 
            // tb_New_Password
            // 
            this.tb_New_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_New_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_New_Password.Location = new System.Drawing.Point(3, 50);
            this.tb_New_Password.Multiline = true;
            this.tb_New_Password.Name = "tb_New_Password";
            this.tb_New_Password.Size = new System.Drawing.Size(395, 52);
            this.tb_New_Password.TabIndex = 7;
            this.tb_New_Password.Text = "Ex.1234";
            this.tb_New_Password.Click += new System.EventHandler(this.tb_New_Password_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Current_Password, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Current_Password, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(430, 198);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lbl_Current_Password
            // 
            this.lbl_Current_Password.AutoSize = true;
            this.lbl_Current_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Current_Password.Location = new System.Drawing.Point(3, 0);
            this.lbl_Current_Password.Name = "lbl_Current_Password";
            this.lbl_Current_Password.Size = new System.Drawing.Size(224, 28);
            this.lbl_Current_Password.TabIndex = 0;
            this.lbl_Current_Password.Text = "Current Password";
            // 
            // tb_Current_Password
            // 
            this.tb_Current_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Current_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Current_Password.Location = new System.Drawing.Point(3, 50);
            this.tb_Current_Password.Multiline = true;
            this.tb_Current_Password.Name = "tb_Current_Password";
            this.tb_Current_Password.Size = new System.Drawing.Size(395, 52);
            this.tb_Current_Password.TabIndex = 6;
            this.tb_Current_Password.Text = "Ex.1234";
            this.tb_Current_Password.Click += new System.EventHandler(this.tb_Current_Password_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Username, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Username, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(430, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(3, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(131, 28);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(697, 549);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(131, 54);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(458, 549);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(131, 54);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Save";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // cb_Username
            // 
            this.cb_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cb_Username.FormattingEnabled = true;
            this.cb_Username.Location = new System.Drawing.Point(3, 50);
            this.cb_Username.Name = "cb_Username";
            this.cb_Username.Size = new System.Drawing.Size(395, 40);
            this.cb_Username.TabIndex = 1;
            // 
            // frm_Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lbl_Change_Password);
            this.Controls.Add(this.pnl_Change_Password_Back);
            this.Name = "frm_Change_Password";
            this.Text = "Change Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Change_Password_Load);
            this.pnl_Change_Password_Back.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Change_Password;
        private System.Windows.Forms.Panel pnl_Change_Password_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_New_Password;
        private System.Windows.Forms.TextBox tb_New_Password;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Current_Password;
        private System.Windows.Forms.TextBox tb_Current_Password;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cb_Username;
    }
}