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

namespace westga_emr.User_Controls
{
    public partial class Nurses : UserControl
    {
        private readonly NurseController nurseController;
        private UserDTO nurse;
        private List<UserDTO> nurses;
        public Nurses()
        {
            InitializeComponent();
            nurseController = new NurseController();
        }

        /// <summary>
        /// Loads the nurse grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Nurses_Load(object sender, EventArgs e)
        {
            this.nurseListDataGrid.DataSource = null;
            this.nurses = nurseController.GetAllNurse();
            this.nurseListDataGrid.DataSource = this.nurses;
        }
        private void NurseListDatatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
