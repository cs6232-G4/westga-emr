
namespace westga_emr.User_Controls
{
    partial class Nurses
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
            this.nurseListDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nurseListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nurseListDataGrid
            // 
            this.nurseListDataGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.nurseListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurseListDataGrid.Location = new System.Drawing.Point(10, 52);
            this.nurseListDataGrid.Name = "nurseListDataGrid";
            this.nurseListDataGrid.Size = new System.Drawing.Size(1067, 471);
            this.nurseListDataGrid.TabIndex = 0;
            // 
            // Nurses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.nurseListDataGrid);
            this.Name = "Nurses";
            this.Size = new System.Drawing.Size(1100, 850);
            ((System.ComponentModel.ISupportInitialize)(this.nurseListDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView nurseListDataGrid;
    }
}
