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
    public partial class frm_View_Product_Details : Form
    {
        public frm_View_Product_Details()
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

        private void pnl_Product_Details_Paint(object sender, PaintEventArgs e)
        {
            
        }

        void Bind_Brand_Name_To_Combobox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details where Status = '"+ 1 +"' ";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Brand_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Brand_Name")));
            }

            Obj.Dispose();

            SqlDataAdapter Sda = new SqlDataAdapter("Select * from Product_Details",Con);

            DataTable dt = new DataTable();

            Sda.Fill(dt);

            dgv_View_Product_Details.DataSource = dt;

            Con_Close();
        }

        private void frm_View_Product_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet5.Product_Details' table. You can move, or remove it, as needed.
            this.product_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet5.Product_Details);
            Bind_Brand_Name_To_Combobox();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Details where Brand_Name = '" + cb_Brand_Name.Text + "' ", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Product_Details.DataSource = dt;

            cb_Brand_Name.Enabled = false;

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cb_Brand_Name.Text = "";
            cb_Brand_Name.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Product_Details.DataSource = dt;

            btn_Search.Enabled = false;
            cb_Brand_Name.Enabled = true;
        }

        private void cb_Brand_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }
    }
}
