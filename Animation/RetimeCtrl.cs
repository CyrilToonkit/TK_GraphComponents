using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;
using TK.BaseLib.Animation;
using TK.GraphComponents.Dialogs;

namespace TK.GraphComponents.Animation
{
    public partial class RetimeCtrl : UserControl
    {
        public event WarpInSoftwareEventHandler WarpInSoftwareEvent;

        public virtual void OnWarpInSoftware(WarpInSoftwareEventArgs e)
        {
            WarpInSoftwareEvent(this, e);
        }

        public RetimeCtrl()
        {
            InitializeComponent();
            miniPlayerUCtrl1.FrameChangedEvent += new FrameChangedEventHandler(miniPlayerUCtrl1_FrameChangedEvent);
            miniPlayerUCtrl1.Warped = true;
            warpBar1.WarpMoved += new MouseEventHandler(warpBar1_WarpMoved);
            WarpInSoftwareEvent += new WarpInSoftwareEventHandler(RetimeForm_WarpInSoftwareEvent);
            ParentChanged += new EventHandler(RetimeForm_ParentChanged);
        }

        public RetimeCtrl(string Sequence)
            : this()
        {
            OpenSequence(Sequence);
        }

        void RetimeForm_ParentChanged(object sender, EventArgs e)
        {
            if(ParentForm != null && ParentForm != parent)
            {
                parent = ParentForm;
                parent.FormClosed += new FormClosedEventHandler(RetimeForm_FormClosed);
            }
        }

        Form parent = null;

        public ToolStripMenuItem SnapItem
        {
            get { return snapOnFrameToolStripMenuItem; }
        }
        
        public bool ShowRetime
        {
            get { return warpBarP.Visible; }
            set { warpBarP.Visible = value; }
        }

        public bool ShowMenu
        {
            get { return mainMenuStrip.Visible; }
            set { mainMenuStrip.Visible = value; }
        }

        public bool ShowPlayControls
        {
            get { return playControlsLP.Visible; }
            set { playControlsLP.Visible = value; }
        }

        public bool ShowTimeLine
        {
            get { return timeLineTB.Visible; }
            set { timeLineTB.Visible = value; }
        }

        public bool Loop
        {
            get { return miniPlayerUCtrl1.Loop; }
            set { miniPlayerUCtrl1.Loop = value; }
        }

        public bool Warp
        {
            get { return miniPlayerUCtrl1.Warped; }
            set { miniPlayerUCtrl1.Warped = value; }
        }

        public double Factor
        {
            get { return miniPlayerUCtrl1.Factor; }
            set
            {
                miniPlayerUCtrl1.Factor = value;
            }
        }

        void RetimeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Flush();
        }

        public void Flush()
        {
            miniPlayerUCtrl1.Flush();
        }

        void RetimeForm_WarpInSoftwareEvent(object sender, WarpInSoftwareEventArgs e)
        {
        }

        void warpBar1_WarpMoved(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
            {
                KeyMap map = sender as KeyMap;
                timeLineTB.Value = e.Y;
                warpedBox.Text = miniPlayerUCtrl1.CurrentFrame.ToString();
            }
            else
            {
                trackBar1_ValueChanged(this, new EventArgs());
            }
        }

        void miniPlayerUCtrl1_FrameChangedEvent(object sender, FrameChangedEventArgs e)
        {
            MuteEvents = true;
            timeLineTB.Value = e.Frame;
            warpedBox.Text = miniPlayerUCtrl1.CurrentFrame.ToString();
            MuteEvents = false;
        }

        bool MuteEvents = false;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!OpenSequence(folderBrowserDialog1.SelectedPath))
                {
                    TKMessageBox.ShowError("Can't found images to read in " + folderBrowserDialog1.SelectedPath, "Open sequence error");
                }
            }
        }

        public bool OpenSequence(string path)
        {
            return OpenSequence(path, false, false);
        }

        public bool OpenSequence(string path, bool play, bool warped)
        {
            if (miniPlayerUCtrl1.Init(path))
            {
                TimeWarp warp = miniPlayerUCtrl1.Warp;
                warpBar1.Warp = warp;

                if (warped)
                {
                    miniPlayerUCtrl1.Warped = true;
                }

                timeLineTB.Value = timeLineTB.Minimum = (int)warp.Min;
                timeLineTB.Maximum = (int)warp.Max;

                Width = miniPlayerUCtrl1.ImageWidth;
                int height = miniPlayerUCtrl1.ImageHeight;

                if (ShowRetime)
                {
                    height += 20;
                }
                if (ShowPlayControls)
                {
                    height += 20;
                }
                if (ShowMenu)
                {
                    height += 24;
                }
                if (ShowTimeLine)
                {
                    height += 45;
                }

                Height = height;
                miniPlayerUCtrl1.Min = (int)warp.Min;

                if (play)
                {
                    miniPlayerUCtrl1.Play();
                }

                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miniPlayerUCtrl1.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            miniPlayerUCtrl1.Stop();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (!MuteEvents && miniPlayerUCtrl1.Loaded)
            {
                miniPlayerUCtrl1.AbsFrame = timeLineTB.Value;
                miniPlayerUCtrl1.UpdateFrame();
                warpedBox.Text = miniPlayerUCtrl1.CurrentFrame.ToString();
            }
        }

        private void warpInXSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnWarpInSoftware(new WarpInSoftwareEventArgs(warpBar1.Warp));
            ParentForm.Close();
        }

        private void loopToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Loop = loopToolStripMenuItem.Checked;
        }

        private void warpToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            Warp = warpToolStripMenuItem1.Checked;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (miniPlayerUCtrl1.Playing)
            {
                miniPlayerUCtrl1.Stop();
            }
        }

        private void completeSlider2_ValueChanged(object sender, EventArgs e)
        {
            Factor = completeSlider2.DoubleValue;
        }
    }

    public delegate void WarpInSoftwareEventHandler(object sender, WarpInSoftwareEventArgs e);

    public class WarpInSoftwareEventArgs : EventArgs
    {
        public WarpInSoftwareEventArgs(TimeWarp inWarp)
        {
            Warp = inWarp;
        }

        public TimeWarp Warp;
    }
}
