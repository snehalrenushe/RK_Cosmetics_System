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
    public partial class frm_Add_New_Distributor : Form
    {
        public frm_Add_New_Distributor()
        {
            InitializeComponent();
        }

        private void frm_Add_New_Distributor_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_New_Distributor.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Distributor_Back.BackColor = Color.FromArgb(42, 42, 54);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

            tb_Name.BackColor = Color.FromArgb(33, 33, 55);
            pnl_For_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Date.ForeColor = Color.FromArgb(100,100,100);
            lbl_For_Date.Text = DateTime.Now.ToString();
            tb_Distributor_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Mobile_No.BackColor = Color.FromArgb(33, 33, 55);
            tb_Email_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Address.BackColor = Color.FromArgb(33, 33, 55);
            tb_Registration_No.BackColor = Color.FromArgb(33, 33, 55);
            tb_Aadhar_No.BackColor = Color.FromArgb(33, 33, 55);

        }

        private void tb_Name_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
        }

        private void tb_Registration_No_Click(object sender, EventArgs e)
        {
            tb_Registration_No.Text = "";
        }

        private void tb_Mobile_No_Click(object sender, EventArgs e)
        {
            tb_Mobile_No.Text = "";
        }

        private void tb_Aadhar_No_Click(object sender, EventArgs e)
        {
            tb_Aadhar_No.Text = "";
        }

        private void tb_Email_ID_Click(object sender, EventArgs e)
        {
            tb_Email_ID.Text = "";
        }

        private void tb_Address_Click(object sender, EventArgs e)
        {
            tb_Address.Text = "";
        }
    }
}
