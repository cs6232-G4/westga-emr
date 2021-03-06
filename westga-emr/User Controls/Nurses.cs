﻿using System;
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
using westga_emr.Model.DTO;
using westga_emr.View;

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
            this.RefreshDataGrid();
        }
        private void NurseListDatatGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nurse = (UserDTO)nurseListDataGrid.Rows[e.RowIndex].DataBoundItem;
            if (nurseListDataGrid.Columns[e.ColumnIndex].Name == "EditNurse")
            {
                using (Form editNurseDialog = new EditNurseDialog(nurse))
                {
                    DialogResult result = editNurseDialog.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        this.RefreshDataGrid();
                    }
                }

            }
        }

        private void RefreshDataGrid()
        {
            this.nurseListDataGrid.DataSource = null;
            if(AuthenticationHelper.currentUser != null && AuthenticationHelper.currentUser.IsActiveAdmin)
            {
                this.nurses = nurseController.GetAllNurse();
                this.nurseListDataGrid.DataSource = this.nurses;
            }
           
        }
    }
}
