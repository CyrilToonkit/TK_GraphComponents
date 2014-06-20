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
    }
}
