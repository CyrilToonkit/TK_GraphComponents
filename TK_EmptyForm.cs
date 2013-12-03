using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public partial class TK_EmptyForm : Form
    {
        public TK_EmptyForm()
        {
            InitializeComponent();
        }

        public TK_EmptyForm(MimicForm inMimic)
        {
            InitializeComponent();
            Mimic = inMimic;
        }

        MimicForm mimic;
        public MimicForm Mimic
        {
            get { return mimic; }
            set
            {
                mimic = value;
                Text = mimic.Title;
            }
        }

        public virtual string Title
        {
            get { return Text; }
            set
            {
                mimic.Title = Text = value;
            }
        }
    }
}
