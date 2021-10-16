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
    public partial class frm_MDI_User_Management : Form
    {
        public frm_MDI_User_Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();
            this.Hide();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_User ANU = new frm_Add_New_User();

            ANU.MdiParent = this;
            ANU.WindowState = FormWindowState.Maximized;
            ANU.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Change_Password CP = new frm_Change_Password();

            CP.MdiParent = this;
            CP.WindowState = FormWindowState.Maximized;
            CP.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Delete_User DU = new frm_Delete_User();

            DU.MdiParent = this;
            DU.WindowState = FormWindowState.Maximized;
            DU.Show();
        }

        
    }
}
