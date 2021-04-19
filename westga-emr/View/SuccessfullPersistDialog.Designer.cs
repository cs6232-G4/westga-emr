
namespace westga_emr.View
{
    partial class SuccessfullPersistDialog
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.closelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(51, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(244, 101);
            this.messageLabel.TabIndex = 21;
            this.messageLabel.Text = "The details provided by you has been successfully saved into our database.";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closelButton
            // 
            this.closelButton.AutoSize = true;
            this.closelButton.BackColor = System.Drawing.Color.DarkGreen;
            this.closelButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelButton.ForeColor = System.Drawing.Color.White;
            this.closelButton.Location = new System.Drawing.Point(107, 113);
            this.closelButton.Name = "closelButton";
            this.closelButton.Size = new System.Drawing.Size(87, 33);
            this.closelButton.TabIndex = 19;
            this.closelButton.Text = "Close";
            this.closelButton.UseVisualStyleBackColor = false;
            this.closelButton.Click += new System.EventHandler(this.closelButton_Click);
            // 
            // SuccessfullPersistDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 172);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuccessfullPersistDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Success Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button closelButton;
    }
}