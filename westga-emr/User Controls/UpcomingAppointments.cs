using System;
using System.Windows.Forms;
using westga_emr.Controller;
using westga_emr.Model.DTO;
using westga_emr.View;

namespace westga_emr.User_Controls
{
    public partial class UpcomingAppointments : UserControl
    {
        private readonly AppointmentController appointmentController;
        private readonly PatientController patientController;
        private AppointmentDTO appointmentDTO;
        public UpcomingAppointments()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            patientController = new PatientController();
        }

        private void UpcomingAppointments_Load(object sender, EventArgs e)
        {
            appointmentDataGridView.DataSource = null;
            this.appointmentCalendar.MinDate = DateTime.Now;
            
        }

        private void AppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                LoadDataGrid();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Unable to load appointments, try again", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void AppointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            appointmentDTO = (AppointmentDTO)appointmentDataGridView.Rows[e.RowIndex].DataBoundItem;
            if (appointmentDataGridView.Columns[e.ColumnIndex].Name == "ViewVisit")
            {
                using (Form appointmmentVisitFormDialog = new AppointmentVisitDialog(appointmentDTO))
                {
                    DialogResult result = appointmmentVisitFormDialog.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        this.LoadDataGrid();
                    }
                };

            }
            else if (appointmentDataGridView.Columns[e.ColumnIndex].Name == "EditAppointment")
            {
                var _datediff = appointmentDTO.AppointmentDateTime - DateTime.Now;
                var patient = patientController.GetPatientByPatientId(appointmentDTO.PatientID.Value);
                if (_datediff.Days >= 1)
                {
                    using (Form editAppointmentDialog = new AppointmentInformationDialog(appointmentDTO, patient))
                    {
                        DialogResult result = editAppointmentDialog.ShowDialog();
                        if (result == DialogResult.OK || result == DialogResult.Cancel)
                        {
                            this.LoadDataGrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Appointments less than 24 hours cannot be edited.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
        }
        /// <summary>
        /// Loads appointments
        /// </summary>
        public void LoadDataGrid()
        {
            var startDate = this.appointmentCalendar.SelectionRange.Start;
            var endDate = this.appointmentCalendar.SelectionRange.End;
            appointmentDataGridView.DataSource = appointmentController.GetAppointmentsInDateRange(startDate, endDate);
        }
    }
}
