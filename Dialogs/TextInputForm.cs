using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents.Dialogs
{
    public partial class TextInputForm : Form
    {
        public TextInputForm()
        {
            InitializeComponent();
        }

        public TextInputForm(string inMessage, string inCaption, string inDefault)
        {
            InitializeComponent();
            Text = inCaption;
            messageTB.Text = inMessage;
            inputTB.Text = inDefault;
        }

        public string InputValue
        {
            get { return inputTB.Text; }
        }

        private void okBT_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
