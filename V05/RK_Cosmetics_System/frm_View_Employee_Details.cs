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
    public partial class frm_View_Employee_Details : Form
    {
        public frm_View_Employee_Details()
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + " ", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Employee_Details.DataSource = dt;

            tb_Employee_ID.Enabled = false;
            Con_Close();
        }

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Employee_ID.Text = "";
            tb_Employee_ID.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Employee_Details",Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Employee_Details.DataSource = dt;

            btn_Search.Enabled = false;
            tb_Employee_ID.Enabled = true;
        }

        private void tb_Employee_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }
    }
}
