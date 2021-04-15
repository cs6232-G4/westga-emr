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
    public partial class OrderTestDialog : Form
    {
        public OrderTestDialog()
        {
            InitializeComponent();
        }

        public OrderTestDialog(VisitDTO visitDTO)
        {
            InitializeComponent();
            this.labTestUserControl.PopulateTextBoxes(visitDTO);
        }
    }
}
