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
        private PersonController personController;
        private AppointmentDTO appointment;
        #endregion

        #region Constructors
        /// <summary>
        /// The constuctor method for AppointmentVisitUserControl
        /// </summary>
        public AppointmentVisitUserControl()
        {
            InitializeComponent();
            visitController = new VisitController();
            personController = new PersonController();
            appointment = new AppointmentDTO();
        }
        #endregion
        #region Methods
        /// <summary>
        /// The method to populate TextBoxes
        /// </summary>
        public void populateTextBoxes(AppointmentDTO appointmentDTO)
        {
            /**
             * 1.Chcek if the VisitDTO is empty or null and Appintment date is today or future dated 
             *                  -> display visit form with create feature
             * 2.Check of visit is Non Empty and 
             *          a. Appotinment date is today or after 
             *                      --> Edit form 
             *          else
             *          b.Appoitnemtn date is back dated then display error message.
             **/
            try
            {
                appointment = appointmentDTO;
                List<VisitDTO> visitDTO = this.visitController.GetVisitByAppointment(
                                    new Appointment(appointmentDTO.AppointmentID, appointmentDTO.PatientID, appointmentDTO.DoctorID,
                                    appointmentDTO.AppointmentDateTime, appointmentDTO.ReasonForVisit));

                var _datediff = appointmentDTO.AppointmentDateTime - DateTime.Now;

                if ((visitDTO is null || visitDTO.Count <= 0) && _datediff.Days >= 1)
                {
                    this.visitLabel.Text = "Create " + this.visitLabel.Text;
                    this.nurseTextBox.Text = "Santosh Jha";
                    this.visitDateTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    this.createButton.Visible = true;
                }
                else if (visitDTO.Count > 0)
                {
                    if (_datediff.Days >= 1)
                    {
                        this.visitLabel.Text = "Edit " + this.visitLabel.Text;
                        this.PopulateTextBoxesForVisit(visitDTO);
                        this.EditButton.Visible = true;
                    }
                    else
                    {
                        this.visitLabel.Text = "View " + this.visitLabel.Text;
                        this.PopulateTextBoxesForVisit(visitDTO);
                        this.DisableAllFormFields();
                        this.messageLabel.Text = "Visit Appointment is backdated." + Environment.NewLine + "Hence can not be edited!!";
                        this.messageLabel.Visible = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// The method to disable text fields
        /// </summary>
        private void DisableAllFormFields()
        {
            this.nurseTextBox.Enabled = false;
            this.initialDiagnosticTextBox.Enabled = false;
            this.visitDateTextBox.Enabled = false;
            this.weightTextBox.Enabled = false;
            this.systolicPressureTextBox.Enabled = false;
            this.dialosticPressureTextBox.Enabled = false;
            this.bodyTemperatureTextBox.Enabled = false;
            this.pulseTextBox.Enabled = false;
            this.symptomsTextBox.Enabled = false;
            this.finalDiagnosticTextBox.Enabled = false;
        }

        /// <summary>
        /// The helper method to populate TextBoxes
        /// </summary>
        private void PopulateTextBoxesForVisit(List<VisitDTO> visitDTO)
        {
            this.nurseTextBox.Text = visitDTO[0].Nurse;
            this.initialDiagnosticTextBox.Text = visitDTO[0].InitialDiagnosis;
            this.visitDateTextBox.Text = visitDTO[0].VisitDateTime.ToString();
            this.weightTextBox.Text = visitDTO[0].Weight.ToString();
            this.systolicPressureTextBox.Text = visitDTO[0].SystolicPressure.ToString();
            this.dialosticPressureTextBox.Text = visitDTO[0].DiastolicPressure.ToString();
            this.bodyTemperatureTextBox.Text = visitDTO[0].BodyTemperature.ToString();
            this.pulseTextBox.Text = visitDTO[0].Pulse.ToString();
            this.symptomsTextBox.Text = visitDTO[0].Symptoms;
            this.finalDiagnosticTextBox.Text = visitDTO[0].FinalDiagnosis;
            this.ParentForm.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// The handlers to closeButton Click
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }


        /// <summary>
        /// The handlers to EditButton Click
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var appointmentID = appointment.AppointmentID.ToString();
                var initialDiagnistic = this.initialDiagnosticTextBox.Text.Trim();
                var weight = decimal.Parse(this.weightTextBox.Text.Trim());
                var systolicPressure = int.Parse(this.systolicPressureTextBox.Text.Trim());
                var diastolicPressure = int.Parse(this.dialosticPressureTextBox.Text.Trim());
                var bodyTemperature = decimal.Parse(this.bodyTemperatureTextBox.Text.Trim());
                var pulse = int.Parse(this.pulseTextBox.Text.Trim());
                var symptoms = this.symptomsTextBox.Text.Trim();
                var finalDiagnosis = this.finalDiagnosticTextBox.Text.Trim();

                if (weight < 0 || systolicPressure < 0 || diastolicPressure < 0 || bodyTemperature < 0
                    && pulse < 0)
                {
                    this.messageLabel.Text = "Invalid Input Data inconsistent!!";
                    this.messageLabel.Visible = true;
                }
                else
                {
                    
                        Visit visit = new Visit(long.Parse(appointmentID),
                                                                        initialDiagnistic, weight, systolicPressure,
                                                                       diastolicPressure, bodyTemperature,
                                                                       pulse, symptoms, finalDiagnosis);
                        if (this.visitController.UpdateVisit(visit))
                        {
                            this.messageLabel.Text = "Incident Update Successfully!!";
                            this.messageLabel.Visible = true;
                        }
                        else
                        {
                            this.messageLabel.Text = "Input Data inconsistent!!";
                            this.messageLabel.Visible = true;
                        }
                }
            }
            catch(Exception ex)
            {
                this.messageLabel.Text = "Input Data inconsistent." + Environment.NewLine +
                                        "Please verify all data entered for the input fields and try again!!";
                var message = ex.Message;
                this.messageLabel.Visible = true;
            }
        }


        /// <summary>
        /// The handlers to Create Button Click
        /// </summary>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var appointmentID = appointment.AppointmentID.ToString();
                var initialDiagnistic = this.initialDiagnosticTextBox.Text.Trim();
                var weight = decimal.Parse(this.weightTextBox.Text.Trim());
                var systolicPressure = int.Parse(this.systolicPressureTextBox.Text.Trim());
                var diastolicPressure = int.Parse(this.dialosticPressureTextBox.Text.Trim());
                var bodyTemperature = decimal.Parse(this.bodyTemperatureTextBox.Text.Trim());
                var pulse = int.Parse(this.pulseTextBox.Text.Trim());
                var symptoms = this.symptomsTextBox.Text.Trim();
                var finalDiagnosis = this.finalDiagnosticTextBox.Text.Trim();

                if (weight < 0 || systolicPressure < 0 || diastolicPressure < 0 || bodyTemperature < 0
                    && pulse < 0)
                {
                    this.messageLabel.Text = "Invalid Input Data inconsistent!!";
                    this.messageLabel.Visible = true;
                }
                else
                {

                    Visit visit = new Visit(long.Parse(appointmentID), 1, DateTime.Now, 
                                                                    initialDiagnistic, weight, systolicPressure,
                                                                   diastolicPressure, bodyTemperature,
                                                                   pulse, symptoms, finalDiagnosis);

                    if (this.visitController.CreateVisit(visit))
                    {
                        this.messageLabel.Text = "Incident Created Successfully!!";
                        this.messageLabel.Visible = true;
                    }
                    else
                    {
                        this.messageLabel.Text = "Input Data inconsistent!!";
                        this.messageLabel.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                this.messageLabel.Text = "Input Data inconsistent." + Environment.NewLine +
                                        "Please verify all data entered for the input fields and try again!!";
                var message = ex.Message;
                this.messageLabel.Visible = true;
            }


        }

        #endregion
    }
}
