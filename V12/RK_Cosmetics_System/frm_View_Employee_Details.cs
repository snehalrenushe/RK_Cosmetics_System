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

            if (tb_Employee_ID.Text == "")
            {
                Warn_Employee_ID.Visible = true;
                Warn_Employee_ID.Text = "*Required";
            }
            else
            {
                Warn_Employee_ID.Visible = false;
            }

            if (tb_Employee_ID.Text != "")
            {
                SqlDataAdapter SDA = new SqlDataAdapter("Select First_Name,Last_Name,Gender,Date_Of_Birth,Joining_Date,Mobile_No,Address from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + " ", Con);

                DataTable dt = new DataTable();

                SDA.Fill(dt);

                dgv_View_Employee_Details.DataSource = dt;
            }

            Con_Close();
        }

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Focus();
            SqlDataAdapter SDA = new SqlDataAdapter("Select Employee_ID,First_Name,Date_Of_Birth,Gender,Joining_Date,Mobile_No,Alternate_Mobile_No,Address from Employee_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Employee_Details.DataSource = dt;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Employee_ID.Text = "";
            Warn_Employee_ID.Text = "";
            tb_Employee_ID.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Employee_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Employee_Details.DataSource = dt;
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
