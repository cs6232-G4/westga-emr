
namespace westga_emr.View
{
    partial class MainTabbedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentUserName = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.userGreeting = new System.Windows.Forms.Label();
            this.signOutLink = new System.Windows.Forms.LinkLabel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.newAppointmentTabPage = new System.Windows.Forms.TabPage();
            this.newAppointment1 = new westga_emr.User_Controls.NewAppointment();
            this.saerchPatientTabPage = new System.Windows.Forms.TabPage();
            this.searchPatient1 = new westga_emr.User_Controls.SearchPatient();
            this.upcomingAppointmentsTabPage = new System.Windows.Forms.TabPage();
            this.upcomingAppointments1 = new westga_emr.User_Controls.UpcomingAppointments();
            this.testsTabPage = new System.Windows.Forms.TabPage();
            this.testsUserControl1 = new westga_emr.User_Controls.TestsUserControl();
            this.nurseListTabPage = new System.Windows.Forms.TabPage();
            this.nurses1 = new westga_emr.User_Controls.Nurses();
            this.addNurseTabPage = new System.Windows.Forms.TabPage();
            this.addNurse1 = new westga_emr.User_Controls.AddNurse();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.report1 = new westga_emr.User_Controls.Report();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.newAppointmentTabPage.SuspendLayout();
            this.saerchPatientTabPage.SuspendLayout();
            this.upcomingAppointmentsTabPage.SuspendLayout();
            this.testsTabPage.SuspendLayout();
            this.nurseListTabPage.SuspendLayout();
            this.addNurseTabPage.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.signOutLink);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.currentUserName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentTimeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userGreeting, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // currentUserName
            // 
            this.currentUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUserName.AutoSize = true;
            this.currentUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserName.Location = new System.Drawing.Point(678, 0);
            this.currentUserName.Name = "currentUserName";
            this.currentUserName.Size = new System.Drawing.Size(0, 47);
            this.currentUserName.TabIndex = 1;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Location = new System.Drawing.Point(451, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(0, 47);
            this.currentTimeLabel.TabIndex = 2;
            // 
            // userGreeting
            // 
            this.userGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGreeting.AutoSize = true;
            this.userGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGreeting.Location = new System.Drawing.Point(2, 0);
            this.userGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userGreeting.Name = "userGreeting";
            this.userGreeting.Size = new System.Drawing.Size(223, 47);
            this.userGreeting.TabIndex = 3;
            // 
            // signOutLink
            // 
            this.signOutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signOutLink.AutoSize = true;
            this.signOutLink.Location = new System.Drawing.Point(920, 0);
            this.signOutLink.Name = "signOutLink";
            this.signOutLink.Size = new System.Drawing.Size(48, 13);
            this.signOutLink.TabIndex = 0;
            this.signOutLink.TabStop = true;
            this.signOutLink.Text = "Sign Out";
            this.signOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signOutLink_LinkClicked);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mainTabControl.Controls.Add(this.newAppointmentTabPage);
            this.mainTabControl.Controls.Add(this.saerchPatientTabPage);
            this.mainTabControl.Controls.Add(this.upcomingAppointmentsTabPage);
            this.mainTabControl.Controls.Add(this.testsTabPage);
            this.mainTabControl.Controls.Add(this.nurseListTabPage);
            this.mainTabControl.Controls.Add(this.addNurseTabPage);
            this.mainTabControl.Controls.Add(this.reportsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Location = new System.Drawing.Point(0, 81);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1184, 930);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // newAppointmentTabPage
            // 
            this.newAppointmentTabPage.AutoScroll = true;
            this.newAppointmentTabPage.BackColor = System.Drawing.Color.SkyBlue;
            this.newAppointmentTabPage.Controls.Add(this.newAppointment1);
            this.newAppointmentTabPage.Location = new System.Drawing.Point(4, 25);
            this.newAppointmentTabPage.Name = "newAppointmentTabPage";
            this.newAppointmentTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.newAppointmentTabPage.Size = new System.Drawing.Size(1176, 901);
            this.newAppointmentTabPage.TabIndex = 0;
            this.newAppointmentTabPage.Text = "New Appointment";
            // 
            // newAppointment1
            // 
            this.newAppointment1.AutoScroll = true;
            this.newAppointment1.BackColor = System.Drawing.Color.SkyBlue;
            this.newAppointment1.Location = new System.Drawing.Point(62, 4);
            this.newAppointment1.Margin = new System.Windows.Forms.Padding(4);
            this.newAppointment1.MaximumSize = new System.Drawing.Size(1100, 850);
            this.newAppointment1.Name = "newAppointment1";
            this.newAppointment1.Size = new System.Drawing.Size(1040, 823);
            this.newAppointment1.TabIndex = 0;
            // 
            // saerchPatientTabPage
            // 
            this.saerchPatientTabPage.AutoScroll = true;
            this.saerchPatientTabPage.BackColor = System.Drawing.Color.SkyBlue;
            this.saerchPatientTabPage.Controls.Add(this.searchPatient1);
            this.saerchPatientTabPage.Location = new System.Drawing.Point(4, 25);
            this.saerchPatientTabPage.Name = "saerchPatientTabPage";
            this.saerchPatientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.saerchPatientTabPage.Size = new System.Drawing.Size(1176, 901);
            this.saerchPatientTabPage.TabIndex = 1;
            this.saerchPatientTabPage.Text = "Search Patient";
            // 
            // searchPatient1
            // 
            this.searchPatient1.AutoScroll = true;
            this.searchPatient1.BackColor = System.Drawing.Color.SkyBlue;
            this.searchPatient1.Location = new System.Drawing.Point(75, 0);
            this.searchPatient1.Margin = new System.Windows.Forms.Padding(1);
            this.searchPatient1.MaximumSize = new System.Drawing.Size(1100, 850);
            this.searchPatient1.Name = "searchPatient1";
            this.searchPatient1.Size = new System.Drawing.Size(1040, 823);
            this.searchPatient1.TabIndex = 0;
            // 
            // upcomingAppointmentsTabPage
            // 
            this.upcomingAppointmentsTabPage.BackColor = System.Drawing.Color.SkyBlue;
            this.upcomingAppointmentsTabPage.Controls.Add(this.upcomingAppointments1);
            this.upcomingAppointmentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.upcomingAppointmentsTabPage.Name = "upcomingAppointmentsTabPage";
            this.upcomingAppointmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.upcomingAppointmentsTabPage.Size = new System.Drawing.Size(1176, 901);
            this.upcomingAppointmentsTabPage.TabIndex = 2;
            this.upcomingAppointmentsTabPage.Text = "Upcoming Appointments";
            // 
            // upcomingAppointments1
            // 
            this.upcomingAppointments1.BackColor = System.Drawing.Color.SkyBlue;
            this.upcomingAppointments1.Location = new System.Drawing.Point(73, 0);
            this.upcomingAppointments1.Margin = new System.Windows.Forms.Padding(4);
            this.upcomingAppointments1.MaximumSize = new System.Drawing.Size(1100, 850);
            this.upcomingAppointments1.Name = "upcomingAppointments1";
            this.upcomingAppointments1.Size = new System.Drawing.Size(1040, 823);
            this.upcomingAppointments1.TabIndex = 0;
            // 
            // testsTabPage
            // 
            this.testsTabPage.BackColor = System.Drawing.Color.SkyBlue;
            this.testsTabPage.Controls.Add(this.testsUserControl1);
            this.testsTabPage.Location = new System.Drawing.Point(4, 25);
            this.testsTabPage.Name = "testsTabPage";
            this.testsTabPage.Size = new System.Drawing.Size(1176, 901);
            this.testsTabPage.TabIndex = 6;
            this.testsTabPage.Text = "Tests";
            // 
            // testsUserControl1
            // 
            this.testsUserControl1.BackColor = System.Drawing.Color.SkyBlue;
            this.testsUserControl1.Location = new System.Drawing.Point(38, 3);
            this.testsUserControl1.Name = "testsUserControl1";
            this.testsUserControl1.Size = new System.Drawing.Size(1100, 850);
            this.testsUserControl1.TabIndex = 0;
            // 
            // nurseListTabPage
            // 
            this.nurseListTabPage.BackColor = System.Drawing.Color.SkyBlue;
            this.nurseListTabPage.Controls.Add(this.nurses1);
            this.nurseListTabPage.Location = new System.Drawing.Point(4, 25);
            this.nurseListTabPage.Name = "nurseListTabPage";
            this.nurseListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nurseListTabPage.Size = new System.Drawing.Size(1176, 901);
            this.nurseListTabPage.TabIndex = 3;
            this.nurseListTabPage.Text = "Nurses";
            // 
            // nurses1
            // 
            this.nurses1.BackColor = System.Drawing.Color.SkyBlue;
            this.nurses1.Location = new System.Drawing.Point(17, 6);
            this.nurses1.Margin = new System.Windows.Forms.Padding(4);
            this.nurses1.Name = "nurses1";
            this.nurses1.Size = new System.Drawing.Size(1133, 886);
            this.nurses1.TabIndex = 0;
            // 
            // addNurseTabPage
            // 
            this.addNurseTabPage.Controls.Add(this.addNurse1);
            this.addNurseTabPage.Location = new System.Drawing.Point(4, 25);
            this.addNurseTabPage.Name = "addNurseTabPage";
            this.addNurseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addNurseTabPage.Size = new System.Drawing.Size(1176, 901);
            this.addNurseTabPage.TabIndex = 4;
            this.addNurseTabPage.Text = "Add Nurse";
            this.addNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // addNurse1
            // 
            this.addNurse1.Location = new System.Drawing.Point(8, 6);
            this.addNurse1.Margin = new System.Windows.Forms.Padding(4);
            this.addNurse1.Name = "addNurse1";
            this.addNurse1.Size = new System.Drawing.Size(585, 332);
            this.addNurse1.TabIndex = 0;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.report1);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 25);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(1176, 901);
            this.reportsTabPage.TabIndex = 5;
            this.reportsTabPage.Text = "Report";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // report1
            // 
            this.report1.Location = new System.Drawing.Point(18, 16);
            this.report1.Margin = new System.Windows.Forms.Padding(4);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(521, 299);
            this.report1.TabIndex = 0;
            // 
            // MainTabbedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 1011);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainTabbedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G4-EMR-Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainTabbedForm_FormClosed);
            this.Load += new System.EventHandler(this.MainTabbedForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.newAppointmentTabPage.ResumeLayout(false);
            this.saerchPatientTabPage.ResumeLayout(false);
            this.upcomingAppointmentsTabPage.ResumeLayout(false);
            this.testsTabPage.ResumeLayout(false);
            this.nurseListTabPage.ResumeLayout(false);
            this.addNurseTabPage.ResumeLayout(false);
            this.reportsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel signOutLink;
        private System.Windows.Forms.Label currentUserName;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage newAppointmentTabPage;
        private System.Windows.Forms.TabPage saerchPatientTabPage;
        private System.Windows.Forms.Label userGreeting;
        private System.Windows.Forms.TabPage upcomingAppointmentsTabPage;
        private System.Windows.Forms.TabPage nurseListTabPage;
        private System.Windows.Forms.TabPage addNurseTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private User_Controls.SearchPatient searchPatient1;
        private User_Controls.UpcomingAppointments upcomingAppointments1;
        private User_Controls.Nurses nurses1;
        private User_Controls.AddNurse addNurse1;
        private User_Controls.Report report1;
        private User_Controls.NewAppointment newAppointment1;
        private System.Windows.Forms.TabPage testsTabPage;
        private User_Controls.TestsUserControl testsUserControl1;
    }
}