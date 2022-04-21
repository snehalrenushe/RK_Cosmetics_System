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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_New_Employee.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Employee_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Name.BackColor = Color.FromArgb(33, 33, 55);

            tb_Employee_ID.BackColor = Color.FromArgb(33, 33, 55);

            tb_Mobile_No.BackColor = Color.FromArgb(33, 33, 55);

            lbl_For_Joining_Date.Text = DateTime.Now.ToString();
            lbl_For_Joining_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Joining_Date.ForeColor = Color.FromArgb(100,100,100);
            pnl_Joining_Date_Back.BackColor = Color.FromArgb(33, 33, 55);

            tb_Aadhar_No.BackColor = Color.FromArgb(33, 33, 55);

            tb_Age.BackColor = Color.FromArgb(33, 33, 55);

            pnl_Back_Gender.BackColor = Color.FromArgb(33, 33, 55);

            tb_Email_ID.BackColor = Color.FromArgb(33, 33, 55);

            tb_Address.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);
        }

        private void tb_Name_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
        }

        private void tb_Employee_ID_Click(object sender, EventArgs e)
        {
            tb_Employee_ID.Text = "";
        }

        private void tb_Mobile_No_Click(object sender, EventArgs e)
        {
            tb_Mobile_No.Text = "";
        }

        private void tb_Aadhar_No_Click(object sender, EventArgs e)
        {
            tb_Aadhar_No.Text = "";
        }

        private void tb_Age_Click(object sender, EventArgs e)
        {
            tb_Age.Text = "";
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
