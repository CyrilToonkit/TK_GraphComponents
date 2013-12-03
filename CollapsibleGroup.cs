using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TK.GraphComponents
{
    public enum DockingPossibilities
    {
        None, LeftRight, TopBottom, All
    }

    public delegate void CollapseChangedEventHandler(object sender, EventArgs e);

    public class CollapsibleGroup : GroupBox
    {
        public CollapsibleGroup(): base()
        {
             baseWidth = Width;

            DoubleBuffered = true;

            MouseDown +=new MouseEventHandler(CollapsibleGroup_MouseDown);
            MouseMove += new MouseEventHandler(CollapsibleGroup_MouseMove);
            MouseUp += new MouseEventHandler(CollapsibleGroup_MouseUp);
            MouseLeave += new EventHandler(CollapsibleGroup_MouseLeave);
            DockChanged += new EventHandler(CollapsibleGroup_DockChanged);
            CollapseChanged += new CollapseChangedEventHandler(CollapsibleGroup_CollapseChanged);

            Content = new Panel();
            Content.BackColor = Color.Transparent;
            Padding pad = Content.Padding;
            pad.All = 3;
            Content.Padding = pad;
            Padding = pad;

            Content.MouseMove += new MouseEventHandler(Content_MouseMove);
            Controls.Add(Content);
            Content.Dock = DockStyle.Fill;

            ControlAdded += new ControlEventHandler(CollapsibleGroup_ControlAdded);
        }

        Dictionary<Control, int> order = null;

        void CollapsibleGroup_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        void Content_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        void CollapsibleGroup_ControlAdded(object sender, ControlEventArgs e)
        {
            if (!this.DesignMode)
            {
                if (order == null)
                {
                    order = new Dictionary<Control, int>();
                   //GetOrder();
                }

                if (Controls.Contains(e.Control))
                {
                    Controls.Remove(e.Control);
                }
                if (!Content.Controls.Contains(e.Control))
                {
                    Content.Controls.Add(e.Control);
                }

                //SetOrder();
                Width += 1;
                Width -= 1;
            }
            Content.SendToBack();
        }

        //==================================== Custom Events ====================================

        public event CollapseChangedEventHandler CollapseChanged;

        public virtual void OnCollapseChanged(EventArgs e)
        {
            CollapseChanged(this, e);
        }

        void CollapsibleGroup_CollapseChanged(object sender, EventArgs e)
        {

        }

        void CollapsibleGroup_DockChanged(object sender, EventArgs e)
        {
            if (!STATUSreEntrant)
            {
                defaultDock = Dock;
            }

            Invalidate();
        }

        //==================================== Mouse Events ====================================

        void CollapsibleGroup_MouseUp(object sender, MouseEventArgs e)
        {
            if (STATUSextending != 0)
            {
                if (CollapsingVertically)
                {
                    OpenedBaseWidth = Width;
                }
                else
                {
                    OpenedBaseHeight = Height;
                }

                STATUSextending = 0;
                STATUSMouseLoc.X = STATUSMouseLoc.Y = -1000;
            }
            else
            {
                switch (e.Button)
                {
                    case MouseButtons.Right: //ContextMenu
                        if (DockingChanges != DockingPossibilities.None)
                        {
                            DockStrip.Items.Clear();

                            DockStrip.Items.Add("Default (" + defaultDock.ToString() + ")", null, new EventHandler(CollapsibleGroup_ChangeDock));
                            DockStrip.Items.Add("-");

                            if (DockingChanges != DockingPossibilities.LeftRight && Dock != DockStyle.Top && defaultDock != DockStyle.Top)
                            {
                                DockStrip.Items.Add("Top", null, new EventHandler(CollapsibleGroup_ChangeDock));
                            }

                            if (DockingChanges != DockingPossibilities.TopBottom && Dock != DockStyle.Right && defaultDock != DockStyle.Right)
                            {
                                DockStrip.Items.Add("Right", null, new EventHandler(CollapsibleGroup_ChangeDock));
                            }

                            if (DockingChanges != DockingPossibilities.LeftRight && Dock != DockStyle.Bottom && defaultDock != DockStyle.Bottom)
                            {
                                DockStrip.Items.Add("Bottom", null, new EventHandler(CollapsibleGroup_ChangeDock));
                            }

                            if (DockingChanges != DockingPossibilities.TopBottom && Dock != DockStyle.Left && defaultDock != DockStyle.Left)
                            {
                                DockStrip.Items.Add("Left", null, new EventHandler(CollapsibleGroup_ChangeDock));
                            }

                            DockStrip.Show(PointToScreen(e.Location));
                        }
                        break;
                    case MouseButtons.Left: //Collapsing
                        if (CollapseOnClick)
                        {
                            Collapsed = !Collapsed;
                        }
                        break;
                }
            }
        }

        void CollapsibleGroup_MouseMove(object sender, MouseEventArgs e)
        {
            if (AllowResize)
            {
                if (STATUSextending != 0)
                {
                    if (STATUSMouseLoc.X != -1000)
                    {
                        Point screened = PointToScreen(e.Location);

                        if (CollapsingVertically)
                        {
                            if (STATUSextending == 4)
                            {
                                int trans = -screened.X + STATUSMouseLoc.X;
                                Width = OpenedBaseWidth + trans;
                            }
                            else
                            {
                                Width = OpenedBaseWidth + (screened.X - STATUSMouseLoc.X);
                            }
                        }
                        else
                        {
                            if (STATUSextending == 1)
                            {
                                int trans = -screened.Y + STATUSMouseLoc.Y;
                                Height = OpenedBaseHeight + trans;
                            }
                            else
                            {
                                Height = OpenedBaseHeight + (screened.Y - STATUSMouseLoc.Y);
                            }
                        }
                    }
                }
                else
                {
                    int Extendable = 0;

                    if (!Collapsed)
                    {
                        Extendable = GetExtendable(e.Location);
                    }

                    if (Extendable == 0)
                    {
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        Cursor = (Extendable == 1 || Extendable == 3) ? Cursors.SizeNS : Cursors.SizeWE;
                    }
                }
            }
        }

        void CollapsibleGroup_MouseDown(object sender, MouseEventArgs e)
        {
            if (AllowResize)
            {
                STATUSextending = GetExtendable(e.Location);
                if (STATUSextending != 0)
                {
                    STATUSMouseLoc = PointToScreen(e.Location);
                }
            }
        }

        //==================================== Status helpers ====================================

        void CollapsibleGroup_ChangeDock(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            STATUSreEntrant = true;
            switch (item.Text)
            {
                case "Top":
                    Dock = DockStyle.Top;
                    Height = OpenedBaseHeight;
                    break;
                case "Right":
                    Dock = DockStyle.Right;
                    Width = OpenedBaseWidth;
                    break;
                case "Bottom":
                    Dock = DockStyle.Bottom;
                    Height = OpenedBaseHeight;
                    break;
                case "Left":
                    Dock = DockStyle.Left;
                    Width = OpenedBaseWidth;
                    break;
                default:

                    Dock = defaultDock;
                    break;
            }
            STATUSreEntrant = false;
            Collapsed = collapsed;
        }

        private int GetExtendable(Point MouseLocation)
        {
            if (!Collapsed && Dock != DockStyle.Fill && Dock != DockStyle.None)
            {
                switch (Dock)
                {
                    case DockStyle.Top:
                        if (MouseLocation.Y > Height - 7)
                        {
                            return 3;
                        }
                        break;
                    case DockStyle.Right:
                        if (MouseLocation.X < 7)
                        {
                            return 4;
                        }
                        break;
                    case DockStyle.Bottom:
                        if (MouseLocation.Y < 7)
                        {
                            return 1;
                        }
                        break;
                    case DockStyle.Left:
                        if (MouseLocation.X > Width - 7)
                        {
                            return 2;
                        }
                        break;
                }
            }

            return 0;
        }

        //==================================== Members ====================================

        bool collapsed = false;
        public bool Collapsed
        {
            get { return collapsed; }
            set
            {
                bool changed = collapsed != value;

                if (changed)
                {
                    if (value)
                    {
                        if (CollapsingVertically)
                        {
                            OpenedBaseWidth = Width;
                            Width = 17;
                        }
                        else
                        {
                            OpenedBaseHeight = Height;
                            Height = 17;
                        }
                    }
                    else
                    {
                        if (CollapsingVertically)
                        {
                            Width = OpenedBaseWidth;
                        }
                        else
                        {
                            Height = OpenedBaseHeight;
                        }
                    }
                }

                collapsed = value;
                Content.Visible = !value;

                if (changed)
                {
                    OnCollapseChanged(new EventArgs());
                }
            }
        }

        public bool CollapsingVertically
        {
            get { return (Dock == DockStyle.Left || Dock == DockStyle.Right); }
        }

        bool collapseOnClick = true;
        public bool CollapseOnClick
        {
            get { return collapseOnClick; }
            set {collapseOnClick = value;}
        }

        bool allowResize = true;
        public bool AllowResize
        {
            get { return allowResize; }
            set { allowResize = value; }
        }

        DockingPossibilities dockingChanges = DockingPossibilities.All;
        public DockingPossibilities DockingChanges
        {
            get { return dockingChanges; }
            set { dockingChanges = value; }
        }
        Panel Content;

        int baseWidth = 150;
        public int OpenedBaseWidth
        {
            get { return baseWidth; }
            set { baseWidth = value; }
        }

        int baseHeight = 150;
        public int OpenedBaseHeight
        {
            get { return baseHeight; }
            set { baseHeight = value; }
        }

        //Status

        int STATUSextending = 0;
        bool STATUSreEntrant = false;
        bool STATUSinit = false;
        Point STATUSMouseLoc = new Point(-1000, -1000);

        DockStyle defaultDock = DockStyle.None;

        //Graphical

        ContextMenuStrip DockStrip = new ContextMenuStrip();
        StringFormat sfVerti = new StringFormat(StringFormatFlags.DirectionVertical);
        StringFormat sf = new StringFormat();

        public Color RealBackColor
        {
            get
            {
                Control control = this;
                while (control.BackColor == Color.Transparent)
                {
                    control = control.Parent;
                }

                return control.BackColor;
            }
        }

        //==================================== Paint ====================================

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!collapsed)
            {
                base.OnPaint(e);
            }
            else
            {
                e.Graphics.Clear(RealBackColor);
                if (CollapsingVertically)
                {
                    RectangleF rf = new RectangleF(0, 8, 17, Height);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), rf, sfVerti);
                    int height = (int)e.Graphics.MeasureString(Text, Font).Width;
                    if (height + 26 < Height - 5)
                    {
                        e.Graphics.DrawRectangle(Pens.Gray, 4, height + 14, 6, 6);
                        e.Graphics.DrawRectangle(Pens.Gray, 6, height + 14 - 4, 8, 8);
                        e.Graphics.DrawLine(Pens.Gray, 7, height + 26, 7, Height - 5);
                        e.Graphics.DrawLine(Pens.White, 8, height + 26, 8, Height - 5);
                    }
                }
                else
                {
                    RectangleF rf = new RectangleF(7, 0, Width, 17);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), rf, sf);
                    int width = (int)e.Graphics.MeasureString(Text, Font).Width;
                    if (width + 10 < Width - 5)
                    {
                        e.Graphics.DrawRectangle(Pens.Gray, width + 7, 7, 6, 6);
                        e.Graphics.DrawRectangle(Pens.Gray, width + 9, 3, 8, 8);
                        e.Graphics.DrawLine(Pens.Gray, width + 21, 7, Width - 5, 7);
                        e.Graphics.DrawLine(Pens.White, width + 21, 8, Width - 5, 8);
                    }
                }
            }

            if (!STATUSinit)
            {
                STATUSinit = true;
                Width += 1;
                Height += 1;
            }
        }
    }
}
