using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGedaLib;

namespace Test_Client
{
    public partial class Form_Main : Form
    {
        User user;
        Form activeForm = null;
        public Form_Main()
        {
            InitializeComponent();
        }

        public Form_Main(User _user)
        {
            InitializeComponent();
            this.user = _user;
            customizeDesign();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void customizeDesign()
        {
            panel_Test_SubMenu.Visible = false;
           // panel_Users_SubMenu.Visible = false;
           // panel_Test_SubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
           // if (panel_Users_SubMenu.Visible == true) panel_Users_SubMenu.Visible = false;
            if (panel_Test_SubMenu.Visible == true) panel_Test_SubMenu.Visible = false;
           // if (panel_Test_SubMenu.Visible == true) panel_Test_SubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            panel_Main.BringToFront();
            childForm.Show();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panel_Test_SubMenu);
        }

        private void btn_Test_Show_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ShowTests(user));
        }
    }
}
