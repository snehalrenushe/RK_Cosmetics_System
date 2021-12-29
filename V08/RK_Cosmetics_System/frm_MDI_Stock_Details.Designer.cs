namespace RK_Cosmetics_System
{
    partial class frm_MDI_Stock_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MDI_Stock_Details));
            this.pnl_Stock_Details = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.VieworSearchStockDetailstoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Stock_Details
            // 
            this.pnl_Stock_Details.BackColor = System.Drawing.Color.DeepPink;
            this.pnl_Stock_Details.Controls.Add(this.btn_Logout);
            this.pnl_Stock_Details.Controls.Add(this.btn_Back);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Stock_Details);
            this.pnl_Stock_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Stock_Details.Location = new System.Drawing.Point(0, 0);
            this.pnl_Stock_Details.Name = "pnl_Stock_Details";
            this.pnl_Stock_Details.Size = new System.Drawing.Size(1400, 100);
            this.pnl_Stock_Details.TabIndex = 5;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1217, 21);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(151, 55);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(30, 21);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(128, 55);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Imprint MT Shadow", 48F, System.Drawing.FontStyle.Bold);
            this.lbl_Stock_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_Stock_Details.Location = new System.Drawing.Point(404, -7);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(602, 113);
            this.lbl_Stock_Details.TabIndex = 1;
            this.lbl_Stock_Details.Text = "Stock Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(302, 106);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(196, 52);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // AddStockToolStripMenuItem
            // 
            this.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem";
            this.AddStockToolStripMenuItem.Size = new System.Drawing.Size(188, 48);
            this.AddStockToolStripMenuItem.Text = "Add Stock";
            this.AddStockToolStripMenuItem.Click += new System.EventHandler(this.AddStockToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip3.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VieworSearchStockDetailstoolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(804, 106);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(464, 52);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            this.menuStrip3.UseWaitCursor = true;
            // 
            // VieworSearchStockDetailstoolStripMenuItem2
            // 
            this.VieworSearchStockDetailstoolStripMenuItem2.Name = "VieworSearchStockDetailstoolStripMenuItem2";
            this.VieworSearchStockDetailstoolStripMenuItem2.Size = new System.Drawing.Size(456, 48);
            this.VieworSearchStockDetailstoolStripMenuItem2.Text = "View or Search Stock Details";
            this.VieworSearchStockDetailstoolStripMenuItem2.Click += new System.EventHandler(this.VieworSearchStockDetailstoolStripMenuItem2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.GreenYellow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(733, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // frm_MDI_Stock_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 1049);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Stock_Details);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MDI_Stock_Details";
            this.Text = "Stock Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MDI_Stock_Details_Load);
            this.pnl_Stock_Details.ResumeLayout(false);
            this.pnl_Stock_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Stock_Details;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Stock_Details;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddStockToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem VieworSearchStockDetailstoolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}