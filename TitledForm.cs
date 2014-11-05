using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public partial class TitledForm : Form
    {
        public TitledForm()
        {
            InitializeComponent();
            RichTitle = "Nothing loaded";
        }

        public TitledForm(string inName)
        {
            InitializeComponent();
            PreFormat = inName + " : '";
            RichTitle = "Nothing loaded";
        }

        public string PreFormat
        {
            get { return preFormat; }
            set { preFormat = value; }
        }
        public string PostFormat
        {
            get { return postFormat; }
            set { postFormat = value; }
        }

        string preFormat = "UntitledForm V1.0 : '";
        string postFormat = "'";

        public string Title
        {
            get { return Text; }
            set { Text = value; }
        }

        public string RichTitle
        {
            set { Text = preFormat + value + postFormat; }
            get { return Text.Substring(preFormat.Length, Text.Length - preFormat.Length - postFormat.Length); }
        }

        public void Match(Control inControl)
        {
            Width = inControl.Width + 16;
            Height = inControl.Height + 40;
        }
    }
}
