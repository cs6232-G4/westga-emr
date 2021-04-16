using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Helpers;
using westga_emr.Model;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class EditNurseDialog : Form
    {
        private UserDTO nurse;
        private Person nursePerson;
        private Address nurseAddress;
        private Nurse theNurse;
        private readonly NurseController nurseController;
        private readonly PersonController personController;
        private Regex validSSN;
        private Regex validPassword;
        private Dictionary<string, string> errors;
        private Bitmap showPasswordImage;
        private Bitmap hidePasswordImage;
        private string hashedPassword;
        public EditNurseDialog(UserDTO _nurse)
        {
            InitializeComponent();
            this.nurse = _nurse;
            nurseController = new NurseController();
            personController = new PersonController();
            validSSN = new Regex("[0-9]{9}");
            validPassword = new Regex(@"^(?=.{8,16}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
            errors = new Dictionary<string, string>();
            showPasswordImage = global::westga_emr.Properties.Resources.viewPassword1;
            hidePasswordImage = global::westga_emr.Properties.Resources.unshowPassword1;
        }

        private void EditNurseDialog_Load(object sender, EventArgs e)
        {
            this.stateComboBox.DataSource = AppointmentHelper.GetStates().ToList();
            this.genderComboBox.DataSource = AppointmentHelper.GetGenders().ToList();
            this.dateOfBirthDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
            this.dateOfBirthDateTimePicker.Value = this.nurse.DateOfBirth.Value;
            this.stateComboBox.SelectedIndex = AppointmentHelper.GetStates().FindIndex(x => x.Value.Equals(nurse.State, StringComparison.InvariantCultureIgnoreCase));
            this.genderComboBox.SelectedIndex = AppointmentHelper.GetGenders().FindIndex(x => x.Value.Equals(nurse.Gender, StringComparison.InvariantCultureIgnoreCase));
            this.firstNameTextBox.Text = nurse.FirstName;
            this.lastNameTextBox.Text = nurse.LastName;
            this.cityTextBox.Text = nurse.City;
            this.streetTextBox.Text = nurse.Street;
            this.contactPhoneTextBox.Text = nurse.ContactPhone;
            this.zipTextBox.Text = nurse.Zip;
            this.ssnTextBox.Text = nurse.SSN;
            this.usernameTextBox.Text = nurse.Username;
            this.passwordTextBox.Text = nurse.Password;
            this.isActiveCheckbox.Checked = nurse.IsActiveNurse;
            this.passwordViewer.Visible = false;
            ssnError.Text = "";
            firstnameError.Text = "";
            lastNameError.Text = "";
            contactPhoneError.Text = "";
            streetError.Text = "";
            cityError.Text = "";
            usernameError.Text = "";
            passwordError.Text = "";
            zipCodeError.Text = "";
            errors = new Dictionary<string, string>();
        }
        private void SsnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ssnTextBox.Text.Length != 9)
            {
                ssnError.Text = "Enter a valid social security number";
            }
            else if (nurse.SSN != ssnTextBox.Text && !validSSN.IsMatch(ssnTextBox.Text))
            {
                ssnError.Text = "Enter a valid social security number";
            }
            else if (this.personController.SocialSecurityExist(ssnTextBox.Text))
            {
                ssnError.Text = "Enter a valid social security number. Duplicate social security nnumber not allowed!";
            }
            else
            {
                ssnError.Text = "";
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

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Length > 45)
            {
                usernameError.Text = "Character limit exceeded. Maximum allowed: 45";
                AddError("usernameError", usernameError.Text);
            }
            else if (String.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                usernameError.Text = "Username is required";
                AddError("usernameError", usernameError.Text);
            }
            else if (usernameTextBox.Text != nurse.Username && personController.IsUsernameDuplicate(usernameTextBox.Text))
            {
                usernameError.Text = "Username is unavailable. Use a different username";
                AddError("usernameError", usernameError.Text);
            }
            else
            {
                usernameError.Text = "";
                RemoveError("usernameError");
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.passwordViewer.Visible = true;

            if (!validPassword.IsMatch(passwordTextBox.Text))
            {
                passwordError.Text = "Password must be between 8 - 16 characters" + Environment.NewLine + "At least one digit, lower case and one uppercase";
                AddError("passwordError", passwordError.Text);
            }
            else
            {
                passwordError.Text = "";
                RemoveError("passwordError");
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();
                if (errors.Count > 0)
                {
                    throw new Exception("Enter all required values and fix errors before saving");
                }
                bool result = false;
                var gender = (AppointmentHelper)genderComboBox.SelectedItem;
                var state = (AppointmentHelper)stateComboBox.SelectedItem;
                hashedPassword = passwordTextBox.Text != nurse.Password ? AuthenticationHelper.HashPassword(passwordTextBox.Text) : passwordTextBox.Text;
                nursePerson = new Person(nurse.Id, usernameTextBox.Text, hashedPassword,
                       firstNameTextBox.Text,
                       lastNameTextBox.Text,
                       dateOfBirthDateTimePicker.Value,
                       ssnTextBox.Text,
                       gender.Value,
                       nurse.AddressId,
                       contactPhoneTextBox.Text);
                nurseAddress = new Address(nurse.AddressId, streetTextBox.Text, cityTextBox.Text, state.Value, zipTextBox.Text);
                theNurse = new Nurse(nurse.NurseId, nurse.Id, isActiveCheckbox.Checked);
                result = personController.UpdateNurse(nursePerson, nurseAddress, theNurse);
                ClearInputs();
                MessageBox.Show("Nurse updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" +
                    Environment.NewLine +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
            this.UsernameTextBox_TextChanged("SUBMIT", EventArgs.Empty);
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
            this.DialogResult = DialogResult.Cancel;
        }


        private void PasswordViewer_Click(object sender, EventArgs e)
        {
            if (passwordViewer.Image == showPasswordImage)
            {
                passwordTextBox.PasswordChar = '\0';
                passwordViewer.Image = hidePasswordImage;
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                passwordViewer.Image = showPasswordImage;
            }
        }
    }
}
