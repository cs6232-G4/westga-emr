using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Helpers;
using westga_emr.Model;
using westga_emr.Model.DTO;

namespace westga_emr.User_Controls
{
    public partial class PatientInformationForm : UserControl
    {
        private bool isNewPatient;
        private Person patientPerson;
        private Address patientAddress;
        private Patient patient;
        private readonly PatientController patientController;
        private Regex validSSN;
        private Dictionary<string, string> errors;
        private int? newPatientAddressId;
        private int? newPersonId;

        public PatientInformationForm()
        {
            InitializeComponent();
            isNewPatient = true;
            patientController = new PatientController();
            validSSN = new Regex("[0-9]{9}");
            errors = new Dictionary<string, string>();
            
        }

        private void PatientInformationForm_Load(object sender, EventArgs e)
        {
            this.dateOfBirthDateTimePicker.MaxDate = DateTime.Now;
        }

        public void PopulateTextBoxes(UserDTO aPatient)
        {
            this.dateOfBirthDateTimePicker.MaxDate = DateTime.Now;
            this.stateComboBox.DataSource = AppointmentHelper.GetStates().ToList();
            this.genderComboBox.DataSource = AppointmentHelper.GetGenders().ToList();
            this.stateComboBox.SelectedIndex = 0;
            this.genderComboBox.SelectedIndex = 0;
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
                patient = new Patient(aPatient.PatientId, aPatient.Id, true);
                patientAddress = new Address(aPatient.AddressId, aPatient.Street, aPatient.City, aPatient.State, aPatient.Zip);
                patientPerson = new Person(aPatient.Id, "", "", aPatient.FirstName, aPatient.LastName, aPatient.DateOfBirth.Value, aPatient.SSN, aPatient.Gender, aPatient.AddressId, aPatient.ContactPhone);
                
            } else
            {
                this.isNewPatient = true;
                this.addNewPatientLabel.Visible = true;
                this.updatePatientLabel.Visible = false;
                newPatientAddressId = null;
                newPersonId = null;
                this.dateOfBirthDateTimePicker.Value = this.dateOfBirthDateTimePicker.MaxDate;

            }

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length > 45)
            {
                firstnameError.Text = "Character limit exceeded. Maximum allowed: 45";
                AddError("firstnameError", firstnameError.Text);
            }
            else if (String.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                firstnameError.Text = "First name is required";
                AddError("firstnameError", firstnameError.Text);
            }
            else
            {
                firstnameError.Text = "";
                RemoveError("firstnameError");
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text.Length > 45)
            {
                lastNameError.Text = "Character limit exceeded. Maximum allowed: 45";
                AddError("lastNameError", lastNameError.Text);
            }
            else if (String.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                lastNameError.Text = "Last name is required";
                AddError("lastNameError", lastNameError.Text);
            }
            else
            {
                lastNameError.Text = "";
                RemoveError("lastNameError");
            }
        }

        private void ContactPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (contactPhoneTextBox.Text.Length != 10)
            {
                contactPhoneError.Text = "Phone number should be 10 digits";
                AddError("contactPhoneError", contactPhoneError.Text);
            }
            else if (String.IsNullOrWhiteSpace(contactPhoneTextBox.Text))
            {
                contactPhoneError.Text = "Phone number is required";
                AddError("contactPhoneError", contactPhoneError.Text);
            }
            else
            {
                contactPhoneError.Text = "";
                RemoveError("contactPhoneError");
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (streetTextBox.Text.Length > 45)
            {
                streetError.Text = "Character limit exceeded. Maximum allowed: 45";
                AddError("streetError", contactPhoneError.Text);
            }
            else if (String.IsNullOrWhiteSpace(streetTextBox.Text))
            {
                streetError.Text = "Street is required";
                AddError("streetError", contactPhoneError.Text);
            }
            else
            {
                streetError.Text = "";
                RemoveError("streetError");
            }
        }

        private void ZipTextBox_TextChanged(object sender, EventArgs e)
        {
            if (zipTextBox.Text.Length != 5)
            {
                zipCodeError.Text = "Please enter a valid zip code";
                AddError("zipCodeError", zipCodeError.Text);
            }
            else if (String.IsNullOrWhiteSpace(zipTextBox.Text))
            {
                zipCodeError.Text = "Zip code is required";
                AddError("zipCodeError", zipCodeError.Text);
            }
            else
            {
                zipCodeError.Text = "";
                RemoveError("zipCodeError");
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cityTextBox.Text.Length > 45)
            {
                cityError.Text = "Character limit exceeded. Maximum allowed: 45";
                AddError("cityError", cityError.Text);
            }
            else if (String.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityError.Text = "City is required";
                AddError("cityError", cityError.Text);
            }
            else
            {
                cityError.Text = "";
                RemoveError("cityError");
            }
        }

        private void SsnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ssnTextBox.Text.Length != 9)
            {
                ssnError.Text = "Enter a valid social security number";
            } else if (!validSSN.IsMatch(ssnTextBox.Text))
            {
                ssnError.Text = "Enter a valid social security number";
            }
            else
            {
                ssnError.Text = "";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();
                if(errors.Count > 0)
                {
                    throw new Exception("Enter all required values and fix errors before saving");
                }
                bool result = false;
                var gender = (AppointmentHelper)genderComboBox.SelectedItem;
                var state = (AppointmentHelper)stateComboBox.SelectedItem;

                if (isNewPatient)
                {
                    patientPerson = new Person(newPersonId, null, null,
                       firstNameTextBox.Text,
                       lastNameTextBox.Text,
                       dateOfBirthDateTimePicker.Value,
                       ssnTextBox.Text,
                       gender.Value,
                       newPatientAddressId,
                       contactPhoneTextBox.Text);
                    patientAddress = new Address(newPatientAddressId, streetTextBox.Text, cityTextBox.Text, state.Value, zipTextBox.Text);
                    result =  patientController.RegisterPatient(patientPerson, patientAddress);

                } else
                {
                    patientPerson = new Person(patientPerson.ID, "", "",
                      firstNameTextBox.Text,
                      lastNameTextBox.Text,
                      dateOfBirthDateTimePicker.Value,
                      ssnTextBox.Text,
                      gender.Value,
                      patientPerson.AddressID,
                      contactPhoneTextBox.Text);
                    patientAddress = new Address(patientPerson.AddressID, streetTextBox.Text, cityTextBox.Text, state.Value, zipTextBox.Text);
                    result = patientController.UpdatePatient(patientPerson, patientAddress, patient);
                }
                ShowMessageBox(result);
            }catch(Exception ex)
            {
                MessageBox.Show("An error occured" + 
                    Environment.NewLine + 
                    ex.Message, 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void ShowMessageBox(bool result)
        {
            if (result && isNewPatient)
            {
                ClearInputs();
                MessageBox.Show("Patient saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ParentForm.DialogResult = DialogResult.OK;
            }
            else if(result && !isNewPatient)
            {
                MessageBox.Show("Patient information updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ParentForm.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("An error occured" + Environment.NewLine +"Unable to save patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddError(string key, string value)
        {
            if (errors.ContainsKey(key))
            {
                errors[key] = value;
            }
            else
            {
                errors.Add(key, value);
            }
        }
        private void RemoveError(string key)
        {
            if (errors.ContainsKey(key))
            {
                errors.Remove(key);
            }
        }

        private void ValidateInputs()
        {
            this.FirstNameTextBox_TextChanged("SUBMIT", EventArgs.Empty);
            this.LastNameTextBox_TextChanged("SUBMIT", EventArgs.Empty);
            this.ContactPhoneTextBox_TextChanged("SUBMIT", EventArgs.Empty);
            this.StreetTextBox_TextChanged("SUBMIT", EventArgs.Empty);
            this.CityTextBox_TextChanged("SUBMIT", EventArgs.Empty);
            this.ZipTextBox_TextChanged("SUBMIT", EventArgs.Empty);
        }

        private void ClearInputs()
        {
            this.firstNameTextBox.Text = "";
            this.firstnameError.Text = "";
            this.lastNameTextBox.Text = "";
            this.lastNameError.Text = "";
            this.contactPhoneTextBox.Text = "";
            this.contactPhoneError.Text = "";
            this.streetTextBox.Text = "";
            this.streetError.Text = "";
            this.cityTextBox.Text = "";
            this.cityError.Text = "";
            this.zipTextBox.Text = "";
            this.zipCodeError.Text = "";
            this.ssnTextBox.Text = "";
            this.ssnError.Text = "";
            this.dateOfBirthDateTimePicker.Value = this.dateOfBirthDateTimePicker.MaxDate;
            this.genderComboBox.SelectedIndex = 0;
            this.stateComboBox.SelectedIndex = 0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearInputs();
        }
    }
}