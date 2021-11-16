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
    public partial class frm_Add_Stock : Form
    {
        public frm_Add_Stock()
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

        void Bind_Brand_Name_To_Combobox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details where Status = '" + 1 + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Brand_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Brand_Name")));
            }

            Cmd.Dispose();

            Con_Close();
        }

        void Bind_Product_Name_To_Combobox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Product_Name from Product_Details where Brand_Name = '" + cb_Brand_Name.Text +"'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Product_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Product_Name")));
            }

            Cmd.Dispose();

            Con_Close();
        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            Bind_Brand_Name_To_Combobox();
            Bind_Product_Name_To_Combobox();
        }

        private void cb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Product_ID from Product_Details where Product_Name = '" + cb_Product_Name.Text +"'";

            var Obj = Cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_Product_ID.Text = (Obj["Product_ID"].ToString());
            }

            Cmd.Dispose();
            Con_Close();
        }

        private void cb_Brand_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Product_Name.Text = "";
            cb_Product_Name.Items.Clear();
            cb_Product_Name.Focus();
            cb_Product_Name.Enabled = true;
            Bind_Product_Name_To_Combobox();
        }
    }
}
