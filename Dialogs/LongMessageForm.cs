using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents.Dialogs
{
    public partial class LongMessageForm : Form
    {
        public LongMessageForm()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return messageTB.Text; }
            set { messageTB.Text = value; }
        }

        public string OptionText
        {
            get { return optionButton.Text; }
            set { optionButton.Text = value; }
        }

        public bool ShowButtons
        {
            get { return buttonsLayout.Visible; }
            set { buttonsLayout.Visible = value; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
