
namespace westga_emr.User_Controls
{
    partial class NewAppointment
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.lnameSearchLabel = new System.Windows.Forms.Label();
            this.fnameSearchLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCriteria = new System.Windows.Forms.ComboBox();
            this.searchCriteriaError = new System.Windows.Forms.Label();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.firstNameTextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePickerSearchInput = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.appointmentHelperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.appointmentDateError = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.appointmentDate = new System.Windows.Forms.DateTimePicker();
            this.appointmentTime = new System.Windows.Forms.ComboBox();
            this.appointmentVisitReason = new System.Windows.Forms.RichTextBox();
            this.reasonForVisitError = new System.Windows.Forms.Label();
            this.visitReasonError = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.doctorListComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorListError = new System.Windows.Forms.Label();
            this.patientsDatatGrid = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAppointment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditPatient = new System.Windows.Forms.DataGridViewButtonColumn();
            this.appointmentInformationSection = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentHelperBindingSource)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDatatGrid)).BeginInit();
            this.appointmentInformationSection.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(305, 13);
            label2.TabIndex = 7;
            label2.Text = "Appointment Date and Time*";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(314, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(722, 13);
            label4.TabIndex = 7;
            label4.Text = "Reason for visit*";
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Location = new System.Drawing.Point(519, 0);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(252, 17);
            this.dobSearchLabel.TabIndex = 5;
            this.dobSearchLabel.Text = "Date Of Birth:";
            // 
            // lnameSearchLabel
            // 
            this.lnameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnameSearchLabel.AutoSize = true;
            this.lnameSearchLabel.Location = new System.Drawing.Point(261, 0);
            this.lnameSearchLabel.Name = "lnameSearchLabel";
            this.lnameSearchLabel.Size = new System.Drawing.Size(252, 17);
            this.lnameSearchLabel.TabIndex = 5;
            this.lnameSearchLabel.Text = "Last Name:";
            // 
            // fnameSearchLabel
            // 
            this.fnameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fnameSearchLabel.AutoSize = true;
            this.fnameSearchLabel.Location = new System.Drawing.Point(3, 0);
            this.fnameSearchLabel.Name = "fnameSearchLabel";
            this.fnameSearchLabel.Size = new System.Drawing.Size(252, 17);
            this.fnameSearchLabel.TabIndex = 5;
            this.fnameSearchLabel.Text = "First Name:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel13, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.1134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.8866F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.searchCriteria, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.searchCriteriaError, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.addPatientButton, 3, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1035, 25);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Patient By:";
            // 
            // searchCriteria
            // 
            this.searchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCriteria.FormattingEnabled = true;
            this.searchCriteria.Items.AddRange(new object[] {
            "Date of Birth",
            "Last name and first name",
            "Date of birth and last name"});
            this.searchCriteria.Location = new System.Drawing.Point(260, 2);
            this.searchCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.searchCriteria.Name = "searchCriteria";
            this.searchCriteria.Size = new System.Drawing.Size(207, 21);
            this.searchCriteria.TabIndex = 1;
            this.searchCriteria.SelectedIndexChanged += new System.EventHandler(this.SearchCriteria_SelectedIndexChanged);
            // 
            // searchCriteriaError
            // 
            this.searchCriteriaError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCriteriaError.AutoSize = true;
            this.searchCriteriaError.ForeColor = System.Drawing.Color.Red;
            this.searchCriteriaError.Location = new System.Drawing.Point(518, 0);
            this.searchCriteriaError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchCriteriaError.Name = "searchCriteriaError";
            this.searchCriteriaError.Size = new System.Drawing.Size(254, 25);
            this.searchCriteriaError.TabIndex = 2;
            // 
            // addPatientButton
            // 
            this.addPatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addPatientButton.BackColor = System.Drawing.Color.SeaGreen;
            this.addPatientButton.ForeColor = System.Drawing.Color.White;
            this.addPatientButton.Location = new System.Drawing.Point(834, 2);
            this.addPatientButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(140, 21);
            this.addPatientButton.TabIndex = 3;
            this.addPatientButton.Text = "Add New Patient";
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.firstNameTextBoxSearchInput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fnameSearchLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lastNameTextBoxSearchInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lnameSearchLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dobSearchLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateOfBirthDateTimePickerSearchInput, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1033, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // firstNameTextBoxSearchInput
            // 
            this.firstNameTextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBoxSearchInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "FirstName", true));
            this.firstNameTextBoxSearchInput.Location = new System.Drawing.Point(3, 20);
            this.firstNameTextBoxSearchInput.Name = "firstNameTextBoxSearchInput";
            this.firstNameTextBoxSearchInput.Size = new System.Drawing.Size(252, 20);
            this.firstNameTextBoxSearchInput.TabIndex = 1;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.UserDTO);
            // 
            // lastNameTextBoxSearchInput
            // 
            this.lastNameTextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBoxSearchInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "LastName", true));
            this.lastNameTextBoxSearchInput.Location = new System.Drawing.Point(261, 20);
            this.lastNameTextBoxSearchInput.Name = "lastNameTextBoxSearchInput";
            this.lastNameTextBoxSearchInput.Size = new System.Drawing.Size(252, 20);
            this.lastNameTextBoxSearchInput.TabIndex = 2;
            // 
            // dateOfBirthDateTimePickerSearchInput
            // 
            this.dateOfBirthDateTimePickerSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthDateTimePickerSearchInput.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userDTOBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePickerSearchInput.Location = new System.Drawing.Point(519, 20);
            this.dateOfBirthDateTimePickerSearchInput.MaxDate = new System.DateTime(2021, 3, 22, 0, 0, 0, 0);
            this.dateOfBirthDateTimePickerSearchInput.Name = "dateOfBirthDateTimePickerSearchInput";
            this.dateOfBirthDateTimePickerSearchInput.Size = new System.Drawing.Size(252, 20);
            this.dateOfBirthDateTimePickerSearchInput.TabIndex = 3;
            this.dateOfBirthDateTimePickerSearchInput.Value = new System.DateTime(2021, 3, 22, 0, 0, 0, 0);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchButton.BackColor = System.Drawing.Color.SeaGreen;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(835, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(137, 21);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1033, 15);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchErrorLabel.Location = new System.Drawing.Point(6, 85);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.searchErrorLabel.TabIndex = 0;
            // 
            // appointmentHelperBindingSource
            // 
            this.appointmentHelperBindingSource.DataSource = typeof(westga_emr.Helpers.AppointmentHelper);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Controls.Add(label2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(label4, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.appointmentDateError, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.appointmentVisitReason, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.reasonForVisitError, 1, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.71223F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.86331F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1039, 113);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // appointmentDateError
            // 
            this.appointmentDateError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDateError.AutoSize = true;
            this.appointmentDateError.ForeColor = System.Drawing.Color.Red;
            this.appointmentDateError.Location = new System.Drawing.Point(3, 89);
            this.appointmentDateError.Name = "appointmentDateError";
            this.appointmentDateError.Size = new System.Drawing.Size(305, 24);
            this.appointmentDateError.TabIndex = 9;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.appointmentDate, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.appointmentTime, 0, 1);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(302, 60);
            this.tableLayoutPanel10.TabIndex = 13;
            // 
            // appointmentDate
            // 
            this.appointmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDate.Location = new System.Drawing.Point(3, 3);
            this.appointmentDate.MinDate = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            this.appointmentDate.Name = "appointmentDate";
            this.appointmentDate.Size = new System.Drawing.Size(296, 20);
            this.appointmentDate.TabIndex = 14;
            this.appointmentDate.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            this.appointmentDate.ValueChanged += new System.EventHandler(this.AppointmentDate_ValueChanged);
            // 
            // appointmentTime
            // 
            this.appointmentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentTime.DataSource = this.appointmentHelperBindingSource;
            this.appointmentTime.DisplayMember = "Title";
            this.appointmentTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appointmentTime.Enabled = false;
            this.appointmentTime.FormattingEnabled = true;
            this.appointmentTime.Location = new System.Drawing.Point(3, 33);
            this.appointmentTime.Name = "appointmentTime";
            this.appointmentTime.Size = new System.Drawing.Size(296, 21);
            this.appointmentTime.TabIndex = 15;
            this.appointmentTime.ValueMember = "Value";
            this.appointmentTime.SelectedIndexChanged += new System.EventHandler(this.AppointmentTime_SelectedIndexChanged);
            // 
            // appointmentVisitReason
            // 
            this.appointmentVisitReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentVisitReason.Location = new System.Drawing.Point(314, 28);
            this.appointmentVisitReason.Name = "appointmentVisitReason";
            this.appointmentVisitReason.Size = new System.Drawing.Size(722, 55);
            this.appointmentVisitReason.TabIndex = 16;
            this.appointmentVisitReason.Text = "";
            this.appointmentVisitReason.TextChanged += new System.EventHandler(this.AppointmentVisitReason_TextChanged);
            // 
            // reasonForVisitError
            // 
            this.reasonForVisitError.AutoSize = true;
            this.reasonForVisitError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonForVisitError.ForeColor = System.Drawing.Color.Red;
            this.reasonForVisitError.Location = new System.Drawing.Point(314, 89);
            this.reasonForVisitError.Name = "reasonForVisitError";
            this.reasonForVisitError.Size = new System.Drawing.Size(722, 24);
            this.reasonForVisitError.TabIndex = 17;
            // 
            // visitReasonError
            // 
            this.visitReasonError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitReasonError.AutoSize = true;
            this.visitReasonError.ForeColor = System.Drawing.Color.Red;
            this.visitReasonError.Location = new System.Drawing.Point(256, 199);
            this.visitReasonError.Name = "visitReasonError";
            this.visitReasonError.Size = new System.Drawing.Size(0, 13);
            this.visitReasonError.TabIndex = 10;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 219);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1037, 100);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.clearButton, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.submitButton, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1031, 43);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(437, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(518, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 37);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59184F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.40816F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.doctorListError, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1031, 45);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.doctorListComboBox, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.77778F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.22222F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(299, 39);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // doctorListComboBox
            // 
            this.doctorListComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorListComboBox.DataSource = this.userDTOBindingSource;
            this.doctorListComboBox.DisplayMember = "FullName";
            this.doctorListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorListComboBox.FormattingEnabled = true;
            this.doctorListComboBox.Location = new System.Drawing.Point(3, 17);
            this.doctorListComboBox.Name = "doctorListComboBox";
            this.doctorListComboBox.Size = new System.Drawing.Size(293, 21);
            this.doctorListComboBox.TabIndex = 17;
            this.doctorListComboBox.ValueMember = "DoctorId";
            this.doctorListComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorListComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Available Doctors*:";
            // 
            // doctorListError
            // 
            this.doctorListError.AutoSize = true;
            this.doctorListError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doctorListError.ForeColor = System.Drawing.Color.Red;
            this.doctorListError.Location = new System.Drawing.Point(308, 27);
            this.doctorListError.Name = "doctorListError";
            this.doctorListError.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.doctorListError.Size = new System.Drawing.Size(720, 18);
            this.doctorListError.TabIndex = 3;
            // 
            // patientsDatatGrid
            // 
            this.patientsDatatGrid.AllowUserToAddRows = false;
            this.patientsDatatGrid.AllowUserToDeleteRows = false;
            this.patientsDatatGrid.AutoGenerateColumns = false;
            this.patientsDatatGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.patientsDatatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDatatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.CreateAppointment,
            this.EditPatient});
            this.patientsDatatGrid.DataSource = this.userDTOBindingSource;
            this.patientsDatatGrid.Location = new System.Drawing.Point(0, 106);
            this.patientsDatatGrid.Margin = new System.Windows.Forms.Padding(2);
            this.patientsDatatGrid.MultiSelect = false;
            this.patientsDatatGrid.Name = "patientsDatatGrid";
            this.patientsDatatGrid.ReadOnly = true;
            this.patientsDatatGrid.RowHeadersWidth = 51;
            this.patientsDatatGrid.RowTemplate.Height = 24;
            this.patientsDatatGrid.Size = new System.Drawing.Size(1039, 189);
            this.patientsDatatGrid.TabIndex = 10;
            this.patientsDatatGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDatatGrid_CellContentClick);
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "Id";
            this.PatientId.MinimumWidth = 6;
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            this.PatientId.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // CreateAppointment
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.CreateAppointment.DefaultCellStyle = dataGridViewCellStyle1;
            this.CreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateAppointment.HeaderText = "";
            this.CreateAppointment.MinimumWidth = 6;
            this.CreateAppointment.Name = "CreateAppointment";
            this.CreateAppointment.ReadOnly = true;
            this.CreateAppointment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CreateAppointment.Text = "New Appointment";
            this.CreateAppointment.UseColumnTextForButtonValue = true;
            this.CreateAppointment.Width = 125;
            // 
            // EditPatient
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.EditPatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.EditPatient.HeaderText = "";
            this.EditPatient.MinimumWidth = 6;
            this.EditPatient.Name = "EditPatient";
            this.EditPatient.ReadOnly = true;
            this.EditPatient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditPatient.Text = "Edit Patient";
            this.EditPatient.UseColumnTextForButtonValue = true;
            this.EditPatient.Width = 125;
            // 
            // appointmentInformationSection
            // 
            this.appointmentInformationSection.BackColor = System.Drawing.Color.AliceBlue;
            this.appointmentInformationSection.Controls.Add(this.tableLayoutPanel3);
            this.appointmentInformationSection.Controls.Add(this.label5);
            this.appointmentInformationSection.Controls.Add(this.visitReasonError);
            this.appointmentInformationSection.Controls.Add(this.tableLayoutPanel6);
            this.appointmentInformationSection.Controls.Add(this.tableLayoutPanel7);
            this.appointmentInformationSection.Location = new System.Drawing.Point(0, 314);
            this.appointmentInformationSection.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentInformationSection.Name = "appointmentInformationSection";
            this.appointmentInformationSection.Size = new System.Drawing.Size(1039, 335);
            this.appointmentInformationSection.TabIndex = 11;
            this.appointmentInformationSection.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.firstNameLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lastNameLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.genderLabel, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dobLabel, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1039, 60);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "First name";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last name";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(779, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Date of Birth";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(2, 38);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(255, 13);
            this.firstNameLabel.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(261, 38);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(255, 13);
            this.lastNameLabel.TabIndex = 5;
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(520, 38);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(255, 13);
            this.genderLabel.TabIndex = 6;
            // 
            // dobLabel
            // 
            this.dobLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(779, 38);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(258, 13);
            this.dobLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Appointment Information";
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.appointmentInformationSection);
            this.Controls.Add(this.patientsDatatGrid);
            this.Controls.Add(this.searchErrorLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1100, 850);
            this.Name = "NewAppointment";
            this.Size = new System.Drawing.Size(1039, 750);
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentHelperBindingSource)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDatatGrid)).EndInit();
            this.appointmentInformationSection.ResumeLayout(false);
            this.appointmentInformationSection.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBoxSearchInput;
        private System.Windows.Forms.TextBox lastNameTextBoxSearchInput;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePickerSearchInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label visitReasonError;
        private System.Windows.Forms.DateTimePicker appointmentDate;
        private System.Windows.Forms.RichTextBox appointmentVisitReason;
        private System.Windows.Forms.Label appointmentDateError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox doctorListComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.ComboBox appointmentTime;
        private System.Windows.Forms.BindingSource appointmentHelperBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label searchErrorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchCriteria;
        private System.Windows.Forms.Label searchCriteriaError;
        private System.Windows.Forms.Label dobSearchLabel;
        private System.Windows.Forms.Label lnameSearchLabel;
        private System.Windows.Forms.Label fnameSearchLabel;
        private System.Windows.Forms.DataGridView patientsDatatGrid;
        private System.Windows.Forms.Panel appointmentInformationSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CreateAppointment;
        private System.Windows.Forms.DataGridViewButtonColumn EditPatient;
        private System.Windows.Forms.Label doctorListError;
        private System.Windows.Forms.Label reasonForVisitError;
    }
}
