namespace RK_Cosmetics_System
{
    partial class frm_Delete_User
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
            this.lbl_Delete_User = new System.Windows.Forms.Label();
            this.pnl_Add_User_Back = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pnl_Add_User_Back.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Delete_User
            // 
            this.lbl_Delete_User.AutoSize = true;
            this.lbl_Delete_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Delete_User.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Delete_User.Location = new System.Drawing.Point(832, 56);
            this.lbl_Delete_User.Name = "lbl_Delete_User";
            this.lbl_Delete_User.Size = new System.Drawing.Size(334, 60);
            this.lbl_Delete_User.TabIndex = 11;
            this.lbl_Delete_User.Text = "Delete User";
            // 
            // pnl_Add_User_Back
            // 
            this.pnl_Add_User_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Add_User_Back.Controls.Add(this.tableLayoutPanel2);
            this.pnl_Add_User_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Add_User_Back.Controls.Add(this.btn_Close);
            this.pnl_Add_User_Back.Controls.Add(this.btn_Delete);
            this.pnl_Add_User_Back.ForeColor = System.Drawing.Color.White;
            this.pnl_Add_User_Back.Location = new System.Drawing.Point(337, 185);
            this.pnl_Add_User_Back.Name = "pnl_Add_User_Back";
            this.pnl_Add_User_Back.Size = new System.Drawing.Size(1233, 489);
            this.pnl_Add_User_Back.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Password, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Password, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(430, 198);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 125);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Password.Location = new System.Drawing.Point(3, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(128, 28);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Password.Location = new System.Drawing.Point(3, 50);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(395, 52);
            this.tb_Password.TabIndex = 6;
            this.tb_Password.Text = "Ex.1234";
            this.tb_Password.Click += new System.EventHandler(this.tb_Password_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Username, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Username, 0, 1);
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
            // tb_Username
            // 
            this.tb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Username.Location = new System.Drawing.Point(3, 50);
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(395, 52);
            this.tb_Username.TabIndex = 6;
            this.tb_Username.Text = "Ex.John123";
            this.tb_Username.Click += new System.EventHandler(this.tb_Username_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(702, 374);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(131, 54);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(450, 374);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(160, 54);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // frm_Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 725);
            this.Controls.Add(this.lbl_Delete_User);
            this.Controls.Add(this.pnl_Add_User_Back);
            this.Name = "frm_Delete_User";
            this.Text = "Delete User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Delete_User_Load);
            this.pnl_Add_User_Back.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Delete_User;
        private System.Windows.Forms.Panel pnl_Add_User_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Delete;
    }
}