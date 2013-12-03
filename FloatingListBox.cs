using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TK.GraphComponents
{
    public partial class FloatingListBox : ListBox
    {
        public FloatingListBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Black, 0f, 0f, (float)Width - 1, (float)Height - 1);
        }
    }
}
