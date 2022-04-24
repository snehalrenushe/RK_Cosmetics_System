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
    public partial class frm_Add_Expenses : Form
    {
        public frm_Add_Expenses()
        {
            InitializeComponent();
        }

        private void Add_Expenses_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_Expense.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Expense_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Expense_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Amount_Paid.BackColor = Color.FromArgb(33, 33, 55);
            tb_Expense_Details.BackColor = Color.FromArgb(33, 33, 55);
            tb_Paid_By.BackColor = Color.FromArgb(33, 33, 55);

            pb_Bill_Image.BackColor = Color.FromArgb(33, 33, 55);

            lbl_For_Date.Text = DateTime.Now.ToString();
            lbl_For_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Date.ForeColor = Color.FromArgb(100, 100, 100);
            pnl_Date_Back.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);
            btn_Browse.BackColor = Color.FromArgb(196, 200, 16);
        }

        private void tb_Expense_Details_Click(object sender, EventArgs e)
        {
            tb_Expense_Details.Text = "";
        }

        private void tb_Amount_Paid_Click(object sender, EventArgs e)
        {
            tb_Amount_Paid.Text = "";
        }

        private void tb_Paid_By_Click(object sender, EventArgs e)
        {
            tb_Paid_By.Text = "";
        }
    }
}
