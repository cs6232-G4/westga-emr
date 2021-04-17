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
            this.testResultTextBox.Text = selectedLabOrderTestDTO.TestResult;
            this.orderDateTextBox.Text = selectedLabOrderTestDTO.OrderedDate.ToString(); 
            this.testDateTextBox.Text = DateTime.Now.ToString();
            this.testResultTextBox.ReadOnly = false;
        }

        private void UpdateLabTestButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(this.testResultTextBox.Text))
                {
                    this.testResultError.Visible = true;
                    this.testResultError.Text = "The Test Result is mandatory!!";
                }
                else
                {
                    this.testResultError.Visible = false;
                    this.testResultError.Text = "";
                    List<Lab_Orders_have_Lab_Tests> labOrderHaveLabTestLst = new List<Lab_Orders_have_Lab_Tests>();
                    labOrderHaveLabTestLst.Add(new Lab_Orders_have_Lab_Tests(selectedLabOrderTestDTO.OrderId,
                                                                        this.selectedLabOrderTestDTO.TestCode,
                                                                        DateTime.Now,
                                                                        this.testResultTextBox.Text));
                    if (this.labOrdersTestController.UpdateLabTestsForVisit(labOrderHaveLabTestLst.ToArray()))
                    {
                        this.messageLabel.Text = "Lab Order Test Updated Successfully!!";
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }
    }
}
