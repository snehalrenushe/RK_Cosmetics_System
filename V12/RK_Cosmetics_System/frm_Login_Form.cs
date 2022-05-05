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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
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


        private void btn_Sign_In_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * from Login_Details where Username = @uname And Password = @pass";

            Cmd.Parameters.Add("uname", SqlDbType.VarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = tb_Password.Text;

            string Ret = Convert.ToString(Cmd.ExecuteScalar());

            if (Ret == tb_Username.Text && tb_Password.Text != "")
            {
                Global_Vars.Uname = tb_Username.Text;

                MessageBox.Show("Login Successfullyyy !!!", "Working", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Admin_Entry_Form AEF = new frm_Admin_Entry_Form();
                AEF.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Username and Password !!!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();

            btn_Sign_In.Enabled = false;
            tb_Password.Enabled = false;
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Sign_In.Enabled = true;
        }
    }
}
