using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Model.DTO;
using westga_emr.Model;
using westga_emr.View;

namespace westga_emr.User_Controls
{
    /// <summary>
    /// User control to create new appoint for a patient
    /// </summary>
    public partial class SearchPatient : UserControl
    {
        #region Data members
        private PersonController personController;
        private AppointmentController appointmentController;
        private VisitController visitController;
        private UserDTO patient;
        private AppointmentDTO appointmentDTO;
        private List<UserDTO> patients;
        private readonly PatientController patientController;

        #endregion

        #region Constructors
        /// <summary>
        /// New appointment constructor
        /// </summary>
        public SearchPatient()
        {
            InitializeComponent();
            personController = new PersonController();
            appointmentController = new AppointmentController();
            visitController = new VisitController();
            patient = new UserDTO();
            appointmentDTO = new AppointmentDTO();
            this.patientController = new PatientController();
        }

        #endregion

        #region Methods
        /// <summary>
        /// The Event handler method for Search patient load
        /// </summary>
        public void SearchPatient_Load(object sender, EventArgs e)
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
            this.appointmentsDataGridView.Visible = false;
            this.appointmentsDataGridView.DataSource = null;
            this.searchCriteria.SelectedIndex = -1;
        }

        /// <summary>
        /// The Event handler method for SearchButton Click
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.appointmentsDataGridView.Visible = false;
            this.appointmentsDataGridView.DataSource = null;

            if (searchCriteria.SelectedIndex == 1 &&  (String.IsNullOrWhiteSpace(firstNameTextBoxSearchInput.Text) && String.IsNullOrWhiteSpace(lastNameTextBoxSearchInput.Text)))
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
                PatientSearch();
            }
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

        /// <summary>
        /// The helper method for Patient Search
        /// </summary>
        private void PatientSearch()
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
                this.firstNameTextBoxSearchInput.Text = "";
                this.lastNameTextBoxSearchInput.Text = "";
                patientsDatatGrid.DataSource = this.patients;
                if (this.patients.Count <= 0)
                {
                    
                    MessageBox.Show("Patient not found in the system." + Environment.NewLine + "Add add the new Patient before doing patient visit search!",  "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// The event handler method for SearchCriteria SelectedIndexChanged
        /// </summary>
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

        /// <summary>
        /// The event handler method for PatientsDatatGrid CellContentClick
        /// </summary>
        private void PatientsDatatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patient = (UserDTO)patientsDatatGrid.Rows[e.RowIndex].DataBoundItem;
            if (patientsDatatGrid.Columns[e.ColumnIndex].Name == "ViewAppointment")
            {
                this.appointmentsDataGridView.Visible = true;
                this.appointmentsDataGridView.DataSource = null;

                List<AppointmentDTO> appointmentDTO = this.appointmentController.GetPatientsAppointments(new Patient(patient.PatientId, patient.Id, true));

                if (appointmentDTO.Count <= 0)
                {

                    MessageBox.Show("No Appointments found in the system for the Patient.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                this.appointmentsDataGridView.DataSource = appointmentDTO; 
            }
            else if (patientsDatatGrid.Columns[e.ColumnIndex].Name == "EditPatient")
            {
                using (Form patientFormDialog = new PatientInformationDialog(patient))
                {
                    DialogResult result = patientFormDialog.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        this.RefreshDataGrid();
                    }
                }
            }
            else if (patientsDatatGrid.Columns[e.ColumnIndex].Name == "CreateAppointment")
            {
                using (Form newAppointmentDialog = new NewAppointmentDialog(patient))
                {
                    DialogResult result = newAppointmentDialog.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        this.RefreshDataGrid();
                    }
                }
            }
            else if (patientsDatatGrid.Columns[e.ColumnIndex].Name == "DeletePatient")
            {
                var hasUpcomingAppointment = this.appointmentController.GetPatientsAppointments(new Patient(patient.PatientId, patient.Id, true)).Exists(x=>x.AppointmentDateTime >= DateTime.Now);
                if (!hasUpcomingAppointment)
                {
                    string message = "Are you sure you want to delete this patient?"
                        + Environment.NewLine + $"Patient: {patient.FullName}";
                    string caption = $"Delete {patient.FirstName}  {patient.LastName}";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if(patientController.DeletePatient(new Patient(patient.PatientId, patient.Id, true)))
                        {
                            MessageBox.Show("Patient deleted successfully");
                            PatientSearch();
                        }
                       
                    }
                } else
                {
                    MessageBox.Show("Patient has upcoming appointment and can't be deleted.");
                }

            }

        }

        /// <summary>
        /// The event handler method for AppointmentDatatGrid CellContentClick
        /// </summary>
        private void AppointmentDatatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            appointmentDTO = (AppointmentDTO)appointmentsDataGridView.Rows[e.RowIndex].DataBoundItem;
            if (appointmentsDataGridView.Columns[e.ColumnIndex].Name == "ViewVisit")
            {
                Form appointmmentVisitFormDialog = new AppointmentVisitDialog(appointmentDTO);
                DialogResult result = appointmmentVisitFormDialog.ShowDialog();
            }
            else if (appointmentsDataGridView.Columns[e.ColumnIndex].Name == "EditAppointment")
            {
                var _datediff = appointmentDTO.AppointmentDateTime - DateTime.Now;
                if(_datediff.Days >= 1)
                {
                    using (Form editAppointmentDialog = new AppointmentInformationDialog(appointmentDTO, patient))
                    {
                        DialogResult result = editAppointmentDialog.ShowDialog();
                        if (result == DialogResult.OK || result == DialogResult.Cancel)
                        {
                            this.RefreshDataGrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Appointments less than 24 hours cannot be edited.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    
                }
            } else if (appointmentsDataGridView.Columns[e.ColumnIndex].Name == "DeleteAppointment")
            {
                var currentAppointment = new Appointment(appointmentDTO.AppointmentID,
                    appointmentDTO.PatientID,
                    appointmentDTO.DoctorID,
                    appointmentDTO.AppointmentDateTime,
                    appointmentDTO.ReasonForVisit);
                var visits = this.visitController.GetVisitByAppointment(currentAppointment).Count;
                if (visits < 1)
                 {
                    string message = "Are you sure you want to delete this appointment?" 
                        + Environment.NewLine + $"Doctor: {appointmentDTO.DoctorName}"
                        + Environment.NewLine + $"Appointement Time: {appointmentDTO.AppointmentDateTime.ToLongTimeString()}";
                    string caption = $"Delete appointment {appointmentDTO.AppointmentID}";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (appointmentController.DeleteAppointment(currentAppointment))
                        {
                            MessageBox.Show("Appointment deleted successfully");
                            RefreshDataGrid();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Appointment has a visit information and can't be deleted.");
                }
            }
        }

        private void RefreshDataGrid()
        {
            this.appointmentsDataGridView.DataSource = null;
            List<AppointmentDTO> appointmentDTO = this.appointmentController.GetPatientsAppointments(new Patient(patient.PatientId, patient.Id, true));

            if (appointmentDTO.Count <= 0)
            {

                MessageBox.Show("No Appointments found in the system for the Patient.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            this.appointmentsDataGridView.DataSource = appointmentDTO;
        }
        #endregion
    }
}
