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
    public partial class frm_View_Product_List : Form
    {
        public frm_View_Product_List()
        {
            InitializeComponent();
        }

        private void frm_View_Product_List_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_View_Product_List.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_View_Product_Back.BackColor = Color.FromArgb(42, 42, 54);

            btn_Search.BackColor = Color.FromArgb(255, 0, 111);

            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

            dgv_Product_List.BackgroundColor = Color.FromArgb(82,82,92);

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
