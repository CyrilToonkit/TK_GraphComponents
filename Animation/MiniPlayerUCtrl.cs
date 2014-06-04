using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using TK.BaseLib;
using TK.BaseLib.Animation;

namespace TK.GraphComponents.Animation
{
    public partial class MiniPlayerUCtrl : UserControl
    {
        public event FrameChangedEventHandler FrameChangedEvent;
        public virtual void OnFrameChanged(FrameChangedEventArgs e)
        {
            FrameChangedEvent(this, e);
        }

        public MiniPlayerUCtrl()
        {
            InitializeComponent();
        }

        public MiniPlayerUCtrl(string SequencePath)
        {
            InitializeComponent();
            Init(SequencePath);
        }

        public int ImageWidth = 0;
        public int ImageHeight = 0;
        public int Min = 0;

        public bool Init(string SequencePath)
        {
            Flush();
            DirectoryInfo SeqDir = new DirectoryInfo(SequencePath);

            mSequencePath = new List<string>();

            if (SeqDir.Exists)
            {
                FileInfo[] SeqFiles = SeqDir.GetFiles();

                foreach (FileInfo CurFile in SeqFiles)
                {
                    if (CurFile.Extension == ".jpg")
                    {
                        mSequencePath.Add(CurFile.FullName);
                    }
                }
            }

            if (mSequencePath.Count > 0)
            {
                mSequencePath.Sort(new ImageSorter());
                LoadImages();
                mWarp = new TimeWarp(ImageSorter.GetNumber(mSequencePath[0]), ImageSorter.GetNumber(mSequencePath[mSequencePath.Count - 1]));

                if (!seqLoaded)
                {
                    FrameChangedEvent += new FrameChangedEventHandler(MiniPlayerUCtrl_FrameChangedEvent);
                }

                seqLoaded = true;
                UpdateFrame();

                SetSize();
                return true;
            }

            return false;
        }

