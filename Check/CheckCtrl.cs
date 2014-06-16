using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents.Check
{
    public partial class CheckCtrl : UserControl
    {
        TK.BaseLib.Checking.Check _check = null;

        public CheckCtrl()
        {
            InitializeComponent();
        }

        public void Init(TK.BaseLib.Checking.Check inCheck)
        {
            _check = inCheck;

            checkCB.Text = _check.Name;
            descTB.Text = _check.Description;
        }

        internal void SetResult(TK.BaseLib.Checking.Statuses status, string p)
        {
            checkCB.Checked = (status != TK.BaseLib.Checking.Statuses.Error && status != TK.BaseLib.Checking.Statuses.Unchecked);
            SetColor(status);
        }

        private void SetColor(TK.BaseLib.Checking.Statuses status)
        {
            switch (status)
            {
                case TK.BaseLib.Checking.Statuses.Ok:
                    BackColor = Color.Green;
                    break;
                case TK.BaseLib.Checking.Statuses.Solved:
                    BackColor = Color.LightGreen;
                    break;
                case TK.BaseLib.Checking.Statuses.SolvedAutomatically:
                    BackColor = Color.PaleGreen;
                    break;
                case TK.BaseLib.Checking.Statuses.Unchecked:
                    BackColor = Color.Gray;
                    break;
                case TK.BaseLib.Checking.Statuses.Error:
                    BackColor = Color.Red;
                    break;
            }
        }
    }
}
