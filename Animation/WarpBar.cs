using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using TK.BaseLib;
using TK.BaseLib.Animation;

namespace TK.GraphComponents.Animation
{
    public partial class WarpBar : Panel
    {
        public event MouseEventHandler WarpMoved;

        public virtual void OnWarpMoved(MouseEventArgs e)
        {
            WarpMoved(this, e);
        }

        public WarpBar(TimeWarp warp)
        {
            Initialize(warp);
        }

        public WarpBar()
        {
            Initialize();
        }

        public WarpBar(IContainer container)
        {
            container.Add(this);
            Initialize();
        }

        const int SLIDERWIDTH = 7;

        double selectedKey = -10000;
        bool moved = false;
        ToolTip tip;
        bool snap = true;

        public TimeWarp Warp;

        Color mCompressColor = Color.Red;
        Color mStechColor = Color.Blue;

        private void Initialize()
        {
            Initialize(null);
        }

        public void SetWarp(TimeWarp warp)
        {
            Warp = warp;
        }

        private void Initialize(TimeWarp warp)
        {
            Warp = warp == null ? new TimeWarp(1,100) : warp;

            tip = new ToolTip();

            InitializeComponent();
            DoubleBuffered = true;
            SizeChanged += new EventHandler(WarpBar_SizeChanged);
            MouseUp += new MouseEventHandler(WarpBar_MouseUp);
            MouseDown += new MouseEventHandler(WarpBar_MouseDown);
            MouseMove += new MouseEventHandler(WarpBar_MouseMove);
            WarpMoved += new MouseEventHandler(WarpBar_WarpMoved);
        }

        void WarpBar_WarpMoved(object sender, MouseEventArgs e)
        {

        }

        void WarpBar_MouseMove(object sender, MouseEventArgs e)
        {
            double factor = (Warp.Length - 1) / (Width - 4);
            double absFrame = Math.Max(0, Math.Min((Warp.Length - 1), factor * e.X)) + Warp.Min;
            KeyMap closest = Warp.GetClosest(absFrame);
            double frame = absFrame;
            if (selectedKey != -10000)
            {
                KeyMap selected = Warp.GetClosest(selectedKey);

                if (snap)
                {
                    frame = Math.Round(absFrame, 0);
                }

                if (!Warp.ContainsKey(frame))
                {
                    Warp.MoveKey(selectedKey, frame);
                    WarpMoved(selected, new MouseEventArgs(MouseButtons.Left, 0, (int)selectedKey, (int)frame, 0));
                    Invalidate();
                }

                selectedKey = selected.WarpKey;
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                double width = (double)SLIDERWIDTH / 2.0;

                if (closest.Index == 0 || closest.Index == Warp.Keys.Count - 1)
                {
                    width = SLIDERWIDTH;
                }

                Form form = Form.ActiveForm;

                if ((e.X + width) * factor > closest.WarpKey - Warp.Min && (e.X - width) * factor < closest.WarpKey - Warp.Min)
                {
                    if (form != null)
                    {
                        Point loc = form.PointToClient(PointToScreen(new Point(e.Location.X, 0)));

                        //touch a slider !!
                        if (!moved)
                        {
                            tip.ToolTipTitle = "Warp : " + closest.WarpKey.ToString();
                            tip.Show("Key : " + closest.RealKey.ToString(), form, loc.X, loc.Y - 25, 20000);
                            moved = true;
                        }
                        else
                        {
                            tip.ToolTipTitle = "Warp : " + closest.WarpKey.ToString();
                        }
                    }
                    Cursor.Current = Cursors.Hand;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    if (moved && form != null)
                    {
                        tip.Hide(form);
                        moved = false;
                    }
                }
            }
        }

