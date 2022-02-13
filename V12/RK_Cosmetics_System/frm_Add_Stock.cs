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

        int T_Stock;

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

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            Bind_Brand_Name_To_Combobox();
            Clear_Controls();
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

        private void cb_Brand_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cb_Product_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details where Brand_Name = '" + cb_Brand_Name.Text + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cb_Product_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("Product_Name")));
            }

            Obj.Dispose();
            Con_Close();
        }

        private void cb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            tb_Product_ID.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Product_ID from Product_Details where Product_Name = '" + cb_Product_Name.Text + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                tb_Product_ID.Text = (Obj["Product_ID"].ToString());
            }

            Obj.Dispose();

            tb_Currect_Stock_Quantity.Clear();

            SqlCommand Cmd1 = new SqlCommand();

            Cmd1.Connection = Con;

            Cmd1.CommandText = "Select Stock From Product_Details where Product_Name = '" + cb_Product_Name.Text + "'";

            var Obj1 = Cmd1.ExecuteReader();

            while (Obj1.Read())
            {
                tb_Currect_Stock_Quantity.Text = (Obj1["Stock"].ToString());
            }

            Obj1.Dispose();
            Con_Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Con_Open();

                T_Stock = Convert.ToInt32(tb_Currect_Stock_Quantity.Text) + Convert.ToInt32(tb_New_Stock_Added.Text);

                if (cb_Brand_Name.Text != "" && cb_Product_Name.Text != "" && tb_Product_ID.Text != "" && tb_Currect_Stock_Quantity.Text != "" && tb_New_Stock_Added.Text != "")
                {
                    Con_Open();

                    SqlCommand Cmd = new SqlCommand();

                    Cmd.Connection = Con;

                    Cmd.CommandText = "Insert into Product_Stock_Details (Product_Id, Manufacturing_Date, Expiry_Date, Date, Total_Stock, Current_Stock, New_Stock) Values (@PID, @MFG, @EXPIRY, @DATE, " + T_Stock + ", @CS, @NS)";

                    Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
                    Cmd.Parameters.Add("MFG", SqlDbType.Date).Value = dtp_Manufacturing_Date.Value.Date;
                    Cmd.Parameters.Add("EXPIRY", SqlDbType.Date).Value = dtp_Expiry_Date.Value.Date;
                    Cmd.Parameters.Add("DATE", SqlDbType.Date).Value = dtp_Date.Value.Date;
                    Cmd.Parameters.Add("CS", SqlDbType.Int).Value = tb_Currect_Stock_Quantity.Text;
                    Cmd.Parameters.Add("NS", SqlDbType.Int).Value = tb_New_Stock_Added.Text;

                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();

                    Cmd.CommandText = "Update Product_Details Set Stock = " + T_Stock + " where Product_ID = " + tb_Product_ID.Text + "";

                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();

                    MessageBox.Show("Stock Added Saved Successfully...!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }

                else
                {
                    MessageBox.Show("Incomplete Information....!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Con_Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
