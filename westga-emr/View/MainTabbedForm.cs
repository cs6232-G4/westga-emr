using System;
using System.Windows.Forms;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class MainTabbedForm : Form
    {
        private LoginForm loginForm;
        private UserDTO currentUser;
        public MainTabbedForm()
        {
            InitializeComponent();
        }

        public MainTabbedForm(LoginForm _loginForm, UserDTO _currentUser)
        {
            InitializeComponent();
            this.loginForm = _loginForm;
            this.currentUser = _currentUser;
        }

        private void signOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            this.currentUser = new UserDTO();
            this.loginForm.Logout();
            this.loginForm.Show();
            this.loginForm.SetMainTabbedForm(this);
        }

        private void MainTabbedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainTabbedForm_Load(object sender, EventArgs e)
        {
            if(this.currentUser.AdminId <= 0 || !this.currentUser.IsActiveAdmin)
            {
                this.nurseListTabPage.Hide();
                this.addNurseTabPage.Hide();
                this.reportsTabPage.Hide();
            }
            if (this.currentUser.NurseId <= 0 || !this.currentUser.IsActiveNurse)
            {
                this.newAppointmentTabPage.Hide();
                this.saerchPatientTabPage.Hide();
                this.upcomingAppointmentsTabPage.Hide();
            }
            this.currentTimeLabel.Text = DateTime.Now.ToShortTimeString();
            this.userGreeting.Text = String.Concat("Hello ", this.currentUser.FirstName, " ", this.currentUser.LastName);
            this.currentUserName.Text = this.currentUser.Username;
        }
    }
}
