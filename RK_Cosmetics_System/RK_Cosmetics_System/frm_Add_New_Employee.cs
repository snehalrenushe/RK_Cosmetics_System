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

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=RK_Cosmetics_System_DB;Integrated Security=True");

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
            tb_Name.Focus();

            Clear_Controls();

            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_New_Employee.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Employee_Back.BackColor = Color.FromArgb(42, 42, 54);

            tb_Name.BackColor = Color.FromArgb(33, 33, 55);

            tb_Employee_ID.BackColor = Color.FromArgb(33, 33, 55);

            tb_Mobile_No.BackColor = Color.FromArgb(33, 33, 55);

            lbl_For_Joining_Date.Text = DateTime.Now.ToString();
            lbl_For_Joining_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Joining_Date.ForeColor = Color.FromArgb(100,100,100);
            pnl_Joining_Date_Back.BackColor = Color.FromArgb(33, 33, 55);

            tb_Aadhar_No.BackColor = Color.FromArgb(33, 33, 55);

            tb_Age.BackColor = Color.FromArgb(33, 33, 55);

            pnl_Back_Gender.BackColor = Color.FromArgb(33, 33, 55);

            tb_Email_ID.BackColor = Color.FromArgb(33, 33, 55);

            tb_Address.BackColor = Color.FromArgb(33, 33, 55);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

        }

        void Clear_Controls()
        {
            tb_Employee_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_Name.Text = "Ex.John";
            tb_Mobile_No.Text = "Ex.9848783455";
            tb_Aadhar_No.Text = "Ex.135984***********";
            tb_Age.Text = "Ex.21";
            tb_Email_ID.Text = "Ex.John@gmail.com";
            tb_Address.Text = "Ex.LA";

            lbl_note_age.Visible = false;
        }

        private void tb_Name_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
        }

        private void tb_Mobile_No_Click(object sender, EventArgs e)
        {
            tb_Mobile_No.Text = "";
        }

        private void tb_Aadhar_No_Click(object sender, EventArgs e)
        {
            tb_Aadhar_No.Text = "";
        }

        private void tb_Age_Click(object sender, EventArgs e)
        {
            tb_Age.Text = "";
        }

        private void tb_Email_ID_Click(object sender, EventArgs e)
        {
            tb_Email_ID.Text = "";
        }

        private void tb_Address_Click(object sender, EventArgs e)
        {
            tb_Address.Text = "";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Gender = " ";

            if (rb_Male.Checked == true)
            {
                Gender = rb_Male.Text;
            }

            else if (rb_Female.Checked == true)
            {
                Gender = rb_Female.Text;
            }

            if (tb_Employee_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Aadhar_No.TextLength == 12  && tb_Address.Text != "" && (rb_Female.Checked || rb_Male.Checked) && tb_Age.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Employee_Details (Name,Employee_ID,Mobile_No,Joining_Date,Aadhar_No,Age,Gender,Email_ID,Address) VALUES (@Name,@Emp_ID,@Mob,@J_Date,@Aadhar_No,@Age,'" + Gender + "',@email,@Add)";

                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Emp_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("J_Date",SqlDbType.NVarChar).Value = (string)lbl_For_Joining_Date.Text;
                Cmd.Parameters.Add("Aadhar_No", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Age", SqlDbType.Int).Value = tb_Age.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;


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
                    MessageBox.Show(tb_Name.Text + " is Not Eligible for these Job !!!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    lbl_note_age.Visible = true;
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
                MessageBox.Show("Incomplete Details !!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            Con_Close();
        }
    }
}
