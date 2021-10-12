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
    public partial class frm_Admin_Entry_Form : Form
    {
        public frm_Admin_Entry_Form()
        {
            InitializeComponent();
        }

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            frm_MDI_User_Management UM = new frm_MDI_User_Management();
            UM.Show();
            this.Hide();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_MDI_Customer_Details MCD = new frm_MDI_Customer_Details();

            MCD.Show();
            this.Hide();
        }
    }
}
