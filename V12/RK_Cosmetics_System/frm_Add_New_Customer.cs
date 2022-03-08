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
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_RK_Cosmetics_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Open();                
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Close();
            }
        }

        void Clear_Controls()
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con_Open();


            Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();


            Con_Close();
        }
    }
}
