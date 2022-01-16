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

        string Gender = " ";
        long Mob_No_2;
        string Email = " ";

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
        }

        void Warning()
        {
            if (tb_Name.Text == "")
            {
                Warn_Name.Visible = true;
                Warn_Name.Text = "*Required";
            }
            else
            {
                Warn_Name.Visible = false;
            }

            if (!rb_Female.Checked && !rb_Male.Checked)
            {
                Warn_Gender.Visible = true;
                Warn_Gender.Text = "*Required";
            }
            else
            {
                Warn_Gender.Visible = false;
            }

            if (tb_Registration_No.Text == "")
            {
                Warn_Registration_No.Visible = true;
                Warn_Name.Text = "*Required";
            }
            else
            {
                Warn_Registration_No.Visible = false;
            }

            if (tb_Mobile_No.TextLength < 10)
            {
                Warn_Mobile_No.Visible = true;
                Warn_Mobile_No.Text = "*Mobile Number Should be Valid";
            }
            else
            {
                Warn_Mobile_No.Visible = false;
            }

            if (tb_Alternate_Mobile_No.Text != "")
            {
                Mob_No_2 = Convert.ToInt64(tb_Alternate_Mobile_No.Text);
            }
            else
            {
                Warn_Alternate_Mobile_No.Visible = false;
            }

            if (tb_Aadhar_No.TextLength < 12)
            {
                Warn_Aadhar_No.Visible = true;
                Warn_Aadhar_No.Text = "*Aadhar Number Should be Valid";
            }
            else
            {
                Warn_Aadhar_No.Visible = false;
            }

            if (tb_Pan_No.TextLength < 10)
            {
                Warn_PAN_No.Visible = true;
                Warn_PAN_No.Text = "*PAN Number Should be Valid";
            }
            else
            {
                Warn_PAN_No.Visible = false;
            }

            if (tb_Address.Text == "")
            {
                Warn_Address.Visible = true;
                Warn_Address.Text = "*Required";
            }
            else
            {
                Warn_Address.Visible = false;
            }

            if (tb_Email_ID.Text != "")
            {
                Email = Convert.ToString(tb_Email_ID.Text);
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (rb_Male.Checked == true)
            {
                Gender = rb_Male.Text;
            }

            else if (rb_Female.Checked == true)
            {
                Gender = rb_Female.Text;
            }

            Warning();

            if (tb_Distributor_ID.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && tb_Registration_No.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Aadhar_No.TextLength == 12 && tb_Pan_No.TextLength == 10 && (rb_Female.Checked || rb_Male.Checked))
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Distributor_Details (Distributor_ID,Name,Address,Gender,Registration_No,Tie_Up_Date,Mobile_No,Alternate_Mobile_No,Aadhar_No,PAN_No,Email_ID) VALUES (@D_ID,@Nm,@Add,'" + Gender + "',@R_No,@Tie_Date,@Mob1," + Mob_No_2 + ",@A_No,@P_No,'" + Email + "')";

                Cmd.Parameters.Add("D_ID",SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("Nm",SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("R_No",SqlDbType.Int).Value = tb_Registration_No.Text;
                Cmd.Parameters.Add("Tie_Date",SqlDbType.Date).Value = dtp_Tieup_Date.Text;
                Cmd.Parameters.Add("Mob1",SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Mob2", SqlDbType.Decimal).Value = Mob_No_2;
                Cmd.Parameters.Add("A_No", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("P_No", SqlDbType.NVarChar).Value = tb_Pan_No.Text;
                Cmd.Parameters.Add("Email",SqlDbType.NVarChar).Value = Email;

                if (tb_Mobile_No.Text == tb_Alternate_Mobile_No.Text)
                {
                    MessageBox.Show("You can't insert same mobile no !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Warning();
                }
                else if (tb_Alternate_Mobile_No.TextLength <= 10 && tb_Alternate_Mobile_No.TextLength > 0)
                {
                    Warn_Alternate_Mobile_No.Visible = true;
                    Warn_Alternate_Mobile_No.Text = "Enter Valid Mobile No";
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
                Warning();
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
