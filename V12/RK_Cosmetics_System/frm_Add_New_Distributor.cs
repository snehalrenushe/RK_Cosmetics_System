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
    public partial class frm_Add_New_Distributor : Form
    {
        public frm_Add_New_Distributor()
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

            Cmd.CommandText = "Select Count(*) from Distributor_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Distributor_ID) from Distributor_Details";

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
            tb_Distributor_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_Name.Text = "";
            tb_Address.Text = "";
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            tb_Registration_No.Text = "";
            dtp_Tieup_Date.ResetText();
            tb_Mobile_No.Text = "";
            tb_Alternate_Mobile_No.Text = "";
            tb_Aadhar_No.Text = "";
            tb_Pan_No.Text = "";
            tb_Email_ID.Text = "";

            tb_Name.Focus();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender = " ";

            Con_Open();

            if (rb_Male.Checked == true)
            {
                Gender = rb_Male.Text;
            }

            else if (rb_Female.Checked == true)
            {
                Gender = rb_Female.Text;
            }


            if (tb_Distributor_ID.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && tb_Registration_No.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Aadhar_No.TextLength == 12 && tb_Pan_No.TextLength == 10 && (rb_Female.Checked || rb_Male.Checked))
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Distributor_Details (Distributor_ID,Name,Address,Gender,Registration_No,Tie_Up_Date,Mobile_No,Alternate_Mobile_No,Aadhar_No,PAN_No,Email_ID) VALUES (@D_ID,@Nm,@Add,'" + Gender + "',@R_No,@Tie_Date,@Mob1,@Mob2,@A_No,@P_No,@email)";

                Cmd.Parameters.Add("D_ID",SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("Nm",SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("R_No",SqlDbType.Int).Value = tb_Registration_No.Text;
                Cmd.Parameters.Add("Tie_Date",SqlDbType.Date).Value = dtp_Tieup_Date.Text;
                Cmd.Parameters.Add("Mob1",SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("A_No", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("P_No", SqlDbType.NVarChar).Value = tb_Pan_No.Text;

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

                    MessageBox.Show("Distributor Details Saved Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_New_Distributor_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void dtp_Tieup_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Tieup_Date.MinDate = dtp_Tieup_Date.MaxDate = DateTime.Now;
        }

    }
}
