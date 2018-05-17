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
    public partial class TK_SplashLicense : Form
    {
        Thread _thread;

        public TK_SplashLicense()
        {
            InitializeComponent();
        }

        public bool SetAllowed = false;
        public bool SetClosed = false;
        public bool SetToken = false;
        public bool SetTokenOK = false;
        public bool SetGranted = false;

        RichResult innerResult;

        public void ShowSplash(string version, RichResult result)
        {
            Shown += new EventHandler(TK_Splash_Shown);

            VersionLabel.Text = version;

            _thread = new Thread(ShowForm);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();

            innerResult = result;
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

        private void token()
        {
            licenseInfo.Text = "Token invalid, reaching license server...";
        }

        private void tokenOK()
        {
            licenseInfo.Text = "Token OK, access granted !";
            licenseType.Text = "Full";
        }

        private void allow()
        {
            licenseInfo.Text = "License not obtained !";

            progressBar1.Visible = false;
            okButton.Visible = true;
            quitButton.Visible = true;

            licenseType.Text = "Limited";
            messageLabel1.Visible = true;
            messageLabel2.Visible = true;
        }

        private void kill()
        {
            timer1.Stop();
            Close();
            _thread.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SetToken)
            {
                token();
                SetToken = false;
            }
            else if (SetTokenOK)
            {
                tokenOK();
                SetTokenOK= false;
            }
            else if (SetAllowed)
            {
                allow();
                SetAllowed= false;
            }
            else if (SetGranted)
            {
                innerResult.Result = true;
                kill();
            }
            else if (SetClosed)
            {
                kill();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            innerResult.Result = true;
            kill();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            innerResult.Result = false;
            kill();
        }
    }
}
