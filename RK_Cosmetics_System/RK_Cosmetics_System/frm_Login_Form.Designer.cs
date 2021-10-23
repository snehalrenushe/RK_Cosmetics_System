namespace RK_Cosmetics_System
{
    partial class frm_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login_Form));
            this.pb_Login_Form = new System.Windows.Forms.PictureBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_Sign_In = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Ready_To_Login = new System.Windows.Forms.Label();
            this.pb_Login_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Form)).BeginInit();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Login_Form
            // 
            this.pb_Login_Form.Location = new System.Drawing.Point(-10, 1);
            this.pb_Login_Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Login_Form.Name = "pb_Login_Form";
            this.pb_Login_Form.Size = new System.Drawing.Size(629, 722);
            this.pb_Login_Form.TabIndex = 5;
            this.pb_Login_Form.TabStop = false;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Monotype Corsiva", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Welcome.Location = new System.Drawing.Point(83, -8);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(414, 122);
            this.lbl_Welcome.TabIndex = 6;
            this.lbl_Welcome.Text = "Wel-Come";
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.DeepPink;
            this.pnl_Login.Controls.Add(this.lbl_Welcome);
            this.pnl_Login.Location = new System.Drawing.Point(618, 1);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(582, 100);
            this.pnl_Login.TabIndex = 7;
            // 
            // btn_Sign_In
            // 
            this.btn_Sign_In.BackColor = System.Drawing.Color.Black;
            this.btn_Sign_In.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_In.ForeColor = System.Drawing.Color.White;
            this.btn_Sign_In.Location = new System.Drawing.Point(846, 554);
            this.btn_Sign_In.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sign_In.Name = "btn_Sign_In";
            this.btn_Sign_In.Size = new System.Drawing.Size(132, 48);
            this.btn_Sign_In.TabIndex = 3;
            this.btn_Sign_In.Text = "Sign In";
            this.btn_Sign_In.UseVisualStyleBackColor = false;
            this.btn_Sign_In.Click += new System.EventHandler(this.btn_Sign_In_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(878, 439);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(266, 45);
            this.tb_Password.TabIndex = 2;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(878, 339);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Username.MaxLength = 15;
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(266, 43);
            this.tb_Username.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Password.Location = new System.Drawing.Point(688, 439);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(152, 37);
            this.lbl_Password.TabIndex = 12;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Username.Location = new System.Drawing.Point(688, 339);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(159, 37);
            this.lbl_Username.TabIndex = 9;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Ready_To_Login
            // 
            this.lbl_Ready_To_Login.AutoSize = true;
            this.lbl_Ready_To_Login.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ready_To_Login.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Ready_To_Login.Location = new System.Drawing.Point(757, 254);
            this.lbl_Ready_To_Login.Name = "lbl_Ready_To_Login";
            this.lbl_Ready_To_Login.Size = new System.Drawing.Size(313, 55);
            this.lbl_Ready_To_Login.TabIndex = 8;
            this.lbl_Ready_To_Login.Text = "Ready To Login";
            // 
            // pb_Login_Icon
            // 
            this.pb_Login_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login_Icon.Image")));
            this.pb_Login_Icon.Location = new System.Drawing.Point(835, 119);
            this.pb_Login_Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Login_Icon.Name = "pb_Login_Icon";
            this.pb_Login_Icon.Size = new System.Drawing.Size(143, 133);
            this.pb_Login_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login_Icon.TabIndex = 13;
            this.pb_Login_Icon.TabStop = false;
            // 
            // frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1188, 714);
            this.Controls.Add(this.pb_Login_Icon);
            this.Controls.Add(this.btn_Sign_In);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Ready_To_Login);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.pb_Login_Form);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frm_Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Form)).EndInit();
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Login_Form;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Button btn_Sign_In;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Ready_To_Login;
        private System.Windows.Forms.PictureBox pb_Login_Icon;
    }
}

