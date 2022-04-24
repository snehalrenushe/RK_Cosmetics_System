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
    public partial class frm_Add_Stock : Form
    {
        public frm_Add_Stock()
        {
            InitializeComponent();
        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_Stock.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Stock_Back.BackColor = Color.FromArgb(42, 42, 54);

            cb_Brand_Name.BackColor = Color.FromArgb(33, 33, 55);
            cb_Product_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Product_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Current_Stock_Quantity.BackColor = Color.FromArgb(33, 33, 55);
            tb_New_Added_Stock.BackColor = Color.FromArgb(33, 33, 55);

            lbl_For_Date.Text = DateTime.Now.ToString();
            lbl_For_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Date.ForeColor = Color.FromArgb(100, 100, 100);
            pnl_Date_Back.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);
        }
    }
}
