using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public partial class StablePanel : Panel
    {
        public StablePanel()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public StablePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            DoubleBuffered = true;
        }
    }
}
