namespace RK_Cosmetics_System
{
    partial class frm_Add_Stock
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
            this.lbl_Add_Stock = new System.Windows.Forms.Label();
            this.pnl_Stock_Back = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Manufacturing_Date = new System.Windows.Forms.Label();
            this.lbl_Expiry_Date = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Current_Stock_Quantity = new System.Windows.Forms.Label();
            this.tb_Current_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_New_Added_Stock = new System.Windows.Forms.Label();
            this.tb_New_Added_Stock = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_Brand_Name = new System.Windows.Forms.ComboBox();
            this.cb_Product_Name = new System.Windows.Forms.ComboBox();
            this.dtp_Manufacturing_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Expiry_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Date_Back = new System.Windows.Forms.Panel();
            this.lbl_For_Date = new System.Windows.Forms.Label();
            this.pnl_Stock_Back.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_Date_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_Stock
            // 
            this.lbl_Add_Stock.AutoSize = true;
            this.lbl_Add_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Add_Stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_Stock.Location = new System.Drawing.Point(863, 25);
            this.lbl_Add_Stock.Name = "lbl_Add_Stock";
            this.lbl_Add_Stock.Size = new System.Drawing.Size(295, 60);
            this.lbl_Add_Stock.TabIndex = 7;
            this.lbl_Add_Stock.Text = "Add Stock";
            // 
            // pnl_Stock_Back
            // 
            this.pnl_Stock_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Stock_Back.Controls.Add(this.tableLayoutPanel4);
            this.pnl_Stock_Back.Controls.Add(this.tableLayoutPanel2);
            this.pnl_Stock_Back.Controls.Add(this.tableLayoutPanel3);
            this.pnl_Stock_Back.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Stock_Back.Controls.Add(this.btn_Refresh);
            this.pnl_Stock_Back.Controls.Add(this.btn_Save);
            this.pnl_Stock_Back.ForeColor = System.Drawing.Color.White;
            this.pnl_Stock_Back.Location = new System.Drawing.Point(135, 120);
            this.pnl_Stock_Back.Name = "pnl_Stock_Back";
            this.pnl_Stock_Back.Size = new System.Drawing.Size(1712, 738);
            this.pnl_Stock_Back.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00459F));
            this.tableLayoutPanel4.Controls.Add(this.dtp_Expiry_Date, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Manufacturing_Date, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Expiry_Date, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtp_Manufacturing_Date, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(279, 470);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1307, 125);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // lbl_Manufacturing_Date
            // 
            this.lbl_Manufacturing_Date.AutoSize = true;
            this.lbl_Manufacturing_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manufacturing_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Manufacturing_Date.Location = new System.Drawing.Point(3, 0);
            this.lbl_Manufacturing_Date.Name = "lbl_Manufacturing_Date";
            this.lbl_Manufacturing_Date.Size = new System.Drawing.Size(239, 28);
            this.lbl_Manufacturing_Date.TabIndex = 0;
            this.lbl_Manufacturing_Date.Text = "Manufacturing Date";
            // 
            // lbl_Expiry_Date
            // 
            this.lbl_Expiry_Date.AutoSize = true;
            this.lbl_Expiry_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expiry_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Expiry_Date.Location = new System.Drawing.Point(761, 0);
            this.lbl_Expiry_Date.Name = "lbl_Expiry_Date";
            this.lbl_Expiry_Date.Size = new System.Drawing.Size(147, 28);
            this.lbl_Expiry_Date.TabIndex = 4;
            this.lbl_Expiry_Date.Text = "Expiry Date";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00459F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Current_Stock_Quantity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Current_Stock_Quantity, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_New_Added_Stock, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_New_Added_Stock, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(279, 324);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1307, 125);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // lbl_Current_Stock_Quantity
            // 
            this.lbl_Current_Stock_Quantity.AutoSize = true;
            this.lbl_Current_Stock_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock_Quantity.ForeColor = System.Drawing.Color.White;
            this.lbl_Current_Stock_Quantity.Location = new System.Drawing.Point(3, 0);
            this.lbl_Current_Stock_Quantity.Name = "lbl_Current_Stock_Quantity";
            this.lbl_Current_Stock_Quantity.Size = new System.Drawing.Size(277, 28);
            this.lbl_Current_Stock_Quantity.TabIndex = 0;
            this.lbl_Current_Stock_Quantity.Text = "Current Stock Quantity";
            // 
            // tb_Current_Stock_Quantity
            // 
            this.tb_Current_Stock_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Current_Stock_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock_Quantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Current_Stock_Quantity.Location = new System.Drawing.Point(3, 53);
            this.tb_Current_Stock_Quantity.Multiline = true;
            this.tb_Current_Stock_Quantity.Name = "tb_Current_Stock_Quantity";
            this.tb_Current_Stock_Quantity.Size = new System.Drawing.Size(395, 52);
            this.tb_Current_Stock_Quantity.TabIndex = 6;
            this.tb_Current_Stock_Quantity.Text = "Ex.12";
            // 
            // lbl_New_Added_Stock
            // 
            this.lbl_New_Added_Stock.AutoSize = true;
            this.lbl_New_Added_Stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Added_Stock.ForeColor = System.Drawing.Color.White;
            this.lbl_New_Added_Stock.Location = new System.Drawing.Point(761, 0);
            this.lbl_New_Added_Stock.Name = "lbl_New_Added_Stock";
            this.lbl_New_Added_Stock.Size = new System.Drawing.Size(218, 28);
            this.lbl_New_Added_Stock.TabIndex = 4;
            this.lbl_New_Added_Stock.Text = "New Added Stock";
            // 
            // tb_New_Added_Stock
            // 
            this.tb_New_Added_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_New_Added_Stock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Added_Stock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_New_Added_Stock.Location = new System.Drawing.Point(761, 53);
            this.tb_New_Added_Stock.Multiline = true;
            this.tb_New_Added_Stock.Name = "tb_New_Added_Stock";
            this.tb_New_Added_Stock.Size = new System.Drawing.Size(395, 52);
            this.tb_New_Added_Stock.TabIndex = 7;
            this.tb_New_Added_Stock.Text = "Ex.2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00459F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_Date, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Product_ID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Product_ID, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pnl_Date_Back, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(279, 176);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1307, 125);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(3, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(66, 28);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_ID.Location = new System.Drawing.Point(761, 0);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(136, 28);
            this.lbl_Product_ID.TabIndex = 4;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Product_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_Product_ID.Location = new System.Drawing.Point(761, 53);
            this.tb_Product_ID.Multiline = true;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(395, 52);
            this.tb_Product_ID.TabIndex = 7;
            this.tb_Product_ID.Text = "Ex.101";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.99541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.00459F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Brand_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Product_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Brand_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_Product_Name, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(279, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1307, 125);
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
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Product_Name.Location = new System.Drawing.Point(761, 0);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(177, 28);
            this.lbl_Product_Name.TabIndex = 4;
            this.lbl_Product_Name.Text = "Product Name";
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
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.BackColor = System.Drawing.Color.White;
            this.cb_Brand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Brand_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Brand_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cb_Brand_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_Brand_Name.FormattingEnabled = true;
            this.cb_Brand_Name.Items.AddRange(new object[] {
            "kjh",
            "klj",
            "kj",
            "iu"});
            this.cb_Brand_Name.Location = new System.Drawing.Point(3, 50);
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(395, 40);
            this.cb_Brand_Name.TabIndex = 12;
            // 
            // cb_Product_Name
            // 
            this.cb_Product_Name.BackColor = System.Drawing.Color.White;
            this.cb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Product_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cb_Product_Name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_Product_Name.FormattingEnabled = true;
            this.cb_Product_Name.Items.AddRange(new object[] {
            "kjh",
            "klj",
            "kj",
            "iu"});
            this.cb_Product_Name.Location = new System.Drawing.Point(761, 50);
            this.cb_Product_Name.Name = "cb_Product_Name";
            this.cb_Product_Name.Size = new System.Drawing.Size(395, 40);
            this.cb_Product_Name.TabIndex = 13;
            // 
            // dtp_Manufacturing_Date
            // 
            this.dtp_Manufacturing_Date.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtp_Manufacturing_Date.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtp_Manufacturing_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.dtp_Manufacturing_Date.Location = new System.Drawing.Point(3, 53);
            this.dtp_Manufacturing_Date.Name = "dtp_Manufacturing_Date";
            this.dtp_Manufacturing_Date.Size = new System.Drawing.Size(395, 40);
            this.dtp_Manufacturing_Date.TabIndex = 5;
            // 
            // dtp_Expiry_Date
            // 
            this.dtp_Expiry_Date.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtp_Expiry_Date.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtp_Expiry_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.dtp_Expiry_Date.Location = new System.Drawing.Point(761, 53);
            this.dtp_Expiry_Date.Name = "dtp_Expiry_Date";
            this.dtp_Expiry_Date.Size = new System.Drawing.Size(395, 40);
            this.dtp_Expiry_Date.TabIndex = 6;
            // 
            // pnl_Date_Back
            // 
            this.pnl_Date_Back.Controls.Add(this.lbl_For_Date);
            this.pnl_Date_Back.Location = new System.Drawing.Point(3, 53);
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
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lbl_Add_Stock);
            this.Controls.Add(this.pnl_Stock_Back);
            this.Name = "frm_Add_Stock";
            this.Text = "Add Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.pnl_Stock_Back.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnl_Date_Back.ResumeLayout(false);
            this.pnl_Date_Back.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Stock;
        private System.Windows.Forms.Panel pnl_Stock_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_Manufacturing_Date;
        private System.Windows.Forms.Label lbl_Expiry_Date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Current_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_Current_Stock_Quantity;
        private System.Windows.Forms.Label lbl_New_Added_Stock;
        private System.Windows.Forms.TextBox tb_New_Added_Stock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_Expiry_Date;
        private System.Windows.Forms.DateTimePicker dtp_Manufacturing_Date;
        private System.Windows.Forms.ComboBox cb_Brand_Name;
        private System.Windows.Forms.ComboBox cb_Product_Name;
        private System.Windows.Forms.Panel pnl_Date_Back;
        private System.Windows.Forms.Label lbl_For_Date;
    }
}