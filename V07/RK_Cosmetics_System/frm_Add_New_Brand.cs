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
    public partial class frm_Add_New_Brand : Form
    {
        public frm_Add_New_Brand()
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

            Cmd.CommandText = "Select Count(*) from Brand_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Brand_ID) from Brand_Details";

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
            tb_Brand_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_Brand_Name.Text = "";
            tb_Brand_Name.Focus();
        }
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            Con_Open();
            string Stat = " ";

            if (rb_In_Use.Checked)
            {
                Stat = "1";         
            }
            else if (rb_Not_In_Use.Checked)
            {
                Stat = "0";
            }

            if (tb_Brand_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Brand_Details (Brand_ID,Brand_Name,Status) VALUES (@B_ID,@B_Name,'" + Stat + "')";

                Cmd.Parameters.Add("B_ID", SqlDbType.Int).Value = tb_Brand_ID.Text;
                Cmd.Parameters.Add("B_Name", SqlDbType.NVarChar).Value = tb_Brand_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Brands Saved Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void frm_Add_New_Brand_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_Brand_Name_TextChanged(object sender, EventArgs e)
        {
            rb_In_Use.Enabled = true;
            rb_Not_In_Use.Enabled = true;
        }

        private void gb_Status_Enter(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
        }
    }
}
