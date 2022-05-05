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
    public partial class frm_Update_Brand_Details : Form
    {
        public frm_Update_Brand_Details()
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
            tb_Brand_ID.Text = "";
            tb_Brand_ID.Enabled = true;
            tb_Brand_Name.Text = "";
            cb_Status.ResetText();
            tb_Brand_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Brand_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * from Brand_Details Where Brand_ID = " + tb_Brand_ID.Text + "";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Brand_Name.Text = Obj.GetString(Obj.GetOrdinal("Brand_Name"));
                    cb_Status.Text = Obj.GetString(Obj.GetOrdinal("Status"));

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
            if (tb_Brand_Name.Text != "" && cb_Status.Text != "")
            { 
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Brand_Details set Brand_Name = @B_Name,Status = @Stat where Brand_ID = @B_ID";

                Cmd.Parameters.Add("B_ID",SqlDbType.Int).Value = tb_Brand_ID.Text;
                Cmd.Parameters.Add("B_Name",SqlDbType.NVarChar).Value = tb_Brand_Name.Text;
                Cmd.Parameters.Add("Stat",SqlDbType.NVarChar).Value = cb_Status.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Brand Details Updated Successfully !!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
