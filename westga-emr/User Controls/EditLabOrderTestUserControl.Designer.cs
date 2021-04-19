
namespace westga_emr.User_Controls
{
    partial class EditLabOrderTestUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label testDateLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label testResultLabel;
            System.Windows.Forms.Label testNameLabel;
            System.Windows.Forms.Label visitIDLabel;
            System.Windows.Forms.Label labOrderIDLabel;
            this.closeButton = new System.Windows.Forms.Button();
            this.addressId = new System.Windows.Forms.Label();
            this.editLabOrderTestLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.testResultTextBox = new System.Windows.Forms.TextBox();
            this.testPerformedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testResultError = new System.Windows.Forms.Label();
            this.testDateError = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.visitIDTextBox = new System.Windows.Forms.TextBox();
            this.testNameTextBox = new System.Windows.Forms.TextBox();
            this.labOrderIDTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.updateLabTestButton = new System.Windows.Forms.Button();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            testDateLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            testResultLabel = new System.Windows.Forms.Label();
            testNameLabel = new System.Windows.Forms.Label();
            visitIDLabel = new System.Windows.Forms.Label();
            labOrderIDLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // testDateLabel
            // 
            testDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            testDateLabel.AutoSize = true;
            testDateLabel.Location = new System.Drawing.Point(529, 0);
            testDateLabel.Name = "testDateLabel";
            testDateLabel.Size = new System.Drawing.Size(258, 13);
            testDateLabel.TabIndex = 9;
            testDateLabel.Text = "Test Date";
            // 
            // orderDateLabel
            // 
            orderDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(266, 0);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(257, 13);
            orderDateLabel.TabIndex = 8;
            orderDateLabel.Text = "Order Date";
            // 
            // testResultLabel
            // 
            testResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            testResultLabel.AutoSize = true;
            testResultLabel.Location = new System.Drawing.Point(3, 0);
            testResultLabel.Name = "testResultLabel";
            testResultLabel.Size = new System.Drawing.Size(257, 13);
            testResultLabel.TabIndex = 7;
            testResultLabel.Text = "Test Result *";
            // 
            // testNameLabel
            // 
            testNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            testNameLabel.AutoSize = true;
            testNameLabel.Location = new System.Drawing.Point(529, 6);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new System.Drawing.Size(258, 13);
            testNameLabel.TabIndex = 3;
            testNameLabel.Text = "Test Name";
            // 
            // visitIDLabel
            // 
            visitIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            visitIDLabel.AutoSize = true;
            visitIDLabel.Location = new System.Drawing.Point(266, 6);
            visitIDLabel.Name = "visitIDLabel";
            visitIDLabel.Size = new System.Drawing.Size(257, 13);
            visitIDLabel.TabIndex = 2;
            visitIDLabel.Text = "Visit ID";
            // 
            // labOrderIDLabel
            // 
            labOrderIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            labOrderIDLabel.AutoSize = true;
            labOrderIDLabel.Location = new System.Drawing.Point(3, 6);
            labOrderIDLabel.Name = "labOrderIDLabel";
            labOrderIDLabel.Size = new System.Drawing.Size(257, 13);
            labOrderIDLabel.TabIndex = 1;
            labOrderIDLabel.Text = "Lab Order ID";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.Location = new System.Drawing.Point(247, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(116, 25);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // addressId
            // 
            this.addressId.AutoSize = true;
            this.addressId.Location = new System.Drawing.Point(26, 4);
            this.addressId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressId.Name = "addressId";
            this.addressId.Size = new System.Drawing.Size(0, 13);
            this.addressId.TabIndex = 35;
            this.addressId.Visible = false;
            // 
            // editLabOrderTestLabel
            // 
            this.editLabOrderTestLabel.AutoSize = true;
            this.editLabOrderTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabOrderTestLabel.Location = new System.Drawing.Point(367, 4);
            this.editLabOrderTestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editLabOrderTestLabel.Name = "editLabOrderTestLabel";
            this.editLabOrderTestLabel.Size = new System.Drawing.Size(103, 20);
            this.editLabOrderTestLabel.TabIndex = 34;
            this.editLabOrderTestLabel.Text = "Edit Lab Test";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(testDateLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(orderDateLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.testResultTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(testResultLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.testPerformedDateTimePicker, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.testResultError, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.testDateError, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.orderDateTimePicker, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 155);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(790, 73);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // testResultTextBox
            // 
            this.testResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.testResultTextBox.Location = new System.Drawing.Point(3, 22);
            this.testResultTextBox.Name = "testResultTextBox";
            this.testResultTextBox.ReadOnly = true;
            this.testResultTextBox.Size = new System.Drawing.Size(257, 20);
            this.testResultTextBox.TabIndex = 4;
            // 
            // testPerformedDateTimePicker
            // 
            this.testPerformedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.testPerformedDateTimePicker.Location = new System.Drawing.Point(529, 22);
            this.testPerformedDateTimePicker.MaxDate = new System.DateTime(2021, 5, 19, 7, 5, 0, 0);
            this.testPerformedDateTimePicker.Name = "testPerformedDateTimePicker";
            this.testPerformedDateTimePicker.Size = new System.Drawing.Size(258, 20);
            this.testPerformedDateTimePicker.TabIndex = 11;
            this.testPerformedDateTimePicker.Value = new System.DateTime(2021, 4, 19, 0, 0, 0, 0);
            // 
            // testResultError
            // 
            this.testResultError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testResultError.AutoSize = true;
            this.testResultError.ForeColor = System.Drawing.Color.Red;
            this.testResultError.Location = new System.Drawing.Point(3, 52);
            this.testResultError.Name = "testResultError";
            this.testResultError.Size = new System.Drawing.Size(257, 21);
            this.testResultError.TabIndex = 10;
            // 
            // testDateError
            // 
            this.testDateError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testDateError.AutoSize = true;
            this.testDateError.ForeColor = System.Drawing.Color.Red;
            this.testDateError.Location = new System.Drawing.Point(529, 52);
            this.testDateError.Name = "testDateError";
            this.testDateError.Size = new System.Drawing.Size(258, 21);
            this.testDateError.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.visitIDTextBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(testNameLabel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.testNameTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(visitIDLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labOrderIDTextBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(labOrderIDLabel, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 48);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(790, 79);
            this.tableLayoutPanel5.TabIndex = 30;
            // 
            // visitIDTextBox
            // 
            this.visitIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.visitIDTextBox.Location = new System.Drawing.Point(266, 28);
            this.visitIDTextBox.Name = "visitIDTextBox";
            this.visitIDTextBox.ReadOnly = true;
            this.visitIDTextBox.Size = new System.Drawing.Size(257, 20);
            this.visitIDTextBox.TabIndex = 2;
            // 
            // testNameTextBox
            // 
            this.testNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.testNameTextBox.Location = new System.Drawing.Point(529, 28);
            this.testNameTextBox.Name = "testNameTextBox";
            this.testNameTextBox.ReadOnly = true;
            this.testNameTextBox.Size = new System.Drawing.Size(258, 20);
            this.testNameTextBox.TabIndex = 3;
            // 
            // labOrderIDTextBox
            // 
            this.labOrderIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labOrderIDTextBox.Location = new System.Drawing.Point(3, 28);
            this.labOrderIDTextBox.Name = "labOrderIDTextBox";
            this.labOrderIDTextBox.ReadOnly = true;
            this.labOrderIDTextBox.Size = new System.Drawing.Size(257, 20);
            this.labOrderIDTextBox.TabIndex = 1;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(286, 240);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(144, 17);
            this.messageLabel.TabIndex = 36;
            this.messageLabel.Text = "                                  ";
            this.messageLabel.Visible = false;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel9.Controls.Add(this.updateLabTestButton, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.closeButton, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 307);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(829, 31);
            this.tableLayoutPanel9.TabIndex = 33;
            // 
            // updateLabTestButton
            // 
            this.updateLabTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateLabTestButton.BackColor = System.Drawing.Color.Green;
            this.updateLabTestButton.ForeColor = System.Drawing.Color.White;
            this.updateLabTestButton.Location = new System.Drawing.Point(417, 3);
            this.updateLabTestButton.Name = "updateLabTestButton";
            this.updateLabTestButton.Size = new System.Drawing.Size(116, 25);
            this.updateLabTestButton.TabIndex = 12;
            this.updateLabTestButton.Text = "Update Lab Test";
            this.updateLabTestButton.UseVisualStyleBackColor = false;
            this.updateLabTestButton.Click += new System.EventHandler(this.UpdateLabTestButton_Click);
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDateTimePicker.Location = new System.Drawing.Point(266, 22);
            this.orderDateTimePicker.MaxDate = new System.DateTime(2021, 5, 19, 7, 5, 0, 0);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(257, 20);
            this.orderDateTimePicker.TabIndex = 13;
            this.orderDateTimePicker.Value = new System.DateTime(2021, 4, 19, 0, 0, 0, 0);
            // 
            // EditLabOrderTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.addressId);
            this.Controls.Add(this.editLabOrderTestLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Name = "EditLabOrderTestUserControl";
            this.Size = new System.Drawing.Size(829, 338);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label addressId;
        private System.Windows.Forms.Label editLabOrderTestLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox testResultTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox visitIDTextBox;
        private System.Windows.Forms.TextBox testNameTextBox;
        private System.Windows.Forms.TextBox labOrderIDTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button updateLabTestButton;
        private System.Windows.Forms.Label testResultError;
        private System.Windows.Forms.DateTimePicker testPerformedDateTimePicker;
        private System.Windows.Forms.Label testDateError;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
    }
}
