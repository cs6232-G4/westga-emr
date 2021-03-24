using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using westga_emr.Helpers;
using westga_emr.Controller;
using westga_emr.Model.DTO;

namespace westga_emr.User_Controls
{
    public partial class NewAppointment : UserControl
    {
        private PersonController personController;
        private UserDTO patient;
        private bool addingNewPatient;
        private TimeSpan selectedAppointmentTime;
        private DateTime selectedAppointmentDateTime;
        public NewAppointment()
        {
            InitializeComponent();
            personController = new PersonController();
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
            this.stateComboBox.DataSource = AppointmentHelper.GetStates().ToList();
            this.genderComboBox.DataSource = AppointmentHelper.GetGenders().ToList();
            this.appointmentTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            this.stateComboBox.SelectedIndex = 0;
            this.genderComboBox.SelectedIndex = 0;
            this.dateOfBirthDateTimePickerSearchInput.MaxDate = DateTime.Now;
            this.dateOfBirthDateTimePicker.MaxDate = DateTime.Now;
            this.dateOfBirthDateTimePicker.Value = this.dateOfBirthDateTimePicker.MaxDate;
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
                this.patient = this.personController.SearchPatient(this.firstNameTextBoxSearchInput.Text, 
                    this.lastNameTextBoxSearchInput.Text, this.dateOfBirthDateTimePickerSearchInput.Value);
                if(this.patient == null)
                {
                    this.addingNewPatient = true;
                    MessageBox.Show("Patient not found in the system." + Environment.NewLine + "Add new patient to the system",  "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }else
                {
                    this.addingNewPatient = false;
                    
                }
                PopulateTextBoxes();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void PopulateTextBoxes()
        {
            this.firstNameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.contactPhoneTextBox.Enabled = true;
            this.dateOfBirthDateTimePicker.Enabled = true;
            this.cityTextBox.Enabled = true;
            this.genderComboBox.Enabled = true;
            this.stateComboBox.Enabled = true;
            this.streetTextBox.Enabled = true;
            this.zipTextBox.Enabled = true;
            this.ssnTextBox.Enabled = true;

            userDTOBindingSource.Clear();
            if (!this.addingNewPatient)
            {
                this.firstNameTextBox.Text = patient.FirstName;
                this.lastNameTextBox.Text = patient.LastName;
                this.dateOfBirthDateTimePicker.Value = patient.DateOfBirth.Value;
                this.contactPhoneTextBox.Text = patient.ContactPhone;
                this.cityTextBox.Text = patient.City;
                this.genderComboBox.SelectedIndex = AppointmentHelper.GetGenders().FindIndex(x => x.Value.Equals(patient.Gender, StringComparison.InvariantCultureIgnoreCase));
                this.stateComboBox.SelectedIndex = AppointmentHelper.GetStates().FindIndex(x => x.Value.Equals(patient.State, StringComparison.InvariantCultureIgnoreCase));
                this.streetTextBox.Text = patient.Street;
                this.zipTextBox.Text = patient.Zip;
                this.ssnTextBox.Text = patient.SSN;
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

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(firstNameTextBox.Text.Length > 45)
            {
                firstnameError.Text = "Character limit exceeded. Maximum allowed: 45";
            } else if (String.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                firstnameError.Text = "First name is required";
            }
            else
            {
                firstnameError.Text = "";
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text.Length > 45)
            {
                lastNameError.Text = "Character limit exceeded. Maximum allowed: 45";
            }
            else if (String.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                lastNameError.Text = "Last name is required";
            }
            else
            {
                lastNameError.Text = "";
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ContactPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (contactPhoneTextBox.Text.Length > 10)
            {
                contactPhoneError.Text = "Character limit exceeded. Maximum allowed: 10";
            }
            else if (String.IsNullOrWhiteSpace(contactPhoneTextBox.Text))
            {
                contactPhoneError.Text = "Phone number is required";
            }
            else
            {
                contactPhoneError.Text = "";
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (streetTextBox.Text.Length > 45)
            {
                streetError.Text = "Character limit exceeded. Maximum allowed: 45";
            }
            else if (String.IsNullOrWhiteSpace(streetTextBox.Text))
            {
                streetError.Text = "Street is required";
            }
            else
            {
                streetError.Text = "";
            }
        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZipTextBox_TextChanged(object sender, EventArgs e)
        {
            if (zipTextBox.Text.Length > 5)
            {
                zipCodeError.Text = "Character limit exceeded. Maximum allowed: 5";
            }
            else if (String.IsNullOrWhiteSpace(zipTextBox.Text))
            {
                zipCodeError.Text = "Zip code is required";
            }
            else
            {
                zipCodeError.Text = "";
            }
        }

        private void StateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cityTextBox.Text.Length > 45)
            {
                cityError.Text = "Character limit exceeded. Maximum allowed: 45";
            }
            else if (String.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityError.Text = "City is required";
            }
            else
            {
                cityError.Text = "";
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

        private void GetAvailableDoctors(DateTime aptTime)
        {

            Console.WriteLine(aptTime);
        }

        private void AppointmentVisitReason_TextChanged(object sender, EventArgs e)
        {

        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
        private void SsnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ssnTextBox.Text.Length > 9)
            {
                ssnError.Text = "Character limit exceeded. Maximum allowed: 9";
            }
            else
            {
                ssnError.Text = "";
            }
        }
    }
}
