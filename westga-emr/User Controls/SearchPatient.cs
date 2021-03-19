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

namespace westga_emr.User_Controls
{
    /// <summary>
    /// User Control for searching for patients
    /// </summary>
    public partial class SearchPatient : UserControl
    {
        private readonly PatientController controller;

        /// <summary>
        /// Instantiates the User Control
        /// </summary>
        public SearchPatient()
        {
            InitializeComponent();
            this.controller = new PatientController();
        }
    }
}
