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
    public partial class frm_View_Brand_Details : Form
    {
        public frm_View_Brand_Details()
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

            if (tb_Brand_ID.Text == "")
            {
                Warn_Brand_ID.Visible = true;
                Warn_Brand_ID.Text = "*Required";
            }
            else
            {
                Warn_Brand_ID.Visible = false;
            }

            if (tb_Brand_ID.Text != "")
            {
                SqlDataAdapter SDA = new SqlDataAdapter("Select * from Brand_Details where Brand_ID = " + tb_Brand_ID.Text + " ", Con);

                DataTable dt = new DataTable();

                SDA.Fill(dt);

                dgv_View_Brand_Details.DataSource = dt;
            }
            
            Con_Close();
        }

        private void frm_View_Brand_Details_Load(object sender, EventArgs e)
        {
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Brand_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Brand_Details.DataSource = dt;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Brand_ID.Text = "";
            tb_Brand_ID.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Brand_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Brand_Details.DataSource = dt;

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
