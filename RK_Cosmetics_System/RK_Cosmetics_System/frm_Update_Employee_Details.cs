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
    public partial class frm_Update_Employee_Details : Form
    {
        public frm_Update_Employee_Details()
        {
            InitializeComponent();
        }

        private void frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Update_Employee_Details.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Update_Employee_Back.BackColor = Color.FromArgb(42, 42, 54);

            btn_Search.BackColor = Color.FromArgb(255, 0, 111);
            btn_Update.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

            tb_Employee_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Mobile_No.BackColor = Color.FromArgb(33, 33, 55);
            tb_Email_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Address.BackColor = Color.FromArgb(33, 33, 55);
        }

        private void tb_Name_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
        }

        private void tb_Mobile_No_Click(object sender, EventArgs e)
        {
            tb_Mobile_No.Text = "";
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
