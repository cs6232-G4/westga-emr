using System;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class MainTabbedForm : Form
    {
        private LoginForm loginForm;
        private UserDTO currentUser;
        private PersonController personController;

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
            this.ReloadTabPages();
            this.loginForm.Logout();
            this.currentUser = new UserDTO();
            this.loginForm.Show();
            this.loginForm.SetMainTabbedForm(this);
        }

        private void MainTabbedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void MainTabbedForm_Load(object sender, EventArgs e)
        {
            personController = new PersonController();
            
            if(this.currentUser.AdminId <= 0 || !this.currentUser.IsActiveAdmin)
            {
                
                this.mainTabControl.TabPages.Remove(this.nurseListTabPage);
                this.mainTabControl.TabPages.Remove(this.addNurseTabPage);
                this.mainTabControl.TabPages.Remove(this.reportsTabPage);
            }
            if (this.currentUser.NurseId <= 0 || !this.currentUser.IsActiveNurse)
            {
               
                this.mainTabControl.TabPages.Remove(this.saerchPatientTabPage);
                this.mainTabControl.TabPages.Remove(this.upcomingAppointmentsTabPage);
                this.mainTabControl.TabPages.Remove(this.testsTabPage);

            }
            this.currentTimeLabel.Text = DateTime.Now.ToShortTimeString();
            this.userGreeting.Text = String.Concat("Hello ", this.currentUser.FirstName, " ", this.currentUser.LastName);
            this.currentUserName.Text = this.currentUser.Username;
        }


        /// <summary>
        /// Sets the new current user when current user is changed
        /// </summary>
        /// <param name="user"></param>
        public void SetCurrentUser(UserDTO user)
        {
            this.currentUser = user;
        }

        /// <summary>
        /// Reloads the tab pages to default tabs
        /// </summary>
        public void ReloadTabPages()
        {
            if (!this.mainTabControl.TabPages.Contains(this.nurseListTabPage))
            {
                this.mainTabControl.TabPages.Add(this.nurseListTabPage);
            }
            if (!this.mainTabControl.TabPages.Contains(this.addNurseTabPage))
            {
                this.mainTabControl.TabPages.Add(this.addNurseTabPage);
            }
            if (!this.mainTabControl.TabPages.Contains(this.reportsTabPage))
            {
                this.mainTabControl.TabPages.Add(this.reportsTabPage);
            }
            if (!this.mainTabControl.TabPages.Contains(this.saerchPatientTabPage))
            {
                this.mainTabControl.TabPages.Add(this.saerchPatientTabPage);
            }
            if (!this.mainTabControl.TabPages.Contains(this.upcomingAppointmentsTabPage))
            {
                this.mainTabControl.TabPages.Add(this.upcomingAppointmentsTabPage);
            }
            if (!this.mainTabControl.TabPages.Contains(this.testsTabPage))
            {
                this.mainTabControl.TabPages.Add(this.testsTabPage);
            }
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.mainTabControl.SelectedTab == this.saerchPatientTabPage)
            {
                this.searchPatient1.SearchPatient_Load("MAIN FORM", EventArgs.Empty);
            }
            else if (this.mainTabControl.SelectedTab == this.upcomingAppointmentsTabPage)
            {
                this.upcomingAppointments1.LoadDataGrid();
            }
            else if (this.mainTabControl.SelectedTab == this.nurseListTabPage)
            {
                this.nurses1.Nurses_Load("MAIN FORM", EventArgs.Empty);

            }

        }
    }
}
