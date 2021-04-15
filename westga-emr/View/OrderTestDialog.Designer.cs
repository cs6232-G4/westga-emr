
namespace westga_emr.View
{
    partial class OrderTestDialog
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
            this.labTestUserControl = new westga_emr.User_Controls.LabTestUserControl();
            this.SuspendLayout();
            // 
            // labTestUserControl
            // 
            this.labTestUserControl.BackColor = System.Drawing.Color.SkyBlue;
            this.labTestUserControl.Location = new System.Drawing.Point(-2, 0);
            this.labTestUserControl.Name = "labTestUserControl";
            this.labTestUserControl.Size = new System.Drawing.Size(800, 383);
            this.labTestUserControl.TabIndex = 0;
            // 
            // OrderTestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(801, 384);
            this.Controls.Add(this.labTestUserControl);
            this.Name = "OrderTestDialog";
            this.Text = "Order Test";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.LabTestUserControl labTestUserControl;
    }
}