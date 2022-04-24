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
    public partial class frm_Change_Password : Form
    {
        public frm_Change_Password()
        {
            InitializeComponent();
        }

        private void frm_Change_Password_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Change_Password.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Change_Password_Back.BackColor = Color.FromArgb(42, 42, 54);

            cb_Username.BackColor = Color.FromArgb(33, 33, 55);

            tb_Current_Password.BackColor = Color.FromArgb(33, 33, 55);
            tb_New_Password.BackColor = Color.FromArgb(33, 33, 55);

            btn_Update.BackColor = Color.FromArgb(255, 0, 111);
            btn_Close.BackColor = Color.FromArgb(255, 0, 111);
        }

        private void tb_Current_Password_Click(object sender, EventArgs e)
        {
            tb_Current_Password.Text = "";
        }

        private void tb_New_Password_Click(object sender, EventArgs e)
        {
            tb_New_Password.Text = "";
        }
    }
}
