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
    public partial class frm_MDI_Expences_Details : Form
    {
        public frm_MDI_Expences_Details()
        {
            InitializeComponent();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Expences FE = new frm_Expences();

            FE.MdiParent = this;

            FE.WindowState = FormWindowState.Maximized;

            FE.Show();
        }

        private void ViewExpensesDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_View_Expences_Details VED = new frm_View_Expences_Details();

            VED.MdiParent = this;

            VED.WindowState = FormWindowState.Maximized;

            VED.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show(" Are You Sure....!!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();

                LF.Show();

                this.Hide();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();

            this.Hide();
        }
    }
}
