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
    public partial class frm_Non_Admin_Entry_Form : Form
    {
        public frm_Non_Admin_Entry_Form()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_MDI_Customer_Details MCD = new frm_MDI_Customer_Details();

            MCD.Show();
            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            frm_MDI_Product_Details MPD = new frm_MDI_Product_Details();

            MPD.Show();
            this.Hide();
        }
    }
}
