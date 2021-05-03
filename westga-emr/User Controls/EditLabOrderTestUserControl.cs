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
using westga_emr.Helpers;
using westga_emr.Model;
using westga_emr.Model.DTO;
using westga_emr.View;

namespace westga_emr.User_Controls
{
    public partial class EditLabOrderTestUserControl : UserControl
    {

        private Lab_Orders_have_Lab_TestsController labOrdersTestController;
        private LabOrderTestDTO selectedLabOrderTestDTO;
        private DateTime selectedAppointmentDateTime;
        private TimeSpan selectedAppointmentTime;

        public EditLabOrderTestUserControl()
        {
            InitializeComponent();
            labOrdersTestController = new Lab_Orders_have_Lab_TestsController();
            selectedLabOrderTestDTO = new LabOrderTestDTO();
        }

        public void PopulateDataGrid(LabOrderTestDTO selectedLabOrderTestDTO)
        {
            
            this.selectedLabOrderTestDTO = selectedLabOrderTestDTO;
            this.labOrderIDTextBox.Text = selectedLabOrderTestDTO.OrderId.ToString();
            this.visitIDTextBox.Text = selectedLabOrderTestDTO.VisitId.ToString();
            this.testNameTextBox.Text = selectedLabOrderTestDTO.TestName;
            this.orderDateTimePicker.Value = selectedLabOrderTestDTO.OrderedDate;
            this.testResultTextBox.Text = selectedLabOrderTestDTO.TestResult;
            if (selectedLabOrderTestDTO.IsNormal.HasValue)
            {
                this.normalRadioButton.Checked = selectedLabOrderTestDTO.IsNormal.Value ? true : false;
                this.abNormalRadioButton.Checked = selectedLabOrderTestDTO.IsNormal.Value ? false : true;
            }
           
            this.messageLabel.Text = "";
            this.messageLabel.Visible = false;
            this.testDateError.Text = "";
            if (!String.IsNullOrWhiteSpace(selectedLabOrderTestDTO.TestResult))
            {
                this.testResultTextBox.ReadOnly = true;
                this.testPerformedDateTimePicker.Enabled = false;
                this.orderDateTimePicker.Enabled = false;
                this.testResultTextBox.ReadOnly = true;
                this.updateLabTestButton.Visible = false;
                this.normalRadioButton.Enabled = false;
                this.abNormalRadioButton.Enabled = false;
                this.editLabOrderTestLabel.Text = "View Lab Test";
                this.testPerformedDateTimePicker.Value = selectedLabOrderTestDTO.TestDate;
                this.messageLabel.Text = "Lab Test Cannot be modified as test results are already submitted!!";
                this.messageLabel.Visible = true;
                SetTestTime();
            }
            else {
                this.testPerformedDateTimePicker.MinDate = selectedLabOrderTestDTO.OrderedDate;
                this.testPerformedDateTimePicker.Value = DateTime.Now;
                this.testPerformedDateTimePicker.MaxDate = DateTime.Now;
                this.testTime.SelectedIndex = -1;
                this.testDateError.Text = "";
                this.testResultTextBox.ReadOnly = false;
                this.testResultTextBox.Text = selectedLabOrderTestDTO.TestResult;
            }
           
        }

        private void SetTestTime()
        {
            this.testTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            string time = this.selectedLabOrderTestDTO.TestDate.TimeOfDay.ToString();
            if (time.Equals("00:00:00"))
            {
                time = AppointmentHelper.GetAppointmentTimeslots()[0].Value;
            }
            this.testTime.SelectedIndex = AppointmentHelper.GetAppointmentTimeslots().FindIndex(x => x.Value == time);
            this.testTime.Enabled = false;

        }

        private void UpdateLabTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.testResultError.Visible = false;
                this.testResultError.Text = "";
                this.testDateError.Visible = false;
                this.testDateError.Text = "";
                this.messageLabel.Visible = false;
                this.testDateError.Text = "";
                this.testResultStatusErrorlabel.Visible = false;
                this.testResultStatusErrorlabel.Text = "";
                bool isTestResultsEmptyOrNull = String.IsNullOrWhiteSpace(this.testResultTextBox.Text);
                bool isTestDateInvalid = this.testPerformedDateTimePicker.Value < selectedLabOrderTestDTO.OrderedDate;
                bool isTestResultRadioBtnSelected = this.CheckIfTestResultRadioButtonSelected();
                bool isSelectedTestDateTimeInValid = ( selectedAppointmentDateTime == null || this.testTime.SelectedIndex <= 0);
                

                if (isTestResultsEmptyOrNull || isTestDateInvalid || !isTestResultRadioBtnSelected || isSelectedTestDateTimeInValid)
                {
                    if (isTestResultsEmptyOrNull)
                    {
                        this.testResultError.Visible = true;
                        this.testResultError.Text = "The Test Result is mandatory!!";
                    }

                    if (isTestDateInvalid)
                    {
                        this.testDateError.Visible = true;
                        this.testDateError.Text = "The Test Date cannot be before test order date!!";
                    }

                    if (!isTestResultRadioBtnSelected)
                    {
                        this.testResultStatusErrorlabel.Visible = true;
                        this.testResultStatusErrorlabel.Text = "The Test Result Status Must be seleced!!";
                    }
                    if (isSelectedTestDateTimeInValid)
                    {
                        this.testDateError.Visible = true;
                        this.testDateError.Text = "The Test time is must to be selected!!";
                    }
                    

                }
                else
                {
                    
                    List<Lab_Orders_have_Lab_Tests> labOrderHaveLabTestLst = new List<Lab_Orders_have_Lab_Tests>();
                    labOrderHaveLabTestLst.Add(new Lab_Orders_have_Lab_Tests(selectedLabOrderTestDTO.OrderId,
                                                                        this.selectedLabOrderTestDTO.TestCode,
                                                                        selectedAppointmentDateTime,
                                                                        this.testResultTextBox.Text,
                                                                        this.normalRadioButton.Checked?true:false));
                    if (this.labOrdersTestController.EnterTestResults(labOrderHaveLabTestLst.ToArray()))
                    {
                        Form successfullPersistDialog = new SuccessfullPersistDialog("Lab Test Updated Successfully!!.");
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
            catch(Exception ex)
            {
             this.messageLabel.Text = "Input Data inconsistent." + Environment.NewLine +
                                        "Please verify all data entered for the input fields and try again!!";
                var message = ex.Message;
                this.messageLabel.Visible = true;
            }
           
        }

        private bool CheckIfTestResultRadioButtonSelected()
        {
            return this.normalRadioButton.Checked || this.abNormalRadioButton.Checked;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }

        private void TestPerformedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.testTime.DataSource = AppointmentHelper.GetAppointmentTimeslots();
            if (testTime.Enabled == false)
            {
                testTime.Enabled = true;
            }
        }

        private void TestTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.testTime.SelectedIndex >= 0)
            {
                testDateError.Text = "";
                var time = (AppointmentHelper)this.testTime.SelectedItem;
                this.selectedAppointmentTime = TimeSpan.Parse(time.Value);
                this.selectedAppointmentDateTime = this.orderDateTimePicker.Value.Date + selectedAppointmentTime;
               // GetAvailableDoctors(this.selectedAppointmentDateTime);
            }
            else
            {
                testDateError.Text = "Please select a time for the appointment";
            }
        }
    }
}
