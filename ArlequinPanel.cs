using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TK.GraphComponents
{
    public class ArlequinPanel : Panel
    {
        public ArlequinPanel() : base()
        {
            _backBrush = new SolidBrush(BackColor);

            BackColorChanged += new EventHandler(ArlequinPanel_BackColorChanged);
        }

        void ArlequinPanel_BackColorChanged(object sender, EventArgs e)
        {
            _backBrush = new SolidBrush(BackColor);
        }

        List<Color> _colors = new List<Color>();

        List<double> _values = new List<double>();

        List<SolidBrush> _brushes = new List<SolidBrush>();

        List<string> _labels = new List<string>();

        SolidBrush _backBrush;

        public void Clear()
        {
            _colors.Clear();
            _values.Clear();
            _brushes.Clear();
        }

        public void AddColor(Color inColor, double inValue, string inLabel)
        {
            _colors.Add(inColor);
            _values.Add(inValue);
            _labels.Add(inLabel);
            _brushes.Add(new SolidBrush(inColor));
        }

        public void AddColor(Color inColor, double inValue)
        {
            AddColor(inColor, inValue, "");
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            int nbColors = Math.Min(_colors.Count, _values.Count);
            if (nbColors > 0)
            {
                double pointer = 0.0;
                double curValue = 0.0;
                for(int i = 0; i < nbColors; i++)
                {
                    curValue =  _values[i] * Width;
                    e.Graphics.FillRectangle(_brushes[i], new Rectangle((int)pointer, 0, (int)curValue - (int)pointer, Height));
                    
                    if (_labels[i] != "")
                    {
                        e.Graphics.DrawString(_labels[i], Font, _backBrush, new Point((int)(pointer + (curValue - pointer) / 2.0) - 10, Height - 13));
                    }
                    
                    pointer += curValue - pointer;
                }
            }
        }
    }
}
