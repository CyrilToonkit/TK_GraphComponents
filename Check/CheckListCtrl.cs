using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib.Checking;
using System.Threading;

namespace TK.GraphComponents.Check
{
    public partial class CheckListCtrl : UserControl
    {
        CheckList _checkList = null;
        List<CheckCtrl> _checks = new List<CheckCtrl>();

        bool _active = true;
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public CheckListCtrl()
        {
            InitializeComponent();
        }

        public void InitCheckList(CheckList inCheckList)
        {
            _checkList = inCheckList;

            _checks.Clear();

            foreach (TK.BaseLib.Checking.Check check in _checkList.Checks)
            {
                CheckCtrl checkCtrl = new CheckCtrl();
                checkCtrl.Init(check);

                _checks.Add(checkCtrl);
            }

            RefreshList();
        }

        public void RefreshList()
        {
            checkListPanel.Controls.Clear();
            checkListPanel.Dock = DockStyle.Top;
            checkListPanel.Height = 0;

            foreach (CheckCtrl check in _checks)
            {
                checkListPanel.Controls.Add(check);
                check.Dock = DockStyle.Top;
                check.BringToFront();
                Panel spacerPanel = new Panel();
                spacerPanel.BackColor = Color.DarkGray;
                spacerPanel.Height = 2;
                checkListPanel.Controls.Add(spacerPanel);
                spacerPanel.Dock = DockStyle.Top;
                spacerPanel.BringToFront();
            }

            checkListPanel.Dock = DockStyle.Fill;
        }

        public void AutoCheckAll()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = _checkList.Checks.Count;
            progressBar1.Step = 1;

            foreach (CheckCtrl check in _checks)
            {
                progressBar1.PerformStep();

                if (Active)
                {
                    //Normal behavior

                }
                else
                {
                    //Simulate something
                    Random rnd = new Random();

                    int timeMilliSecs = rnd.Next(200, 2001);
                    Thread.Sleep(timeMilliSecs);

                    Invalidate(true);

                    int rslt = rnd.Next(0, 4);

                    TK.BaseLib.Checking.Statuses status = Statuses.Ok;
                    if (rslt > 2) { status = Statuses.Error;}
                    else if (rslt > 1) { status = Statuses.Solved; }
                    else if (rslt > 0) { status = Statuses.SolvedAutomatically; }

                    check.SetResult(status, "Simulated result");
                }
            }
        }

        private void autoCheckBT_Click(object sender, EventArgs e)
        {
            AutoCheckAll();
        }
    }
}
