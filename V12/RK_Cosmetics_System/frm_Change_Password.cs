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
    public partial class frm_Change_Password : Form
    {
        public frm_Change_Password()
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
        void Bind_Username_To_Combobox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Username) from Login_Details";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();
            Con_Close();
        }

        void Clear_Controls()
        {
            cmb_Username.SelectedIndex = -1;
            tb_Current_Password.Clear();
            tb_New_Password.Clear();

            cmb_Username.Focus();
        }

        private void frm_Change_Password_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Bind_Username_To_Combobox();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_Username.Text != "" && tb_Current_Password.Text != "" && tb_New_Password.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * from Login_Details where Username = '" + cmb_Username.Text + "'", Con);
                var Obj = Cmd.ExecuteReader();

                string Pass = "";

                if (Obj.Read())
                {
                    Pass = Obj.GetString(Obj.GetOrdinal("Password"));
                }

                Obj.Dispose();
                Cmd.Dispose();

                if (tb_Current_Password.Text == Pass)
                {
                    SqlCommand Cmd1 = new SqlCommand();

                    Cmd1.Connection = Con;

                    Cmd1.CommandText = "Update Login_Details set Password = '" + tb_New_Password.Text + "' Where Username = '" + cmb_Username.Text + "'";

                    Cmd1.ExecuteNonQuery();

                    MessageBox.Show("Password Updated Successfully !!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }

                else
                {
                    MessageBox.Show("Password Didn't Match!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Controls();
            }

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (cmb_Username.Text == "" || tb_Current_Password.Text == "" || tb_New_Password.Text == "")
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
