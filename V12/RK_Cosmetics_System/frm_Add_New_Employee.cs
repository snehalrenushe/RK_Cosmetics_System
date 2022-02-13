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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Employee_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Employee_ID) from Employee_Details";

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
            tb_Employee_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_First_Name.Text = "";
            tb_Middle_Name.Text = "";
            tb_Last_Name.Text = "";
            dtp_Date_Of_Birth.ResetText();
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            dtp_Joining_Date.ResetText();
            tb_Mobile_No.Text = "";
            tb_Alternate_Mobile_No.Text = "";
            tb_Aadhar_No.Text = "";
            tb_Pan_No.Text = "";
            tb_Email_ID.Clear();
            tb_Address.Text = "";

            Warn_First_Name.Visible = false;
            Warn_Middle_Name.Visible = false;
            Warn_Last_Name.Visible = false;
            Warn_Gender.Visible = false;
            Warn_Mobile_No.Visible = false;
            Warn_Alternate_Mobile_No.Visible = false;
            Warn_Aadhar_No.Visible = false;
            Warn_PAN_No.Visible = false;
            Warn_Address.Visible = false;

            tb_First_Name.Focus();
        }

        private void dtp_Date_Of_Birth_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dtp_Date_Of_Birth.Value;
            DateTime to = DateTime.Now;
            TimeSpan tspan = to - from;
            double days = tspan.TotalDays;
            tb_Age.Text = (days / 365).ToString("0");
        }

        void Warning()
        {
            if (tb_First_Name.Text == "")
            {
                Warn_First_Name.Visible = true;
                Warn_First_Name.Text = "*Required";
            }
            else
            {
                Warn_First_Name.Visible = false;
            }

            if (tb_Middle_Name.Text == "")
            {
                Warn_Middle_Name.Visible = true;
                Warn_Middle_Name.Text = "*Required";
            }
            else
            {
                Warn_Middle_Name.Visible = false;
            }

            if (tb_Last_Name.Text == "")
            {
                Warn_Last_Name.Visible = true;
                Warn_Last_Name.Text = "*Required";
            }
            else
            {
                Warn_Last_Name.Visible = false;
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

            if (tb_Mobile_No.TextLength < 10)
            {
                Warn_Mobile_No.Visible = true;
                Warn_Mobile_No.Text = "*Mobile Number Should be Valid";
            }
            else
            {
                Warn_Mobile_No.Visible = false;
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

            Warning();

            if (tb_Employee_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Aadhar_No.TextLength == 12 && tb_Pan_No.TextLength == 10 && tb_Address.Text != "" && (rb_Female.Checked || rb_Male.Checked))
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Employee_Details (Employee_ID,First_Name,Middle_Name,Last_Name,Date_Of_Birth,Age,Gender,Joining_Date,Mobile_No,Alternate_Mobile_No,Aadhar_No,Pan_No,Email_ID,Address) VALUES (@Emp_ID,@F_Name,@M_Name,@L_Name,@DOB,@Age,'" + Gender + "',@J_Date,@Mob1,@Mob2,@Aadhar_No,@Pan_No,@email,@Add)";

                Cmd.Parameters.Add("Emp_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("F_Name", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("M_Name", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("L_Name", SqlDbType.VarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                //Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = gb_Gender.Text;  
                Cmd.Parameters.Add("J_Date", SqlDbType.Date).Value = dtp_Joining_Date.Text;
                Cmd.Parameters.Add("Mob1", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                //Cmd.Parameters.Add("Mob2", SqlDbType.Decimal).Value = Mob_No_2;
                Cmd.Parameters.Add("Aadhar_No", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Pan_No", SqlDbType.NVarChar).Value = tb_Pan_No.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Age",SqlDbType.Int).Value = tb_Age.Text;

                if (tb_Alternate_Mobile_No.Text != "")
                {
                    Cmd.Parameters.Add("Mob2", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                }
                else if (tb_Alternate_Mobile_No.Text == "")
                {
                    Cmd.Parameters.Add("Mob2", SqlDbType.Decimal).Value = "0";
                    Warn_Alternate_Mobile_No.Visible = false;
                }
                else
                {
                    Warn_Alternate_Mobile_No.Visible = false;
                }


                if (tb_Email_ID.Text != "")
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                }
                else
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = "Annonymous";
                }


                if ((Convert.ToInt32(tb_Age.Text) < 18) || (Convert.ToInt32(tb_Age.Text) > 60))
                {
                    MessageBox.Show(tb_First_Name.Text + " is Not Eligible for these Job !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Warning();
                }

                else if (tb_Mobile_No.Text == tb_Alternate_Mobile_No.Text)
                {
                    MessageBox.Show("You can't insert same mobile no !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Warning();
                }
                else if (tb_Alternate_Mobile_No.TextLength < 10 && tb_Alternate_Mobile_No.TextLength > 0)
                {
                    Warn_Alternate_Mobile_No.Visible = true;
                    Warn_Alternate_Mobile_No.Text = "Enter Valid Mobile No";
                }
                else
                {
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee Details Saved Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void dtp_Joining_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Joining_Date.MinDate = dtp_Joining_Date.MaxDate = DateTime.Now;
        }
    }
}
