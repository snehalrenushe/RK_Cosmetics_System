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
    public partial class frm_MDI_Customer_Details : Form
    {
        public frm_MDI_Customer_Details()
        {
            InitializeComponent();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer ANC = new frm_Add_New_Customer();

            ANC.MdiParent = this;
            ANC.WindowState = FormWindowState.Maximized;
            ANC.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();
            this.Hide();
        }

        private void ViewCustomerDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Customer_Details VCD = new frm_View_Customer_Details();

            VCD.MdiParent = this;
            VCD.WindowState = FormWindowState.Maximized;
            VCD.Show();
        }
    }
}
