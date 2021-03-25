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
using westga_emr.Model.DTO;

namespace westga_emr.User_Controls
{
    public partial class PatientInformationForm : UserControl
    {
        private bool isNewPatient;
        public PatientInformationForm()
        {
            InitializeComponent();
        }

        private void PatientInformationForm_Load(object sender, EventArgs e)
        {
            this.stateComboBox.DataSource = AppointmentHelper.GetStates().ToList();
            this.genderComboBox.DataSource = AppointmentHelper.GetGenders().ToList();
            this.stateComboBox.SelectedIndex = 0;
            this.genderComboBox.SelectedIndex = 0;
            this.dateOfBirthDateTimePicker.MaxDate = DateTime.Now;
            this.dateOfBirthDateTimePicker.Value = this.dateOfBirthDateTimePicker.MaxDate;
        }

        public void PopulateTextBoxes(UserDTO aPatient)
        {
            if (aPatient.PatientId >  0)
            {
                this.isNewPatient = false;
                this.addNewPatientLabel.Visible = false;
                this.updatePatientLabel.Visible = true;
                this.firstNameTextBox.Text = aPatient.FirstName;
                this.lastNameTextBox.Text = aPatient.LastName;
                this.dateOfBirthDateTimePicker.Value = aPatient.DateOfBirth.Value;
                this.contactPhoneTextBox.Text = aPatient.ContactPhone;
                this.cityTextBox.Text = aPatient.City;
                this.genderComboBox.SelectedIndex = AppointmentHelper.GetGenders().FindIndex(x => x.Value.Equals(aPatient.Gender, StringComparison.InvariantCultureIgnoreCase));
                this.stateComboBox.SelectedIndex = AppointmentHelper.GetStates().FindIndex(x => x.Value.Equals(aPatient.State, StringComparison.InvariantCultureIgnoreCase));
                this.streetTextBox.Text = aPatient.Street;
                this.zipTextBox.Text = aPatient.Zip;
                this.ssnTextBox.Text = aPatient.SSN;
            } else
            {
                this.isNewPatient = true;
                this.addNewPatientLabel.Visible = true;
                this.updatePatientLabel.Visible = false;
            }

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length > 45)
            {
                firstnameError.Text = "Character limit exceeded. Maximum allowed: 45";
            }
            else if (String.IsNullOrWhiteSpace(firstNameTextBox.Text))
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
