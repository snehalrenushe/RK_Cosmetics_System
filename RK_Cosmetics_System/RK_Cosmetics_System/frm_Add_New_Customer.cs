using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_New_Customer.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Customer_Details_Back.BackColor = Color.FromArgb(42, 42, 54);
            pnl_Customer_Purchase_Back.BackColor = Color.FromArgb(42, 42, 54);
            pnl_Customer_Bill_Back.BackColor = Color.FromArgb(42, 42, 54);

            dgv_Add_Customer.BackgroundColor = Color.FromArgb(82,82,92);

            tb_ID.BackColor = Color.FromArgb(33, 33, 55);

            lbl_For_Date.Text = DateTime.Now.ToString();
            lbl_For_Date.BackColor = Color.FromArgb(33, 33, 55);

            tb_Mobile_No.BackColor = Color.FromArgb(33, 33, 55);
            tb_Name.BackColor = Color.FromArgb(33, 33, 55);

            cb_Brand_Name.BackColor = Color.FromArgb(33, 33, 55);
            cb_Product_Name.BackColor = Color.FromArgb(33, 33, 55);

            tb_Per_Price.BackColor = Color.FromArgb(33, 33, 55);
            tb_Quantity.BackColor = Color.FromArgb(33, 33, 55);
            tb_GST_Applied.BackColor = Color.FromArgb(33, 33, 55);
            tb_Price.BackColor = Color.FromArgb(33, 33, 55);
            tb_Bill.BackColor = Color.FromArgb(33, 33, 55);
            tb_Discount.BackColor = Color.FromArgb(33, 33, 55);
            tb_Final_Bill.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Add.BackColor = Color.FromArgb(255, 0, 111);
        }

        private void tb_ID_Click(object sender, EventArgs e)
        {
            tb_ID.Text = "";
        }

        private void tb_Name_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
        }

        private void tb_Mobile_No_Click(object sender, EventArgs e)
        {
            tb_Mobile_No.Text = "";
        }

        private void tb_Per_Price_Click(object sender, EventArgs e)
        {
            tb_Per_Price.Text = "";
        }

        private void tb_GST_Applied_Click(object sender, EventArgs e)
        {
            tb_GST_Applied.Text = "";
        }

        private void tb_Quantity_Click(object sender, EventArgs e)
        {
            tb_Quantity.Text = "";
        }

        private void tb_Price_Click(object sender, EventArgs e)
        {
            tb_Price.Text = "";
        }

        private void tb_Bill_Click(object sender, EventArgs e)
        {
            tb_Bill.Text = "";
        }

        private void tb_Discount_Click(object sender, EventArgs e)
        {
            tb_Discount.Text = "";
        }

        private void tb_Final_Bill_Click(object sender, EventArgs e)
        {
            tb_Final_Bill.Text = "";
        }

    }
}
