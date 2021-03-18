using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace westga_emr.View
{
    public partial class MainTabbedForm : Form
    {
        private LoginForm loginForm;
        public MainTabbedForm()
        {
            InitializeComponent();
        }

        public MainTabbedForm(LoginForm _loginForm)
        {
            InitializeComponent();
            this.loginForm = _loginForm;
        }

        private void signOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.loginForm.Logout();
            this.loginForm.Show();
            this.loginForm.SetMainTabbedForm(this);
        }

        private void MainTabbedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
