
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
            System.Windows.Forms.Label orderNameLabel;
            System.Windows.Forms.Label selectedTestLabel;
            this.labTestHeaderLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.testNameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clearTestNamebutton = new System.Windows.Forms.Button();
            this.addTestNamebutton = new System.Windows.Forms.Button();
            this.selectedTestNameListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            orderNameLabel = new System.Windows.Forms.Label();
            selectedTestLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderNameLabel
            // 
            orderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            orderNameLabel.AutoSize = true;
            orderNameLabel.Location = new System.Drawing.Point(3, 12);
            orderNameLabel.Name = "orderNameLabel";
            orderNameLabel.Size = new System.Drawing.Size(240, 13);
            orderNameLabel.TabIndex = 5;
            orderNameLabel.Text = "Order Name*";
            // 
            // selectedTestLabel
            // 
            selectedTestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            selectedTestLabel.AutoSize = true;
            selectedTestLabel.Location = new System.Drawing.Point(352, 12);
            selectedTestLabel.Name = "selectedTestLabel";
            selectedTestLabel.Size = new System.Drawing.Size(225, 13);
            selectedTestLabel.TabIndex = 25;
            selectedTestLabel.Text = "Selected Order Name*";
            // 
            // labTestHeaderLabel
            // 
            this.labTestHeaderLabel.AutoSize = true;
            this.labTestHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestHeaderLabel.Location = new System.Drawing.Point(213, 5);
            this.labTestHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTestHeaderLabel.Name = "labTestHeaderLabel";
            this.labTestHeaderLabel.Size = new System.Drawing.Size(71, 20);
            this.labTestHeaderLabel.TabIndex = 17;
            this.labTestHeaderLabel.Text = "Lab Test";
            this.labTestHeaderLabel.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Location = new System.Drawing.Point(222, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 37);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.89552F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.10448F));
            this.tableLayoutPanel9.Controls.Add(this.closeButton, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.submitButton, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 325);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(654, 50);
            this.tableLayoutPanel9.TabIndex = 16;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.submitButton.BackColor = System.Drawing.Color.Green;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(303, 6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 37);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Save";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tableLayoutPanel5.Controls.Add(this.testNameCheckedListBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(orderNameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.selectedTestNameListBox, 2, 1);
            this.tableLayoutPanel5.Controls.Add(selectedTestLabel, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(50, 28);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(580, 259);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // testNameCheckedListBox
            // 
            this.testNameCheckedListBox.FormattingEnabled = true;
            this.testNameCheckedListBox.Location = new System.Drawing.Point(3, 28);
            this.testNameCheckedListBox.Name = "testNameCheckedListBox";
            this.testNameCheckedListBox.ScrollAlwaysVisible = true;
            this.testNameCheckedListBox.Size = new System.Drawing.Size(231, 199);
            this.testNameCheckedListBox.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.clearTestNamebutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addTestNamebutton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(249, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(97, 199);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // clearTestNamebutton
            // 
            this.clearTestNamebutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clearTestNamebutton.BackColor = System.Drawing.Color.Green;
            this.clearTestNamebutton.ForeColor = System.Drawing.Color.White;
            this.clearTestNamebutton.Location = new System.Drawing.Point(3, 130);
            this.clearTestNamebutton.Name = "clearTestNamebutton";
            this.clearTestNamebutton.Size = new System.Drawing.Size(91, 37);
            this.clearTestNamebutton.TabIndex = 22;
            this.clearTestNamebutton.Text = "Clear";
            this.clearTestNamebutton.UseVisualStyleBackColor = false;
            this.clearTestNamebutton.Click += new System.EventHandler(this.ClearTestNamebutton_Click);
            // 
            // addTestNamebutton
            // 
            this.addTestNamebutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addTestNamebutton.BackColor = System.Drawing.Color.Green;
            this.addTestNamebutton.ForeColor = System.Drawing.Color.White;
            this.addTestNamebutton.Location = new System.Drawing.Point(3, 31);
            this.addTestNamebutton.Name = "addTestNamebutton";
            this.addTestNamebutton.Size = new System.Drawing.Size(91, 37);
            this.addTestNamebutton.TabIndex = 21;
            this.addTestNamebutton.Text = "Add Test Name";
            this.addTestNamebutton.UseVisualStyleBackColor = false;
            this.addTestNamebutton.Click += new System.EventHandler(this.AddTestNamebutton_Click);
            // 
            // selectedTestNameListBox
            // 
            this.selectedTestNameListBox.FormattingEnabled = true;
            this.selectedTestNameListBox.Location = new System.Drawing.Point(352, 28);
            this.selectedTestNameListBox.Name = "selectedTestNameListBox";
            this.selectedTestNameListBox.ScrollAlwaysVisible = true;
            this.selectedTestNameListBox.Size = new System.Drawing.Size(225, 199);
            this.selectedTestNameListBox.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.messageLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(50, 293);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(580, 31);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(3, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(84, 17);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "                   ";
            this.messageLabel.Visible = false;
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(westga_emr.Model.Lab_Test);
            // 
            // LabTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.labTestHeaderLabel);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "LabTestUserControl";
            this.Size = new System.Drawing.Size(654, 375);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTestHeaderLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckedListBox testNameCheckedListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clearTestNamebutton;
        private System.Windows.Forms.Button addTestNamebutton;
        private System.Windows.Forms.ListBox selectedTestNameListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label messageLabel;
    }
}
