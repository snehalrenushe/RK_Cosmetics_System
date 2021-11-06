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
    public partial class frm_Update_Employee_Details : Form
    {
        public frm_Update_Employee_Details()
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
            tb_Employee_ID.Focus();
            tb_Employee_ID.Enabled = true;
            btn_Search.Enabled = false;
            btn_Update.Enabled = false;
            tb_Employee_ID.Text = "";
            tb_First_Name.Text = "";
            tb_Middle_Name.Text = "";
            tb_Last_Name.Text = "";
            tb_Mobile_No_1.Text = "";
            tb_Mobile_No_2.Text = "";
            tb_Addres.Text = "";

            tb_Employee_ID.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            tb_Employee_ID.Enabled = false;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + " ";

            var Obj = Cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_First_Name.Text = Obj.GetString(Obj.GetOrdinal("First_Name"));
                tb_Middle_Name.Text = Obj.GetString(Obj.GetOrdinal("Middle_Name"));
                tb_Last_Name.Text = Obj.GetString(Obj.GetOrdinal("Last_Name"));
                tb_Addres.Text = Obj.GetString(Obj.GetOrdinal("Address"));
                tb_Mobile_No_1.Text = (Obj["Mobile_No_1"].ToString());
                tb_Mobile_No_2.Text = (Obj["Mobile_No_2"].ToString());

                btn_Update.Enabled = true;
            }
            else
            {
                MessageBox.Show("Information is not Available...", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear_Controls();
            }

            Con_Close();
        }

        private void tb_Employee_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Mobile_No_1.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number!!! Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Mobile_No_1.Focus();

                goto DWN;
            }

            if (tb_Mobile_No_2.TextLength < 10)
            {
                MessageBox.Show("Invalid Mobile Number!!! Please Enter Valid Mobile Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Mobile_No_1.Focus();

                goto DWN;
            }

            Con_Open();

            if (tb_Employee_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Mobile_No_1.Text != "" && tb_Addres.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Employee_Details Set First_Name = @F_Name, Middle_Name = @M_Name, Last_Name = @L_Name, Mobile_No_1 = @Mob1, Mobile_No_2 = @Mob2, Address = @Add Where Employee_ID = @Emp_ID";

                Cmd.Parameters.Add("Emp_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("F_Name", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("M_Name", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("L_Name", SqlDbType.VarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("Mob1", SqlDbType.Money).Value = tb_Mobile_No_1.Text;
                Cmd.Parameters.Add("Mob2", SqlDbType.Money).Value = tb_Mobile_No_2.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Addres.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Details Updated Successfully !!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DWN:
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Employee_ID.Focus();
        }
    }
}
