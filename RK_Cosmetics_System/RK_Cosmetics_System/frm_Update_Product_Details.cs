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
    public partial class frm_Update_Product_Details : Form
    {
        public frm_Update_Product_Details()
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

        private void frm_Update_Product_Details_Load(object sender, EventArgs e)
        {
            tb_Product_ID.Focus();

            Bind_Brand_Name_To_Combox();

            Clear_Controls();

            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Update_Product_Details.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Update_Product_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Product_ID.BackColor = Color.FromArgb(33, 33, 55);
            cb_Brand_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Product_Name.BackColor = Color.FromArgb(33, 33, 55);
            tb_Description.BackColor = Color.FromArgb(33, 33, 55);
            tb_Purchase_Price.BackColor = Color.FromArgb(33, 33, 55);
            tb_Selling_Price.BackColor = Color.FromArgb(33, 33, 55);
            tb_Stock.BackColor = Color.FromArgb(33, 33, 55);

            btn_Search.BackColor = Color.FromArgb(255, 0, 111);
            btn_Update.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);
        }

        void Clear_Controls()
        {
            tb_Product_ID.Enabled = true;
            tb_Product_ID.Text = "Ex.101";

            tb_Product_Name.Text = "Ex.Foundation";
            tb_Purchase_Price.Text = "Ex.1200 Rs.";
            tb_Selling_Price.Text = "Ex.1500";
            tb_Stock.Text = "Ex.2";
            tb_Description.Text = "Ex.These is product is made by natural ingredient";
            cb_Brand_Name.SelectedIndex = -1;
            Bind_Brand_Name_To_Combox();
        }

        private void tb_Product_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }


        void Bind_Brand_Name_To_Combox()
        {
            Con_Open();

            string Stat = "In Used";

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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
            tb_Product_ID.Enabled = false;

            Con_Open();

            if (tb_Product_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * from Product_Details where Product_ID = " + tb_Product_ID.Text + " ";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    cb_Brand_Name.Text = Obj.GetString(Obj.GetOrdinal("Brand_Name"));
                    tb_Product_Name.Text = Obj.GetString(Obj.GetOrdinal("Product_Name"));
                    tb_Purchase_Price.Text = (Obj["Purchase_Price"].ToString());
                    tb_Selling_Price.Text = (Obj["Selling_Price"].ToString());
                    tb_Stock.Text = (Obj["Stock"].ToString());
                    tb_Description.Text = Obj.GetString(Obj.GetOrdinal("Description"));

                    btn_Update.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Information is not Available...", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Clear_Controls();
                }
            }

            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Search.Enabled = false;

            Con_Open();

            if (tb_Product_ID.Text != "" && cb_Brand_Name.Text != "" && tb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Selling_Price.Text != "" && tb_Stock.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Product_Details set Brand_Name = @B_Name, Product_Name = @P_Name, Purchase_Price = @P_Price, Selling_Price = @S_Price, Stock = @Stock, Description = @Des where Product_ID = @P_ID";

                Cmd.Parameters.Add("P_ID", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("B_Name", SqlDbType.NVarChar).Value = cb_Brand_Name.Text;
                Cmd.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("P_Price", SqlDbType.Money).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("S_Price", SqlDbType.Money).Value = tb_Selling_Price.Text;
                Cmd.Parameters.Add("Stock", SqlDbType.Int).Value = tb_Stock.Text;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = tb_Description.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Details Updated Successfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void tb_Product_ID_Click(object sender, EventArgs e)
        {
            tb_Product_ID.Text = "";
        }
    }
}