        private void SetSize()
        {
            playerLayoutPanel.ColumnStyles[1] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float)ImageWidth);
            playerLayoutPanel.RowStyles[1] = new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float)ImageHeight);
        }

        void MiniPlayerUCtrl_FrameChangedEvent(object sender, FrameChangedEventArgs e)
        {
        }

        //Settings
        double m_fps = 24;
        public double Fps
        {
            get { return m_fps; }
            set
            {
                m_fps = value;
                SetSpeed();
            }
        }

        private void SetSpeed()
        {
            PlayTimer.Interval = (int)(1000.0 / m_fps);
        }

        double m_factor = 1.0;
        public double Factor
        {
            get { return m_factor; }
            set
            {
                m_factor = value;
            }
        }

        int m_CurrentFrame = 0;
        public int CurrentFrame
        {
            get { return m_CurrentFrame + Min; }
            set
            {
                if (seqLoaded)
                {
                    int oldFrame = m_CurrentFrame;
                    m_CurrentFrame = (int)Math.Max(Math.Min(Length - 1, value - Min), 0);
                    FrameOffset = m_CurrentFrame - oldFrame;
                }
            }
        }

        int absFrame = 0;
        public int AbsFrame
        {
            get { return absFrame + Min; }
            set
            {
                if (seqLoaded)
                {
                    int oldFrame = m_CurrentFrame;
                    absFrame = value - Min;

                    m_CurrentFrame = (int)Math.Max(Math.Min(Length - 1, mWarp.GetWarped(value) - Min), 0);
                    FrameOffset = m_CurrentFrame - oldFrame;
                }
            }
        }

        public int Length
        {
            get { return mSequencePath.Count; }
        }

        bool mWarped = false;
        public bool Warped
        {
            get { return mWarped; }
            set { mWarped = (value && mWarp != null); }
        }

        private TimeWarp mWarp = null;
        public TimeWarp Warp
        {
            get { return mWarp; }
            set { mWarp = value; }
        }

        private bool m_Loop = true;
        public bool Loop
        {
            get { return m_Loop; }
            set { m_Loop = value; }
        }

        private bool seqLoaded = false;
        public bool Loaded
        {
            get { return seqLoaded; }
            set { seqLoaded = value; }
        }

        private Stopwatch watch = new Stopwatch();

        private bool Dragging = false;
        private int XDragging = -1000;
        private int framesPlayed = 0;
        private long TicksBuffer = 0;
        private int FrameOffset = 0;

        private bool mPlaying;
        public bool Playing
        {
            get { return mPlaying; }
            set
            {
                if (value)
                {
                    Play();
                }
                else
                {
                    Stop();
                }
            }
        }

        #region Player Image Management

        private void LoadImages()
        {
            mSequence = new List<Image>();
            Image img = null;

            foreach (string CurFilePath in mSequencePath)
            {
                FileStream NewStream = new FileStream(CurFilePath, FileMode.Open, FileAccess.Read);
                img = Image.FromStream(NewStream);
                ImageWidth = img.Width;
                ImageHeight = img.Height;
                mSequence.Add(new Bitmap(img));
                img.Dispose();
                NewStream.Close();
            }
        }

        private List<string> mSequencePath;

        private List<Image> mSequence = null;
        public List<Image> Sequence
        {
            get
            {
                return mSequence;
            }
        }

        #endregion

        public void Play()
        {
            if (seqLoaded)
            {
                mPlaying = true;
                watch.Start();
                PlayTimer.Start();
            }
        }

        public void Stop()
        {
            PlayTimer.Stop();
            watch.Stop();
            mPlaying = false;
        }

        public void UpdateFrame()
        {
            if (m_CurrentFrame < 0)
            {
                if (m_Loop)
                {
                    m_CurrentFrame = Sequence.Count - 1;
                    FrameOffset = 0;
                }
                else
                {
                    m_CurrentFrame = 0;
                    FrameOffset = 0;
                }
            }
            else
            {
                if (m_CurrentFrame > Sequence.Count - 1)
                {
                    m_CurrentFrame = m_CurrentFrame % Length;
                    FrameOffset = 0;

                    if (!m_Loop)
                    {
                        Playing = false;
                    }
                }
            }
            ImageHolder.BackgroundImage = Sequence[m_CurrentFrame];
        }

        #region MouseEvents

        private void MiniPlayerUCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            XDragging = e.X;
        }

        private void MiniPlayerUCtrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (seqLoaded && XDragging != -1000 && (e.X < XDragging - 2 || e.X > XDragging + 2))
            {
                Dragging = true;

                int XDiff = e.X - XDragging;
                CurrentFrame += (int)((double)XDiff / 2.0);
                XDragging = e.X;
                UpdateFrame();
            }
        }

        private void MiniPlayerUCtrl_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Dragging)
            {
                Playing = !Playing;
            }

            Dragging = false;
            XDragging = -1000;
        }

        private void MiniPlayerUCtrl_MouseLeave(object sender, EventArgs e)
        {
            Playing = false;
        }

        #endregion

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            int newFrame = absFrame = GetFrame();
            long elasped = watch.Elapsed.Ticks;

            //fpsLabel.Text = framesPlayed.ToString() + " fps (" + m_fps.ToString() + " asked) - " + ((double)elasped / 10000000.0).ToString("0.00") + "sec";

            if (Warped)
            {
                newFrame = (int)mWarp.GetWarped(newFrame + mWarp.Min) - (int)mWarp.Min;
            }

            if (newFrame != m_CurrentFrame)
            {
                framesPlayed += absFrame - m_CurrentFrame;
                if (elasped - TicksBuffer > 5000000)
                {
                    TicksBuffer = elasped;
                    framesPlayed = 0;
                }

                FrameChangedEventArgs fcea = new FrameChangedEventArgs(CurrentFrame, absFrame > (Length - 1) ? (Length - 1) + Min : (absFrame < 0 ? Min : absFrame + Min));
                m_CurrentFrame = newFrame;
                UpdateFrame();
                OnFrameChanged(fcea);
            }
        }

        private int GetFrame()
        {
            return (int)((((double)watch.Elapsed.Ticks / 10000000.0) * m_fps * m_factor) % (Loop ? Length : 1) + FrameOffset);
        }

        public void Flush()
        {
            PlayTimer.Stop();
            ImageHolder.BackgroundImage = null;

            if (mSequence != null)
            {
                foreach (Image CurImage in mSequence)
                {
                    CurImage.Dispose();
                }

                mSequence.Clear();
                mSequence = null;
                seqLoaded = false;
            }
        }
    }

    public delegate void FrameChangedEventHandler(object sender, FrameChangedEventArgs e);

    public class FrameChangedEventArgs : EventArgs
    {
        public FrameChangedEventArgs(int inOldFrame, int inFrame)
        {
            Frame = inFrame;
            OldFrame = inOldFrame;
        }

        public int Frame;
        public int OldFrame;
    }
}
