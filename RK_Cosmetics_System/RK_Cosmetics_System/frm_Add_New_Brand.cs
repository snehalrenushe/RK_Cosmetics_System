using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RK_Cosmetics_System
{
    public partial class frm_Add_New_Brand : Form
    {
        public frm_Add_New_Brand()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=RK_Cosmetics_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_Add_New_Brand_Load(object sender, EventArgs e)
        {
            tb_Brand_Name.Focus();

            Clear_Controls();

            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_New_Brand.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Brand_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Brand_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Brand_ID.BackColor = Color.FromArgb(33, 33, 55);

            pnl_Back_Status.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);
        }

        private void tb_Brand_Name_Click(object sender, EventArgs e)
        {
            tb_Brand_Name.Text = "";
        }

        private void tb_Brand_ID_Click(object sender, EventArgs e)
        {
            tb_Brand_ID.Text = "";
        }

        void Clear_Controls()
        {
            tb_Brand_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_Brand_Name.Text = "Ex.Lakme";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Brand_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Brand_ID) from Brand_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            string Stat = " ";

            if (rb_In_Use.Checked)
            {
                Stat = rb_In_Use.Text;
            }
            else if (rb_Not_In_Use.Checked)
            {
                Stat = rb_Not_In_Use.Text;
            }

            if (tb_Brand_Name.Text != "" && (rb_In_Use.Checked || rb_Not_In_Use.Checked))
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Brand_Details (Brand_ID,Brand_Name,Status) VALUES (@B_ID,@B_Name,'" + Stat + "')";

                Cmd.Parameters.Add("B_ID", SqlDbType.Int).Value = tb_Brand_ID.Text;
                Cmd.Parameters.Add("B_Name", SqlDbType.NVarChar).Value = tb_Brand_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Brands Saved Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }
    }
}
