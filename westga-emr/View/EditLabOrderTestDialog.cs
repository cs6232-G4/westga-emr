using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class EditLabOrderTestDialog : Form
    {
        public EditLabOrderTestDialog()
        {
            InitializeComponent();
        }

        public EditLabOrderTestDialog(LabOrderTestDTO selectedLabOrderTestDTO)
        {
            InitializeComponent();
            this.editLabOrderTestUserControl.PopulateDataGrid(selectedLabOrderTestDTO);
        }
    }
}
