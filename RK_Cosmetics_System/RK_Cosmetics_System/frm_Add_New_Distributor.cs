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

        private void frm_Add_New_Distributor_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();

            Clear_Controls();

            this.BackColor = Color.FromArgb(26, 26, 26);

            lbl_Add_New_Distributor.ForeColor = Color.FromArgb(255, 0, 111);

            pnl_Distributor_Back.BackColor = Color.FromArgb(42, 42, 54);

            btn_Save.BackColor = Color.FromArgb(255, 0, 111);
            btn_Refresh.BackColor = Color.FromArgb(255, 0, 111);

            tb_Name.BackColor = Color.FromArgb(33, 33, 55);
            pnl_For_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Date.BackColor = Color.FromArgb(33, 33, 55);
            lbl_For_Date.ForeColor = Color.FromArgb(100,100,100);
            lbl_For_Date.Text = DateTime.Now.ToString();
            tb_Distributor_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Mobile_No.BackColor = Color.FromArgb(33, 33, 55);
            tb_Email_ID.BackColor = Color.FromArgb(33, 33, 55);
            tb_Address.BackColor = Color.FromArgb(33, 33, 55);
            tb_Registration_No.BackColor = Color.FromArgb(33, 33, 55);
            tb_Aadhar_No.BackColor = Color.FromArgb(33, 33, 55);

        }

        void Clear_Controls()
        {
            tb_Distributor_ID.Text = Convert.ToString(Auto_Increament_ID());

            tb_Name.Text = "Ex.John";
            tb_Mobile_No.Text = "Ex.9848783455";
            tb_Aadhar_No.Text = "Ex.135984***********";
            tb_Email_ID.Text = "Ex.John@gmail.com";
            tb_Address.Text = "Ex.LA";
            tb_Registration_No.Text = "Ex.8974832";
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

        private void tb_Name_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
        }

        private void tb_Registration_No_Click(object sender, EventArgs e)
        {
            tb_Registration_No.Text = "";
        }

        private void tb_Mobile_No_Click(object sender, EventArgs e)
        {
            tb_Mobile_No.Text = "";
        }

        private void tb_Aadhar_No_Click(object sender, EventArgs e)
        {
            tb_Aadhar_No.Text = "";
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Distributor_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Aadhar_No.TextLength == 12 && tb_Address.Text != "" && tb_Registration_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert into Distributor_Details (Name,Distributor_ID,Mobile_No,Email_ID,Tie_Up_Date,Registration_No,Aadhar_No,Address) VALUES (@Name,@Dist_ID,@Mob,@email,@Date,@Reg_No,@Aadhar_No,@Add)";

                Cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Dist_ID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Date", SqlDbType.NVarChar).Value = (string)lbl_For_Date.Text;
                Cmd.Parameters.Add("Reg_No", SqlDbType.Int).Value = tb_Registration_No.Text;
                Cmd.Parameters.Add("Aadhar_No", SqlDbType.NVarChar).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;


                if (tb_Email_ID.Text != "")
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                }
                else
                {
                    Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = "Annonymous";
                }
               
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Distributor Details Saved Successfully !!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                
            } 
            else
            {
                MessageBox.Show("Incomplete Details !!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            Con_Close();
        }


    }
}
