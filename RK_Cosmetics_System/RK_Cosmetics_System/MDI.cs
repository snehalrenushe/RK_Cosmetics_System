using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RK_Cosmetics_System
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            CustomizeDesigning();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            pnl_Child.Visible = true;
            this.BackColor = Color.FromArgb(43, 41, 41);

            btn_New.BackColor = Color.FromArgb(225, 74, 140);
            btn_Update.BackColor = Color.FromArgb(225, 74, 140);
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }

            sliderimg.ImageLocation = string.Format(@"ImagesSlider\{0}.jpg",imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnl_Main.Visible = true;
            pnl_Main.BackColor = Color.FromArgb(43, 41, 41);

            btn_Home.BackColor = Color.FromArgb(43, 41, 41);
            btn_Home.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Product.BackColor = Color.FromArgb(43, 41, 41);
            btn_Product.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Add_New_Product.BackColor = Color.FromArgb(112, 12, 55);
            btn_Update_Product_Details.BackColor = Color.FromArgb(112, 12, 55);
            btn_View_Product_List.BackColor = Color.FromArgb(112, 12, 55);

            btn_User_Management.BackColor = Color.FromArgb(43, 41, 41);
            btn_User_Management.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Add_New_User.BackColor = Color.FromArgb(112, 12, 55);
            btn_Change_Password.BackColor = Color.FromArgb(112, 12, 55);
            btn_Delete_Password.BackColor = Color.FromArgb(112, 12, 55);

            btn_Stock.BackColor = Color.FromArgb(43, 41, 41);
            btn_Stock.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Add_Stock.BackColor = Color.FromArgb(112, 12, 55);
            btn_View_Stock_List.BackColor = Color.FromArgb(112, 12, 55);

            btn_Expenses.BackColor = Color.FromArgb(43, 41, 41);
            btn_Expenses.ForeColor = Color.FromArgb(255, 0, 111);

            btn_Add_New_Expenses.BackColor = Color.FromArgb(112, 12, 55);
            btn_View_Expenses_List.BackColor = Color.FromArgb(112, 12, 55);

            btn_Report.BackColor = Color.FromArgb(43, 41, 41);
            btn_Report.ForeColor = Color.FromArgb(255, 0, 111);
        }

        private void CustomizeDesigning()
        {
            pnl_Product_Submenu.Visible = false;
            pnl_User_Submenu.Visible = false;
            pnl_Stock_Submenu.Visible = false;
            pnl_Expenses_Submenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (pnl_Product_Submenu.Visible == true)
            {
                pnl_Product_Submenu.Visible = false;
            }

            if (pnl_User_Submenu.Visible == true)
            {
                pnl_User_Submenu.Visible = false;
            }

            if (pnl_Stock_Submenu.Visible == true)
            {
                pnl_Stock_Submenu.Visible = false;
            }

            if (pnl_Expenses_Submenu.Visible == true)
            {
                pnl_Expenses_Submenu.Visible = false;
            }
        }

        private void ShowSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HideSubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Product_Submenu);
        }

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_User_Submenu);
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Stock_Submenu);
        }

        private void btn_Expenses_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Expenses_Submenu);
        }

       
        private void btn_New_MouseEnter(object sender, EventArgs e)
        {
            pnl_New_Submenu.Visible = true;
            btn_Customer.BackColor = Color.FromArgb(106, 42, 96);
            btn_Employee.BackColor = Color.FromArgb(106, 42, 96);
            btn_Distributor.BackColor = Color.FromArgb(106, 42, 96);
            btn_brand.BackColor = Color.FromArgb(106, 42, 96);
        }

        private void pnl_New_Submenu_MouseLeave(object sender, EventArgs e)
        {
            pnl_New_Submenu.Visible = false;
        }

        private void pnl_New_Submenu_ControlRemoved(object sender, ControlEventArgs e)
        {
            pnl_New_Submenu.Visible = false;
        }

        private void pnl_New_Submenu_MouseDown(object sender, MouseEventArgs e)
        {
            pnl_New_Submenu.Visible = false;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            btn_Customer.BackColor = Color.FromArgb(48, 25, 35);
        }

        private void btn_Update_MouseEnter(object sender, EventArgs e)
        {
            pnl_Update_Submenu.Visible = true;
            btn_Update_Employee.BackColor = Color.FromArgb(106, 42, 96);
            btn_Update_Distributor.BackColor = Color.FromArgb(106, 42, 96);
            btn_Update_Brand.BackColor = Color.FromArgb(106, 42, 96);
            btn_Customer_List.BackColor = Color.FromArgb(106, 42, 96);
        }

        private void pnl_Update_Submenu_ControlRemoved(object sender, ControlEventArgs e)
        {
            pnl_Update_Submenu.Visible = false;
        }

        private void pnl_Update_Submenu_MouseDown(object sender, MouseEventArgs e)
        {
            pnl_Update_Submenu.Visible = false;
        }

        private void pnl_Update_Submenu_MouseLeave(object sender, EventArgs e)
        {
            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            MDI m = new MDI();
            this.Hide();
            m.Show();
        }

        private void pnl_Child_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(26, 26, 26);
        }

        private Form activeForm = null;

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            pnl_Child.Controls.Add(ChildForm);
            pnl_Child.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_New_Product());

            pnl_Main.Visible = false;
        }

        private void btn_Update_Product_Details_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Update_Product_Details());

            pnl_Main.Visible = false;
        }

        private void btn_View_Product_List_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_View_Product_List());

            pnl_Main.Visible = false;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_New_Customer());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_New_Employee());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Update_Employee_Details());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_New_Distributor());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Update_Distributor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Update_Distributor_Details());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_New_Brand());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Update_Brand_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Update_Brand_Details());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Add_New_User_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_New_User());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Change_Password_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Change_Password());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Delete_Password_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Delete_User());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Add_Stock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_Stock());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_View_Stock_List_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_View_Stock_List());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_Add_New_Expenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Add_Expenses());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }

        private void btn_View_Expenses_List_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_View_Expense_Details());

            pnl_Main.Visible = false;

            pnl_New_Submenu.Visible = false;

            pnl_Update_Submenu.Visible = false;
        }
    }
}
