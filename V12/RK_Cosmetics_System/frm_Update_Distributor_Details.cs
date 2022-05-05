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
    public partial class frm_Update_Distributor_Details : Form
    {
        public frm_Update_Distributor_Details()
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
            tb_Distributor_ID.Enabled = true;
            tb_Distributor_ID.Focus();
            btn_Update.Enabled = false;
            tb_Distributor_ID.Text = "";
            tb_Name.Text = "";
            tb_Mobile_No.Text = "";
            tb_Alternate_Mobile_No.Text = "";
            tb_Addres.Text = "";
            tb_Email_ID.Text = "";
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Distributor_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * from Distributor_Details where Distributor_ID = " + tb_Distributor_ID.Text + " ";

                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Name.Text = Obj.GetString(Obj.GetOrdinal("Name"));
                    tb_Addres.Text = Obj.GetString(Obj.GetOrdinal("Address"));
                    tb_Mobile_No.Text = (Obj["Mobile_No"].ToString());
                    tb_Alternate_Mobile_No.Text = (Obj["Alternate_Mobile_No"].ToString());
                    tb_Email_ID.Text = Obj.GetString(Obj.GetOrdinal("Email_ID"));

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
            Con_Open();


            if (tb_Distributor_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Addres.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Distributor_Details Set Name = @Name, Mobile_No = @Mob1, Alternate_Mobile_No = @Mob2 , Address = @Add ,Email_ID = @email Where Distributor_ID = @Dist_ID";

                Cmd.Parameters.Add("Dist_ID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Mob1", SqlDbType.Money).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Addres.Text;

                if (tb_Alternate_Mobile_No.Text != "")
                {
                    Cmd.Parameters.Add("Mob2", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                }
                else if (tb_Alternate_Mobile_No.Text == "")
                {
                    Cmd.Parameters.Add("Mob2", SqlDbType.Decimal).Value = "0";
                }

                if (tb_Email_ID.Text != "")
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                }
                else
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = "Annonymous";
                }
                

                if (tb_Mobile_No.Text == tb_Alternate_Mobile_No.Text)
                {
                    MessageBox.Show("You can't insert same mobile no !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                else if (tb_Alternate_Mobile_No.TextLength < 10 && tb_Alternate_Mobile_No.TextLength > 0)
                {
                    MessageBox.Show("Mobile no Should be 10 Digit !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Distributor Details Updated Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }

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

        private void tb_Distributor_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void frm_Update_Distributor_Details_Load(object sender, EventArgs e)
        {
              Clear_Controls();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }
        }
    }
}
