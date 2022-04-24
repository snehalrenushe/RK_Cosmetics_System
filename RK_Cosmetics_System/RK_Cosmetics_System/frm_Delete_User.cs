﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class frm_Delete_User : Form
    {
        public frm_Delete_User()
        {
            InitializeComponent();
        }

        private void frm_Delete_User_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Delete_User.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Add_User_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Username.BackColor = Color.FromArgb(33, 33, 55);
            tb_Password.BackColor = Color.FromArgb(33, 33, 55);

            btn_Delete.BackColor = Color.FromArgb(255, 0, 111);
            btn_Close.BackColor = Color.FromArgb(255, 0, 111);
        }

        private void tb_Username_Click(object sender, EventArgs e)
        {
            tb_Username.Text = "";
        }

        private void tb_Password_Click(object sender, EventArgs e)
        {
            tb_Password.Text = "";
        }
    }
}
