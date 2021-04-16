
namespace westga_emr.User_Controls
{
    partial class TestsUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCriteria = new System.Windows.Forms.ComboBox();
            this.searchCriteriaError = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.firstNameTextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.fnameSearchLabel = new System.Windows.Forms.Label();
            this.lastNameTextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.lnameSearchLabel = new System.Windows.Forms.Label();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePickerSearchInput = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.visitsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDiagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDiagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewTests = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OrderTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.visitDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsDatatGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewVisits = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitForLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testsDataGrid = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterTestResults = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labOrderTestDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDatatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labOrderTestDTOBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 100);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.tableLayoutPanel14.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1110, 25);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 0);
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
            this.searchCriteria.Location = new System.Drawing.Point(279, 2);
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
            this.searchCriteriaError.Location = new System.Drawing.Point(556, 0);
            this.searchCriteriaError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchCriteriaError.MaximumSize = new System.Drawing.Size(890, 812);
            this.searchCriteriaError.Name = "searchCriteriaError";
            this.searchCriteriaError.Size = new System.Drawing.Size(273, 25);
            this.searchCriteriaError.TabIndex = 2;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1108, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // firstNameTextBoxSearchInput
            // 
            this.firstNameTextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBoxSearchInput.Location = new System.Drawing.Point(3, 20);
            this.firstNameTextBoxSearchInput.Name = "firstNameTextBoxSearchInput";
            this.firstNameTextBoxSearchInput.Size = new System.Drawing.Size(271, 20);
            this.firstNameTextBoxSearchInput.TabIndex = 1;
            // 
            // fnameSearchLabel
            // 
            this.fnameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fnameSearchLabel.AutoSize = true;
            this.fnameSearchLabel.Location = new System.Drawing.Point(3, 0);
            this.fnameSearchLabel.Name = "fnameSearchLabel";
            this.fnameSearchLabel.Size = new System.Drawing.Size(271, 17);
            this.fnameSearchLabel.TabIndex = 5;
            this.fnameSearchLabel.Text = "First Name:";
            // 
            // lastNameTextBoxSearchInput
            // 
            this.lastNameTextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBoxSearchInput.Location = new System.Drawing.Point(280, 20);
            this.lastNameTextBoxSearchInput.Name = "lastNameTextBoxSearchInput";
            this.lastNameTextBoxSearchInput.Size = new System.Drawing.Size(271, 20);
            this.lastNameTextBoxSearchInput.TabIndex = 2;
            // 
            // lnameSearchLabel
            // 
            this.lnameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnameSearchLabel.AutoSize = true;
            this.lnameSearchLabel.Location = new System.Drawing.Point(280, 0);
            this.lnameSearchLabel.Name = "lnameSearchLabel";
            this.lnameSearchLabel.Size = new System.Drawing.Size(271, 17);
            this.lnameSearchLabel.TabIndex = 5;
            this.lnameSearchLabel.Text = "Last Name:";
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Location = new System.Drawing.Point(557, 0);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(271, 17);
            this.dobSearchLabel.TabIndex = 5;
            this.dobSearchLabel.Text = "Date Of Birth:";
            // 
            // dateOfBirthDateTimePickerSearchInput
            // 
            this.dateOfBirthDateTimePickerSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthDateTimePickerSearchInput.Location = new System.Drawing.Point(557, 20);
            this.dateOfBirthDateTimePickerSearchInput.MaxDate = new System.DateTime(2021, 3, 22, 0, 0, 0, 0);
            this.dateOfBirthDateTimePickerSearchInput.Name = "dateOfBirthDateTimePickerSearchInput";
            this.dateOfBirthDateTimePickerSearchInput.Size = new System.Drawing.Size(271, 20);
            this.dateOfBirthDateTimePickerSearchInput.TabIndex = 3;
            this.dateOfBirthDateTimePickerSearchInput.Value = new System.DateTime(2021, 3, 22, 0, 0, 0, 0);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchButton.BackColor = System.Drawing.Color.SeaGreen;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(901, 20);
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
            this.tableLayoutPanel13.Controls.Add(this.searchErrorLabel, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1108, 15);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchErrorLabel.Location = new System.Drawing.Point(3, 0);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(1102, 15);
            this.searchErrorLabel.TabIndex = 0;
            // 
            // visitsDataGridView
            // 
            this.visitsDataGridView.AllowUserToAddRows = false;
            this.visitsDataGridView.AllowUserToDeleteRows = false;
            this.visitsDataGridView.AutoGenerateColumns = false;
            this.visitsDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.visitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nurseDataGridViewTextBoxColumn,
            this.VisitReason,
            this.AppointmentDateTime,
            this.visitDateTimeDataGridViewTextBoxColumn,
            this.initialDiagnosisDataGridViewTextBoxColumn,
            this.symptomsDataGridViewTextBoxColumn,
            this.finalDiagnosisDataGridViewTextBoxColumn,
            this.ViewTests,
            this.OrderTest});
            this.visitsDataGridView.DataSource = this.visitDTOBindingSource;
            this.visitsDataGridView.Location = new System.Drawing.Point(-2, 303);
            this.visitsDataGridView.Name = "visitsDataGridView";
            this.visitsDataGridView.ReadOnly = true;
            this.visitsDataGridView.Size = new System.Drawing.Size(1114, 345);
            this.visitsDataGridView.TabIndex = 3;
            this.visitsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitsDatatGrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Visit ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // nurseDataGridViewTextBoxColumn
            // 
            this.nurseDataGridViewTextBoxColumn.DataPropertyName = "Nurse";
            this.nurseDataGridViewTextBoxColumn.HeaderText = "Nurse";
            this.nurseDataGridViewTextBoxColumn.Name = "nurseDataGridViewTextBoxColumn";
            this.nurseDataGridViewTextBoxColumn.ReadOnly = true;
            this.nurseDataGridViewTextBoxColumn.Width = 150;
            // 
            // VisitReason
            // 
            this.VisitReason.DataPropertyName = "VisitReason";
            this.VisitReason.HeaderText = "Visit Reason";
            this.VisitReason.Name = "VisitReason";
            this.VisitReason.ReadOnly = true;
            this.VisitReason.Width = 150;
            // 
            // AppointmentDateTime
            // 
            this.AppointmentDateTime.DataPropertyName = "AppointmentDateTime";
            this.AppointmentDateTime.HeaderText = "Appointment Date & Time";
            this.AppointmentDateTime.Name = "AppointmentDateTime";
            this.AppointmentDateTime.ReadOnly = true;
            // 
            // visitDateTimeDataGridViewTextBoxColumn
            // 
            this.visitDateTimeDataGridViewTextBoxColumn.DataPropertyName = "VisitDateTime";
            this.visitDateTimeDataGridViewTextBoxColumn.HeaderText = "Visit Date & Time";
            this.visitDateTimeDataGridViewTextBoxColumn.Name = "visitDateTimeDataGridViewTextBoxColumn";
            this.visitDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialDiagnosisDataGridViewTextBoxColumn
            // 
            this.initialDiagnosisDataGridViewTextBoxColumn.DataPropertyName = "InitialDiagnosis";
            this.initialDiagnosisDataGridViewTextBoxColumn.HeaderText = "Initial Diagnosis";
            this.initialDiagnosisDataGridViewTextBoxColumn.Name = "initialDiagnosisDataGridViewTextBoxColumn";
            this.initialDiagnosisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // symptomsDataGridViewTextBoxColumn
            // 
            this.symptomsDataGridViewTextBoxColumn.DataPropertyName = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.HeaderText = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.Name = "symptomsDataGridViewTextBoxColumn";
            this.symptomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalDiagnosisDataGridViewTextBoxColumn
            // 
            this.finalDiagnosisDataGridViewTextBoxColumn.DataPropertyName = "FinalDiagnosis";
            this.finalDiagnosisDataGridViewTextBoxColumn.HeaderText = "Final Diagnosis";
            this.finalDiagnosisDataGridViewTextBoxColumn.Name = "finalDiagnosisDataGridViewTextBoxColumn";
            this.finalDiagnosisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewTests
            // 
            this.ViewTests.HeaderText = "";
            this.ViewTests.Name = "ViewTests";
            this.ViewTests.ReadOnly = true;
            this.ViewTests.Text = "View Tests";
            this.ViewTests.UseColumnTextForButtonValue = true;
            // 
            // OrderTest
            // 
            this.OrderTest.HeaderText = "";
            this.OrderTest.Name = "OrderTest";
            this.OrderTest.ReadOnly = true;
            this.OrderTest.Text = "Order Test";
            this.OrderTest.UseColumnTextForButtonValue = true;
            // 
            // visitDTOBindingSource
            // 
            this.visitDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.VisitDTO);
            // 
            // patientsDatatGrid
            // 
            this.patientsDatatGrid.AllowUserToAddRows = false;
            this.patientsDatatGrid.AllowUserToDeleteRows = false;
            this.patientsDatatGrid.AutoGenerateColumns = false;
            this.patientsDatatGrid.BackgroundColor = System.Drawing.Color.LightCyan;
            this.patientsDatatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDatatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactPhoneDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.ViewVisits});
            this.patientsDatatGrid.DataSource = this.userDTOBindingSource;
            this.patientsDatatGrid.Location = new System.Drawing.Point(0, 100);
            this.patientsDatatGrid.Name = "patientsDatatGrid";
            this.patientsDatatGrid.ReadOnly = true;
            this.patientsDatatGrid.Size = new System.Drawing.Size(1114, 197);
            this.patientsDatatGrid.TabIndex = 5;
            this.patientsDatatGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDatatGrid_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "ContactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            this.contactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewVisits
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.ViewVisits.DefaultCellStyle = dataGridViewCellStyle1;
            this.ViewVisits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewVisits.HeaderText = "";
            this.ViewVisits.Name = "ViewVisits";
            this.ViewVisits.ReadOnly = true;
            this.ViewVisits.Text = "View Visits";
            this.ViewVisits.UseColumnTextForButtonValue = true;
            this.ViewVisits.Width = 150;
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.UserDTO);
            // 
            // visitForLabel
            // 
            this.visitForLabel.AutoSize = true;
            this.visitForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitForLabel.Location = new System.Drawing.Point(519, 416);
            this.visitForLabel.Name = "visitForLabel";
            this.visitForLabel.Size = new System.Drawing.Size(0, 18);
            this.visitForLabel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.testsDataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 665);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 450);
            this.panel1.TabIndex = 7;
            // 
            // testsDataGrid
            // 
            this.testsDataGrid.AllowUserToAddRows = false;
            this.testsDataGrid.AllowUserToDeleteRows = false;
            this.testsDataGrid.AutoGenerateColumns = false;
            this.testsDataGrid.BackgroundColor = System.Drawing.Color.OldLace;
            this.testsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.visitIdDataGridViewTextBoxColumn,
            this.testNameDataGridViewTextBoxColumn,
            this.testResultDataGridViewTextBoxColumn,
            this.orderedDateDataGridViewTextBoxColumn,
            this.testDateDataGridViewTextBoxColumn,
            this.testCodeDataGridViewTextBoxColumn,
            this.EnterTestResults});
            this.testsDataGrid.DataSource = this.labOrderTestDTOBindingSource;
            this.testsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.testsDataGrid.Name = "testsDataGrid";
            this.testsDataGrid.ReadOnly = true;
            this.testsDataGrid.Size = new System.Drawing.Size(1114, 450);
            this.testsDataGrid.TabIndex = 0;
            this.testsDataGrid.Visible = false;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Lab Order Id";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitIdDataGridViewTextBoxColumn
            // 
            this.visitIdDataGridViewTextBoxColumn.DataPropertyName = "VisitId";
            this.visitIdDataGridViewTextBoxColumn.HeaderText = "Visit Id";
            this.visitIdDataGridViewTextBoxColumn.Name = "visitIdDataGridViewTextBoxColumn";
            this.visitIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testNameDataGridViewTextBoxColumn
            // 
            this.testNameDataGridViewTextBoxColumn.DataPropertyName = "TestName";
            this.testNameDataGridViewTextBoxColumn.HeaderText = "Test Name";
            this.testNameDataGridViewTextBoxColumn.Name = "testNameDataGridViewTextBoxColumn";
            this.testNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.testNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // testResultDataGridViewTextBoxColumn
            // 
            this.testResultDataGridViewTextBoxColumn.DataPropertyName = "TestResult";
            this.testResultDataGridViewTextBoxColumn.HeaderText = "Test Result";
            this.testResultDataGridViewTextBoxColumn.Name = "testResultDataGridViewTextBoxColumn";
            this.testResultDataGridViewTextBoxColumn.ReadOnly = true;
            this.testResultDataGridViewTextBoxColumn.Width = 300;
            // 
            // orderedDateDataGridViewTextBoxColumn
            // 
            this.orderedDateDataGridViewTextBoxColumn.DataPropertyName = "OrderedDate";
            this.orderedDateDataGridViewTextBoxColumn.HeaderText = "Date Ordered";
            this.orderedDateDataGridViewTextBoxColumn.Name = "orderedDateDataGridViewTextBoxColumn";
            this.orderedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testDateDataGridViewTextBoxColumn
            // 
            this.testDateDataGridViewTextBoxColumn.DataPropertyName = "TestDate";
            this.testDateDataGridViewTextBoxColumn.HeaderText = "Test Date";
            this.testDateDataGridViewTextBoxColumn.Name = "testDateDataGridViewTextBoxColumn";
            this.testDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testCodeDataGridViewTextBoxColumn
            // 
            this.testCodeDataGridViewTextBoxColumn.DataPropertyName = "TestCode";
            this.testCodeDataGridViewTextBoxColumn.HeaderText = "Test Code";
            this.testCodeDataGridViewTextBoxColumn.Name = "testCodeDataGridViewTextBoxColumn";
            this.testCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.testCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // EnterTestResults
            // 
            this.EnterTestResults.HeaderText = "";
            this.EnterTestResults.Name = "EnterTestResults";
            this.EnterTestResults.ReadOnly = true;
            this.EnterTestResults.Text = "Enter Test Result";
            this.EnterTestResults.UseColumnTextForButtonValue = true;
            this.EnterTestResults.Width = 150;
            // 
            // labOrderTestDTOBindingSource
            // 
            this.labOrderTestDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.LabOrderTestDTO);
            // 
            // TestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.visitForLabel);
            this.Controls.Add(this.patientsDatatGrid);
            this.Controls.Add(this.visitsDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestsUserControl";
            this.Size = new System.Drawing.Size(1114, 1115);
            this.Load += new System.EventHandler(this.TestsUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDatatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labOrderTestDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchCriteria;
        private System.Windows.Forms.Label searchCriteriaError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox firstNameTextBoxSearchInput;
        private System.Windows.Forms.Label fnameSearchLabel;
        private System.Windows.Forms.TextBox lastNameTextBoxSearchInput;
        private System.Windows.Forms.Label lnameSearchLabel;
        private System.Windows.Forms.Label dobSearchLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePickerSearchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.DataGridView visitsDataGridView;
        private System.Windows.Forms.Label searchErrorLabel;
        private System.Windows.Forms.DataGridView patientsDatatGrid;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewVisits;
        private System.Windows.Forms.Label visitForLabel;
        private System.Windows.Forms.BindingSource visitDTOBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView testsDataGrid;
        private System.Windows.Forms.BindingSource labOrderTestDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDiagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDiagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewTests;
        private System.Windows.Forms.DataGridViewButtonColumn OrderTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EnterTestResults;
    }
}
