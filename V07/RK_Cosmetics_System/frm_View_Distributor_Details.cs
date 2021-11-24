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
    public partial class frm_View_Distributor_Details : Form
    {
        public frm_View_Distributor_Details()
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

        private void frm_View_Distributor_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet4.Distributor_Details' table. You can move, or remove it, as needed.
            //this.distributor_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet4.Distributor_Details);
            tb_Distributor_ID.Focus();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Distributor_Details Where Distributor_ID = " + tb_Distributor_ID.Text +" ",Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Distributor_Details.DataSource = dt;

            tb_Distributor_ID.Enabled = false;

            Con_Close();
        }

        private void tb_Distributor_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Distributor_ID.Text = "";
            tb_Distributor_ID.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * From Distributor_Details",Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Distributor_Details.DataSource = dt;

            btn_Search.Enabled = false;
            tb_Distributor_ID.Enabled = true;

            Con_Close();
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
