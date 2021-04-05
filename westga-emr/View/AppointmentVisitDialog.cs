using System.Windows.Forms;
using westga_emr.Model.DTO;

namespace westga_emr.View
{
    public partial class AppointmentVisitDialog : Form
    {
        #region Constructors
        /// <summary>
        /// The constructor for AppointmentVisitDialog
        /// </summary>
        public AppointmentVisitDialog(AppointmentDTO appointmentDTO)
        {
            InitializeComponent();
            this.appointmentVisitUserControl.populateTextBoxes(appointmentDTO);
        }
        #endregion
    }
}
