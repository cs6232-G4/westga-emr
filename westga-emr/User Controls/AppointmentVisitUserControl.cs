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
        private NurseController nurseController;
        private AppointmentDTO appointment;
        private Dictionary<string, string> errors;
        List<VisitDTO> visitDTO;
        private bool finalDiagnosticConfirmationClicked;
        private Lab_Orders_have_Lab_TestsController labOrdersTestController;
        private List<LabOrderTestDTO> visitTests;

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
            nurseController = new NurseController();
            errors = new Dictionary<string, string>();
            labOrdersTestController = new Lab_Orders_have_Lab_TestsController();
            visitTests = new List<LabOrderTestDTO>();
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
                finalDiagnosticConfirmationClicked = false;
                appointment = appointmentDTO;
                visitDTO = this.visitController.GetVisitByAppointment(
                                    new Appointment(appointmentDTO.AppointmentID, appointmentDTO.PatientID, appointmentDTO.DoctorID,
                                    appointmentDTO.AppointmentDateTime, appointmentDTO.ReasonForVisit));
                string loggedInNurse = AuthenticationHelper.currentUser.FirstName + " " + AuthenticationHelper.currentUser.LastName;
                if (visitDTO is null || visitDTO.Count <= 0 )
                {
                    this.visitLabel.Text = "Create " + this.visitLabel.Text;
                    this.doctorTextBox.Text = appointmentDTO.DoctorName;
                    this.nurseTextBox.Text = loggedInNurse;
                    this.visitDateTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    this.createButton.Visible = true;
                    EnableFormFields();
                }
                else if (visitDTO.Count > 0 )
                {
                    bool IsThisNurseTheNurseOfTheVisit = nurseController.
                        IsThisNurseTheNurseOfTheVisit(AuthenticationHelper.currentUser, visitDTO[0]);

                    this.PopulateTextBoxesForVisit(visitDTO);
                    if (String.IsNullOrWhiteSpace(visitDTO[0].FinalDiagnosis))
                    {
                        if (IsThisNurseTheNurseOfTheVisit)
                        {
                            this.visitLabel.Text = "Edit " + this.visitLabel.Text;
                            EnableFormFields();
                            this.finalDiagnosticTextBox.ReadOnly = true;
                            this.editButton.Visible = true;
                            this.editFinalDiagnosticButton.Visible = true;
                            this.finalDiagnosticTextBox.ReadOnly = true;
                            this.orderLabTestButton.Visible = true;
                            this.viewLabTestButton.Visible = true;
                        }
                        else
                        {
                            this.visitLabel.Text = "View " + this.visitLabel.Text;
                            DisableFormFields();
                            this.finalDiagnosticTextBox.ReadOnly = true;
                            this.editFinalDiagnosticButton.Visible = false;
                            this.orderLabTestButton.Visible = false;
                            this.viewLabTestButton.Visible = false;
                            this.messageLabel.Text = "Error: The Nurse : "+ loggedInNurse  + " is not the one associated with the visit." + Environment.NewLine + "No modification is allowed!!";
                            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            this.messageLabel.Visible = true;
                        }
                       
                    }
                    else
                    {
                        this.visitLabel.Text = "View " + this.visitLabel.Text;
                        DisableFormFields();
                        this.finalDiagnosticTextBox.ReadOnly = true;
                        this.editFinalDiagnosticButton.Visible = false;
                        this.orderLabTestButton.Visible = false;
                        this.viewLabTestButton.Visible = false;
                        this.messageLabel.Text = "Note: The final diagnostic has already been submitted."+Environment.NewLine+"No modification is now allowed!!";
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

        private void EnableFormFields()
        {
            this.nurseTextBox.ReadOnly = false;
            this.initialDiagnosticTextBox.ReadOnly = false;
            this.visitDateTextBox.ReadOnly = false;
            this.systolicPressureTextBox.ReadOnly = false;
            this.weightTextBox.ReadOnly = false;
            this.dialosticPressureTextBox.ReadOnly = false;
            this.bodyTemperatureTextBox.ReadOnly = false;
            this.pulseTextBox.ReadOnly = false;
            this.symptomsTextBox.ReadOnly = false;
            this.finalDiagnosticErrorLabel.Text = "";
            this.finalDiagnosticErrorLabel.Visible = false;
        }

        private void DisableFormFields()
        {
            this.nurseTextBox.ReadOnly = true;
            this.initialDiagnosticTextBox.ReadOnly = true;
            this.visitDateTextBox.ReadOnly = true;
            this.systolicPressureTextBox.ReadOnly = true;
            this.weightTextBox.ReadOnly = true;
            this.dialosticPressureTextBox.ReadOnly = true;
            this.bodyTemperatureTextBox.ReadOnly = true;
            this.pulseTextBox.ReadOnly = true;
            this.symptomsTextBox.ReadOnly = true;
            
        }

        /// <summary>
        /// The helper method to populate TextBoxes
        /// </summary>
        private void PopulateTextBoxesForVisit(List<VisitDTO> visitDTO)
        {
            this.doctorTextBox.Text = visitDTO[0].Doctor;
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
            this.messageLabel.Text = "";
            this.messageLabel.Visible = false;
            this.finalDiagnosticErrorLabel.Text = "";
            this.finalDiagnosticErrorLabel.Visible = false;
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
                ResetMessageFields();
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
                    if (finalDiagnosticConfirmationClicked && 
                        String.IsNullOrWhiteSpace(finalDiagnosticTextBox.Text))
                    {
                        this.finalDiagnosticErrorLabel.Text = "Final Diagnostic is mandatory!!";
                        this.finalDiagnosticErrorLabel.Visible = true;
                    }
                    else
                    {
                        UpdateVisitInformation();
                        this.finalDiagnosticErrorLabel.Text = "";
                        this.finalDiagnosticErrorLabel.Visible = false;
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

        private void UpdateVisitInformation()
        {
            Visit visit = PopulateVisitFromFormFields();
            if (this.visitController.UpdateVisit(visit))
            {
                Form successfullPersistDialog = new SuccessfullPersistDialog("Appointment Visit Updated Successfully!!.");
                DialogResult result = successfullPersistDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.ParentForm.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                this.messageLabel.Text = "Input Data inconsistent!!";
                this.messageLabel.Visible = true;
            }
        }

        /// <summary>
        /// The handlers to CreateVisit From FormFields
        /// </summary>
        private Visit PopulateVisitFromFormFields()
        {
            var appointmentID = appointment.AppointmentID.ToString();
            var initialDiagnistic = this.initialDiagnosticTextBox.Text.Trim();
            var weight = decimal.Parse(this.weightTextBox.Text.Trim());
            var systolicPressure = int.Parse(this.systolicPressureTextBox.Text.Trim());
            var diastolicPressure = int.Parse(this.dialosticPressureTextBox.Text.Trim());
            var bodyTemperature = decimal.Parse(this.bodyTemperatureTextBox.Text.Trim());
            var pulse = int.Parse(this.pulseTextBox.Text.Trim());
            var symptoms = this.symptomsTextBox.Text.Trim();
            var finalDiagnostic = this.finalDiagnosticTextBox.Text.Trim();
            Visit visit = new Visit(visitDTO[0].ID, long.Parse(appointmentID),
                                                   AuthenticationHelper.currentUser.NurseId, visitDTO[0].VisitDateTime,
                                                                initialDiagnistic, weight, systolicPressure,
                                                               diastolicPressure, bodyTemperature,
                                                               pulse, symptoms, finalDiagnostic);
            return visit;
        }


        /// <summary>
        /// The handlers to Create Button Click
        /// </summary>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ResetMessageFields();
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
                    Visit visit = new Visit(long.Parse(appointmentID), AuthenticationHelper.currentUser.NurseId, DateTime.Now, 
                                                                    initialDiagnistic, weight, systolicPressure,
                                                                   diastolicPressure, bodyTemperature,
                                                                   pulse, symptoms, null);

                    if (this.visitController.CreateVisit(visit))
                    {
                        Form successfullPersistDialog = new SuccessfullPersistDialog("Appointment Visit Submitted Successfully!!");
                        DialogResult result = successfullPersistDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            this.ParentForm.DialogResult = DialogResult.Cancel;
                        }
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

        /// <summary>
        /// The handler for OrderLabTestButton Click
        /// </summary>
        private void OrderLabTestButton_Click(object sender, EventArgs e)
        {
            ResetMessageFields();
            Form orderTestDialog = new OrderTestDialog(this.visitDTO[0]);
            DialogResult result = orderTestDialog.ShowDialog();
        }

        /// <summary>
        /// The handler for EditFinalDiagnosticButton Click
        /// </summary>
        private void EditFinalDiagnosticButton_Click(object sender, EventArgs e)
        {
            ResetMessageFields();
            Form finalDiagnosticConfirmationDialog = new FinalDiagnosticConfirmationForm();
            DialogResult result = finalDiagnosticConfirmationDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.finalDiagnosticConfirmationClicked = true;
                this.editFinalDiagnosticButton.Visible = false;
                this.createButton.Visible = false;
                this.editButton.Visible = true;
                this.editButton.Text = "Enter Final Diagnostic";
                this.orderLabTestButton.Visible = false;
                this.viewLabTestButton.Visible = false;
                this.finalDiagnosticTextBox.ReadOnly = false;
                this.messageLabel.Text = "";
                this.messageLabel.Visible = false;
                DisableFormFields();
            }

        }

        private void ResetMessageFields()
        {
            this.messageLabel.Visible = false;
            this.finalDiagnosticErrorLabel.Visible = false;
            this.messageLabel.Text = "";
            this.finalDiagnosticErrorLabel.Text = "";
        }

        private void ViewLabTestButton_Click(object sender, EventArgs e)
        {
            ResetMessageFields();
            visitTests = labOrdersTestController.GetVisitTests(Convert.ToInt32(visitDTO[0].ID));
            if (visitTests.Count <= 0)
            {
                MessageBox.Show($"No test found in the system for visit {visitDTO[0].ID}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form viewLabOrderDialog = new ViewLabOrderDialog(this.visitDTO[0]);
                DialogResult result = viewLabOrderDialog.ShowDialog();
            }
           
        }

        #endregion
    }
}
