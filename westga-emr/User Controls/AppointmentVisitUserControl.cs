using System;
using System.Collections.Generic;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Model;
using westga_emr.Model.DTO;

namespace westga_emr.User_Controls
{
    public partial class AppointmentVisitUserControl : UserControl
    {
        #region Data members
        private VisitController visitController;
        #endregion

        #region Constructors
        /// <summary>
        /// The constuctor method for AppointmentVisitUserControl
        /// </summary>
        public AppointmentVisitUserControl()
        {
            InitializeComponent();
            visitController = new VisitController();
        }
        #endregion
        #region Methods
        /// <summary>
        /// The method to populate TextBoxes
        /// </summary>
        public void populateTextBoxes(AppointmentDTO appointmentDTO)
        {
            try
            {
                List<VisitDTO> visitDTO = this.visitController.GetVisitByAppointment(
                                    new Appointment(appointmentDTO.AppointmentID, appointmentDTO.PatientID, appointmentDTO.DoctorID,
                                    appointmentDTO.AppointmentDateTime, appointmentDTO.ReasonForVisit));
                this.nurseTextBox.Text = visitDTO[0].Nurse;
                this.nurseTextBox.Enabled = false;
                this.initialDiagnosticTextBox.Text = visitDTO[0].InitialDiagnosis;
                this.initialDiagnosticTextBox.Enabled = false;
                this.visitDateTextBox.Text = visitDTO[0].VisitDateTime.ToString();
                this.visitDateTextBox.Enabled = false;
                this.weightTextBox.Text = visitDTO[0].Weight.ToString();
                this.weightTextBox.Enabled = false;
                this.systolicPressureTextBox.Text = visitDTO[0].SystolicPressure.ToString();
                this.systolicPressureTextBox.Enabled = false;
                this.dialosticPressureTextBox.Text = visitDTO[0].DiastolicPressure.ToString();
                this.dialosticPressureTextBox.Enabled = false;
                this.bodyTemperatureTextBox.Text = visitDTO[0].BodyTemperature.ToString();
                this.bodyTemperatureTextBox.Enabled = false;
                this.pulseTextBox.Text = visitDTO[0].Pulse.ToString();
                this.pulseTextBox.Enabled = false;
                this.symptomsTextBox.Text = visitDTO[0].Symptoms;
                this.symptomsTextBox.Enabled = false;
                this.finalDiagnosticTextBox.Text = visitDTO[0].FinalDiagnosis;
                this.finalDiagnosticTextBox.Enabled = false;
                this.ParentForm.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// The handlers to closeButton Click
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
