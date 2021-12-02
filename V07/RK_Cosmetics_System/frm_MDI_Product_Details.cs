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
    public partial class frm_MDI_Product_Details : Form
    {
        public frm_MDI_Product_Details()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();

            AEF.Show();
            this.Hide();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product ANP = new frm_Add_New_Product();

            ANP.MdiParent = this;
            ANP.WindowState = FormWindowState.Maximized;
            ANP.Show();
        }

        private void UpdateProductDetailstoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Update_Product_Details UPD = new frm_Update_Product_Details();

            UPD.MdiParent = this;
            UPD.WindowState = FormWindowState.Maximized;
            UPD.Show();
        }

        private void ViewProductDetailstoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_View_Product_Details VPD = new frm_View_Product_Details();

            VPD.MdiParent = this;
            VPD.WindowState = FormWindowState.Maximized;
            VPD.Show();
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
