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
    public partial class LoginForm : Form
    {
        private MainTabbedForm mainTabbedForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login()
        {
            ShowMainForm();
        }

        /// <summary>
        /// Method to show main form and hide login form
        /// </summary>
        public void ShowMainForm()
        {
            this.Hide();
            if(mainTabbedForm == null)
            {
                mainTabbedForm = new MainTabbedForm(this);
            }
            mainTabbedForm.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void ClearForm()
        {
            this.usernameTextBox.Text = "";
            this.usernameErrorLabel.Text = "";
            this.passwordTextBox.Text = "";
            this.passwordErrorLabel.Text = "";
            this.passwordTextBox.BackColor = Color.White;
            this.usernameTextBox.BackColor = Color.White;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.usernameTextBox.Text))
            {
                this.usernameErrorLabel.Text = "Username is required";
                this.usernameTextBox.BackColor = Color.Red;
            } else
            {
                this.usernameErrorLabel.Text = "";
                this.usernameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Logout user method
        /// </summary>
        public void Logout()
        {
            ClearForm();
        }

        /// <summary>
        /// Method to set the current main form
        /// </summary>
        /// <param name="_mainForm"></param>
        public void SetMainTabbedForm(MainTabbedForm _mainTabbedForm)
        {
            this.mainTabbedForm = _mainTabbedForm;
        }


        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.passwordTextBox.Text))
            {
                this.passwordErrorLabel.Text = "Password is required";
                this.passwordTextBox.BackColor = Color.Red;
            }
            else
            {
                this.passwordErrorLabel.Text = "";
                this.passwordTextBox.BackColor = Color.White;
            }
        }
    }
}
