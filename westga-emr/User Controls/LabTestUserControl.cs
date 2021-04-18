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
    public partial class LabTestUserControl : UserControl
    {
        private Lab_TestController labTestController;
        private Lab_OrderController labOrderController;
        private Lab_Orders_have_Lab_TestsController labOrdersHaveLabTestsController;
        private List<Lab_Test> labTestList;
        private List<Lab_Test> selectedLabTestList;
        private VisitDTO visitDTO;

        public LabTestUserControl()
        {
            InitializeComponent();
            labTestController = new Lab_TestController();
            labOrderController = new Lab_OrderController();
            labOrdersHaveLabTestsController = new Lab_Orders_have_Lab_TestsController();
            labTestList = new List<Lab_Test>();
            selectedLabTestList= new List<Lab_Test>();
        }

        public void PopulateTextBoxes(VisitDTO visitDTO)
        {
            this.visitDTO = visitDTO;
            populateUserControlOnLoad();
        }

        private void populateUserControlOnLoad()
        {
            labTestList = labTestController.GetLab_Tests();
            List<string> testNames = new List<string>();
            labTestList.ForEach(x=> testNames.Add(x.Name));
            this.testNameCheckedListBox.Items.AddRange(testNames.ToArray());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (this.selectedTestNameListBox.Items.Count > 0)
            {
                foreach (string s in this.selectedTestNameListBox.Items)
                {
                    labTestList.ForEach(x => { if (x.Name.Equals(s)) selectedLabTestList.Add(x); });
                }

                Lab_Order labOrder = new Lab_Order(this.visitDTO.ID, DateTime.Now);
                this.labOrderController.OrderLabs(labOrder, selectedLabTestList.ToArray());
                this.selectedTestNameListBox.Items.Clear();
                this.messageLabel.Visible = true;
                this.messageLabel.Text = "Lab Order placed Successfully!!";
            }
            else
            {
                this.messageLabel.Visible = true;
                this.messageLabel.Text = "Please select atlease one test to proceed!!";
            }

        }

        private void AddTestNamebutton_Click(object sender, EventArgs e)
        {
            this.selectedTestNameListBox.Items.Clear();
            foreach (string s in this.testNameCheckedListBox.CheckedItems)
            {
                this.selectedTestNameListBox.Items.Add(s);
            }
        }

        private void ClearTestNamebutton_Click(object sender, EventArgs e)
        {
            this.selectedTestNameListBox.Items.Clear();
            for (int i = 0; i < this.testNameCheckedListBox.Items.Count; i++)
            {
                this.testNameCheckedListBox.SetItemChecked(i, false);
            }
            this.messageLabel.Visible = false;
            this.messageLabel.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.DialogResult = DialogResult.Cancel;
        }
    }
}
