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
using westga_emr.Model;
using westga_emr.Model.DTO;
using westga_emr.View;

namespace westga_emr.User_Controls
{
    public partial class EditLabOrderTestUserControl : UserControl
    {

        private Lab_Orders_have_Lab_TestsController labOrdersTestController;
        private LabOrderTestDTO selectedLabOrderTestDTO;

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
            this.messageLabel.Text = "";
            this.messageLabel.Visible = false;
            if (!String.IsNullOrWhiteSpace(selectedLabOrderTestDTO.TestResult))
            {
                this.testResultTextBox.ReadOnly = true;
                this.testPerformedDateTimePicker.Enabled = false;
                this.orderDateTimePicker.Enabled = false;
                this.testResultTextBox.ReadOnly = true;
                this.updateLabTestButton.Visible = false;
                this.editLabOrderTestLabel.Text = "View Lab Test";
                this.testPerformedDateTimePicker.Value = selectedLabOrderTestDTO.TestDate;
                this.messageLabel.Text = "Lab Test Cannot be modified as test results are already submitted!!";
                this.messageLabel.Visible = true;
            }
            else {
                this.testPerformedDateTimePicker.Value = DateTime.Now;
                this.testPerformedDateTimePicker.MaxDate = DateTime.Now;
                this.testResultTextBox.ReadOnly = false;
                this.testResultTextBox.Text = selectedLabOrderTestDTO.TestResult;
            }
           
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
                bool isTestResultsEmptyOrNull = String.IsNullOrWhiteSpace(this.testResultTextBox.Text);
                bool isTestDateInvalid = this.testPerformedDateTimePicker.Value < selectedLabOrderTestDTO.OrderedDate;
                if (isTestResultsEmptyOrNull || isTestDateInvalid)
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
                    
                }
                else
                {
                    
                    List<Lab_Orders_have_Lab_Tests> labOrderHaveLabTestLst = new List<Lab_Orders_have_Lab_Tests>();
                    labOrderHaveLabTestLst.Add(new Lab_Orders_have_Lab_Tests(selectedLabOrderTestDTO.OrderId,
                                                                        this.selectedLabOrderTestDTO.TestCode,
                                                                        this.testPerformedDateTimePicker.Value,
                                                                        this.testResultTextBox.Text));
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }
    }
}
