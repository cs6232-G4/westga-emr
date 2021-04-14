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
using westga_emr.Model.DTO;

namespace westga_emr.User_Controls
{
    public partial class TestsUserControl : UserControl
    {
        private PersonController personController;
        private VisitController visitController;
        private UserDTO patient;
        private List<VisitDTO> visits;
        private List<UserDTO> patients;
        public TestsUserControl()
        {
            InitializeComponent();
        }

        private void TestsUserControl_Load(object sender, EventArgs e)
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
            this.visitsDataGridView.Visible = false;
            this.visitsDataGridView.DataSource = null;
            this.searchCriteria.SelectedIndex = -1;
        }
        /// <summary>
        /// The Event handler method for SearchButton Click
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (searchCriteria.SelectedIndex == 1 && (String.IsNullOrWhiteSpace(firstNameTextBoxSearchInput.Text) && String.IsNullOrWhiteSpace(lastNameTextBoxSearchInput.Text)))
            {
                this.searchErrorLabel.Text = "Please enter first and last name to search for a patient.";

            }
            else if (searchCriteria.SelectedIndex == 2 && (String.IsNullOrWhiteSpace(lastNameTextBoxSearchInput.Text)))
            {
                this.searchErrorLabel.Text = "Please enter last name and date of birth to search for a patient.";

            }
            else if (searchCriteria.SelectedIndex == 0 && dateOfBirthDateTimePickerSearchInput.Value == null)
            {
                this.searchErrorLabel.Text = "Please enter date of birth to search for a patient.";
            }
            else
            {

                this.searchErrorLabel.Text = "";
                PatientSearch();
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
                if (this.visits.Count <= 0)
                {

                    MessageBox.Show("Patient not found in the system." + Environment.NewLine + "Add add the new Patient before doing patient visit search!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
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

            }
            else if (searchCriteria.SelectedIndex == 1)
            {
                fnameSearchLabel.Show();
                lnameSearchLabel.Show();
                this.firstNameTextBoxSearchInput.Show();
                this.lastNameTextBoxSearchInput.Show();

                dobSearchLabel.Hide();
                this.dateOfBirthDateTimePickerSearchInput.Hide();

            }
            else if (searchCriteria.SelectedIndex == 2)
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
            this.visitForLabel.Text = "";
            patient = (UserDTO)patientsDatatGrid.Rows[e.RowIndex].DataBoundItem;
            if (patientsDatatGrid.Columns[e.ColumnIndex].Name == "ViewVisits")
            {
                this.visitsDataGridView.Visible = true;
                this.visitsDataGridView.DataSource = null;
                visits = visitController.GetVisitsByPatientId(patient.PatientId);
                if (visits.Count <= 0)
                {

                    MessageBox.Show("No visit found in the system for the Patient.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.visitsDataGridView.DataSource = visits;
            }

        }
    }
}
