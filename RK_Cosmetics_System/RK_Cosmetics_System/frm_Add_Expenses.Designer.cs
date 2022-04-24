namespace RK_Cosmetics_System
{
    partial class frm_Add_Expenses
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
            this.lbl_Add_Expense = new System.Windows.Forms.Label();
            this.pnl_Expense_Back = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Expenses_Details = new System.Windows.Forms.Label();
            this.tb_Expense_Details = new System.Windows.Forms.TextBox();
            this.lbl_Bill_Image = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Amount_Paid = new System.Windows.Forms.Label();
            this.lbl_Paid_By = new System.Windows.Forms.Label();
            this.tb_Paid_By = new System.Windows.Forms.TextBox();
            this.pnl_Date_Back = new System.Windows.Forms.Panel();
            this.lbl_For_Date = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Expense_ID = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Expense_ID = new System.Windows.Forms.TextBox();
            this.tb_Amount_Paid = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.pnl_Expense_Back.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnl_Date_Back.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Add_Expense
            // 
            this.lbl_Add_Expense.AutoSize = true;
            this.lbl_Add_Expense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Add_Expense.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_Expense.Location = new System.Drawing.Point(934, 23);
            this.lbl_Add_Expense.Name = "lbl_Add_Expense";
            this.lbl_Add_Expense.Size = new System.Drawing.Size(368, 60);
            this.lbl_Add_Expense.TabIndex = 9;
            this.lbl_Add_Expense.Text = "Add Expense";
            // 
            // pnl_Expense_Back
            // 
            this.pnl_Expense_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Expense_Back.Controls.Add(this.btn_Browse);
            this.pnl_Expense_Back.Controls.Add(this.tableLayoutPanel2);
            this.pnl_Expense_Back.Controls.Add(this.tableLayoutPanel3);
            this.pnl_Expense_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Expense_Back.Controls.Add(this.btn_Refresh);
            this.pnl_Expense_Back.Controls.Add(this.btn_Save);
            this.pnl_Expense_Back.ForeColor = System.Drawing.Color.White;
            this.pnl_Expense_Back.Location = new System.Drawing.Point(229, 118);
            this.pnl_Expense_Back.Name = "pnl_Expense_Back";
            this.pnl_Expense_Back.Size = new System.Drawing.Size(1712, 738);
            this.pnl_Expense_Back.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00459F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Expenses_Details, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Expense_Details, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Bill_Image, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_Bill_Image, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(279, 173);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.04878F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1307, 185);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // lbl_Expenses_Details
            // 
            this.lbl_Expenses_Details.AutoSize = true;
            this.lbl_Expenses_Details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expenses_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_Expenses_Details.Location = new System.Drawing.Point(3, 0);
            this.lbl_Expenses_Details.Name = "lbl_Expenses_Details";
            this.lbl_Expenses_Details.Size = new System.Drawing.Size(198, 28);
            this.lbl_Expenses_Details.TabIndex = 0;
            this.lbl_Expenses_Details.Text = "Expense Details";
            // 
            // tb_Expense_Details
            // 
            this.tb_Expense_Details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Expense_Details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expense_Details.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Expense_Details.Location = new System.Drawing.Point(3, 41);
            this.tb_Expense_Details.Multiline = true;
            this.tb_Expense_Details.Name = "tb_Expense_Details";
            this.tb_Expense_Details.Size = new System.Drawing.Size(395, 123);
            this.tb_Expense_Details.TabIndex = 6;
            this.tb_Expense_Details.Text = "Ex.tea";
            this.tb_Expense_Details.Click += new System.EventHandler(this.tb_Expense_Details_Click);
            // 
            // lbl_Bill_Image
            // 
            this.lbl_Bill_Image.AutoSize = true;
            this.lbl_Bill_Image.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Image.ForeColor = System.Drawing.Color.White;
            this.lbl_Bill_Image.Location = new System.Drawing.Point(761, 0);
            this.lbl_Bill_Image.Name = "lbl_Bill_Image";
            this.lbl_Bill_Image.Size = new System.Drawing.Size(128, 28);
            this.lbl_Bill_Image.TabIndex = 4;
            this.lbl_Bill_Image.Text = "Bill Image";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00459F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Amount_Paid, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Paid_By, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Paid_By, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Amount_Paid, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(279, 467);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1307, 125);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // lbl_Amount_Paid
            // 
            this.lbl_Amount_Paid.AutoSize = true;
            this.lbl_Amount_Paid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount_Paid.ForeColor = System.Drawing.Color.White;
            this.lbl_Amount_Paid.Location = new System.Drawing.Point(3, 0);
            this.lbl_Amount_Paid.Name = "lbl_Amount_Paid";
            this.lbl_Amount_Paid.Size = new System.Drawing.Size(158, 28);
            this.lbl_Amount_Paid.TabIndex = 0;
            this.lbl_Amount_Paid.Text = "Amount Paid";
            // 
            // lbl_Paid_By
            // 
            this.lbl_Paid_By.AutoSize = true;
            this.lbl_Paid_By.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid_By.ForeColor = System.Drawing.Color.White;
            this.lbl_Paid_By.Location = new System.Drawing.Point(761, 0);
            this.lbl_Paid_By.Name = "lbl_Paid_By";
            this.lbl_Paid_By.Size = new System.Drawing.Size(100, 28);
            this.lbl_Paid_By.TabIndex = 4;
            this.lbl_Paid_By.Text = "Paid By";
            // 
            // tb_Paid_By
            // 
            this.tb_Paid_By.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Paid_By.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Paid_By.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Paid_By.Location = new System.Drawing.Point(761, 53);
            this.tb_Paid_By.Multiline = true;
            this.tb_Paid_By.Name = "tb_Paid_By";
            this.tb_Paid_By.Size = new System.Drawing.Size(395, 52);
            this.tb_Paid_By.TabIndex = 7;
            this.tb_Paid_By.Text = "Ex.1500";
            this.tb_Paid_By.Click += new System.EventHandler(this.tb_Paid_By_Click);
            // 
            // pnl_Date_Back
            // 
            this.pnl_Date_Back.Controls.Add(this.lbl_For_Date);
            this.pnl_Date_Back.Location = new System.Drawing.Point(761, 50);
            this.pnl_Date_Back.Name = "pnl_Date_Back";
            this.pnl_Date_Back.Size = new System.Drawing.Size(395, 52);
            this.pnl_Date_Back.TabIndex = 11;
            // 
            // lbl_For_Date
            // 
            this.lbl_For_Date.AutoSize = true;
            this.lbl_For_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_For_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_For_Date.Location = new System.Drawing.Point(3, 10);
            this.lbl_For_Date.Name = "lbl_For_Date";
            this.lbl_For_Date.Size = new System.Drawing.Size(80, 32);
            this.lbl_For_Date.TabIndex = 9;
            this.lbl_For_Date.Text = "Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00459F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Expense_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Expense_ID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Date_Back, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(279, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1307, 125);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // lbl_Expense_ID
            // 
            this.lbl_Expense_ID.AutoSize = true;
            this.lbl_Expense_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expense_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_Expense_ID.Location = new System.Drawing.Point(3, 0);
            this.lbl_Expense_ID.Name = "lbl_Expense_ID";
            this.lbl_Expense_ID.Size = new System.Drawing.Size(143, 28);
            this.lbl_Expense_ID.TabIndex = 0;
            this.lbl_Expense_ID.Text = "Expense ID";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(761, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(66, 28);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1058, 638);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 54);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(582, 638);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 54);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // tb_Expense_ID
            // 
            this.tb_Expense_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Expense_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expense_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Expense_ID.Location = new System.Drawing.Point(3, 50);
            this.tb_Expense_ID.Multiline = true;
            this.tb_Expense_ID.Name = "tb_Expense_ID";
            this.tb_Expense_ID.Size = new System.Drawing.Size(395, 52);
            this.tb_Expense_ID.TabIndex = 7;
            this.tb_Expense_ID.Text = "Ex.12";
            // 
            // tb_Amount_Paid
            // 
            this.tb_Amount_Paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Amount_Paid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount_Paid.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Amount_Paid.Location = new System.Drawing.Point(3, 53);
            this.tb_Amount_Paid.Multiline = true;
            this.tb_Amount_Paid.Name = "tb_Amount_Paid";
            this.tb_Amount_Paid.Size = new System.Drawing.Size(395, 52);
            this.tb_Amount_Paid.TabIndex = 8;
            this.tb_Amount_Paid.Text = "Ex.1200";
            this.tb_Amount_Paid.Click += new System.EventHandler(this.tb_Amount_Paid_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.FlatAppearance.BorderSize = 0;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Browse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btn_Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Browse.Location = new System.Drawing.Point(1153, 386);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(171, 54);
            this.btn_Browse.TabIndex = 15;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.Location = new System.Drawing.Point(761, 41);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(395, 132);
            this.pb_Bill_Image.TabIndex = 7;
            this.pb_Bill_Image.TabStop = false;
            // 
            // frm_Add_Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lbl_Add_Expense);
            this.Controls.Add(this.pnl_Expense_Back);
            this.Name = "frm_Add_Expenses";
            this.Text = "Add Expenses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Expenses_Load);
            this.pnl_Expense_Back.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnl_Date_Back.ResumeLayout(false);
            this.pnl_Date_Back.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Expense;
        private System.Windows.Forms.Panel pnl_Expense_Back;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Expenses_Details;
        private System.Windows.Forms.TextBox tb_Expense_Details;
        private System.Windows.Forms.Label lbl_Bill_Image;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Amount_Paid;
        private System.Windows.Forms.Label lbl_Paid_By;
        private System.Windows.Forms.TextBox tb_Paid_By;
        private System.Windows.Forms.TextBox tb_Amount_Paid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Expense_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Expense_ID;
        private System.Windows.Forms.Panel pnl_Date_Back;
        private System.Windows.Forms.Label lbl_For_Date;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
    }
}