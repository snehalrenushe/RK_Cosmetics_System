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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_User ANU = new frm_Add_New_User();

            ANU.MdiParent = this;
            ANU.WindowState = FormWindowState.Maximized;
            ANU.Show();
            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Change_Password CP = new frm_Change_Password();

            CP.MdiParent = this;
            CP.WindowState = FormWindowState.Maximized;
            CP.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Delete_User DU = new frm_Delete_User();

            DU.MdiParent = this;
            DU.WindowState = FormWindowState.Maximized;
            DU.Show();
        }

        private void frm_User_Management_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Non_Admin_Entry_Form NAEF = new frm_Non_Admin_Entry_Form();

            NAEF.Show();
            this.Hide();
        }

        
    }
}
