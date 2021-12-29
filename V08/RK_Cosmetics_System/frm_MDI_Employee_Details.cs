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
    public partial class frm_MDI_Employee_Details : Form
    {
        public frm_MDI_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();
            this.Hide();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ANE = new frm_Add_New_Employee();

            ANE.MdiParent = this;
            ANE.WindowState = FormWindowState.Maximized;
            ANE.Show();
        }

        private void UpdateEmployeeDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Update_Employee_Details UED = new frm_Update_Employee_Details();

            UED.MdiParent = this;
            UED.WindowState = FormWindowState.Maximized;
            UED.Show();
        }

        private void ViewEmployeeDetailstoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_View_Employee_Details VED = new frm_View_Employee_Details();

            VED.MdiParent = this;
            VED.WindowState = FormWindowState.Maximized;
            VED.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out", "Are you Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();

                LF.Show();

                this.Hide();
            }
        }
    }
}
