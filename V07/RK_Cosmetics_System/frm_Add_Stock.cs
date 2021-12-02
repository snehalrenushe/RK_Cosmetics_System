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

        void Clear_Controls()
        {
            cb_Brand_Name.Enabled = true;
            cb_Brand_Name.Focus();
            tb_Product_ID.Text = "";
            cb_Brand_Name.SelectedIndex = -1;
            cb_Product_Name.SelectedIndex = -1;
            dtp_Date.ResetText();
            tb_Currect_Stock_Quantity.Text = "";
            tb_New_Stock_Added.Text = "";
        }

        void Bind_Brand_Name_To_Combobox()
        {
            string Stat = "In Use";

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details where Status = '" + Stat + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Brand_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Brand_Name")));
            }

            Obj.Dispose();

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

            //tb_Currect_Stock_Quantity.Text = "0";
            tb_New_Stock_Added.Text = "0";
        }

        private void cb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cb_Brand_Name.Enabled = false;

            SqlCommand Cmd = new SqlCommand("Select Product_ID from Product_Details where Product_Name = '" + cb_Product_Name.Text + "' ", Con);

            tb_Product_ID.Text = Convert.ToString(Cmd.ExecuteScalar());

            SqlCommand Cmd1 = new SqlCommand("Select Stock from Product_Details where Product_Name = '" + cb_Product_Name.Text + "' ", Con);
            tb_Currect_Stock_Quantity.Text = Convert.ToString(Cmd1.ExecuteScalar());
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_ID.Text != "" && dtp_Date.Text != "" && tb_Currect_Stock_Quantity.Text != "" && tb_New_Stock_Added.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Stock_Details(Product_ID,Brand_Name,Product_Name,Date,Current_Stock_Quantity,New_Added_Stock) VALUES (@P_ID,@B_Name,@P_Name,@Date,@CSQ,@NSA)";

                Cmd.Parameters.Add("P_ID", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("B_Name", SqlDbType.NVarChar).Value = cb_Brand_Name.Text;
                Cmd.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = cb_Product_Name.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("CSQ",SqlDbType.Int).Value = tb_Currect_Stock_Quantity.Text;
                Cmd.Parameters.Add("NSA",SqlDbType.Int).Value = tb_New_Stock_Added.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Stock Details has been Saved Successfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_New_Stock_Added_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Currect_Stock_Quantity_TextChanged(object sender, EventArgs e)
        {
            tb_New_Stock_Added.Text = "";
        }

        private void tb_Product_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
