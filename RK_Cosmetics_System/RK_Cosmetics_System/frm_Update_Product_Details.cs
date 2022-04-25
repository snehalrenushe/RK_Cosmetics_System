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
    public partial class frm_Update_Product_Details : Form
    {
        public frm_Update_Product_Details()
        {
            InitializeComponent();
        }

        private void frm_Update_Product_Details_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Update_Product_Details.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Update_Product_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Product_ID.BackColor = Color.FromArgb(33, 33, 55);
            cb_Brand_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Product_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Description.BackColor = Color.FromArgb(33, 33, 55);
            tb_Purchase_Price.BackColor = Color.FromArgb(33, 33, 55);
            tb_Selling_Price.BackColor = Color.FromArgb(33, 33, 55);
            tb_Stock.BackColor = Color.FromArgb(33, 33, 55);

            btn_Search.BackColor = Color.FromArgb(255, 0, 111);
            btn_Update.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);
        }
    }
}
