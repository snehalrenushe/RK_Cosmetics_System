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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
        {
            InitializeComponent();
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26,26,26);

            lbl_Add_New_Product.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Product_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Product_Name.BackColor = Color.FromArgb(33,33,55);

            cb_Brand_Name.BackColor = Color.FromArgb(33, 33, 55);

            tb_Product_ID.BackColor = Color.FromArgb(33, 33, 55);

            tb_Purchase_Price.BackColor = Color.FromArgb(33, 33, 55);

            tb_Selling_Price.BackColor = Color.FromArgb(33, 33, 55);

            tb_Stock.BackColor = Color.FromArgb(33, 33, 55);

            tb_GST.BackColor = Color.FromArgb(33, 33, 55);

            cb_Distributor_Name.BackColor = Color.FromArgb(33, 33, 55);

            tb_Description.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

            lbl_For_Date.Text = DateTime.Now.ToString();

            lbl_For_Date.BackColor = Color.FromArgb(33,33,55);

        }

        private void tb_Product_Name_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Product_Name_Click(object sender, EventArgs e)
        {
            tb_Product_Name.Text = "";
        }
        private void tb_Product_ID_Click(object sender, EventArgs e)
        {
            tb_Product_ID.Text = "";
        }

        private void tb_Purchase_Price_Click(object sender, EventArgs e)
        {
            tb_Purchase_Price.Text = "";
        }

        private void tb_Selling_Price_Click(object sender, EventArgs e)
        {
            tb_Selling_Price.Text = "";
        }

        private void tb_Stock_Click(object sender, EventArgs e)
        {
            tb_Stock.Text = "";
        }

        private void tb_GST_Click(object sender, EventArgs e)
        {
            tb_GST.Text = "";
        }

        private void tb_Description_Click(object sender, EventArgs e)
        {
            tb_Description.Text = "";
        }

        private void pnl_Product_Back_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
