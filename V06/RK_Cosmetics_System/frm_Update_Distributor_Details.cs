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
            btn_Search.Enabled = false;
            btn_Update.Enabled = false;
            tb_Distributor_ID.Text = "";
            tb_First_Name.Text = "";
            tb_Middle_Name.Text = "";
            tb_Last_Name.Text = "";
            tb_Mobile_No_1.Text = "";
            tb_Alternate_Mobile_No.Text = "";
            tb_Addres.Text = "";

            tb_Distributor_ID.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            tb_Distributor_ID.Enabled = false;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * from Distributor_Details where Distributor_ID = " + tb_Distributor_ID.Text + " ";

            var Obj = Cmd.ExecuteReader();

            if (Obj.Read())
            {
                tb_First_Name.Text = Obj.GetString(Obj.GetOrdinal("First_Name"));
                tb_Middle_Name.Text = Obj.GetString(Obj.GetOrdinal("Middle_Name"));
                tb_Last_Name.Text = Obj.GetString(Obj.GetOrdinal("Last_Name"));
                tb_Addres.Text = Obj.GetString(Obj.GetOrdinal("Address"));
                tb_Mobile_No_1.Text = (Obj["Mobile_No"].ToString());
                tb_Alternate_Mobile_No.Text = (Obj["Alternate_Mobile_No"].ToString());

                btn_Update.Enabled = true;
            }
            else
            {
                MessageBox.Show("Information is not Available...", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear_Controls();
            }

            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
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

            Con_Open();

            if (tb_Distributor_ID.Text != "" && tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Last_Name.Text != "" && tb_Mobile_No_1.Text != "" && tb_Addres.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Distributor_Details Set First_Name = @F_Name, Middle_Name = @M_Name, Last_Name = @L_Name, Mobile_No = @Mob1, Alternate_Mobile_No = @Mob2, Address = @Add Where Distributor_ID = @Dist_ID";

                Cmd.Parameters.Add("Dist_ID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("F_Name", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("M_Name", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("L_Name", SqlDbType.VarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("Mob1", SqlDbType.Money).Value = tb_Mobile_No_1.Text;
                Cmd.Parameters.Add("Mob2", SqlDbType.Money).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Addres.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Distributor Details Updated Successfully !!!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void tb_Distributor_ID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void frm_Update_Distributor_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

       
    }
}
