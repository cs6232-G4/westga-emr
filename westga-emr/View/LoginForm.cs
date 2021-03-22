using System;
using System.Drawing;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class LoginForm : Form
    {
        private PersonController personController;
        private MainTabbedForm mainTabbedForm;
        public LoginForm()
        {
            InitializeComponent();
            personController = new PersonController();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login()
        {
            try
            {
                ShowMainForm(personController.SignIn(this.usernameTextBox.Text, this.passwordTextBox.Text));
       
            }catch(Exception)
            {
                MessageBox.Show("The email and password you entered did not match our records." + Environment.NewLine + "Please double-check and try again.",
                  "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Method to show main form and hide login form
        /// </summary>
        public void ShowMainForm(UserDTO authenticatedUser)
        {
           if(authenticatedUser.NurseId > 0 || authenticatedUser.AdminId > 0)
            {
                if (authenticatedUser.IsActiveNurse || authenticatedUser.IsActiveAdmin)
                {
                    this.Hide();
                    if (mainTabbedForm == null)
                    {
                        mainTabbedForm = new MainTabbedForm(this, authenticatedUser);
                    }
                    else
                    {
                        mainTabbedForm.SetCurrentUser(authenticatedUser);
                        mainTabbedForm.MainTabbedForm_Load("LOGIN", EventArgs.Empty);
                    }
                    mainTabbedForm.Show();
                }
                else
                {
                    MessageBox.Show("Your account is not activate " + Environment.NewLine + "Please activate your account.",
                     "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } 
            else
            {
                MessageBox.Show("Access denied" + Environment.NewLine + "You do not have permission to use this system.",
                     "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateUsernameInput() && this.ValidatePasswordInput())
            {
                Login();
            } 
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
            this.ValidateUsernameInput();
        }

        /// <summary>
        /// Logout user method
        /// </summary>
        public void Logout()
        {
            this.personController.SignOutUser();
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
            this.ValidatePasswordInput();
        }

        private bool ValidateUsernameInput()
        {
            if (String.IsNullOrWhiteSpace(this.usernameTextBox.Text))
            {
                this.usernameErrorLabel.Text = "Username is required";
                this.usernameTextBox.BackColor = Color.Red;
                return false;
            }
            else
            {
                this.usernameErrorLabel.Text = "";
                this.usernameTextBox.BackColor = Color.White;
                return true;
            }
        }
        private bool ValidatePasswordInput()
        {
            if (String.IsNullOrWhiteSpace(this.passwordTextBox.Text))
            {
                this.passwordErrorLabel.Text = "Password is required";
                this.passwordTextBox.BackColor = Color.Red;
                return false;
            }
            else
            {
                this.passwordErrorLabel.Text = "";
                this.passwordTextBox.BackColor = Color.White;
                return true;
            }
        }
    }
}
