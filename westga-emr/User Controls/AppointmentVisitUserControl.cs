using System;
using System.Collections.Generic;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Helpers;
using westga_emr.Model;
using westga_emr.Model.DTO;
using westga_emr.View;

namespace westga_emr.User_Controls
{
    public partial class AppointmentVisitUserControl : UserControl
    {
        #region Data members
        private VisitController visitController;
        private PersonController personController;
        private AppointmentDTO appointment;
        private Dictionary<string, string> errors;
        List<VisitDTO> visitDTO;
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
            errors = new Dictionary<string, string>();
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
                appointment = appointmentDTO;
                visitDTO = this.visitController.GetVisitByAppointment(
                                    new Appointment(appointmentDTO.AppointmentID, appointmentDTO.PatientID, appointmentDTO.DoctorID,
                                    appointmentDTO.AppointmentDateTime, appointmentDTO.ReasonForVisit));

               // var _datediff = appointmentDTO.AppointmentDateTime - DateTime.Now;

                if (visitDTO is null || visitDTO.Count <= 0 )
                {
                    this.visitLabel.Text = "Create " + this.visitLabel.Text;
                    this.nurseTextBox.Text = AuthenticationHelper.currentUser.FirstName + " " +
                        AuthenticationHelper.currentUser.LastName;
                    this.visitDateTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    this.createButton.Visible = true;
                }
                else if (visitDTO.Count > 0)
                {
                    this.visitLabel.Text = "Edit " + this.visitLabel.Text;
                    this.PopulateTextBoxesForVisit(visitDTO);
                    this.EditButton.Visible = true;
                    this.orderLabTestButton.Visible = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// The helper method to populate TextBoxes
        /// </summary>
        private void PopulateTextBoxesForVisit(List<VisitDTO> visitDTO)
        {
            this.nurseTextBox.Text = visitDTO[0].Nurse;
            this.initialDiagnosticTextBox.Text = visitDTO[0].InitialDiagnosis;
            this.visitDateTextBox.Text = visitDTO[0].VisitDateTime.ToString();
            this.systolicPressureTextBox.Text = visitDTO[0].SystolicPressure.ToString();
            this.weightTextBox.Text = visitDTO[0].Weight.ToString();
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
                bool isInValidInitialDiagnostic = ValidateInitialDiagnostic();
                bool isInValidateWeight = ValidateWeight();
                bool isInValidateSystolicPressure = ValidateSystolicPressure();
                bool isInValidateDialosticPressure = ValidateDialosticPressur();
                bool isInValidateBodyTemperature = ValidateBodyTemperature();
                bool isInValidatePulse = ValidatePulse();

                if (isInValidInitialDiagnostic || isInValidateWeight || isInValidateSystolicPressure
                    || isInValidateBodyTemperature
                    || isInValidatePulse)
                {
                    this.messageLabel.Text = "Invalid Input Data inconsistent!!";
                    this.messageLabel.Visible = true;
                }
                else
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
                bool isInValidInitialDiagnostic = ValidateInitialDiagnostic();
                bool isInValidateWeight =   ValidateWeight();
                bool isInValidateSystolicPressure = ValidateSystolicPressure();
                bool isInValidateDialosticPressure = ValidateDialosticPressur();
                bool isInValidateBodyTemperature =  ValidateBodyTemperature();
                bool isInValidatePulse =  ValidatePulse();

                if (isInValidInitialDiagnostic || isInValidateWeight || isInValidateSystolicPressure 
                    || isInValidateBodyTemperature
                    || isInValidatePulse)
                {
                    this.messageLabel.Text = "Invalid Input Data inconsistent!!";
                    this.messageLabel.Visible = true;
                }
                else
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
                    Visit visit = new Visit(long.Parse(appointmentID), AuthenticationHelper.currentUser.NurseId, DateTime.Now, 
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

        /// <summary>
        /// The handlers to Validate InitialDiagnostic
        /// </summary>
        private bool ValidateInitialDiagnostic()
        {
            bool isInValidInitialDiagnostic = false;
            if (String.IsNullOrWhiteSpace(initialDiagnosticTextBox.Text))
            {
                initialDiagnosticError.Text = "Initial Diagnostic is required";
                AddError("initialDiagnosticError", initialDiagnosticError.Text);
                isInValidInitialDiagnostic = true;
            }
            else
            {
                initialDiagnosticError.Text = "";
                RemoveError("initialDiagnosticError");
                isInValidInitialDiagnostic = false;
            }
            return isInValidInitialDiagnostic;
        }

        /// <summary>
        /// The handlers to Validate Weight
        /// </summary>
        private bool ValidateWeight()
        {
            bool isInValidateWeight = false; ;

            if (String.IsNullOrWhiteSpace(weightTextBox.Text))
            {
                isInValidateWeight = true;
                weightError.Text = "Weight is required";
                AddError("weightError", weightError.Text);
            }
            else
            {
                try
                {
                    bool isInValidNumber = ValidateDecimalNumbers(this.weightTextBox.Text.Trim(), 3, 2);

                    if (isInValidNumber || (decimal.Parse(this.weightTextBox.Text.Trim()) < 0))
                    {
                        weightError.Text = "Weight is Invalid";
                        AddError("weightError", weightError.Text);
                        isInValidateWeight = true;
                    }
                    else
                    {
                        weightError.Text = "";
                        RemoveError("weightError");
                        isInValidateWeight = false;
                    }

                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                    weightError.Text = "Weight is Invalid";
                    AddError("weightError", weightError.Text);
                    isInValidateWeight = true;
                }
            }
            return isInValidateWeight ;
        }

        /// <summary>
        /// The handlers to Validate DecimalNumbers
        /// </summary>
        private bool ValidateDecimalNumbers(String number, int expectedNumberBeforeDecimal, int expectedNumberAfterDecimal)
        {
            string[] digits = number.Trim().ToString().Split('.');
            var numbeforeDecimal = digits[0].Length;
            if (digits.Length > 2)
            {
                return true;
            }
            else if (numbeforeDecimal > expectedNumberBeforeDecimal)
            {
                return true;
            }
            else if (digits.Length > 1 && digits[1].Length > expectedNumberAfterDecimal)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// The handlers to Validate SystolicPressure
        /// </summary>
        private bool ValidateSystolicPressure()
        {
            bool isInValidateSystolicPressure = false;

            if (String.IsNullOrWhiteSpace(systolicPressureTextBox.Text))
            {
                systolicPressureError.Text = "Systolic Pressure is required";
                AddError("systolicPressureError", systolicPressureError.Text);
                isInValidateSystolicPressure = true;
            }
            else
            {
                try
                {
                    var systolicPressure = int.Parse(this.systolicPressureTextBox.Text.Trim());
                    if (systolicPressure <= 0)
                    {
                        systolicPressureError.Text = "Systolic Pressure is Invalid";
                        AddError("systolicPressureError", systolicPressureError.Text);
                        isInValidateSystolicPressure = true;
                    }
                    else
                    {
                        systolicPressureError.Text = "";
                        RemoveError("systolicPressureError");
                        isInValidateSystolicPressure = false;
                    }

                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                    systolicPressureError.Text = "Systolic Pressure is Invalid";
                    AddError("systolicPressureError", systolicPressureError.Text);
                    isInValidateSystolicPressure = true;
                }
            }
            return isInValidateSystolicPressure;
        }


        /// <summary>
        /// The handlers to Validate DialosticPressur
        /// </summary>
        private bool ValidateDialosticPressur()
        {
            bool isInValidateDialosticPressur = false;
            if (String.IsNullOrWhiteSpace(dialosticPressureTextBox.Text))
            {
                dialosticPressureError.Text = "Dialostic Pressure is required";
                AddError("dialosticPressureError", dialosticPressureError.Text);
                isInValidateDialosticPressur = true;
            }
            else
            {
                try
                {
                    var dialosticPressure = int.Parse(this.dialosticPressureTextBox.Text.Trim());
                    if (dialosticPressure <= 0)
                    {
                        dialosticPressureError.Text = "Dialostic Pressure is Invalid";
                        AddError("dialosticPressureError", dialosticPressureError.Text);
                        isInValidateDialosticPressur = true;
                    }
                    else
                    {
                        dialosticPressureError.Text = "";
                        RemoveError("dialosticPressureError");
                        isInValidateDialosticPressur = false;
                    }

                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                    dialosticPressureError.Text = "Dialostic Pressure is Invalid";
                    AddError("dialosticPressureError", dialosticPressureError.Text);
                    isInValidateDialosticPressur = true;
                }
            }
            return isInValidateDialosticPressur;
        }

        /// <summary>
        /// The handlers to Validate BodyTemperature
        /// </summary>
        private bool ValidateBodyTemperature()
        {
            bool isInValidateBodyTemperature = false;

            if (String.IsNullOrWhiteSpace(bodyTemperatureTextBox.Text))
            {
                bodyTemperatureError.Text = "Body Temperatue is required";
                AddError("bodyTemperatureError", bodyTemperatureError.Text);
                isInValidateBodyTemperature = true;
            }
            else
            {
                try
                {
                    bool isInValidNumber = ValidateDecimalNumbers(this.bodyTemperatureTextBox.Text.Trim(), 3, 1);
                    if (isInValidNumber || (decimal.Parse(this.bodyTemperatureTextBox.Text.Trim()) < 0))
                    {
                        bodyTemperatureError.Text = "Body Temperatue is Invalid";
                        AddError("bodyTemperatureError", bodyTemperatureError.Text);
                        isInValidateBodyTemperature = true;
                    }
                    else
                    {
                        bodyTemperatureError.Text = "";
                        RemoveError("bodyTemperatureError");
                        isInValidateBodyTemperature = false;
                    }

                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                    bodyTemperatureError.Text = "Body Temperatue is Invalid";
                    AddError("bodyTemperatureError", bodyTemperatureError.Text);
                    isInValidateBodyTemperature = true;
                }

            }
            return isInValidateBodyTemperature;
        }

        /// <summary>
        /// The handlers to Validate Pulse
        /// </summary>
        private bool ValidatePulse()
        {
            bool isInValidatePulse = false;
            if (String.IsNullOrWhiteSpace(pulseTextBox.Text))
            {
                pulseError.Text = "Pulse is required";
                AddError("pulseError", pulseError.Text);
                isInValidatePulse = true;
            }
            else
            {
                try
                {
                    var pulse = int.Parse(this.pulseTextBox.Text.Trim());
                    if (pulse <= 0)
                    {
                        pulseError.Text = "Pulse is Invalid";
                        AddError("pulseError", pulseError.Text);
                        isInValidatePulse = true;
                    }
                    else
                    {
                        pulseError.Text = "";
                        RemoveError("pulseError");
                        isInValidatePulse = false;
                    }

                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                    pulseError.Text = "Pulse is Invalid";
                    AddError("pulseError", pulseError.Text);
                    isInValidatePulse = true;
                }
            }
            return isInValidatePulse;
        }

        /// <summary>
        /// The handlers to Add Error
        /// </summary>
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

        /// <summary>
        /// The handlers to Remove Error
        /// </summary>
        private void RemoveError(string key)
        {
            if (errors.ContainsKey(key))
            {
                errors.Remove(key);
            }
        }

        private void orderLabTestButton_Click(object sender, EventArgs e)
        {
            Form orderTestDialog = new OrderTestDialog(this.visitDTO[0]);
            DialogResult result = orderTestDialog.ShowDialog();
        }
        #endregion


    }
}
