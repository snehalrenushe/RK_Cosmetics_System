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
    public partial class frm_View_Expense_Details : Form
    {
        public frm_View_Expense_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Expense_Details_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_View_Expense_List.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_View_Expense_Back.BackColor = Color.FromArgb(42, 42, 54);

            btn_Search.BackColor = Color.FromArgb(255, 0, 111);

            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

            dgv_Expense_List.BackgroundColor = Color.FromArgb(82, 82, 92);
        }
    }
}
