
namespace westga_emr.View
{
    partial class EditLabOrderTestDialog
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
            this.editLabOrderTestUserControl = new westga_emr.User_Controls.EditLabOrderTestUserControl();
            this.SuspendLayout();
            // 
            // editLabOrderTestUserControl
            // 
            this.editLabOrderTestUserControl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editLabOrderTestUserControl.Location = new System.Drawing.Point(-2, 0);
            this.editLabOrderTestUserControl.Name = "editLabOrderTestUserControl";
            this.editLabOrderTestUserControl.Size = new System.Drawing.Size(825, 325);
            this.editLabOrderTestUserControl.TabIndex = 0;
            // 
            // EditLabOrderTestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(827, 324);
            this.Controls.Add(this.editLabOrderTestUserControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLabOrderTestDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Lab Order Test";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.EditLabOrderTestUserControl editLabOrderTestUserControl;
    }
}