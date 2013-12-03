using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TK.GraphComponents
{
    public partial class CustomToolTip : Panel
    {
        public CustomToolTip()
        {
            InitializeComponent();
            time.Tick += new EventHandler(time_Tick);
            measurer = CreateGraphics();
            DoubleBuffered = true;
        }

        void time_Tick(object sender, EventArgs e)
        {
            Hidden();
        }

        Timer time = new Timer();
        Font font = new Font("Tahoma", 8f, FontStyle.Regular);
        Graphics measurer;

        public void Show(Point Location)
        {
            Show(Location, 0);
        }

        public void Show(Point Location, float seconds)
        {
            SizeF size = measurer.MeasureString(Text, font);
            MoveAt(Location);
            Width = (int)(size.Width + 10);
            Height = (int)(size.Height + 10);
            if (seconds != 0)
            {
                time.Interval = (int)(seconds * 1000);
                time.Start();
            }
            BringToFront();
            Visible = true;
            Invalidate();
        }

        public void Hidden()
        {
            time.Stop();
            Visible = false;
        }

        public void MoveAt(Point loc)
        {
            Location = new Point(loc.X - Width / 2, loc.Y - Height - 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0,0,Width-1, Height-1));
            e.Graphics.DrawString(Text, font, Brushes.Black, new PointF(5,5));
        }
    }
}