        void WarpBar_MouseDown(object sender, MouseEventArgs e)
        {
            double factor = (Warp.Length - 1) / (Width - 4);
            double absFrame = factor * e.X + Warp.Min;

            KeyMap after = Warp.GetClosest(absFrame);

            bool boundary = false;
            double width = (double)SLIDERWIDTH / 2.0;

            if (after.Index == 0 || after.Index == Warp.Keys.Count - 1)
            {
                width = SLIDERWIDTH;
            }

            if ((e.X + width) * factor > after.WarpKey - Warp.Min && (e.X - width) * factor < after.WarpKey - Warp.Min)
            {
                selectedKey = after.WarpKey;

                //touch a slider !!
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenuStrip strip = new ContextMenuStrip();
                    ToolStripMenuItem item = new ToolStripMenuItem("Reset", null, Reset_Key);
                    item.Tag = selectedKey;
                    strip.Items.Add(item);

                    if (!boundary)
                    {
                        item = new ToolStripMenuItem("Delete", null, Delete_Key);
                        item.Tag = selectedKey;
                        strip.Items.Add(item);
                    }

                    strip.Show(Cursor.Position.X, Cursor.Position.Y);

                    selectedKey = -10000;
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    double RealKey = Warp.GetWarped(absFrame);
                    if (RealKey > Warp.Min && RealKey < Warp.Max)
                    {
                        if (snap && after.WarpKey != absFrame)
                        {
                            absFrame = Math.Round(absFrame, 0);
                        }

                        if (Math.Abs(after.WarpKey - absFrame) > 0.2)
                        {
                            selectedKey = Warp.AddKey(Warp.GetWarped(absFrame), absFrame).WarpKey;
                        }
                    }
                }
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        ContextMenuStrip strip = new ContextMenuStrip();
                        ToolStripMenuItem item = new ToolStripMenuItem("Reset All", null, Reset_All);
                        item.Tag = selectedKey;
                        strip.Items.Add(item);

                        item = new ToolStripMenuItem("Delete All", null, Delete_All);
                        item.Tag = selectedKey;
                        strip.Items.Add(item);

                        strip.Show(Cursor.Position.X, Cursor.Position.Y);
                    }
                }
            }

            Invalidate();
        }

        void Delete_Key(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Warp.RemoveKey((double)item.Tag);
            Invalidate();
        }

        void Reset_Key(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            KeyMap map = Warp.GetClosest((double)item.Tag);
            Warp.MoveKey(map.WarpKey, map.RealKey);
            Invalidate();
        }

        void Delete_All(object sender, EventArgs e)
        {
            Warp.Reset(true);
            Invalidate();
        }

        void Reset_All(object sender, EventArgs e)
        {
            Warp.Reset(false);
            Invalidate();
        }

        void WarpBar_MouseUp(object sender, MouseEventArgs e)
        {
            selectedKey = -10000;
        }

        void WarpBar_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Gray);

            int blocks = Warp.Keys.Count - 1;

            //Draw first slider
            DrawSlider(e.Graphics, Warp.Keys[0]);

            KeyMap beforeMap = Warp.Keys[0];
            KeyMap afterMap = null;

            for (var i = 0; i < blocks; i++)
            {
                afterMap = Warp.Keys[i + 1];

                //Get locations

                int start = GetLocation(beforeMap.WarpKey);
                int end = GetLocation(afterMap.WarpKey);

                //Get color
                float factor = (float)((afterMap.WarpKey - beforeMap.WarpKey) / (afterMap.RealKey - beforeMap.RealKey));
                Brush brush = new SolidBrush(ColorHelper.BlendColors(mCompressColor,Color.White, factor));

                if(factor > 1)
                {
                    brush = new SolidBrush(ColorHelper.BlendColors(Color.White, mStechColor, Math.Min(5, (factor - .5) / 5)));
                }

                Rectangle Rect = new Rectangle();
                Rect.X = start + SLIDERWIDTH + 1;
                Rect.Width = end - start - SLIDERWIDTH;
                Rect.Height = Height;

                e.Graphics.FillRectangle(brush, Rect);

                //Draw %
                if (Rect.Width > 20)
                {
                    string txt = ((int)(1f/factor * 100)).ToString() + " %";
                    e.Graphics.DrawString(txt, Font, Brushes.Black, (float)(Rect.X - 13) + (float)Rect.Width / 2f, (float)Height / 5f);
                }

                //Draw end  slider
                DrawSlider(e.Graphics, afterMap);

                beforeMap = Warp.Keys[i + 1];
            }
        }

        private void DrawSlider(Graphics graphics, KeyMap keyMap)
        {
            Rectangle sliderRect = new Rectangle();
            sliderRect.X = GetLocation(keyMap.WarpKey);
            sliderRect.Width = 7;
            sliderRect.Height = Height-1;

            graphics.FillRectangle(Brushes.Gainsboro, sliderRect);
            graphics.DrawRectangle(Pens.Black, sliderRect);
        }

        private int GetLocation(double WarpKey)
        {
            return (int)(((WarpKey - Warp.Min) / (Warp.Length - 1)) * (Width - 8));
        }
    }
}
