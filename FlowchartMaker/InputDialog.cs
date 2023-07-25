using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowchartMaker
{
    public partial class InputDialog : Form
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        public string InputText
        {
            get { return textBox1.Text; }
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
