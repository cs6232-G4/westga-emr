using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using westga_emr.Model;

namespace westga_emr.User_Controls
{
    /// <summary>
    /// Form for viewing a Patient's demographics
    /// </summary>
    public partial class PatientDemographics : Form
    {
        private Person patient;
        /// <summary>
        /// Instantiates the form
        /// </summary>
        public PatientDemographics(Person patient)
        {
            InitializeComponent();
            this.patient = patient;
        }
    }
}
