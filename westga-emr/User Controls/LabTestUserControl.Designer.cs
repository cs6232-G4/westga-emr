
namespace westga_emr.User_Controls
{
    partial class LabTestUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label resultLabel;
            System.Windows.Forms.Label testPerformedLabel;
            System.Windows.Forms.Label dateOrderedLabel;
            System.Windows.Forms.Label orderNameLabel;
            this.labTestHeaderLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.submitButton = new System.Windows.Forms.Button();
            this.genderError = new System.Windows.Forms.Label();
            this.testResultTextBox = new System.Windows.Forms.TextBox();
            this.testPerformedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstnameError = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.Label();
            this.orderNameComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dobError = new System.Windows.Forms.Label();
            this.orderedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            resultLabel = new System.Windows.Forms.Label();
            testPerformedLabel = new System.Windows.Forms.Label();
            dateOrderedLabel = new System.Windows.Forms.Label();
            orderNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(255, 7);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(264, 13);
            resultLabel.TabIndex = 6;
            resultLabel.Text = "Test Result*";
            // 
            // testPerformedLabel
            // 
            testPerformedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            testPerformedLabel.AutoSize = true;
            testPerformedLabel.Location = new System.Drawing.Point(529, 7);
            testPerformedLabel.Name = "testPerformedLabel";
            testPerformedLabel.Size = new System.Drawing.Size(258, 13);
            testPerformedLabel.TabIndex = 5;
            testPerformedLabel.Text = "Test Performed Date*";
            // 
            // dateOrderedLabel
            // 
            dateOrderedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dateOrderedLabel.AutoSize = true;
            dateOrderedLabel.Location = new System.Drawing.Point(266, 7);
            dateOrderedLabel.Name = "dateOrderedLabel";
            dateOrderedLabel.Size = new System.Drawing.Size(257, 13);
            dateOrderedLabel.TabIndex = 5;
            dateOrderedLabel.Text = "Ordered Date*";
            // 
            // orderNameLabel
            // 
            orderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            orderNameLabel.AutoSize = true;
            orderNameLabel.Location = new System.Drawing.Point(3, 7);
            orderNameLabel.Name = "orderNameLabel";
            orderNameLabel.Size = new System.Drawing.Size(257, 13);
            orderNameLabel.TabIndex = 5;
            orderNameLabel.Text = "Order Name*";
            // 
            // labTestHeaderLabel
            // 
            this.labTestHeaderLabel.AutoSize = true;
            this.labTestHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestHeaderLabel.Location = new System.Drawing.Point(360, 5);
            this.labTestHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTestHeaderLabel.Name = "labTestHeaderLabel";
            this.labTestHeaderLabel.Size = new System.Drawing.Size(71, 20);
            this.labTestHeaderLabel.TabIndex = 17;
            this.labTestHeaderLabel.Text = "Lab Test";
            this.labTestHeaderLabel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearButton.Location = new System.Drawing.Point(337, 6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.clearButton, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.submitButton, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 388);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(830, 50);
            this.tableLayoutPanel9.TabIndex = 16;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(418, 6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 37);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Save";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // genderError
            // 
            this.genderError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderError.AutoSize = true;
            this.genderError.ForeColor = System.Drawing.Color.Red;
            this.genderError.Location = new System.Drawing.Point(3, 80);
            this.genderError.Name = "genderError";
            this.genderError.Size = new System.Drawing.Size(246, 20);
            this.genderError.TabIndex = 9;
            // 
            // testResultTextBox
            // 
            this.testResultTextBox.Location = new System.Drawing.Point(255, 23);
            this.testResultTextBox.Name = "testResultTextBox";
            this.testResultTextBox.Size = new System.Drawing.Size(264, 20);
            this.testResultTextBox.TabIndex = 10;
            // 
            // testPerformedDateTimePicker
            // 
            this.testPerformedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.testPerformedDateTimePicker.Location = new System.Drawing.Point(529, 30);
            this.testPerformedDateTimePicker.MaxDate = new System.DateTime(2021, 3, 21, 7, 5, 30, 0);
            this.testPerformedDateTimePicker.Name = "testPerformedDateTimePicker";
            this.testPerformedDateTimePicker.Size = new System.Drawing.Size(258, 20);
            this.testPerformedDateTimePicker.TabIndex = 7;
            this.testPerformedDateTimePicker.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.genderError, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.testResultTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(resultLabel, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 164);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(790, 100);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(westga_emr.Model.Lab_Test);
            // 
            // firstnameError
            // 
            this.firstnameError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameError.AutoSize = true;
            this.firstnameError.ForeColor = System.Drawing.Color.Red;
            this.firstnameError.Location = new System.Drawing.Point(3, 60);
            this.firstnameError.Name = "firstnameError";
            this.firstnameError.Size = new System.Drawing.Size(257, 20);
            this.firstnameError.TabIndex = 7;
            // 
            // lastNameError
            // 
            this.lastNameError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameError.AutoSize = true;
            this.lastNameError.ForeColor = System.Drawing.Color.Red;
            this.lastNameError.Location = new System.Drawing.Point(266, 60);
            this.lastNameError.Name = "lastNameError";
            this.lastNameError.Size = new System.Drawing.Size(257, 20);
            this.lastNameError.TabIndex = 8;
            // 
            // orderNameComboBox
            // 
            this.orderNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderNameComboBox.DataSource = this.labTestBindingSource;
            this.orderNameComboBox.DisplayMember = "Name";
            this.orderNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderNameComboBox.FormattingEnabled = true;
            this.orderNameComboBox.Location = new System.Drawing.Point(3, 29);
            this.orderNameComboBox.Name = "orderNameComboBox";
            this.orderNameComboBox.Size = new System.Drawing.Size(257, 21);
            this.orderNameComboBox.TabIndex = 12;
            this.orderNameComboBox.ValueMember = "Value";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.testPerformedDateTimePicker, 2, 1);
            this.tableLayoutPanel5.Controls.Add(testPerformedLabel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(dateOrderedLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(orderNameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.firstnameError, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lastNameError, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.dobError, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.orderedDateTimePicker, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.orderNameComboBox, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(16, 38);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(790, 100);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // dobError
            // 
            this.dobError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobError.AutoSize = true;
            this.dobError.ForeColor = System.Drawing.Color.Red;
            this.dobError.Location = new System.Drawing.Point(529, 60);
            this.dobError.Name = "dobError";
            this.dobError.Size = new System.Drawing.Size(258, 20);
            this.dobError.TabIndex = 9;
            // 
            // orderedDateTimePicker
            // 
            this.orderedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderedDateTimePicker.Location = new System.Drawing.Point(266, 30);
            this.orderedDateTimePicker.MaxDate = new System.DateTime(2021, 3, 21, 7, 5, 30, 0);
            this.orderedDateTimePicker.Name = "orderedDateTimePicker";
            this.orderedDateTimePicker.Size = new System.Drawing.Size(257, 20);
            this.orderedDateTimePicker.TabIndex = 11;
            this.orderedDateTimePicker.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            // 
            // LabTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.labTestHeaderLabel);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "LabTestUserControl";
            this.Size = new System.Drawing.Size(830, 438);
            this.Load += new System.EventHandler(this.LabTestUserControl_Load);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTestHeaderLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label genderError;
        private System.Windows.Forms.TextBox testResultTextBox;
        private System.Windows.Forms.DateTimePicker testPerformedDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.Label firstnameError;
        private System.Windows.Forms.Label lastNameError;
        private System.Windows.Forms.ComboBox orderNameComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label dobError;
        private System.Windows.Forms.DateTimePicker orderedDateTimePicker;
    }
}
