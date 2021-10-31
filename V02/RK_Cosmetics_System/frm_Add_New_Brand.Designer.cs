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
            this.gb_Brand_Details = new System.Windows.Forms.GroupBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Brand_ID = new System.Windows.Forms.Label();
            this.tb_Brand_Name = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb_Brand_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Brand_Details
            // 
            this.gb_Brand_Details.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Brand_Details.Controls.Add(this.tb_Brand_Name);
            this.gb_Brand_Details.Controls.Add(this.tb_Product_ID);
            this.gb_Brand_Details.Controls.Add(this.lbl_Brand_Name);
            this.gb_Brand_Details.Controls.Add(this.lbl_Brand_ID);
            this.gb_Brand_Details.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Brand_Details.Location = new System.Drawing.Point(414, 165);
            this.gb_Brand_Details.Name = "gb_Brand_Details";
            this.gb_Brand_Details.Size = new System.Drawing.Size(1104, 408);
            this.gb_Brand_Details.TabIndex = 3;
            this.gb_Brand_Details.TabStop = false;
            this.gb_Brand_Details.Text = "Brand Details";
            this.gb_Brand_Details.Enter += new System.EventHandler(this.gb_Brand_Details_Enter);
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(569, 96);
            this.tb_Product_ID.MaxLength = 15;
            this.tb_Product_ID.Multiline = true;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(301, 40);
            this.tb_Product_ID.TabIndex = 13;
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(259, 249);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(182, 36);
            this.lbl_Brand_Name.TabIndex = 16;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // lbl_Brand_ID
            // 
            this.lbl_Brand_ID.AutoSize = true;
            this.lbl_Brand_ID.BackColor = System.Drawing.Color.Pink;
            this.lbl_Brand_ID.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_ID.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Brand_ID.Location = new System.Drawing.Point(259, 93);
            this.lbl_Brand_ID.Name = "lbl_Brand_ID";
            this.lbl_Brand_ID.Size = new System.Drawing.Size(131, 36);
            this.lbl_Brand_ID.TabIndex = 15;
            this.lbl_Brand_ID.Text = "Brand ID";
            // 
            // tb_Brand_Name
            // 
            this.tb_Brand_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_Name.Location = new System.Drawing.Point(569, 248);
            this.tb_Brand_Name.MaxLength = 10;
            this.tb_Brand_Name.Multiline = true;
            this.tb_Brand_Name.Name = "tb_Brand_Name";
            this.tb_Brand_Name.Size = new System.Drawing.Size(301, 40);
            this.tb_Brand_Name.TabIndex = 45;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Yellow;
            this.btn_Save.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(943, 594);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(149, 66);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1586, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Brand_Details);
            this.Name = "frm_Add_New_Brand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Brand";
            this.gb_Brand_Details.ResumeLayout(false);
            this.gb_Brand_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Brand_Details;
        private System.Windows.Forms.TextBox tb_Brand_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Label lbl_Brand_ID;
        private System.Windows.Forms.Button btn_Save;
    }
}