
namespace westga_emr.User_Controls
{
    partial class ViewLabOrderUserControl
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
            this.labOrderTestGrid = new System.Windows.Forms.DataGridView();
            this.EditLabTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labOrderTestDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.labOrderTestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labOrderTestDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labOrderTestGrid
            // 
            this.labOrderTestGrid.AllowUserToAddRows = false;
            this.labOrderTestGrid.AllowUserToDeleteRows = false;
            this.labOrderTestGrid.AutoGenerateColumns = false;
            this.labOrderTestGrid.BackgroundColor = System.Drawing.Color.OldLace;
            this.labOrderTestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labOrderTestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.EditLabTest});
            this.labOrderTestGrid.DataSource = this.labOrderTestDTOBindingSource;
            this.labOrderTestGrid.Location = new System.Drawing.Point(-3, 3);
            this.labOrderTestGrid.Name = "labOrderTestGrid";
            this.labOrderTestGrid.Size = new System.Drawing.Size(906, 268);
            this.labOrderTestGrid.TabIndex = 1;
            this.labOrderTestGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LabOrderTestGrid_CellContentClick);
            // 
            // EditLabTest
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.EditLabTest.DefaultCellStyle = dataGridViewCellStyle1;
            this.EditLabTest.HeaderText = "   ";
            this.EditLabTest.Name = "EditLabTest";
            this.EditLabTest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditLabTest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditLabTest.Text = "Edit Lab Test";
            this.EditLabTest.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Lab Order Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VisitId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Visit Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderedDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ordered Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TestName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Test Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TestResult";
            this.dataGridViewTextBoxColumn4.HeaderText = "Test Result";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TestDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Test Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TestCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Test Code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // labOrderTestDTOBindingSource
            // 
            this.labOrderTestDTOBindingSource.DataSource = typeof(westga_emr.Model.DTO.LabOrderTestDTO);
            // 
            // ViewLabOrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.labOrderTestGrid);
            this.Name = "ViewLabOrderUserControl";
            this.Size = new System.Drawing.Size(906, 273);
            ((System.ComponentModel.ISupportInitialize)(this.labOrderTestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labOrderTestDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource labOrderTestDTOBindingSource;
        private System.Windows.Forms.DataGridView labOrderTestGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn EditLabTest;
    }
}
