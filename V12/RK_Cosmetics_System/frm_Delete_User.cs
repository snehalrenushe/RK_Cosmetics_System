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
    public partial class frm_Delete_User : Form
    {
        public frm_Delete_User()
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

            tb_Username.Focus();
        }

        private void frm_Delete_User_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Fill All Information...!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Controls();
            }

            else if (tb_Username.Text == "Admin" || tb_Username.Text == "admin")
            {
                MessageBox.Show("Admin User Can't  Deleted...!!", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_Controls();
            }

            else
            {
                SqlCommand Cmd = new SqlCommand("Select * from Login_Details where Username = '" + tb_Username.Text + "'", Con);
                var Obj = Cmd.ExecuteReader();

                string Pass = "";

                if (Obj.Read())
                {
                    Pass = Obj.GetString(Obj.GetOrdinal("Password"));
                }

                Obj.Dispose();
                Cmd.Dispose();

                if (tb_Password.Text == Pass)
                {
                    DialogResult Res = MessageBox.Show(" Are You Sure To Delete The User....!!!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (Res == DialogResult.Yes)
                    {
                        SqlCommand Cmd1 = new SqlCommand();
                        Cmd1.Connection = Con;

                        Cmd1.CommandText = "Delete from Login_Details where Username = '" + tb_Username.Text + "'";

                        Cmd1.ExecuteNonQuery();

                        MessageBox.Show("User Deleted Successfully...!!", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear_Controls();
                    }

                    else
                    {
                        Clear_Controls();
                    }
                }

                else
                {
                    MessageBox.Show("Password Didn't Match!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Password.Clear();
                    tb_Password.Focus();
                }

            }

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Username.Text == "" || tb_Password.Text == "")
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
