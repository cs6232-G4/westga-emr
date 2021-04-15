using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using westga_emr.Helpers;
using westga_emr.Controller;
using westga_emr.Model.DTO;
using westga_emr.View;
using westga_emr.Model;

namespace westga_emr.User_Controls
{
    /// <summary>
    /// User control to create new appoint for a patient
    /// </summary>
    public partial class NewAppointment : UserControl
    {
        private PersonController personController;
        private DoctorController doctorController;
        private AppointmentController appointmentController;
        private UserDTO patient;
        private List<UserDTO> patients;
        private TimeSpan selectedAppointmentTime;
        private DateTime selectedAppointmentDateTime;
        private PatientController patientController;

        /// <summary>
        /// New appointment constructor
        /// </summary>
        public NewAppointment()
        {
            InitializeComponent();
            personController = new PersonController();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
            patientController = new PatientController();
            patient = new UserDTO();
        }

        public void NewAppointment_Load(object sender, EventArgs e)
        {
            patientsDatatGrid.DataSource = null;
            this.searchErrorLabel.BackColor = Color.White;
            fnameSearchLabel.Hide();
            lnameSearchLabel.Hide();
            dobSearchLabel.Hide();
            this.firstNameTextBoxSearchInput.Text = "";
            this.lastNameTextBoxSearchInput.Text = "";
            this.searchErrorLabel.Text = "";
            this.firstNameTextBoxSearchInput.Hide();
            this.lastNameTextBoxSearchInput.Hide();
            this.dateOfBirthDateTimePickerSearchInput.Hide();
            this.searchButton.Hide();
            this.dateOfBirthDateTimePickerSearchInput.MaxDate = DateTime.Now;
            this.dateOfBirthDateTimePickerSearchInput.Value = this.dateOfBirthDateTimePickerSearchInput.MaxDate;
            this.appointmentDate.MinDate = DateTime.Now;
            this.appointmentInformationSection.Hide();
            this.searchCriteria.SelectedIndex = -1;
            this.appointmentTime.SelectedIndex = -1;
            this.doctorListComboBox.SelectedIndex = -1;
            doctorListError.Text = "";
            appointmentDateError.Text = "";
        }

      

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(searchCriteria.SelectedIndex == 1 &&  (String.IsNullOrWhiteSpace(firstNameTextBoxSearchInput.Text) && String.IsNullOrWhiteSpace(lastNameTextBoxSearchInput.Text)))
            {
                this.searchErrorLabel.Text = "Please enter first and last name to search for a patient.";
               
            } else if(searchCriteria.SelectedIndex == 2 && (String.IsNullOrWhiteSpace(lastNameTextBoxSearchInput.Text)))
            {
                this.searchErrorLabel.Text = "Please enter last name and date of birth to search for a patient.";

            }else if (searchCriteria.SelectedIndex == 0 && dateOfBirthDateTimePickerSearchInput.Value == null)
            {
                this.searchErrorLabel.Text = "Please enter date of birth to search for a patient.";
            }
            else
            {
                
                this.searchErrorLabel.Text = "";
                SearchPatient();
            }
        }

