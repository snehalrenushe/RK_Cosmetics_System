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
    public partial class frm_Login_Page : Form
    {
        public frm_Login_Page()
        {
            InitializeComponent();
        }

        private void frm_Login_Page_Load(object sender, EventArgs e)
        {
            pnl_Left_Container.BackColor = Color.FromArgb(51, 49, 49);
            btn_Close.ForeColor = Color.FromArgb(51,49,49);
            lbl_Login_To_Your_Account.ForeColor = Color.FromArgb(51, 49, 49);

            tb_Username.ForeColor = Color.FromArgb(51, 49, 49);
            tb_Password.ForeColor = Color.FromArgb(51, 49, 49);

            btn_Login.BackColor = Color.FromArgb(51, 49, 49);
            btn_Sign_In.ForeColor = Color.FromArgb(51, 49, 49);
            btn_Sign_In.FlatAppearance.BorderColor = Color.FromArgb(51,49,49);
        }

        private void tb_Username_Click(object sender, EventArgs e)
        {
            tb_Username.BackColor = Color.White;
            pnl_Username.BackColor = Color.White;
            tb_Password.BackColor = Color.HotPink;
            pnl_Password.BackColor = Color.HotPink;
        }

        private void tb_Password_Click(object sender, EventArgs e)
        {
            tb_Password.BackColor = Color.White;
            pnl_Password.BackColor = Color.White;
            tb_Username.BackColor = Color.HotPink;
            pnl_Username.BackColor = Color.HotPink;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            tb_Password.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            tb_Password.UseSystemPasswordChar = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            MDI m = new MDI();
            this.Hide();
            m.Show();
        }

        private void pnl_Username_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
