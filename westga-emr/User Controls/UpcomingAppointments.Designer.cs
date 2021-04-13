
namespace westga_emr.User_Controls
{
    partial class UpcomingAppointments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditAppointment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appointmentCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 181);
            this.panel1.TabIndex = 1;
            // 
            // appointmentCalendar
            // 
            this.appointmentCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.appointmentCalendar.Location = new System.Drawing.Point(9, 9);
            this.appointmentCalendar.Name = "appointmentCalendar";
            this.appointmentCalendar.TabIndex = 0;
            this.appointmentCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentCalendar_DateChanged);
            this.appointmentCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentCalendar_DateChanged);
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.AutoGenerateColumns = false;
            this.appointmentDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.DoctorName,
            this.PatientName,
            this.appointmentDateTimeDataGridViewTextBoxColumn,
            this.reasonForVisitDataGridViewTextBoxColumn,
            this.ViewVisit,
            this.EditAppointment});
            this.appointmentDataGridView.DataSource = this.appointmentDTOBindingSource;
            this.appointmentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appointmentDataGridView.Location = new System.Drawing.Point(0, 205);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1100, 645);
            this.appointmentDataGridView.TabIndex = 2;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDataGridView_CellContentClick);
            // 
            // appointmentDTOBindingSource
            // 
            this.appointmentDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.AppointmentDTO);
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.HeaderText = "ID";
            this.AppointmentID.Name = "AppointmentID";
            this.AppointmentID.ReadOnly = true;
            this.AppointmentID.Width = 50;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "Doctor";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            this.DoctorName.Width = 150;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Patient";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 150;
            // 
            // appointmentDateTimeDataGridViewTextBoxColumn
            // 
            this.appointmentDateTimeDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDateTime";
            this.appointmentDateTimeDataGridViewTextBoxColumn.HeaderText = "Appointment Date & Time";
            this.appointmentDateTimeDataGridViewTextBoxColumn.Name = "appointmentDateTimeDataGridViewTextBoxColumn";
            this.appointmentDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentDateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // reasonForVisitDataGridViewTextBoxColumn
            // 
            this.reasonForVisitDataGridViewTextBoxColumn.DataPropertyName = "ReasonForVisit";
            this.reasonForVisitDataGridViewTextBoxColumn.HeaderText = "ReasonForVisit";
            this.reasonForVisitDataGridViewTextBoxColumn.Name = "reasonForVisitDataGridViewTextBoxColumn";
            this.reasonForVisitDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonForVisitDataGridViewTextBoxColumn.Width = 250;
            // 
            // ViewVisit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.ViewVisit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ViewVisit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewVisit.HeaderText = "";
            this.ViewVisit.Name = "ViewVisit";
            this.ViewVisit.ReadOnly = true;
            this.ViewVisit.Text = "View Visit";
            this.ViewVisit.UseColumnTextForButtonValue = true;
            // 
            // EditAppointment
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.EditAppointment.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAppointment.HeaderText = "";
            this.EditAppointment.Name = "EditAppointment";
            this.EditAppointment.ReadOnly = true;
            this.EditAppointment.Text = "Edit Appointment";
            this.EditAppointment.UseColumnTextForButtonValue = true;
            this.EditAppointment.Width = 150;
            // 
            // UpcomingAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UpcomingAppointments";
            this.Size = new System.Drawing.Size(1100, 850);
            this.Load += new System.EventHandler(this.UpcomingAppointments_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar appointmentCalendar;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.BindingSource appointmentDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewVisit;
        private System.Windows.Forms.DataGridViewButtonColumn EditAppointment;
    }
}
