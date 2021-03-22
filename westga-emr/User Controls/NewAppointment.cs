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
        public NewAppointment()
        {
            InitializeComponent();
            personController = new PersonController();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            this.stateComboBox.DataSource = AppointmentHelper.GetStates().ToList();
            this.genderComboBox.DataSource = AppointmentHelper.GetGenders().ToList();
            this.stateComboBox.SelectedIndex = 0;
            this.genderComboBox.SelectedIndex = 0;
            this.dateOfBirthDateTimePickerSearchInput.MaxDate = DateTime.Now;
            this.dateOfBirthDateTimePicker.MaxDate = DateTime.Now;
            this.appointmentDate.MinDate = DateTime.Now.AddDays(1.0);
            this.appointmentTime.SelectedIndex = 0;
        }

        private void SsnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(firstNameTextBoxSearchInput.Text) && !String.IsNullOrWhiteSpace(lastNameTextBoxSearchInput.Text))
            {
                this.searchErrorLabel.Text = "";
                SearchPatient();
            } else if(dateOfBirthDateTimePickerSearchInput.Value != null && !String.IsNullOrWhiteSpace(lastNameTextBoxSearchInput.Text))
            {
                this.searchErrorLabel.Text = "";
                SearchPatient();
            }else if (dateOfBirthDateTimePickerSearchInput.Value != null)
            {
                this.searchErrorLabel.Text = "";
                SearchPatient();
            }
            else
            {
                this.searchErrorLabel.Text = "Enter date of birth and last name or both first and last name to search for a patient.";
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
                    throw new Exception("Patient not found in the system.");
                }
                PopulateTextBoxes();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void PopulateTextBoxes()
        {
            userDTOBindingSource.Clear();
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
}
