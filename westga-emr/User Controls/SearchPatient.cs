using System;
using System.Windows.Forms;
using westga_emr.Controller;

namespace westga_emr.User_Controls
{
    /// <summary>
    /// User Control for searching for patients
    /// </summary>
    public partial class SearchPatient : UserControl
    {
        private readonly PatientController controller;

        /// <summary>
        /// Instantiates the User Control
        /// </summary>
        public SearchPatient()
        {
            InitializeComponent();
            this.controller = new PatientController();
            this.comboSearchBy.SelectedIndex = 0;
            this.gridPatients.DataSource = null;
        }

        private void SearchBy_GrayOut(object sender, EventArgs e)
        {
            switch (this.comboSearchBy.SelectedIndex)
            {
                case 0:
                    this.txtFirstName.Enabled = true;
                    this.txtLastName.Enabled = true;
                    this.pickerDateOfBirth.Enabled = false;
                    break;
                case 1:
                    this.txtFirstName.Enabled = false;
                    this.txtLastName.Enabled = false;
                    this.pickerDateOfBirth.Enabled = true;
                    break;
                case 2:
                    this.txtFirstName.Enabled = false;
                    this.txtLastName.Enabled = true;
                    this.pickerDateOfBirth.Enabled = true;
                    break;
                default:
                    this.txtFirstName.Enabled = false;
                    this.txtLastName.Enabled = false;
                    this.pickerDateOfBirth.Enabled = false;
                    break;
            }
        }

        private void SearchButton_Search(object sender, EventArgs e)
        {
            switch (this.comboSearchBy.SelectedIndex)
            {
                case 0:
                    this.gridPatients.DataSource = null;
                    this.gridPatients.DataSource = 
                        this.controller.GetActivePatientsByFirstAndLastName(this.txtFirstName.Text, this.txtLastName.Text);
                    break;
                case 1:
                    this.gridPatients.DataSource = null;
                    this.gridPatients.DataSource =
                        this.controller.GetActivePatientsByDoB(this.pickerDateOfBirth.Value);
                    break;
                case 2:
                    this.gridPatients.DataSource = null;
                    this.gridPatients.DataSource = 
                        this.controller.GetActivePatientsByDoBAndLastName(this.txtLastName.Text, this.pickerDateOfBirth.Value);
                    break;
                default:
                    break;
            }
        }

        private void LoadPatientDemographics(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1 && e.ColumnIndex > -1)
            //{
            //    PatientDemographics demographics = new PatientDemographics((Model.Person)gridPatients.Rows[e.RowIndex].DataBoundItem);
            //    demographics.ShowDialog();
            //}
        }
    }
}
