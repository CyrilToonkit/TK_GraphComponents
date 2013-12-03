using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public partial class MimicForm : UserControl
    {
        public MimicForm()
        {
            InitializeComponent();
        }

        public virtual string Title
        {
            get { return ""; }
            set {}
        }
    }
}
