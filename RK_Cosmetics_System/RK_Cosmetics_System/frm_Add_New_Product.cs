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
        }
    }
}
