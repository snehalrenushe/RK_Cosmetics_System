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
    public partial class frm_View_Product_List : Form
    {
        public frm_View_Product_List()
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

        void Bind_Brand_Name_To_Combobox()
        {
            Con_Open();

            string Stat = "In Used";

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details where Status = '" + Stat + "' ";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Brand_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Brand_Name")));
            }

            Obj.Dispose();

            Con_Close();
        }

        private void frm_View_Product_List_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_View_Product_List.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_View_Product_Back.BackColor = Color.FromArgb(42, 42, 54);

            btn_Search.BackColor = Color.FromArgb(255, 0, 111);

            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

            dgv_Product_List.BackgroundColor = Color.FromArgb(82,82,92);

            Bind_Brand_Name_To_Combobox();

            cb_Brand_Name.Text = "";
            cb_Brand_Name.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_Product_List.DataSource = dt;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cb_Brand_Name.Text = "";
            cb_Brand_Name.Focus();

            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Details", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_Product_List.DataSource = dt;

            cb_Brand_Name.ResetText();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cb_Brand_Name.Text != "")
            {
                SqlDataAdapter SDA = new SqlDataAdapter("Select * from Product_Details where Brand_Name = '" + cb_Brand_Name.Text + "' ", Con);

                DataTable dt = new DataTable();

                SDA.Fill(dt);

                dgv_Product_List.DataSource = dt;
            }

            Con_Close();
        }

    }
}
