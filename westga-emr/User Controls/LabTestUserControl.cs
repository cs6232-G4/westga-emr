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
        private VisitDTO visitDTO;

        public LabTestUserControl()
        {
            InitializeComponent();
            labTestController = new Lab_TestController();
            labOrderController = new Lab_OrderController();
            labOrdersHaveLabTestsController = new Lab_Orders_have_Lab_TestsController();
            labTestList = new List<Lab_Test>();
        }

        public void PopulateTextBoxes(VisitDTO visitDTO)
        {
            this.visitDTO = visitDTO;
            populateUserControlOnLoad();
        }

        private void LabTestUserControl_Load(object sender, EventArgs e)
        {
            populateUserControlOnLoad();
        }

        private void populateUserControlOnLoad()
        {
            labTestList = labTestController.GetLab_Tests();
            this.orderNameComboBox.DataSource = labTestList;
            this.orderedDateTimePicker.MaxDate = DateTime.Now;
            this.testPerformedDateTimePicker.MaxDate = DateTime.Now;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Lab_Order labOrder = new Lab_Order(this.visitDTO.ID , this.orderedDateTimePicker.Value);
            int OrderId = (int) this.labOrderController.InsertLab_Order(labOrder);

            Lab_Orders_have_Lab_Tests labOrdersHaveLabTests = new Lab_Orders_have_Lab_Tests(OrderId , labTestList[this.orderNameComboBox.SelectedIndex].Code , this.testPerformedDateTimePicker.Value , this.testResultTextBox.Text);
            bool labOrderID = this.labOrdersHaveLabTestsController.InsertLab_Orders_have_Lab_Tests(labOrdersHaveLabTests);
            
            if(labOrderID == false)
            {
                MessageBox.Show("labOrderID  " + labOrderID +  Environment.NewLine ,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
