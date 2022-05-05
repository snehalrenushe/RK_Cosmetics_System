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
    public partial class frm_Expences : Form
    {
        public frm_Expences()
        {
            InitializeComponent();
        }

        string imgLocation = "";

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

            Cmd.CommandText = "Select Count(*) from Expences_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Expences_Id) from Expences_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }

            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;

        }

        void Clear_Control()
        {
            tb_Expences_ID.Text = Convert.ToString(Auto_Increament_ID());

            tb_Expences_Datiles.Clear();
            tb_Amount_Paid.Clear();
            dtp_Date.ResetText();
            tb_Paid_By.Clear();
            pb_Bill_Image.Image = null;
        }

        private void frm_Expences_Load(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Date.MinDate = dtp_Date.MaxDate = DateTime.Now;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Expences_Datiles.Text != "" || tb_Amount_Paid.Text != "" || tb_Paid_By.Text != "")
            {
                Res = MessageBox.Show("Are You Sure... Data Entered Will Be Lost...?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Control();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Expences_Datiles.Text != "" && tb_Amount_Paid.Text != "" & tb_Paid_By.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Expences_Details Values (@ID , @EXP , @AMT , @DATE , @IMG , @PAID)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Expences_ID.Text;
                Cmd.Parameters.Add("EXP", SqlDbType.NVarChar).Value = tb_Expences_Datiles.Text;
                Cmd.Parameters.Add("AMT", SqlDbType.Money).Value = tb_Amount_Paid.Text;
                Cmd.Parameters.Add("DATE", SqlDbType.Date).Value = dtp_Date.Value.Date;

                ImageConverter IC = new ImageConverter();
                byte[] imgArray = (byte[])IC.ConvertTo(pb_Bill_Image.Image, typeof(byte[]));
                Cmd.Parameters.Add("IMG", SqlDbType.Image).Value = imgArray;

                Cmd.Parameters.Add("PAID", SqlDbType.NVarChar).Value = tb_Paid_By.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully...!!", "Saving");

                Clear_Control();
            }

            else
            {
                MessageBox.Show("First Fill All Fields...!!", "Warning");
            }

            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Expences_Datiles.Text != "" || tb_Amount_Paid.Text != "" || tb_Paid_By.Text != "")
            {
                Res = MessageBox.Show("Are You Sure... Data Entered Will Be Lost...?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpg; *.jpeg;)| *.jpg; *jpeg;";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                imgLocation = OFD.FileName.ToString();
                pb_Bill_Image.ImageLocation = imgLocation;
                // pb_Bill_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
