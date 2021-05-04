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

namespace westga_emr.User_Controls
{
    public partial class Report : UserControl
    {
        private readonly ReportController reportController;
        public Report()
        {
            InitializeComponent();
            this.reportController = new ReportController();
            this.startDatePicker.Value = DateTime.Now;
            this.startDatePicker.MaxDate = DateTime.Now;
            this.endDatePicker.Value = DateTime.Now;
            this.endDatePicker.MaxDate = DateTime.Now;
        }

        private void getReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(startDatePicker.Value <= endDatePicker.Value)
                {
                    errorLabel.Text = "";
                   this.reportViewer1.RefreshReport();
                    var reportData = this.reportController.GetMostPerformedTestsDuringDates(startDatePicker.Value, endDatePicker.Value);
                    this.reportBindingSource.DataSource = reportData;
                } else
                {
                    errorLabel.Text ="Start date should not be greater than end date";
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured" +
                   Environment.NewLine +
                  "Unable to generate report. Please contact site administrator",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            

        }
    }
}
