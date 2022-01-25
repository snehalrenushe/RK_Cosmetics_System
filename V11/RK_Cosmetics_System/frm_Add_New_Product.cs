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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
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

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Product_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Product_ID) from Product_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();
            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Product_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_Product_Name.Text = "";
            cb_Brand_Name.SelectedIndex = -1;
            tb_Purchase_Price.Text = "";
            tb_Selling_Price.Text = "";
            //tb_Stock.Text = "";
            tb_GST.Text = "";
            tb_Description.Text = "";
            cb_Distributor_Name.SelectedIndex = -1;
            dtp_Date.ResetText();
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

        void Bind_Distributor_Name_To_Combobox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Name) from Distributor_Details ";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Distributor_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Name")));
            }

            Obj.Dispose();
            Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_ID.Text != "" && cb_Brand_Name.Text != "" && tb_Product_Name.Text != "" && tb_Purchase_Price.Text != "" && tb_Selling_Price.Text != "" && tb_Stock.Text != "" && cb_Distributor_Name.Text != "" && dtp_Date.Text != "" && tb_GST.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Product_Details(Product_ID,Brand_Name,Product_Name,Purchase_Price,Selling_Price,Stock,Distributor_Name,Date,GST,Description) VALUES (@P_ID,@B_Name,@P_Name,@P_Price,@S_Price,@Stock,@D_Name,@Date,@GST,@Des)";

                Cmd.Parameters.Add("P_ID",SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("B_Name",SqlDbType.NVarChar).Value = cb_Brand_Name.Text;
                Cmd.Parameters.Add("P_Name",SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("P_Price",SqlDbType.Money).Value = tb_Purchase_Price.Text;
                Cmd.Parameters.Add("S_Price",SqlDbType.Money).Value = tb_Selling_Price.Text;
                Cmd.Parameters.Add("Stock",SqlDbType.Int).Value = tb_Stock.Text;
                Cmd.Parameters.Add("D_Name",SqlDbType.VarChar).Value = cb_Distributor_Name.Text;
                Cmd.Parameters.Add("Date",SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("GST", SqlDbType.Float).Value = tb_GST.Text;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = tb_Description.Text;

                if ((Convert.ToInt32(tb_GST.Text)) > 5 )
                {
                    MessageBox.Show("GST Must be Less than 5%!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if ((Convert.ToInt32(tb_Selling_Price.Text)) <= (Convert.ToInt32(tb_Purchase_Price.Text)))
                {
                    MessageBox.Show("Selling Price must not be less than or equal to Purchase Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Details Saved Successfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();   
                }          
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Bind_Brand_Name_To_Combobox();
            Bind_Distributor_Name_To_Combobox();
            Clear_Controls();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void cb_Distributor_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            
            //SqlCommand Cmd = new SqlCommand("Select Current_Stock_Quantity from Stock_Details where Product_ID = " + tb_Product_ID.Text + " ", Con);

            //tb_Stock.Text = Convert.ToString(Cmd.ExecuteScalar());

            Con_Close();
        }

        private void tb_GST_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(tb_GST.Text)) > 5)
                {
                    MessageBox.Show("GST Must be Less than 5%!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Warn_Selling_Price.Visible = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void tb_Selling_Price_MouseLeave(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(tb_Selling_Price.Text)) <= (Convert.ToInt32(tb_Purchase_Price.Text)))
            {
                MessageBox.Show("Selling Price must not be less than or equal to Purchase Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Warn_Selling_Price.Visible = false;
            }
        }                                                                     
    }
}
