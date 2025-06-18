using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Wellness_Project
{
    public partial class frmWS : Form
    {
        public frmWS()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void txtbxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private List<TabPage> hiddenTabs = new List<TabPage>();

        private void frmWS_Load(object sender, EventArgs e)
        {

            // Store the non-login tabs to hide them
            foreach (TabPage tab in tabCtrlcenter.TabPages)
            {
                if (tab != tabCtrlLogin) // Keep only the login tab
                {
                    hiddenTabs.Add(tab);
                }
            }

            // Remove all non-login tabs
            foreach (TabPage tab in hiddenTabs)
            {
                tabCtrlcenter.TabPages.Remove(tab);
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtbxUser.Text;
            string password = txtboxPass.Text;

            if (username == "student" && password == "123")
            {
                tabCtrlcenter.SelectedIndex = 1;
                tabCtrlcenter.TabPages.Add(tabCtrlSView);
                tabCtrlcenter.TabPages.Remove(tabCtrlLogin);
            }
            else
            {
                txtboxPass.Clear();
            }
            if (username == "professor" && password == "123")
            {
                tabCtrlcenter.SelectedIndex = 1;
                tabCtrlcenter.TabPages.Add(tabCtrlPView);
                tabCtrlcenter.TabPages.Remove(tabCtrlLogin);
            }
            else
            {
                txtboxPass.Clear();
            }
            if (username == "admin" && password == "123")
            {
                tabCtrlcenter.SelectedIndex = 1;
                tabCtrlcenter.TabPages.Add(tabCtrlAView);
                tabCtrlcenter.TabPages.Remove(tabCtrlLogin);
            }
            else
            {
                txtboxPass.Clear();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxMidGR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
