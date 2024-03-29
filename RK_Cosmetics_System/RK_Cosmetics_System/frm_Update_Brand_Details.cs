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
    public partial class frm_Update_Brand_Details : Form
    {
        public frm_Update_Brand_Details()
        {
            InitializeComponent();
        }

        private void frm_Update_Brand_Details_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Update_Brand_Details.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Update_Brand_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Brand_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Brand_ID.BackColor = Color.FromArgb(33, 33, 55);

            pnl_Back_Status.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);
            btn_Search.BackColor = Color.FromArgb(255, 0, 111);
        }

        private void tb_Brand_Name_Click(object sender, EventArgs e)
        {
            tb_Brand_Name.Text = "";
        }
    }
}
