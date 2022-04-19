namespace RK_Cosmetics_System
{
    partial class frm_Add_New_Product
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
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.pnl_Product_Back = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(706, 28);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(449, 55);
            this.lbl_Add_New_Product.TabIndex = 0;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // pnl_Product_Back
            // 
            this.pnl_Product_Back.Location = new System.Drawing.Point(240, 130);
            this.pnl_Product_Back.Name = "pnl_Product_Back";
            this.pnl_Product_Back.Size = new System.Drawing.Size(1446, 908);
            this.pnl_Product_Back.TabIndex = 1;
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnl_Product_Back);
            this.Controls.Add(this.lbl_Add_New_Product);
            this.Name = "frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_New_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Product;
        private System.Windows.Forms.Panel pnl_Product_Back;

    }
}