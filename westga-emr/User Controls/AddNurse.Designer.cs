
namespace westga_emr.User_Controls
{
    partial class AddNurse
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label contactPhoneLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityError = new System.Windows.Forms.Label();
            this.stateError = new System.Windows.Forms.Label();
            this.zipCodeError = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.addNewPatientLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.addressId = new System.Windows.Forms.Label();
            this.contactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameError = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.Label();
            this.dobError = new System.Windows.Forms.Label();
            this.contactPhoneError = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.genderError = new System.Windows.Forms.Label();
            this.streetError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.ssnError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passwordViewer = new System.Windows.Forms.PictureBox();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentHelperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cityLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            contactPhoneLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentHelperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(3, 7);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(367, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City*";
            // 
            // zipLabel
            // 
            zipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(749, 7);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(368, 13);
            zipLabel.TabIndex = 7;
            zipLabel.Text = "Zip*";
            // 
            // stateLabel
            // 
            stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(376, 7);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(367, 13);
            stateLabel.TabIndex = 7;
            stateLabel.Text = "State*";
            // 
            // streetLabel
            // 
            streetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(749, 7);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(368, 13);
            streetLabel.TabIndex = 6;
            streetLabel.Text = "Street*";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(376, 7);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(367, 13);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender*";
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new System.Drawing.Point(3, 7);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new System.Drawing.Size(367, 13);
            contactPhoneLabel.TabIndex = 6;
            contactPhoneLabel.Text = "Contact Phone*";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(749, 12);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(368, 13);
            dateOfBirthLabel.TabIndex = 5;
            dateOfBirthLabel.Text = "Date Of Birth*";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(376, 12);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(367, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name*";
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(3, 12);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(367, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name*";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(376, 12);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(367, 13);
            usernameLabel.TabIndex = 30;
            usernameLabel.Text = "Username*";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(749, 12);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(368, 13);
            passwordLabel.TabIndex = 30;
            passwordLabel.Text = "Password*";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(cityLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(zipLabel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.stateComboBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.zipTextBox, 2, 1);
            this.tableLayoutPanel4.Controls.Add(stateLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cityTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cityError, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.stateError, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.zipCodeError, 2, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 283);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1120, 100);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // stateComboBox
            // 
            this.stateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stateComboBox.DataSource = this.appointmentHelperBindingSource;
            this.stateComboBox.DisplayMember = "Title";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(376, 39);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(367, 21);
            this.stateComboBox.TabIndex = 12;
            this.stateComboBox.ValueMember = "Value";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.zipTextBox.Location = new System.Drawing.Point(749, 40);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(368, 20);
            this.zipTextBox.TabIndex = 13;
            this.zipTextBox.TextChanged += new System.EventHandler(this.ZipTextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cityTextBox.Location = new System.Drawing.Point(3, 40);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(367, 20);
            this.cityTextBox.TabIndex = 11;
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // cityError
            // 
            this.cityError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityError.AutoSize = true;
            this.cityError.ForeColor = System.Drawing.Color.Red;
            this.cityError.Location = new System.Drawing.Point(3, 80);
            this.cityError.Name = "cityError";
            this.cityError.Size = new System.Drawing.Size(367, 20);
            this.cityError.TabIndex = 9;
            // 
            // stateError
            // 
            this.stateError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateError.AutoSize = true;
            this.stateError.ForeColor = System.Drawing.Color.Red;
            this.stateError.Location = new System.Drawing.Point(376, 80);
            this.stateError.Name = "stateError";
            this.stateError.Size = new System.Drawing.Size(367, 20);
            this.stateError.TabIndex = 10;
            // 
            // zipCodeError
            // 
            this.zipCodeError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zipCodeError.AutoSize = true;
            this.zipCodeError.ForeColor = System.Drawing.Color.Red;
            this.zipCodeError.Location = new System.Drawing.Point(749, 80);
            this.zipCodeError.Name = "zipCodeError";
            this.zipCodeError.Size = new System.Drawing.Size(368, 20);
            this.zipCodeError.TabIndex = 11;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.streetTextBox.Location = new System.Drawing.Point(749, 40);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(368, 20);
            this.streetTextBox.TabIndex = 10;
            this.streetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SSN:";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ssnTextBox.Location = new System.Drawing.Point(3, 40);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(367, 20);
            this.ssnTextBox.TabIndex = 18;
            this.ssnTextBox.TextChanged += new System.EventHandler(this.SsnTextBox_TextChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.clearButton, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.submitButton, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 568);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1120, 282);
            this.tableLayoutPanel9.TabIndex = 24;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(482, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(563, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 37);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Save";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // addNewPatientLabel
            // 
            this.addNewPatientLabel.AutoSize = true;
            this.addNewPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPatientLabel.Location = new System.Drawing.Point(493, 21);
            this.addNewPatientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewPatientLabel.Name = "addNewPatientLabel";
            this.addNewPatientLabel.Size = new System.Drawing.Size(84, 20);
            this.addNewPatientLabel.TabIndex = 25;
            this.addNewPatientLabel.Text = "Add Nurse";
            this.addNewPatientLabel.Visible = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.DataSource = this.appointmentHelperBindingSource;
            this.genderComboBox.DisplayMember = "Title";
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(376, 39);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(367, 21);
            this.genderComboBox.TabIndex = 9;
            this.genderComboBox.ValueMember = "Value";
            // 
            // addressId
            // 
            this.addressId.AutoSize = true;
            this.addressId.Location = new System.Drawing.Point(89, 26);
            this.addressId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressId.Name = "addressId";
            this.addressId.Size = new System.Drawing.Size(0, 13);
            this.addressId.TabIndex = 28;
            this.addressId.Visible = false;
            // 
            // contactPhoneTextBox
            // 
            this.contactPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contactPhoneTextBox.Location = new System.Drawing.Point(3, 40);
            this.contactPhoneTextBox.Name = "contactPhoneTextBox";
            this.contactPhoneTextBox.Size = new System.Drawing.Size(367, 20);
            this.contactPhoneTextBox.TabIndex = 8;
            this.contactPhoneTextBox.TextChanged += new System.EventHandler(this.ContactPhoneTextBox_TextChanged);
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(749, 40);
            this.dateOfBirthDateTimePicker.MaxDate = new System.DateTime(2021, 3, 21, 7, 5, 30, 0);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(368, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 7;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.dateOfBirthDateTimePicker, 2, 1);
            this.tableLayoutPanel5.Controls.Add(dateOfBirthLabel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lastNameTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(lastNameLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.firstNameTextBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(firstNameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.firstnameError, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lastNameError, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.dobError, 2, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1120, 100);
            this.tableLayoutPanel5.TabIndex = 21;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Location = new System.Drawing.Point(376, 40);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(367, 20);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Location = new System.Drawing.Point(3, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(367, 20);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // firstnameError
            // 
            this.firstnameError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameError.AutoSize = true;
            this.firstnameError.ForeColor = System.Drawing.Color.Red;
            this.firstnameError.Location = new System.Drawing.Point(3, 75);
            this.firstnameError.Name = "firstnameError";
            this.firstnameError.Size = new System.Drawing.Size(367, 25);
            this.firstnameError.TabIndex = 7;
            // 
            // lastNameError
            // 
            this.lastNameError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameError.AutoSize = true;
            this.lastNameError.ForeColor = System.Drawing.Color.Red;
            this.lastNameError.Location = new System.Drawing.Point(376, 75);
            this.lastNameError.Name = "lastNameError";
            this.lastNameError.Size = new System.Drawing.Size(367, 25);
            this.lastNameError.TabIndex = 8;
            // 
            // dobError
            // 
            this.dobError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobError.AutoSize = true;
            this.dobError.ForeColor = System.Drawing.Color.Red;
            this.dobError.Location = new System.Drawing.Point(749, 75);
            this.dobError.Name = "dobError";
            this.dobError.Size = new System.Drawing.Size(368, 25);
            this.dobError.TabIndex = 9;
            // 
            // contactPhoneError
            // 
            this.contactPhoneError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactPhoneError.AutoSize = true;
            this.contactPhoneError.ForeColor = System.Drawing.Color.Red;
            this.contactPhoneError.Location = new System.Drawing.Point(3, 80);
            this.contactPhoneError.Name = "contactPhoneError";
            this.contactPhoneError.Size = new System.Drawing.Size(367, 20);
            this.contactPhoneError.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.streetTextBox, 2, 1);
            this.tableLayoutPanel3.Controls.Add(streetLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.genderComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(genderLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.contactPhoneTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(contactPhoneLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.contactPhoneError, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.genderError, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.streetError, 2, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 177);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1120, 100);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // genderError
            // 
            this.genderError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderError.AutoSize = true;
            this.genderError.ForeColor = System.Drawing.Color.Red;
            this.genderError.Location = new System.Drawing.Point(376, 80);
            this.genderError.Name = "genderError";
            this.genderError.Size = new System.Drawing.Size(367, 20);
            this.genderError.TabIndex = 9;
            // 
            // streetError
            // 
            this.streetError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetError.AutoSize = true;
            this.streetError.ForeColor = System.Drawing.Color.Red;
            this.streetError.Location = new System.Drawing.Point(749, 80);
            this.streetError.Name = "streetError";
            this.streetError.Size = new System.Drawing.Size(368, 20);
            this.streetError.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(usernameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ssnTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(passwordLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ssnError, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.usernameError, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordError, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 386);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 100);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDTOBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(376, 40);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(367, 20);
            this.usernameTextBox.TabIndex = 31;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // ssnError
            // 
            this.ssnError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ssnError.AutoSize = true;
            this.ssnError.ForeColor = System.Drawing.Color.Red;
            this.ssnError.Location = new System.Drawing.Point(3, 75);
            this.ssnError.Name = "ssnError";
            this.ssnError.Size = new System.Drawing.Size(367, 25);
            this.ssnError.TabIndex = 32;
            // 
            // usernameError
            // 
            this.usernameError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameError.AutoSize = true;
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(376, 75);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(367, 25);
            this.usernameError.TabIndex = 33;
            // 
            // passwordError
            // 
            this.passwordError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordError.AutoSize = true;
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(749, 75);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(368, 25);
            this.passwordError.TabIndex = 34;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(749, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.passwordTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.passwordViewer);
            this.splitContainer1.Size = new System.Drawing.Size(368, 44);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 35;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(0, 12);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(272, 20);
            this.passwordTextBox.TabIndex = 35;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // passwordViewer
            // 
            this.passwordViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordViewer.Image = global::westga_emr.Properties.Resources.viewPassword1;
            this.passwordViewer.Location = new System.Drawing.Point(0, 0);
            this.passwordViewer.Name = "passwordViewer";
            this.passwordViewer.Size = new System.Drawing.Size(60, 40);
            this.passwordViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.passwordViewer.TabIndex = 35;
            this.passwordViewer.TabStop = false;
            this.passwordViewer.WaitOnLoad = true;
            this.passwordViewer.Click += new System.EventHandler(this.PasswordViewer_Click);
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.UserDTO);
            // 
            // appointmentHelperBindingSource
            // 
            this.appointmentHelperBindingSource.DataSource = typeof(westga_emr.Helpers.AppointmentHelper);
            // 
            // AddNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.addNewPatientLabel);
            this.Controls.Add(this.addressId);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "AddNurse";
            this.Size = new System.Drawing.Size(1120, 850);
            this.Load += new System.EventHandler(this.AddNurse_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentHelperBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityError;
        private System.Windows.Forms.Label stateError;
        private System.Windows.Forms.Label zipCodeError;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label addNewPatientLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label addressId;
        private System.Windows.Forms.TextBox contactPhoneTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstnameError;
        private System.Windows.Forms.Label lastNameError;
        private System.Windows.Forms.Label dobError;
        private System.Windows.Forms.Label contactPhoneError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label genderError;
        private System.Windows.Forms.Label streetError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label ssnError;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.PictureBox passwordViewer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource appointmentHelperBindingSource;
    }
}
