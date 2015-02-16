using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace TK.GraphComponents
{
    public partial class TK_Splash : Form
    {
        Thread _thread;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11; 

        public TK_Splash()
        {
            InitializeComponent();
            DoubleBuffered = true;
            BackMargin = Height - BG.Height;
            TransparencyKey = Color.FromArgb(0, 255, 0);
        }

        public bool Check(string company, string version, string host, DateTime releaseDate, int expireDays, bool SplashAnyway, bool waitsClosing)
        {
            return ShowSplash(company, version, host, releaseDate, expireDays, SplashAnyway, waitsClosing);
        }

        const double DURATION = 3;
        const double MAXDURATION = 6;
        double elapsed = 0;
        int BackMargin = 0;
        int remainingDays = 0;
        bool loads = false;

        public bool Granted
        {
            get { return remainingDays > 0; }
        }

        public bool ShowSplash(string company, string version, string host, DateTime releaseDate, int expireDays, bool SplashAnyway, bool waitsClosing)
        {
            loads = waitsClosing;
            Shown += new EventHandler(TK_Splash_Shown);

            OwnerLabel.Text = company;
            VersionLabel.Text = version;
            HostLabel.Text = host;
            DateTime now = DateTime.Now;
            progressBar1.Maximum = expireDays;

            remainingDays = Math.Max(0,expireDays - (int)now.Subtract(releaseDate).TotalDays);
            progressBar1.Value = expireDays - remainingDays;

            if (!Granted)
            {
                ExpiresLabel.Text = "EXPIRED";
                ExpiresLabel.ForeColor = Color.Red;
                RemainingLabel.Text = "Unavailable, contact Toonkit !";
                RemainingLabel.ForeColor = Color.Red;

                progressBar1.ForeColor = Color.Red;
            }
            else
            {
                ExpiresLabel.Text = releaseDate.AddDays((double)expireDays).ToShortDateString();
                RemainingLabel.Text = "Framework available for " + remainingDays.ToString() + " days";

                if (remainingDays < expireDays / 2)
                { progressBar1.ForeColor = Color.Orange; }
            }

            if (!Granted || SplashAnyway)
            {
                Rectangle screen = Screen.PrimaryScreen.Bounds;

                _thread = new Thread(ShowForm);
                _thread.SetApartmentState(ApartmentState.STA);
                _thread.Start();
            }

            return Granted;
        }

        // A private entry point for the thread.
        private void ShowForm()
        {
            Application.Run(this);
        }

        void TK_Splash_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void CallClose()
        {
            elapsed = DURATION * .75;
            loads = false; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed += (double)timer1.Interval / 1000.0;
            if (!loads && elapsed >= DURATION)
            {
                if (elapsed >= (Granted ? DURATION : MAXDURATION))
                {
                    timer1.Stop();
                    Close();
                    _thread.Abort();
                    return;
                }
            }

            SendMessage(BG.Handle, WM_SETREDRAW, false, 0);
            SendMessage(FG.Handle, WM_SETREDRAW, false, 0);
            double percent = (elapsed / (Granted ? DURATION : MAXDURATION));

            if(!loads)
            {
                Opacity = Math.Min(1,4-(percent * 4));
                if (Opacity < 0.001)
                {
                    Visible = false;
                }
            }

            int Move = (int)(BackMargin * percent)%218;
            BG.Location = new Point(0, Move);
            FG.Location = new Point(0, -Move);
            SendMessage(BG.Handle, WM_SETREDRAW, true, 0);
            SendMessage(FG.Handle, WM_SETREDRAW, true, 0);
            BG.Invalidate();
            FG.Invalidate();
        }
    }
}
