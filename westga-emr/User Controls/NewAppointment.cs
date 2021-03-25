using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using westga_emr.Helpers;
using westga_emr.Controller;
using westga_emr.Model.DTO;
using westga_emr.View;

namespace westga_emr.User_Controls
{
    /// <summary>
    /// User control to create new appoint for a patient
    /// </summary>
    public partial class NewAppointment : UserControl
    {
        private PersonController personController;
        private DoctorController doctorController;
        private UserDTO patient;
        private List<UserDTO> patients;
        private TimeSpan selectedAppointmentTime;
        private DateTime selectedAppointmentDateTime;
        public NewAppointment()
        {
            InitializeComponent();
            personController = new PersonController();
            doctorController = new DoctorController();
            patient = new UserDTO();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            this.searchErrorLabel.BackColor = Color.White;
            fnameSearchLabel.Hide();
            lnameSearchLabel.Hide();
            dobSearchLabel.Hide();
            this.firstNameTextBoxSearchInput.Hide();
            this.lastNameTextBoxSearchInput.Hide();
            this.dateOfBirthDateTimePickerSearchInput.Hide();
            this.searchButton.Hide();
            this.appointmentTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            this.doctorListComboBox.DataSource = doctorController.GetDoctors();
            this.dateOfBirthDateTimePickerSearchInput.MaxDate = DateTime.Now;
            this.dateOfBirthDateTimePickerSearchInput.Value = this.dateOfBirthDateTimePickerSearchInput.MaxDate;
            this.appointmentDate.MinDate = DateTime.Now.AddDays(1.0);
            this.appointmentTime.Enabled = false;
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
                this.patients = this.personController.SearchPatient(this.firstNameTextBoxSearchInput.Text, 
                    this.lastNameTextBoxSearchInput.Text, this.dateOfBirthDateTimePickerSearchInput.Value);
                this.firstNameTextBoxSearchInput.Text = "";
                this.lastNameTextBoxSearchInput.Text = "";
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
            if (appointmentTime.Enabled == false)
            {
                appointmentTime.Enabled = true;
            }
            if(appointmentTime.SelectedIndex <= 0)
            {
                appointmentTime.SelectedIndex = 0;
            }
            
        }

        private void AppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            var time = (AppointmentHelper)this.appointmentTime.SelectedItem;
            this.selectedAppointmentTime = TimeSpan.Parse(time.Value);
            this.selectedAppointmentDateTime = this.appointmentDate.Value.Date + selectedAppointmentTime;
            GetAvailableDoctors(this.selectedAppointmentDateTime);
        }

        private void GetAvailableDoctors(DateTime aptDateTime)
        {
            try
            {
                if(aptDateTime == null)
                {
                    throw new Exception("Please select appointment date");
                }
                doctorListComboBox.DataSource = doctorController.GetAvailableDoctorsOnDate(aptDateTime);
                doctorListComboBox.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private void AppointmentVisitReason_TextChanged(object sender, EventArgs e)
        {
            if (appointmentVisitReason.Text.Length > 45)
            {
                visitReasonError.Text = "Character limit exceeded. Maximum allowed: 45";
            }
            else if (String.IsNullOrWhiteSpace(appointmentVisitReason.Text))
            {
                visitReasonError.Text = "Reason for visit is required";
            }
            else
            {
                visitReasonError.Text = "";
            }
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(appointmentVisitReason.Text) 
                    || patient.PatientId <= 0 
                    || selectedAppointmentDateTime == null)
                {
                    throw new Exception("Enter all the required fields to create an appointment");
                }
            } catch(Exception ex)
            {

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            appointmentVisitReason.Text = "";
            visitReasonError.Text = "";
            this.appointmentTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            this.doctorListComboBox.DataSource = doctorController.GetDoctors();
            this.firstNameLabel.Text = "";
            this.lastNameLabel.Text = "";
            this.genderLabel.Text = "";
            this.dobLabel.Text = "";
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            using (Form patientFormDialog = new PatientInformationDialog(new UserDTO()))
            {
                DialogResult result = patientFormDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.RefreshDataGrid();
                }
            }
        }

        private void RefreshDataGrid()
        {
            patientsDatatGrid.DataSource = null;
           
        }

        private void PatientsDatatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (patientsDatatGrid.Columns[e.ColumnIndex].Name  == "CreateAppointment")
            {
                patient = (UserDTO)patientsDatatGrid.Rows[e.RowIndex].DataBoundItem;           

                this.firstNameLabel.Text = patient.FirstName;
                this.lastNameLabel.Text = patient.LastName;
                this.genderLabel.Text = patient.Gender;
                this.dobLabel.Text = patient.DateOfBirth.Value.ToShortDateString();

                this.appointmentInformationSection.Visible = true;
            } else
            {
                this.appointmentInformationSection.Visible = false;
            }
        }
    }
}
