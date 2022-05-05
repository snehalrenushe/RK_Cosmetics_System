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
    public partial class frm_View_Expences_Details : Form
    {
        public frm_View_Expences_Details()
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

        private void frm_View_Expences_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet4.Expences_Details' table. You can move, or remove it, as needed.
            this.expences_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet4.Expences_Details);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Expences_Details where Date Between '" + dtp_From_Date.Text + "' And '" + dtp_To_Date.Text + "' ", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Expences_Details.DataSource = dt;


            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dtp_From_Date.ResetText();
            dtp_To_Date.ResetText();
            dtp_From_Date.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Expences_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Expences_Details.DataSource = dt;
        }
    }
}
