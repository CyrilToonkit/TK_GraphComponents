using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public partial class FixedRatioUCtrl : UserControl
    {
        public FixedRatioUCtrl()
        {
            InitializeComponent();
        }

        bool _muteEvents = false;

        float _ratio = 0;
        public float Ratio
        {
            get { return _ratio; }
            set { _ratio = value; }
        }
 

        private void FixedRatioUCtrl_SizeChanged(object sender, EventArgs e)
        {
            if (!_muteEvents && _ratio != 0 && Dock != DockStyle.None)
            {
                _muteEvents = true;
                if (Dock == DockStyle.Bottom || Dock == DockStyle.Top)
                {
                    Height = (int)((float)Width / _ratio); 
                }
                else if (Dock == DockStyle.Left || Dock == DockStyle.Left)
                {
                    Width = (int)((float)Height * _ratio);
                }
                _muteEvents = false;
            }
        }
    }
}
