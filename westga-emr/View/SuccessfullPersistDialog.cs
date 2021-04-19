using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace westga_emr.View
{
    public partial class SuccessfullPersistDialog : Form
    {
        public SuccessfullPersistDialog()
        {
            InitializeComponent();
        }

        public SuccessfullPersistDialog(String message)
        {
           
            InitializeComponent();
            this.messageLabel.Text = message;
        }

        private void closelButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
