namespace RK_Cosmetics_System
{
    partial class frm_Expences
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
            this.gb_Expences = new System.Windows.Forms.GroupBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.tb_Paid_By = new System.Windows.Forms.TextBox();
            this.lbl_Paid_By = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Bill_Image = new System.Windows.Forms.Label();
            this.tb_Amount_Paid = new System.Windows.Forms.TextBox();
            this.lbl_Amount_Paid = new System.Windows.Forms.Label();
            this.tb_Expences_Datiles = new System.Windows.Forms.TextBox();
            this.lbl_Expences_ID = new System.Windows.Forms.Label();
            this.lbl_Expences_Details = new System.Windows.Forms.Label();
            this.tb_Expences_ID = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Expences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Expences
            // 
            this.gb_Expences.Controls.Add(this.btn_Browse);
            this.gb_Expences.Controls.Add(this.pb_Bill_Image);
            this.gb_Expences.Controls.Add(this.tb_Paid_By);
            this.gb_Expences.Controls.Add(this.lbl_Paid_By);
            this.gb_Expences.Controls.Add(this.dtp_Date);
            this.gb_Expences.Controls.Add(this.lbl_Date);
            this.gb_Expences.Controls.Add(this.lbl_Bill_Image);
            this.gb_Expences.Controls.Add(this.tb_Amount_Paid);
            this.gb_Expences.Controls.Add(this.lbl_Amount_Paid);
            this.gb_Expences.Controls.Add(this.tb_Expences_Datiles);
            this.gb_Expences.Controls.Add(this.lbl_Expences_ID);
            this.gb_Expences.Controls.Add(this.lbl_Expences_Details);
            this.gb_Expences.Controls.Add(this.tb_Expences_ID);
            this.gb_Expences.Location = new System.Drawing.Point(181, 155);
            this.gb_Expences.Margin = new System.Windows.Forms.Padding(6);
            this.gb_Expences.Name = "gb_Expences";
            this.gb_Expences.Padding = new System.Windows.Forms.Padding(6);
            this.gb_Expences.Size = new System.Drawing.Size(1590, 561);
            this.gb_Expences.TabIndex = 1;
            this.gb_Expences.TabStop = false;
            this.gb_Expences.Text = "Expences";
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Browse.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(1143, 347);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(191, 81);
            this.btn_Browse.TabIndex = 40;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Bill_Image.Location = new System.Drawing.Point(1074, 157);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(349, 171);
            this.pb_Bill_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Bill_Image.TabIndex = 39;
            this.pb_Bill_Image.TabStop = false;
            // 
            // tb_Paid_By
            // 
            this.tb_Paid_By.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid_By.Location = new System.Drawing.Point(1074, 434);
            this.tb_Paid_By.MaxLength = 50;
            this.tb_Paid_By.Name = "tb_Paid_By";
            this.tb_Paid_By.Size = new System.Drawing.Size(349, 47);
            this.tb_Paid_By.TabIndex = 38;
            // 
            // lbl_Paid_By
            // 
            this.lbl_Paid_By.AutoSize = true;
            this.lbl_Paid_By.BackColor = System.Drawing.Color.Pink;
            this.lbl_Paid_By.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_By.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Paid_By.Location = new System.Drawing.Point(836, 434);
            this.lbl_Paid_By.Name = "lbl_Paid_By";
            this.lbl_Paid_By.Size = new System.Drawing.Size(148, 46);
            this.lbl_Paid_By.TabIndex = 37;
            this.lbl_Paid_By.Text = "Paid By";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1074, 85);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(349, 50);
            this.dtp_Date.TabIndex = 36;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Date.Location = new System.Drawing.Point(836, 89);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(100, 46);
            this.lbl_Date.TabIndex = 35;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Bill_Image
            // 
            this.lbl_Bill_Image.AutoSize = true;
            this.lbl_Bill_Image.BackColor = System.Drawing.Color.Pink;
            this.lbl_Bill_Image.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Image.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Bill_Image.Location = new System.Drawing.Point(836, 174);
            this.lbl_Bill_Image.Name = "lbl_Bill_Image";
            this.lbl_Bill_Image.Size = new System.Drawing.Size(192, 46);
            this.lbl_Bill_Image.TabIndex = 34;
            this.lbl_Bill_Image.Text = "Bill Image";
            // 
            // tb_Amount_Paid
            // 
            this.tb_Amount_Paid.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount_Paid.Location = new System.Drawing.Point(390, 434);
            this.tb_Amount_Paid.MaxLength = 5;
            this.tb_Amount_Paid.Name = "tb_Amount_Paid";
            this.tb_Amount_Paid.Size = new System.Drawing.Size(320, 47);
            this.tb_Amount_Paid.TabIndex = 33;
            // 
            // lbl_Amount_Paid
            // 
            this.lbl_Amount_Paid.AutoSize = true;
            this.lbl_Amount_Paid.BackColor = System.Drawing.Color.Pink;
            this.lbl_Amount_Paid.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount_Paid.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Amount_Paid.Location = new System.Drawing.Point(77, 434);
            this.lbl_Amount_Paid.Name = "lbl_Amount_Paid";
            this.lbl_Amount_Paid.Size = new System.Drawing.Size(245, 46);
            this.lbl_Amount_Paid.TabIndex = 32;
            this.lbl_Amount_Paid.Text = "Amount Paid";
            // 
            // tb_Expences_Datiles
            // 
            this.tb_Expences_Datiles.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expences_Datiles.Location = new System.Drawing.Point(390, 172);
            this.tb_Expences_Datiles.MaxLength = 50;
            this.tb_Expences_Datiles.Multiline = true;
            this.tb_Expences_Datiles.Name = "tb_Expences_Datiles";
            this.tb_Expences_Datiles.Size = new System.Drawing.Size(320, 119);
            this.tb_Expences_Datiles.TabIndex = 29;
            // 
            // lbl_Expences_ID
            // 
            this.lbl_Expences_ID.AutoSize = true;
            this.lbl_Expences_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Expences_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expences_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Expences_ID.Location = new System.Drawing.Point(77, 89);
            this.lbl_Expences_ID.Name = "lbl_Expences_ID";
            this.lbl_Expences_ID.Size = new System.Drawing.Size(227, 46);
            this.lbl_Expences_ID.TabIndex = 30;
            this.lbl_Expences_ID.Text = "Expences ID";
            // 
            // lbl_Expences_Details
            // 
            this.lbl_Expences_Details.AutoSize = true;
            this.lbl_Expences_Details.BackColor = System.Drawing.Color.Pink;
            this.lbl_Expences_Details.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expences_Details.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Expences_Details.Location = new System.Drawing.Point(77, 174);
            this.lbl_Expences_Details.Name = "lbl_Expences_Details";
            this.lbl_Expences_Details.Size = new System.Drawing.Size(306, 46);
            this.lbl_Expences_Details.TabIndex = 31;
            this.lbl_Expences_Details.Text = "Expences Details";
            // 
            // tb_Expences_ID
            // 
            this.tb_Expences_ID.Enabled = false;
            this.tb_Expences_ID.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expences_ID.Location = new System.Drawing.Point(390, 87);
            this.tb_Expences_ID.MaxLength = 5;
            this.tb_Expences_ID.Name = "tb_Expences_ID";
            this.tb_Expences_ID.Size = new System.Drawing.Size(320, 47);
            this.tb_Expences_ID.TabIndex = 28;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Yellow;
            this.btn_Close.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1207, 754);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(166, 52);
            this.btn_Close.TabIndex = 37;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(441, 754);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(178, 52);
            this.btn_Refresh.TabIndex = 36;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(819, 754);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(156, 52);
            this.btn_Save.TabIndex = 35;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Expences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1804, 883);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Expences);
            this.Name = "frm_Expences";
            this.Text = "Add Expences";
            this.Load += new System.EventHandler(this.frm_Expences_Load);
            this.gb_Expences.ResumeLayout(false);
            this.gb_Expences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Expences;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
        private System.Windows.Forms.TextBox tb_Paid_By;
        private System.Windows.Forms.Label lbl_Paid_By;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Bill_Image;
        private System.Windows.Forms.TextBox tb_Amount_Paid;
        private System.Windows.Forms.Label lbl_Amount_Paid;
        private System.Windows.Forms.TextBox tb_Expences_Datiles;
        private System.Windows.Forms.Label lbl_Expences_ID;
        private System.Windows.Forms.Label lbl_Expences_Details;
        private System.Windows.Forms.TextBox tb_Expences_ID;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
    }
}