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
    public partial class frm_Update_Brand_Details : Form
    {
        public frm_Update_Brand_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RK_Cosmetics_System;Integrated Security=True");

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

        void Clear_Controls()
        {
            tb_Brand_Name.Text = "";
            tb_Brand_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
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

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * from Brand_Details Where Brand_ID = " + tb_Brand_ID.Text + "";

            var Obj = Cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_Brand_Name.Text = Obj.GetString(Obj.GetOrdinal("Brand_Name"));
                rb_In_Use.Text = Obj.GetString(Obj.GetOrdinal("Status"));
                rb_Not_In_Use.Text = Obj.GetString(Obj.GetOrdinal("Status"));

            }
            else
            {
                MessageBox.Show("Information is not Available...", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear_Controls();
            }

            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
