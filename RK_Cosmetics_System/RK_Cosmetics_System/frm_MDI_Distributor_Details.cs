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
    public partial class frm_MDI_Distributor_Details : Form
    {
        public frm_MDI_Distributor_Details()
        {
            InitializeComponent();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Distributor AND = new frm_Add_New_Distributor();

            AND.MdiParent = this;
            AND.WindowState = FormWindowState.Maximized;
            AND.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Update_Distributor_Details UDD = new frm_Update_Distributor_Details();

            UDD.MdiParent = this;
            UDD.WindowState = FormWindowState.Maximized;
            UDD.Show();
        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frm_View_Distributor_Details VDD = new frm_View_Distributor_Details();

            VDD.MdiParent = this;
            VDD.WindowState = FormWindowState.Maximized;
            VDD.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();
            this.Hide();
        }
    }
}