        private void SearchPatient()
        {
            try
            {
                patientsDatatGrid.DataSource = null;
                switch (this.searchCriteria.SelectedIndex)
                {
                    case 0:
                        this.patients = this.personController.SearchPatient("", "", this.dateOfBirthDateTimePickerSearchInput.Value);
                        break;
                    case 1:
                        this.patients = this.personController.SearchPatient(this.firstNameTextBoxSearchInput.Text, this.lastNameTextBoxSearchInput.Text, null);
                        break;
                    case 2:
                        this.patients = this.personController.SearchPatient("", this.lastNameTextBoxSearchInput.Text, this.dateOfBirthDateTimePickerSearchInput.Value);
                        break;
                }
                patientsDatatGrid.DataSource = this.patients;
                if (this.patients.Count <= 0)
                {
                    
                    MessageBox.Show("Patient not found in the system." + Environment.NewLine + "Add new patient to the system before creating an appointment",  "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void SearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.searchButton.Show();
            if (searchCriteria.SelectedIndex == 0)
            {
                dobSearchLabel.Show();
                this.dateOfBirthDateTimePickerSearchInput.Show();

                fnameSearchLabel.Hide();
                lnameSearchLabel.Hide();
                this.firstNameTextBoxSearchInput.Hide();
                this.lastNameTextBoxSearchInput.Hide();

            } else if (searchCriteria.SelectedIndex == 1)
            {
                fnameSearchLabel.Show();
                lnameSearchLabel.Show();
                this.firstNameTextBoxSearchInput.Show();
                this.lastNameTextBoxSearchInput.Show();

                dobSearchLabel.Hide();
                this.dateOfBirthDateTimePickerSearchInput.Hide();

            } else if (searchCriteria.SelectedIndex == 2)
            {
                lnameSearchLabel.Show();
                dobSearchLabel.Show();
                this.dateOfBirthDateTimePickerSearchInput.Show();
                this.lastNameTextBoxSearchInput.Show();

                fnameSearchLabel.Hide();
                this.firstNameTextBoxSearchInput.Hide();
            }
            else
            {
                fnameSearchLabel.Hide();
                lnameSearchLabel.Hide();
                dobSearchLabel.Hide();
                this.dateOfBirthDateTimePickerSearchInput.Hide();
                this.firstNameTextBoxSearchInput.Hide();
                this.lastNameTextBoxSearchInput.Hide();
                this.searchButton.Hide();
            }
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
            if(this.appointmentTime.SelectedIndex >= 0)
            {
                appointmentDateError.Text = "";
                var time = (AppointmentHelper)this.appointmentTime.SelectedItem;
                this.selectedAppointmentTime = TimeSpan.Parse(time.Value);
                this.selectedAppointmentDateTime = this.appointmentDate.Value.Date + selectedAppointmentTime;
                GetAvailableDoctors(this.selectedAppointmentDateTime);
            } else
            {
                appointmentDateError.Text = "Please select a time for the appointment";
            }
            
        }

        private void GetAvailableDoctors(DateTime aptDateTime)
        {
            try
            {
                if(aptDateTime == null)
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
                    RefreshDataGrid();
                    MessageBox.Show("Appointment created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearButton_Click("Appointment Created", EventArgs.Empty);
                }


            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
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

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            using (Form patientFormDialog = new PatientInformationDialog(new UserDTO()))
            {
                DialogResult result = patientFormDialog.ShowDialog();
                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    this.RefreshDataGrid();
                } 
            }
        }

        private void RefreshDataGrid()
        {
            patientsDatatGrid.DataSource = null;
            if(searchCriteria.SelectedIndex >= 0)
            {
                this.SearchPatient();
            }
           
        }

        private void PatientsDatatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patient = (UserDTO)patientsDatatGrid.Rows[e.RowIndex].DataBoundItem;
            if (patientsDatatGrid.Columns[e.ColumnIndex].Name  == "CreateAppointment")
            {
                this.firstNameLabel.Text = patient.FirstName;
                this.lastNameLabel.Text = patient.LastName;
                this.genderLabel.Text = patient.Gender;
                this.dobLabel.Text = patient.DateOfBirth.Value.ToShortDateString();
                this.appointmentInformationSection.Visible = true;

            } else if (patientsDatatGrid.Columns[e.ColumnIndex].Name == "EditPatient")
            {
                using (Form patientFormDialog = new PatientInformationDialog(patient))
                {
                    DialogResult result = patientFormDialog.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        this.RefreshDataGrid();
                    }
                }
                this.appointmentInformationSection.Visible = false;
            }
        }

        private void DoctorListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.doctorListComboBox.SelectedIndex < 0)
            {
                doctorListError.Text = "Please select a doctor for the appointment";
            } else
            {
                doctorListError.Text = "";
            }
        }
    }
}