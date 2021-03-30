
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
            this.signOutLink = new System.Windows.Forms.LinkLabel();
            this.currentUserName = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.userGreeting = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.newAppointmentTabPage = new System.Windows.Forms.TabPage();
            this.saerchPatientTabPage = new System.Windows.Forms.TabPage();
            this.upcomingAppointmentsTabPage = new System.Windows.Forms.TabPage();
            this.nurseListTabPage = new System.Windows.Forms.TabPage();
            this.addNurseTabPage = new System.Windows.Forms.TabPage();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.newAppointment1 = new westga_emr.User_Controls.NewAppointment();
            this.searchPatient1 = new westga_emr.User_Controls.SearchPatient();
            this.upcomingAppointments1 = new westga_emr.User_Controls.UpcomingAppointments();
            this.nurses1 = new westga_emr.User_Controls.Nurses();
            this.addNurse1 = new westga_emr.User_Controls.AddNurse();
            this.report1 = new westga_emr.User_Controls.Report();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.newAppointmentTabPage.SuspendLayout();
            this.saerchPatientTabPage.SuspendLayout();
            this.upcomingAppointmentsTabPage.SuspendLayout();
            this.nurseListTabPage.SuspendLayout();
            this.addNurseTabPage.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1232, 62);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.signOutLink, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentUserName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentTimeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userGreeting, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1215, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // signOutLink
            // 
            this.signOutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signOutLink.AutoSize = true;
            this.signOutLink.Location = new System.Drawing.Point(1148, 0);
            this.signOutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signOutLink.Name = "signOutLink";
            this.signOutLink.Size = new System.Drawing.Size(63, 17);
            this.signOutLink.TabIndex = 0;
            this.signOutLink.TabStop = true;
            this.signOutLink.Text = "Sign Out";
            this.signOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signOutLink_LinkClicked);
            // 
            // currentUserName
            // 
            this.currentUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUserName.AutoSize = true;
            this.currentUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserName.Location = new System.Drawing.Point(905, 0);
            this.currentUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentUserName.Name = "currentUserName";
            this.currentUserName.Size = new System.Drawing.Size(0, 58);
            this.currentUserName.TabIndex = 1;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Location = new System.Drawing.Point(602, 0);
            this.currentTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(0, 58);
            this.currentTimeLabel.TabIndex = 2;
            // 
            // userGreeting
            // 
            this.userGreeting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGreeting.AutoSize = true;
            this.userGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGreeting.Location = new System.Drawing.Point(3, 0);
            this.userGreeting.Name = "userGreeting";
            this.userGreeting.Size = new System.Drawing.Size(297, 58);
            this.userGreeting.TabIndex = 3;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mainTabControl.Controls.Add(this.newAppointmentTabPage);
            this.mainTabControl.Controls.Add(this.saerchPatientTabPage);
            this.mainTabControl.Controls.Add(this.upcomingAppointmentsTabPage);
            this.mainTabControl.Controls.Add(this.nurseListTabPage);
            this.mainTabControl.Controls.Add(this.addNurseTabPage);
            this.mainTabControl.Controls.Add(this.reportsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Location = new System.Drawing.Point(0, 98);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1232, 957);
            this.mainTabControl.TabIndex = 1;
            // 
            // newAppointmentTabPage
            // 
            this.newAppointmentTabPage.AutoScroll = true;
            this.newAppointmentTabPage.BackColor = System.Drawing.Color.SkyBlue;
            this.newAppointmentTabPage.Controls.Add(this.newAppointment1);
            this.newAppointmentTabPage.Location = new System.Drawing.Point(4, 28);
            this.newAppointmentTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.newAppointmentTabPage.Name = "newAppointmentTabPage";
            this.newAppointmentTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.newAppointmentTabPage.Size = new System.Drawing.Size(1224, 925);
            this.newAppointmentTabPage.TabIndex = 0;
            this.newAppointmentTabPage.Text = "New Appointment";
            // 
            // saerchPatientTabPage
            // 
            this.saerchPatientTabPage.Controls.Add(this.searchPatient1);
            this.saerchPatientTabPage.Location = new System.Drawing.Point(4, 28);
            this.saerchPatientTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.saerchPatientTabPage.Name = "saerchPatientTabPage";
            this.saerchPatientTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.saerchPatientTabPage.Size = new System.Drawing.Size(1224, 925);
            this.saerchPatientTabPage.TabIndex = 1;
            this.saerchPatientTabPage.Text = "Search Patient";
            this.saerchPatientTabPage.UseVisualStyleBackColor = true;
            // 
            // upcomingAppointmentsTabPage
            // 
            this.upcomingAppointmentsTabPage.Controls.Add(this.upcomingAppointments1);
            this.upcomingAppointmentsTabPage.Location = new System.Drawing.Point(4, 28);
            this.upcomingAppointmentsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.upcomingAppointmentsTabPage.Name = "upcomingAppointmentsTabPage";
            this.upcomingAppointmentsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.upcomingAppointmentsTabPage.Size = new System.Drawing.Size(1224, 925);
            this.upcomingAppointmentsTabPage.TabIndex = 2;
            this.upcomingAppointmentsTabPage.Text = "Upcoming Appointments";
            this.upcomingAppointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // nurseListTabPage
            // 
            this.nurseListTabPage.Controls.Add(this.nurses1);
            this.nurseListTabPage.Location = new System.Drawing.Point(4, 28);
            this.nurseListTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.nurseListTabPage.Name = "nurseListTabPage";
            this.nurseListTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.nurseListTabPage.Size = new System.Drawing.Size(1224, 925);
            this.nurseListTabPage.TabIndex = 3;
            this.nurseListTabPage.Text = "Nurses";
            this.nurseListTabPage.UseVisualStyleBackColor = true;
            // 
            // addNurseTabPage
            // 
            this.addNurseTabPage.Controls.Add(this.addNurse1);
            this.addNurseTabPage.Location = new System.Drawing.Point(4, 28);
            this.addNurseTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.addNurseTabPage.Name = "addNurseTabPage";
            this.addNurseTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.addNurseTabPage.Size = new System.Drawing.Size(1224, 925);
            this.addNurseTabPage.TabIndex = 4;
            this.addNurseTabPage.Text = "Add Nurse";
            this.addNurseTabPage.UseVisualStyleBackColor = true;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.report1);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 28);
            this.reportsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.reportsTabPage.Size = new System.Drawing.Size(1224, 925);
            this.reportsTabPage.TabIndex = 5;
            this.reportsTabPage.Text = "Report";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // newAppointment1
            // 
            this.newAppointment1.AutoScroll = true;
            this.newAppointment1.BackColor = System.Drawing.Color.SkyBlue;
            this.newAppointment1.Location = new System.Drawing.Point(32, 8);
            this.newAppointment1.Margin = new System.Windows.Forms.Padding(4);
            this.newAppointment1.MaximumSize = new System.Drawing.Size(1187, 1000);
            this.newAppointment1.Name = "newAppointment1";
            this.newAppointment1.Size = new System.Drawing.Size(1133, 900);
            this.newAppointment1.TabIndex = 0;
            // 
            // searchPatient1
            // 
            this.searchPatient1.Location = new System.Drawing.Point(20, 5);
            this.searchPatient1.Margin = new System.Windows.Forms.Padding(1);
            this.searchPatient1.Name = "searchPatient1";
            this.searchPatient1.Size = new System.Drawing.Size(848, 491);
            this.searchPatient1.TabIndex = 0;
            // 
            // upcomingAppointments1
            // 
            this.upcomingAppointments1.Location = new System.Drawing.Point(27, 7);
            this.upcomingAppointments1.Margin = new System.Windows.Forms.Padding(5);
            this.upcomingAppointments1.Name = "upcomingAppointments1";
            this.upcomingAppointments1.Size = new System.Drawing.Size(792, 352);
            this.upcomingAppointments1.TabIndex = 0;
            // 
            // nurses1
            // 
            this.nurses1.Location = new System.Drawing.Point(23, 7);
            this.nurses1.Margin = new System.Windows.Forms.Padding(5);
            this.nurses1.Name = "nurses1";
            this.nurses1.Size = new System.Drawing.Size(712, 332);
            this.nurses1.TabIndex = 0;
            // 
            // addNurse1
            // 
            this.addNurse1.Location = new System.Drawing.Point(11, 7);
            this.addNurse1.Margin = new System.Windows.Forms.Padding(5);
            this.addNurse1.Name = "addNurse1";
            this.addNurse1.Size = new System.Drawing.Size(780, 409);
            this.addNurse1.TabIndex = 0;
            // 
            // report1
            // 
            this.report1.Location = new System.Drawing.Point(24, 20);
            this.report1.Margin = new System.Windows.Forms.Padding(5);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(695, 368);
            this.report1.TabIndex = 0;
            // 
            // MainTabbedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1232, 1055);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainTabbedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G4-EMR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainTabbedForm_FormClosed);
            this.Load += new System.EventHandler(this.MainTabbedForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.newAppointmentTabPage.ResumeLayout(false);
            this.saerchPatientTabPage.ResumeLayout(false);
            this.upcomingAppointmentsTabPage.ResumeLayout(false);
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
    }
}