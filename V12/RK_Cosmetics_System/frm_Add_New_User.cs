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
    public partial class frm_Add_New_User : Form
    {
        public frm_Add_New_User()
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
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Confirm_Password.Clear();

            tb_Username.Focus();
        }
        private void frm_Add_New_User_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(*) from Login_Details where Username = '" + tb_Username.Text + "'", Con);

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Use Different Username..!", "Username Already Used", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear_Controls();
            }

            else if (tb_Username.Text == "" || tb_Password.Text == "" || tb_Confirm_Password.Text == "")
            {
                MessageBox.Show("Fill Username Or Password First !!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear_Controls();
            }

            else if (tb_Password.Text == tb_Confirm_Password.Text)
            {
                SqlCommand Cmd1 = new SqlCommand();
                Cmd1.Connection = Con;
                Cmd1.CommandText = "Insert Into Login_Details (Username , Password) Values (@UN , @Pass)";

                Cmd1.Parameters.Add("UN", SqlDbType.NVarChar).Value = tb_Username.Text;
                Cmd1.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Password.Text;

                Cmd1.ExecuteNonQuery();

                MessageBox.Show("User Create Successfully...!!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Password Didn't Match!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Username.Text == "" || tb_Password.Text == "" || tb_Confirm_Password.Text == "")
            {
                Res = MessageBox.Show("Are You Sure... Data Entered Will Be Lost...?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
