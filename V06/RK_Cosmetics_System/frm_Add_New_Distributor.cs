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
            tb_First_Name.Text = "";
            tb_Last_Name.Text = "";
            tb_Middle_Name.Text = "";
            tb_Address.Text = "";
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            tb_Registration_No.Text = "";
            dtp_Tieup_Date.ResetText();
            tb_Mobile_No_1.Text = "";
            tb_Alternate_Mobile_No.Text = "";
            tb_Aadhar_No.Text = "";
            tb_Pan_No.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Gender = " ";

            if (rb_Male.Checked)
            {
                Gender = rb_Male.Text;
            }

            else if (rb_Female.Checked)
            {
                Gender = rb_Female.Text;
            }

            if (tb_Mobile_No_1.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number!!! Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Mobile_No_1.Focus();

                goto DWN;
            }

            if (tb_Alternate_Mobile_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number!!! Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Mobile_No_1.Focus();

                goto DWN;
            }

            if (tb_Aadhar_No.TextLength < 12)
            {
                MessageBox.Show("Invalid Aadhar Number!!! Please Enter Valid Aadhar Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Aadhar_No.Focus();

                goto DWN;
            }

            if (tb_Pan_No.TextLength < 10)
            {
                MessageBox.Show("Invalid Pan Number!!! Please Enter Valid PAN Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Pan_No.Focus();

                goto DWN;
            }

            if (tb_Distributor_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Address.Text != "" && tb_Registration_No.Text != "" && tb_Mobile_No_1.Text != "" && tb_Alternate_Mobile_No.Text != "" && tb_Aadhar_No.Text != "" && tb_Pan_No.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Distributor_Details (Distributor_ID,First_Name,Middle_Name,Last_Name,Address,Gender,Registration_ID,Tie_Up_Date,Mobile_No,Alternate_Mobile_No,Aadhar_No,PAN_No) VALUES (@D_ID,@F_N,@M_N,@L_N,@Add,'" + Gender + "',@R_No,@Tie_Date,@Mob1,@Mob2,@A_No,@P_No)";

                Cmd.Parameters.Add("D_ID",SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("F_N",SqlDbType.NVarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("M_N", SqlDbType.NVarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("L_N", SqlDbType.NVarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("R_No",SqlDbType.Int).Value = tb_Registration_No.Text;
                Cmd.Parameters.Add("Tie_Date",SqlDbType.Date).Value = dtp_Tieup_Date.Text;
                Cmd.Parameters.Add("Mob1",SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
                Cmd.Parameters.Add("Mob2", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("A_No", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("P_No", SqlDbType.NVarChar).Value = tb_Pan_No.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Distributor Details Saved Successfully!!!","Saving",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DWN:
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

    }
}
