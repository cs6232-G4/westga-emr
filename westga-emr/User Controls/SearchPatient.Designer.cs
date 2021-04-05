
namespace westga_emr.User_Controls
{
    partial class SearchPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.lnameSearchLabel = new System.Windows.Forms.Label();
            this.fnameSearchLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCriteria = new System.Windows.Forms.ComboBox();
            this.searchCriteriaError = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.firstNameTextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.lastNameTextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePickerSearchInput = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.patientsDatatGrid = new System.Windows.Forms.DataGridView();
            this.contactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewAppointment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentHelperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDatatGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentHelperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Location = new System.Drawing.Point(425, 0);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(205, 17);
            this.dobSearchLabel.TabIndex = 5;
            this.dobSearchLabel.Text = "Date Of Birth:";
            // 
            // lnameSearchLabel
            // 
            this.lnameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnameSearchLabel.AutoSize = true;
            this.lnameSearchLabel.Location = new System.Drawing.Point(214, 0);
            this.lnameSearchLabel.Name = "lnameSearchLabel";
            this.lnameSearchLabel.Size = new System.Drawing.Size(205, 17);
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
            this.fnameSearchLabel.Size = new System.Drawing.Size(205, 17);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 100);
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
            this.tableLayoutPanel14.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(849, 25);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 0);
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
            this.searchCriteria.Location = new System.Drawing.Point(214, 2);
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
            this.searchCriteriaError.Location = new System.Drawing.Point(426, 0);
            this.searchCriteriaError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchCriteriaError.Name = "searchCriteriaError";
            this.searchCriteriaError.Size = new System.Drawing.Size(208, 25);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(847, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // firstNameTextBoxSearchInput
            // 
            this.firstNameTextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBoxSearchInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "FirstName", true));
            this.firstNameTextBoxSearchInput.Location = new System.Drawing.Point(3, 20);
            this.firstNameTextBoxSearchInput.Name = "firstNameTextBoxSearchInput";
            this.firstNameTextBoxSearchInput.Size = new System.Drawing.Size(205, 20);
            this.firstNameTextBoxSearchInput.TabIndex = 1;
            // 
            // lastNameTextBoxSearchInput
            // 
            this.lastNameTextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBoxSearchInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "LastName", true));
            this.lastNameTextBoxSearchInput.Location = new System.Drawing.Point(214, 20);
            this.lastNameTextBoxSearchInput.Name = "lastNameTextBoxSearchInput";
            this.lastNameTextBoxSearchInput.Size = new System.Drawing.Size(205, 20);
            this.lastNameTextBoxSearchInput.TabIndex = 2;
            // 
            // dateOfBirthDateTimePickerSearchInput
            // 
            this.dateOfBirthDateTimePickerSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthDateTimePickerSearchInput.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userDTOBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePickerSearchInput.Location = new System.Drawing.Point(425, 20);
            this.dateOfBirthDateTimePickerSearchInput.MaxDate = new System.DateTime(2021, 3, 22, 0, 0, 0, 0);
            this.dateOfBirthDateTimePickerSearchInput.Name = "dateOfBirthDateTimePickerSearchInput";
            this.dateOfBirthDateTimePickerSearchInput.Size = new System.Drawing.Size(205, 20);
            this.dateOfBirthDateTimePickerSearchInput.TabIndex = 3;
            this.dateOfBirthDateTimePickerSearchInput.Value = new System.DateTime(2021, 3, 22, 0, 0, 0, 0);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchButton.BackColor = System.Drawing.Color.SeaGreen;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(671, 20);
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
            this.tableLayoutPanel13.Size = new System.Drawing.Size(847, 15);
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
            // patientsDatatGrid
            // 
            this.patientsDatatGrid.AllowUserToAddRows = false;
            this.patientsDatatGrid.AllowUserToDeleteRows = false;
            this.patientsDatatGrid.AutoGenerateColumns = false;
            this.patientsDatatGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.patientsDatatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDatatGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.contactPhoneDataGridViewTextBoxColumn,
            this.PatientId,
            this.ViewAppointment});
            this.patientsDatatGrid.DataSource = this.userDTOBindingSource;
            this.patientsDatatGrid.Location = new System.Drawing.Point(0, 106);
            this.patientsDatatGrid.Margin = new System.Windows.Forms.Padding(2);
            this.patientsDatatGrid.MultiSelect = false;
            this.patientsDatatGrid.Name = "patientsDatatGrid";
            this.patientsDatatGrid.ReadOnly = true;
            this.patientsDatatGrid.RowHeadersWidth = 51;
            this.patientsDatatGrid.RowTemplate.Height = 24;
            this.patientsDatatGrid.Size = new System.Drawing.Size(850, 189);
            this.patientsDatatGrid.TabIndex = 10;
            this.patientsDatatGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDatatGrid_CellContentClick);
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "Contact Phone";
            this.contactPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            this.contactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "PatientId";
            this.PatientId.MinimumWidth = 6;
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            this.PatientId.Visible = false;
            this.PatientId.Width = 125;
            // 
            // ViewAppointment
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.ViewAppointment.DefaultCellStyle = dataGridViewCellStyle1;
            this.ViewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewAppointment.HeaderText = "";
            this.ViewAppointment.MinimumWidth = 6;
            this.ViewAppointment.Name = "ViewAppointment";
            this.ViewAppointment.ReadOnly = true;
            this.ViewAppointment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewAppointment.Text = "View Appointment";
            this.ViewAppointment.UseColumnTextForButtonValue = true;
            this.ViewAppointment.Width = 125;
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AllowUserToAddRows = false;
            this.appointmentsDataGridView.AllowUserToDeleteRows = false;
            this.appointmentsDataGridView.AutoGenerateColumns = false;
            this.appointmentsDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorNameDataGridViewTextBoxColumn,
            this.appointmentDateTimeDataGridViewTextBoxColumn,
            this.reasonForVisitDataGridViewTextBoxColumn,
            this.ViewVisit});
            this.appointmentsDataGridView.DataSource = this.appointmentDTOBindingSource;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(0, 299);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersWidth = 51;
            this.appointmentsDataGridView.RowTemplate.Height = 24;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(850, 159);
            this.appointmentsDataGridView.TabIndex = 11;
            this.appointmentsDataGridView.Visible = false;
            this.appointmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDatatGrid_CellContentClick);
            // 
            // ViewVisit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.ViewVisit.DefaultCellStyle = dataGridViewCellStyle2;
            this.ViewVisit.HeaderText = "";
            this.ViewVisit.Name = "ViewVisit";
            this.ViewVisit.ReadOnly = true;
            this.ViewVisit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewVisit.Text = "View Visit";
            this.ViewVisit.UseColumnTextForButtonValue = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentDateTimeDataGridViewTextBoxColumn
            // 
            this.appointmentDateTimeDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDateTime";
            this.appointmentDateTimeDataGridViewTextBoxColumn.HeaderText = "Appointment Date";
            this.appointmentDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentDateTimeDataGridViewTextBoxColumn.Name = "appointmentDateTimeDataGridViewTextBoxColumn";
            this.appointmentDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // reasonForVisitDataGridViewTextBoxColumn
            // 
            this.reasonForVisitDataGridViewTextBoxColumn.DataPropertyName = "ReasonForVisit";
            this.reasonForVisitDataGridViewTextBoxColumn.HeaderText = "Reason For Visit";
            this.reasonForVisitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reasonForVisitDataGridViewTextBoxColumn.Name = "reasonForVisitDataGridViewTextBoxColumn";
            this.reasonForVisitDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonForVisitDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentDTOBindingSource
            // 
            this.appointmentDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.AppointmentDTO);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
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
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.UserDTO);
            // 
            // appointmentHelperBindingSource
            // 
            this.appointmentHelperBindingSource.DataSource = typeof(westga_emr.Helpers.AppointmentHelper);
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.appointmentsDataGridView);
            this.Controls.Add(this.patientsDatatGrid);
            this.Controls.Add(this.searchErrorLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(890, 812);
            this.Name = "SearchPatient";
            this.Size = new System.Drawing.Size(853, 513);
            this.Load += new System.EventHandler(this.SearchPatient_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDatatGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentHelperBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource appointmentHelperBindingSource;
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
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.BindingSource appointmentDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewButtonColumn ViewAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewVisit;
    }
}
