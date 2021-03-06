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
    public partial class frm_View_Stock_Details : Form
    {
        public frm_View_Stock_Details()
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

        void Clear_Control()
        {
            cb_Brand_Name.Focus();
            cb_Brand_Name.Items.Clear();
            cb_Product_Name.Items.Clear();
            cb_Brand_Name.Text = "";
            cb_Product_Name.Text = "";
            Bind_Brand_Name_To_Combobox();
        }

        void Bind_Brand_Name_To_Combobox()
        {
            Con_Open();

            string Stat = "In Use";

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details where Status = '" + Stat + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Brand_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Brand_Name")));
            }

            Obj.Dispose();

            /*SqlDataAdapter Sda = new SqlDataAdapter("Select * from Product_Details", Con);

            DataTable dt = new DataTable();

            Sda.Fill(dt);

            dgv_View_Stock_Details.DataSource = dt;*/

            Con_Close();
        }

        void Bind_Product_Name_To_Combobox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Product_Name from Product_Details where Brand_Name = '" + cb_Brand_Name.Text + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Product_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Product_Name")));
            }

            Obj.Dispose();

            Con_Close();
        }


        private void frm_View_Stock_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_RK_Cosmetics_SystemDataSet3.Stock_Details' table. You can move, or remove it, as needed.
            //this.stock_DetailsTableAdapter.Fill(this.dB_RK_Cosmetics_SystemDataSet3.Stock_Details);
            btn_Search.Enabled = true;
            Clear_Control();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_Brand_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Product_Name.Text = "";
            cb_Product_Name.Items.Clear();

            cb_Product_Name.Enabled = true;

            Bind_Product_Name_To_Combobox();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cb_Brand_Name.Text = "";
            cb_Product_Name.Text = "";
            cb_Brand_Name.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Stock_Details.DataSource = dt;

            btn_Search.Enabled = false;
            cb_Brand_Name.Enabled = true;
        }

        private void cb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }
    }
}
