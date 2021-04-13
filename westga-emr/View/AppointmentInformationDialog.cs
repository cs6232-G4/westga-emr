using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Helpers;
using westga_emr.Model;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class AppointmentInformationDialog : Form
    {
        private AppointmentDTO appointmentDTO;
        private DoctorController doctorController;
        private AppointmentController appointmentController;
        private UserDTO patient;
        private UserDTO doctor;
        private TimeSpan selectedAppointmentTime;
        private DateTime selectedAppointmentDateTime;
        private List<UserDTO> availableDoctors;

        public AppointmentInformationDialog(AppointmentDTO appointmentDTO, UserDTO _patient)
        {
            InitializeComponent();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
            this.patient = _patient;
            this.appointmentDTO = appointmentDTO;
            this.doctor = doctorController.GetDoctorById(this.appointmentDTO.DoctorID.Value);
        }

        private void AppointmentInformationDialog_Load(object sender, EventArgs e)
        {
            this.appointmentTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            this.appointmentDate.MinDate = DateTime.Now.AddDays(1.0);

            string time = this.appointmentDTO.AppointmentDateTime.TimeOfDay.ToString();
            if (time.Equals("00:00:00"))
            {
                time = AppointmentHelper.GetAppointmentTimeslots()[0].Value;
            }

            this.firstNameText.Text = this.patient.FirstName;
            this.lastNameText.Text = this.patient.LastName;
            this.genderText.Text = this.patient.Gender;
            this.dobText.Text = this.patient.DateOfBirth.Value.ToShortDateString();

            this.appointmentTime.SelectedIndex = AppointmentHelper.GetAppointmentTimeslots().FindIndex(x => x.Value == time);
            this.appointmentVisitReason.Text = this.appointmentDTO.ReasonForVisit;
            this.appointmentDate.Value = this.appointmentDTO.AppointmentDateTime.Date;
            this.selectedAppointmentDateTime = this.appointmentDTO.AppointmentDateTime;
            if(this.doctor != null)
            {
                this.availableDoctors = doctorController.GetAvailableDoctorsOnDate(this.appointmentDTO.AppointmentDateTime);
                this.availableDoctors.Add(doctor);
                this.availableDoctorsComboBox.DataSource = this.availableDoctors;
                this.availableDoctorsComboBox.SelectedIndex = this.availableDoctors.FindIndex(x => x.DoctorId == appointmentDTO.DoctorID);
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
                this.availableDoctors = doctorController.GetAvailableDoctorsOnDate(aptDateTime);
                if (this.availableDoctors.Count <= 0)
                {
                    MessageBox.Show("No avilable doctor" + Environment.NewLine + "Please choose another date or time for your appointment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                availableDoctorsComboBox.DataSource = this.availableDoctors;
                availableDoctorsComboBox.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            if (appointmentTime.Enabled == false)
            {
                appointmentTime.Enabled = true;
            }
        }

        private void AppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            var time = (AppointmentHelper)this.appointmentTime.SelectedItem;
            this.selectedAppointmentTime = TimeSpan.Parse(time.Value);
            this.selectedAppointmentDateTime = this.appointmentDate.Value.Date + selectedAppointmentTime;
            GetAvailableDoctors(this.selectedAppointmentDateTime);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void UpdateAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctor = (UserDTO)availableDoctorsComboBox.SelectedItem;
                var updatedAppointment = new Appointment(
                    this.appointmentDTO.AppointmentID,
                    this.appointmentDTO.PatientID,
                    this.doctor.DoctorId,
                    this.selectedAppointmentDateTime,
                    this.appointmentVisitReason.Text);
                bool result = this.appointmentController.UpdateAppointment(updatedAppointment);
                if (result)
                {
                    MessageBox.Show("Appointment updated successfully" , "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }else
                {
                    throw new Exception("Unable to update appointment. Please try again later");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void appointmentVisitReason_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(appointmentVisitReason.Text))
            {
                reasonForVisitError.Text = "Please enter a reason for the visit";
            }
            else
            {
                reasonForVisitError.Text = "";
            }
        }
    }
}
