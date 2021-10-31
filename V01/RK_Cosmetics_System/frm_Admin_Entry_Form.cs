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

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            frm_MDI_Employee_Details MED = new frm_MDI_Employee_Details();

            MED.Show();
            this.Hide();
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            frm_MDI_Distributor_Details MDD = new frm_MDI_Distributor_Details();

            MDD.Show();
            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            frm_MDI_Product_Details MPD = new frm_MDI_Product_Details();

            MPD.Show();
            this.Hide();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            frm_MDI_Stock_Details MSD = new frm_MDI_Stock_Details();

            MSD.Show();
            this.Hide();
        }
    }
}
