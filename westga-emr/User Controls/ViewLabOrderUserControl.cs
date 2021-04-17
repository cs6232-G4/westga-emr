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
using westga_emr.Model.DTO;
using westga_emr.View;

namespace westga_emr.User_Controls
{
    public partial class ViewLabOrderUserControl : UserControl
    {
        private readonly Lab_Orders_have_Lab_TestsController labOrdersTestController;
        private List<LabOrderTestDTO> visitTests;
        private LabOrderTestDTO selectedLabOrderTestDTO;
        private VisitDTO visitDTO;

        public ViewLabOrderUserControl()
        {
            InitializeComponent();
            labOrdersTestController = new Lab_Orders_have_Lab_TestsController();
            visitTests = new List<LabOrderTestDTO>();
            selectedLabOrderTestDTO = new LabOrderTestDTO();
            visitDTO = new VisitDTO();
        }

        public void PopulateDataGrid(VisitDTO visitDTO)
        {
            this.visitDTO = visitDTO;
            this.labOrderTestGrid.DataSource = null;
            visitTests = labOrdersTestController.GetVisitTests(Convert.ToInt32(visitDTO.ID));
            this.labOrderTestGrid.DataSource = visitTests;
        }

        private void LabOrderTestGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedLabOrderTestDTO = (LabOrderTestDTO)labOrderTestGrid.Rows[e.RowIndex].DataBoundItem;
            if (labOrderTestGrid.Columns[e.ColumnIndex].Name == "EditLabTest")
            {
                using (Form editLabOrderTestDialog = new EditLabOrderTestDialog(selectedLabOrderTestDTO))
                {
                    DialogResult result = editLabOrderTestDialog.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        this.RefreshDataGrid();
                    }
                }

            }
        }

        private void RefreshDataGrid()
        {
            this.labOrderTestGrid.DataSource = null;
            this.visitTests = labOrdersTestController.GetVisitTests(Convert.ToInt32(this.visitDTO.ID));
            this.labOrderTestGrid.DataSource = this.visitTests;
        }
    }
}
