
namespace westga_emr.View
{
    partial class ViewLabOrderDialog
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
            this.viewLabOrderUserControl = new westga_emr.User_Controls.ViewLabOrderUserControl();
            this.SuspendLayout();
            // 
            // viewLabOrderUserControl
            // 
            this.viewLabOrderUserControl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.viewLabOrderUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewLabOrderUserControl.Location = new System.Drawing.Point(0, 0);
            this.viewLabOrderUserControl.Name = "viewLabOrderUserControl";
            this.viewLabOrderUserControl.Size = new System.Drawing.Size(886, 375);
            this.viewLabOrderUserControl.TabIndex = 0;
            // 
            // ViewLabOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(886, 375);
            this.Controls.Add(this.viewLabOrderUserControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewLabOrderDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Lab Order";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.ViewLabOrderUserControl viewLabOrderUserControl;
    }
}