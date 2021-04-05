
namespace westga_emr.View
{
    partial class AppointmentVisitDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appointmentVisitUserControl = new westga_emr.User_Controls.AppointmentVisitUserControl();
            this.SuspendLayout();
            // 
            // appointmentVisitUserControl
            // 
            this.appointmentVisitUserControl.BackColor = System.Drawing.Color.SkyBlue;
            this.appointmentVisitUserControl.Location = new System.Drawing.Point(1, 2);
            this.appointmentVisitUserControl.Name = "appointmentVisitUserControl";
            this.appointmentVisitUserControl.Size = new System.Drawing.Size(850, 505);
            this.appointmentVisitUserControl.TabIndex = 0;
            // 
            // AppointmentVisitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 508);
            this.Controls.Add(this.appointmentVisitUserControl);
            this.Name = "AppointmentVisitDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Visit";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.AppointmentVisitUserControl appointmentVisitUserControl;
    }
}