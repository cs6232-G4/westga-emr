
namespace westga_emr.User_Controls
{
    partial class AppointmentVisitUserControl
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
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label finalDiagnosticLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label dialosticPressureLabel;
            System.Windows.Forms.Label visitDateLabel;
            System.Windows.Forms.Label initialDiagnosticLabel;
            System.Windows.Forms.Label nurseLabel;
            System.Windows.Forms.Label systolicPressureLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label bodyTemperatureLabel;
            this.bodyTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pulseError = new System.Windows.Forms.Label();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.finalDiagnosticTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.EditButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addressId = new System.Windows.Forms.Label();
            this.visitLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.systolicPressureError = new System.Windows.Forms.Label();
            this.weightError = new System.Windows.Forms.Label();
            this.bodyTemperatureError = new System.Windows.Forms.Label();
            this.dialosticPressureError = new System.Windows.Forms.Label();
            this.systolicPressureTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.dialosticPressureTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.initialDiagnosticTextBox = new System.Windows.Forms.TextBox();
            this.visitDateTextBox = new System.Windows.Forms.TextBox();
            this.nurseTextBox = new System.Windows.Forms.TextBox();
            this.initialDiagnosticError = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            finalDiagnosticLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            dialosticPressureLabel = new System.Windows.Forms.Label();
            visitDateLabel = new System.Windows.Forms.Label();
            initialDiagnosticLabel = new System.Windows.Forms.Label();
            nurseLabel = new System.Windows.Forms.Label();
            systolicPressureLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            bodyTemperatureLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pulseLabel
            // 
            pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(3, 3);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(257, 13);
            pulseLabel.TabIndex = 15;
            pulseLabel.Text = "Pulse";
            // 
            // finalDiagnosticLabel
            // 
            finalDiagnosticLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            finalDiagnosticLabel.AutoSize = true;
            finalDiagnosticLabel.Location = new System.Drawing.Point(529, 3);
            finalDiagnosticLabel.Name = "finalDiagnosticLabel";
            finalDiagnosticLabel.Size = new System.Drawing.Size(258, 13);
            finalDiagnosticLabel.TabIndex = 17;
            finalDiagnosticLabel.Text = "Final Diagnostic";
            // 
            // symptomsLabel
            // 
            symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(266, 3);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(257, 13);
            symptomsLabel.TabIndex = 16;
            symptomsLabel.Text = "Symptoms";
            // 
            // dialosticPressureLabel
            // 
            dialosticPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dialosticPressureLabel.AutoSize = true;
            dialosticPressureLabel.Location = new System.Drawing.Point(382, 0);
            dialosticPressureLabel.Name = "dialosticPressureLabel";
            dialosticPressureLabel.Size = new System.Drawing.Size(184, 13);
            dialosticPressureLabel.TabIndex = 9;
            dialosticPressureLabel.Text = "Dialostic Pressure";
            // 
            // visitDateLabel
            // 
            visitDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            visitDateLabel.AutoSize = true;
            visitDateLabel.Location = new System.Drawing.Point(529, 6);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(258, 13);
            visitDateLabel.TabIndex = 3;
            visitDateLabel.Text = "Visit Date";
            // 
            // initialDiagnosticLabel
            // 
            initialDiagnosticLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            initialDiagnosticLabel.AutoSize = true;
            initialDiagnosticLabel.Location = new System.Drawing.Point(266, 6);
            initialDiagnosticLabel.Name = "initialDiagnosticLabel";
            initialDiagnosticLabel.Size = new System.Drawing.Size(257, 13);
            initialDiagnosticLabel.TabIndex = 2;
            initialDiagnosticLabel.Text = "Initial Diagnostic";
            // 
            // nurseLabel
            // 
            nurseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nurseLabel.AutoSize = true;
            nurseLabel.Location = new System.Drawing.Point(3, 6);
            nurseLabel.Name = "nurseLabel";
            nurseLabel.Size = new System.Drawing.Size(257, 13);
            nurseLabel.TabIndex = 1;
            nurseLabel.Text = "Nurse Name";
            // 
            // systolicPressureLabel
            // 
            systolicPressureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            systolicPressureLabel.AutoSize = true;
            systolicPressureLabel.Location = new System.Drawing.Point(192, 0);
            systolicPressureLabel.Name = "systolicPressureLabel";
            systolicPressureLabel.Size = new System.Drawing.Size(184, 13);
            systolicPressureLabel.TabIndex = 8;
            systolicPressureLabel.Text = "Systolic Pressure";
            // 
            // weightLabel
            // 
            weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(3, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(183, 13);
            weightLabel.TabIndex = 7;
            weightLabel.Text = "Weight";
            // 
            // bodyTemperatureLabel
            // 
            bodyTemperatureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            bodyTemperatureLabel.AutoSize = true;
            bodyTemperatureLabel.Location = new System.Drawing.Point(572, 0);
            bodyTemperatureLabel.Name = "bodyTemperatureLabel";
            bodyTemperatureLabel.Size = new System.Drawing.Size(215, 13);
            bodyTemperatureLabel.TabIndex = 10;
            bodyTemperatureLabel.Text = "Body Temperature";
            // 
            // bodyTemperatureTextBox
            // 
            this.bodyTemperatureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureTextBox.Location = new System.Drawing.Point(572, 22);
            this.bodyTemperatureTextBox.Name = "bodyTemperatureTextBox";
            this.bodyTemperatureTextBox.Size = new System.Drawing.Size(215, 20);
            this.bodyTemperatureTextBox.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.pulseError, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.symptomsTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(pulseLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(finalDiagnosticLabel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.finalDiagnosticTextBox, 2, 1);
            this.tableLayoutPanel4.Controls.Add(symptomsLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pulseTextBox, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(23, 265);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.58537F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.41463F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(790, 62);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // pulseError
            // 
            this.pulseError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseError.AutoSize = true;
            this.pulseError.ForeColor = System.Drawing.Color.Red;
            this.pulseError.Location = new System.Drawing.Point(3, 44);
            this.pulseError.Name = "pulseError";
            this.pulseError.Size = new System.Drawing.Size(257, 18);
            this.pulseError.TabIndex = 23;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsTextBox.Location = new System.Drawing.Point(266, 20);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(257, 20);
            this.symptomsTextBox.TabIndex = 19;
            // 
            // finalDiagnosticTextBox
            // 
            this.finalDiagnosticTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.finalDiagnosticTextBox.Location = new System.Drawing.Point(529, 20);
            this.finalDiagnosticTextBox.Name = "finalDiagnosticTextBox";
            this.finalDiagnosticTextBox.Size = new System.Drawing.Size(258, 20);
            this.finalDiagnosticTextBox.TabIndex = 20;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseTextBox.Location = new System.Drawing.Point(3, 20);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(257, 20);
            this.pulseTextBox.TabIndex = 18;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel9.Controls.Add(this.EditButton, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.createButton, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.closeButton, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 407);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(830, 31);
            this.tableLayoutPanel9.TabIndex = 24;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.BackColor = System.Drawing.Color.Green;
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(654, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(116, 25);
            this.EditButton.TabIndex = 23;
            this.EditButton.Text = "Edit Visit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createButton.BackColor = System.Drawing.Color.Green;
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(385, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(116, 25);
            this.createButton.TabIndex = 22;
            this.createButton.Text = "Create Visit";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Visible = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.Location = new System.Drawing.Point(87, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(116, 25);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // addressId
            // 
            this.addressId.AutoSize = true;
            this.addressId.Location = new System.Drawing.Point(26, 8);
            this.addressId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressId.Name = "addressId";
            this.addressId.Size = new System.Drawing.Size(0, 13);
            this.addressId.TabIndex = 28;
            this.addressId.Visible = false;
            // 
            // visitLabel
            // 
            this.visitLabel.AutoSize = true;
            this.visitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitLabel.Location = new System.Drawing.Point(367, 8);
            this.visitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.visitLabel.Name = "visitLabel";
            this.visitLabel.Size = new System.Drawing.Size(92, 20);
            this.visitLabel.TabIndex = 26;
            this.visitLabel.Text = "Visit Details";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.Controls.Add(this.systolicPressureError, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.weightError, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.bodyTemperatureError, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dialosticPressureError, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.systolicPressureTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.bodyTemperatureTextBox, 2, 1);
            this.tableLayoutPanel3.Controls.Add(dialosticPressureLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(systolicPressureLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.weightTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(weightLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dialosticPressureTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(bodyTemperatureLabel, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 159);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(790, 73);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // systolicPressureError
            // 
            this.systolicPressureError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicPressureError.AutoSize = true;
            this.systolicPressureError.ForeColor = System.Drawing.Color.Red;
            this.systolicPressureError.Location = new System.Drawing.Point(192, 52);
            this.systolicPressureError.Name = "systolicPressureError";
            this.systolicPressureError.Size = new System.Drawing.Size(184, 21);
            this.systolicPressureError.TabIndex = 18;
            // 
            // weightError
            // 
            this.weightError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightError.AutoSize = true;
            this.weightError.ForeColor = System.Drawing.Color.Red;
            this.weightError.Location = new System.Drawing.Point(3, 52);
            this.weightError.Name = "weightError";
            this.weightError.Size = new System.Drawing.Size(183, 21);
            this.weightError.TabIndex = 17;
            // 
            // bodyTemperatureError
            // 
            this.bodyTemperatureError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTemperatureError.AutoSize = true;
            this.bodyTemperatureError.ForeColor = System.Drawing.Color.Red;
            this.bodyTemperatureError.Location = new System.Drawing.Point(572, 52);
            this.bodyTemperatureError.Name = "bodyTemperatureError";
            this.bodyTemperatureError.Size = new System.Drawing.Size(215, 21);
            this.bodyTemperatureError.TabIndex = 16;
            // 
            // dialosticPressureError
            // 
            this.dialosticPressureError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialosticPressureError.AutoSize = true;
            this.dialosticPressureError.ForeColor = System.Drawing.Color.Red;
            this.dialosticPressureError.Location = new System.Drawing.Point(382, 52);
            this.dialosticPressureError.Name = "dialosticPressureError";
            this.dialosticPressureError.Size = new System.Drawing.Size(184, 21);
            this.dialosticPressureError.TabIndex = 15;
            // 
            // systolicPressureTextBox
            // 
            this.systolicPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.systolicPressureTextBox.Location = new System.Drawing.Point(192, 22);
            this.systolicPressureTextBox.Name = "systolicPressureTextBox";
            this.systolicPressureTextBox.Size = new System.Drawing.Size(184, 20);
            this.systolicPressureTextBox.TabIndex = 11;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.Location = new System.Drawing.Point(3, 22);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(183, 20);
            this.weightTextBox.TabIndex = 12;
            // 
            // dialosticPressureTextBox
            // 
            this.dialosticPressureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dialosticPressureTextBox.Location = new System.Drawing.Point(382, 22);
            this.dialosticPressureTextBox.Name = "dialosticPressureTextBox";
            this.dialosticPressureTextBox.Size = new System.Drawing.Size(184, 20);
            this.dialosticPressureTextBox.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.initialDiagnosticTextBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(visitDateLabel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.visitDateTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(initialDiagnosticLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.nurseTextBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(nurseLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.initialDiagnosticError, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 52);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(790, 79);
            this.tableLayoutPanel5.TabIndex = 21;
            // 
            // initialDiagnosticTextBox
            // 
            this.initialDiagnosticTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.initialDiagnosticTextBox.Location = new System.Drawing.Point(266, 28);
            this.initialDiagnosticTextBox.Name = "initialDiagnosticTextBox";
            this.initialDiagnosticTextBox.Size = new System.Drawing.Size(257, 20);
            this.initialDiagnosticTextBox.TabIndex = 5;
            // 
            // visitDateTextBox
            // 
            this.visitDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.visitDateTextBox.Enabled = false;
            this.visitDateTextBox.Location = new System.Drawing.Point(529, 28);
            this.visitDateTextBox.Name = "visitDateTextBox";
            this.visitDateTextBox.Size = new System.Drawing.Size(258, 20);
            this.visitDateTextBox.TabIndex = 6;
            // 
            // nurseTextBox
            // 
            this.nurseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nurseTextBox.Enabled = false;
            this.nurseTextBox.Location = new System.Drawing.Point(3, 28);
            this.nurseTextBox.Name = "nurseTextBox";
            this.nurseTextBox.Size = new System.Drawing.Size(257, 20);
            this.nurseTextBox.TabIndex = 4;
            // 
            // initialDiagnosticError
            // 
            this.initialDiagnosticError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initialDiagnosticError.AutoSize = true;
            this.initialDiagnosticError.ForeColor = System.Drawing.Color.Red;
            this.initialDiagnosticError.Location = new System.Drawing.Point(266, 58);
            this.initialDiagnosticError.Name = "initialDiagnosticError";
            this.initialDiagnosticError.Size = new System.Drawing.Size(257, 21);
            this.initialDiagnosticError.TabIndex = 8;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(289, 359);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(144, 17);
            this.messageLabel.TabIndex = 29;
            this.messageLabel.Text = "                                  ";
            // 
            // AppointmentVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.addressId);
            this.Controls.Add(this.visitLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "AppointmentVisitUserControl";
            this.Size = new System.Drawing.Size(830, 438);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bodyTemperatureTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox finalDiagnosticTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label addressId;
        private System.Windows.Forms.Label visitLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox dialosticPressureTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox visitDateTextBox;
        private System.Windows.Forms.TextBox nurseTextBox;
        private System.Windows.Forms.TextBox initialDiagnosticTextBox;
        private System.Windows.Forms.TextBox systolicPressureTextBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label initialDiagnosticError;
        private System.Windows.Forms.Label dialosticPressureError;
        private System.Windows.Forms.Label bodyTemperatureError;
        private System.Windows.Forms.Label weightError;
        private System.Windows.Forms.Label systolicPressureError;
        private System.Windows.Forms.Label pulseError;
    }
}
