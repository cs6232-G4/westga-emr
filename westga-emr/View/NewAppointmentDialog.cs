using System;
using System.Collections.Generic;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Helpers;
using westga_emr.Model;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class NewAppointmentDialog : Form
    {
        private readonly DoctorController doctorController;
        private readonly AppointmentController appointmentController;
        private UserDTO patient;
        private TimeSpan selectedAppointmentTime;
        private DateTime selectedAppointmentDateTime;
        private readonly PatientController patientController;
        public NewAppointmentDialog(UserDTO _patient)
        {
            InitializeComponent();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
            patientController = new PatientController();
            patient = _patient;
        }

        private void NewAppointmentDialog_Load(object sender, EventArgs e)
        {
            this.firstNameLabel.Text = patient.FirstName;
            this.lastNameLabel.Text = patient.LastName;
            this.genderLabel.Text = patient.Gender;
            this.dobLabel.Text = patient.DateOfBirth.Value.ToShortDateString();
            this.appointmentInformationSection.Visible = true;
            this.appointmentDate.MinDate = DateTime.Now;
            this.appointmentTime.SelectedIndex = -1;
            this.doctorListComboBox.SelectedIndex = -1;
            doctorListError.Text = "";
            appointmentDateError.Text = "";
        }

        private void AppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            this.appointmentTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            if (appointmentTime.Enabled == false)
            {
                appointmentTime.Enabled = true;
            }
        }

        private void AppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.appointmentTime.SelectedIndex >= 0)
            {
                appointmentDateError.Text = "";
                var time = (AppointmentHelper)this.appointmentTime.SelectedItem;
                this.selectedAppointmentTime = TimeSpan.Parse(time.Value);
                this.selectedAppointmentDateTime = this.appointmentDate.Value.Date + selectedAppointmentTime;
                GetAvailableDoctors(this.selectedAppointmentDateTime);
            }
            else
            {
                appointmentDateError.Text = "Please select a time for the appointment";
            }

        }

        private void GetAvailableDoctors(DateTime aptDateTime)
        {
            try
            {
                if (aptDateTime == null)
                {
                    throw new Exception("Please select appointment date");
                }
                var availableDoctors = doctorController.GetAvailableDoctorsOnDate(aptDateTime);
                if (availableDoctors.Count <= 0)
                {
                    MessageBox.Show("No avilable doctor" + Environment.NewLine + "Please choose another date or time for your appointment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                doctorListComboBox.DataSource = availableDoctors;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AppointmentVisitReason_TextChanged(object sender, EventArgs e)
        {
            if (appointmentVisitReason.Text.Length > 45)
            {
                reasonForVisitError.Text = "Character limit exceeded. Maximum allowed: 45";
            }
            else if (String.IsNullOrWhiteSpace(appointmentVisitReason.Text))
            {
                reasonForVisitError.Text = "Reason for visit is required";
            }
            else
            {
                reasonForVisitError.Text = "";
            }
        }
        private void DoctorListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.doctorListComboBox.SelectedIndex < 0)
            {
                doctorListError.Text = "Please select a doctor for the appointment";
            }
            else
            {
                doctorListError.Text = "";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDoctor = (UserDTO)doctorListComboBox.SelectedItem;
                if (this.doctorListComboBox.SelectedIndex < 0)
                {
                    doctorListError.Text = "Please select a doctor for the appointment";
                }
                if (this.appointmentTime.SelectedIndex < 0)
                {
                    appointmentDateError.Text = "Please select a time for the appointment";
                }
                if (String.IsNullOrWhiteSpace(appointmentVisitReason.Text))
                {
                    reasonForVisitError.Text = "Please enter a reason for the appointment";
                }
                if (String.IsNullOrWhiteSpace(appointmentVisitReason.Text)
                    || patient.PatientId <= 0
                    || selectedAppointmentDateTime == null)
                {
                    throw new Exception("Enter all the required fields to create an appointment");
                }
                if (patientController.PatientHasAppointment(patient.PatientId, selectedAppointmentDateTime))
                {
                    throw new Exception($"Patient already has appointment scheduled for {selectedAppointmentDateTime.ToLocalTime()}");
                }
                var appointment = new Appointment(null,
                    patient.PatientId,
                    selectedDoctor.DoctorId,
                    selectedAppointmentDateTime,
                    appointmentVisitReason.Text);
                if (this.appointmentController.CreateAppointment(appointment))
                {
                    ClearForm();
                    MessageBox.Show("Appointment created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            appointmentVisitReason.Text = "";
            reasonForVisitError.Text = "";
            this.appointmentTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            this.appointmentTime.SelectedIndex = -1;
            GetAvailableDoctors(this.selectedAppointmentDateTime);
            this.doctorListComboBox.SelectedIndex = -1;
            this.firstNameLabel.Text = "";
            this.lastNameLabel.Text = "";
            this.genderLabel.Text = "";
            this.dobLabel.Text = "";
            doctorListError.Text = "";
            appointmentDateError.Text = "";
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
