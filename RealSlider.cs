using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TK.GraphComponents
{
    public partial class RealSlider : TrackBar
    {
        public event EventHandler StopValueChanged;

        public virtual void OnStopValueChanged(EventArgs e)
        {
            StopValueChanged(this, e);
        }

        const int BORDER = 14;

        public RealSlider()
        {
            MouseDown += new MouseEventHandler(RealSlider_MouseDown);
            MouseUp += new MouseEventHandler(RealSlider_MouseUp);
            MouseMove += new MouseEventHandler(RealSlider_MouseMove);
            Resize += new EventHandler(RealSlider_Resize);

            StopValueChanged += new EventHandler(RealSlider_StopValueChanged);

            mGraphics = Graphics.FromHwnd(base.Handle);

            mMinLabel = new Label();
            mMinLabel.AutoSize = true;
            mMinLabel.Visible = false;

            mMaxLabel = new Label();
            mMaxLabel.AutoSize = true; 
            mMaxLabel.Visible = false;

            Controls.Add(mMinLabel);
            Controls.Add(mMaxLabel);

            /*
            arlequinPanel.AddColor(Color.Blue, 0.33, "Bleu");
            arlequinPanel.AddColor(Color.White, 0.66, "Blanc");
            arlequinPanel.AddColor(Color.Red, 1, "Rouge");
            */

            arlequinPanel.Location = new Point(1, 27);
            arlequinPanel.Dock = DockStyle.Bottom;
            arlequinPanel.Height = Height - 30;

            Controls.Add(arlequinPanel);

            InitializeComponent();
        }

        public void AddColorInterval(Color inColor, double inValue, string inLabel)
        {
            arlequinPanel.AddColor(inColor, inValue, inLabel);
        }

        public void ClearIntervals()
        {
            arlequinPanel.Clear();
        }

        public void UpdateLabels()
        {
            if (DisplayFrames || DisplayTexts)
            {
                string space = (DisplayFrames && DisplayTexts ? " " : "");

                mMinLabel.Text = (DisplayFrames ? PrintFrame(Minimum) : "") + space + (DisplayTexts ? StartText : "");
                mMaxLabel.Text = (DisplayFrames ? PrintFrame(Maximum) : "") + space + (DisplayTexts ? EndText : "");

                mMinLabel.Visible = mMaxLabel.Visible = true;
            }
            else
            {
                mMinLabel.Visible = mMaxLabel.Visible = false;
            }

            UpdateDisplays();
        }

        void RealSlider_Resize(object sender, EventArgs e)
        {
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            SizeF fontSize = mGraphics.MeasureString(mMaxLabel.Text, _altFont);
            int fontY = Math.Min(30, Height - (int)fontSize.Height);

            int startX = BORDER - 6;
            int endX = Width - BORDER + 5;

            mMinLabel.Location = new Point(startX, fontY);
            mMaxLabel.Location = new Point(endX - (int)fontSize.Width, fontY);

            if (framesLabelsFrequency > 0)
            {
                double frequency = framesLabelsFrequency;

                if (framesLabelsDynamicFrequency)
                {
                    frequency = framesLabelsFrequency * 10 / (double)((Width - BORDER + 5) - (BORDER - 6));
                }

                if (mLabels.Count != Math.Floor((DoubleMaximum - DoubleMinimum - frequency) / frequency))
                {
                    foreach (Label label in mLabels)
                    {
                        Controls.Remove(label);
                    }
                    mLabels.Clear();

                    for (double val = DoubleMinimum + frequency; val < DoubleMaximum; val++)
                    {
                        if (val % frequency == 0)
                        {
                            Label newLabel = new Label();
                            newLabel.Font = _altFont;
                            newLabel.Text = val.ToString("#.##");
                            newLabel.AutoSize = true;
                            newLabel.Tag = val;
                            Controls.Add(newLabel);
                            mLabels.Add(newLabel);
                        }
                    }
                    arlequinPanel.SendToBack();
                }
            }
            else
            {
                foreach (Label label in mLabels)
                {
                    Controls.Remove(label);
                }
                mLabels.Clear();
            }

            foreach (Label label in mLabels)
            {
                double normalizedValue = ((double)label.Tag - DoubleMinimum) / (DoubleMaximum - DoubleMinimum);

                label.Location = new Point(startX + (int)(normalizedValue * ((double)endX - 7 - (double)startX)), fontY);
            }
        }

        private ArlequinPanel arlequinPanel = new ArlequinPanel();
        private Label mMinLabel;					// label for min value
        private Label mMaxLabel;                    // label for max value
        private List<Label> mLabels = new List<Label>();//intermediate Labels
        private Graphics mGraphics = null;			// the graphics object for the base trackbar

        int draggingRef = -1000;
        bool isChangingValues = false;

        List<int> DrawnValues = new List<int>();
        List<string> DrawnTexts = new List<string>();

        int Range
        {
            get { return 1 + Maximum - Minimum; }
        }

        // ========================================================================================
        // Extensions
        // ========================================================================================

        // Click on value -------------------------------------------------

        void RealSlider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Value = GetValue(e.X);
                draggingRef = e.X;
                isChangingValues = true;
            }
        }

        void RealSlider_MouseUp(object sender, MouseEventArgs e)
        {
            draggingRef = -1000;

            if (isChangingValues)
            {
                OnStopValueChanged(new EventArgs());
            }

            isChangingValues = false;

            if (e.Button == MouseButtons.Middle && DefaultOnMiddleClick && hasDefault)
            {
                Value = DefaultValue; 
            }
        }

        void RealSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggingRef != -1000)
            {
                Value = GetValue(e.X);
            }
        }

        void RealSlider_StopValueChanged(object sender, EventArgs e)
        {

        }

        Font _altFont = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Pixel);
        [Browsable(true)]
        [CategoryAttribute("Appearance")]
        public Font SliderFont
        {
            get { return _altFont; }
            set
            {
                _altFont = mMinLabel.Font = mMaxLabel.Font = value;
                
                foreach (Label label in mLabels)
                {
                    label.Font = value;
                }
            }
        }

        Color _altForeColor = Color.Gray;
        [Browsable(true)]
        [CategoryAttribute("Appearance")]
        public Color SliderForeColor
        {
            get { return _altForeColor; }
            set
            {
                _altForeColor = mMinLabel.ForeColor = mMaxLabel.ForeColor = value;

                foreach (Label label in mLabels)
                {
                    label.ForeColor = value;
                }
            }
        }

        // Doubles -------------------------------------------------

        int decimals = 0;
        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The number of decimals for Double values (0 mean int)")]
        public int Decimals
        {
            get { return decimals; }
            set { decimals = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The Double value")]
        public double DoubleValue
        {
            get { return GetDoubleValue(Value); }
            set { Value = GetIntValue(value); }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The Double minimum")]
        public double DoubleMinimum
        {
            get { return GetDoubleValue(Minimum); }
            set { Minimum = GetIntValue(value); UpdateLabels(); }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The Double maximum")]
        public double DoubleMaximum
        {
            get { return GetDoubleValue(Maximum); }
            set { Maximum = GetIntValue(value); UpdateLabels(); }
        }

        // Default -------------------------------------------------

        bool hasDefault = false;
        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("Tells if the default is consistent")]
        public bool HasDefault
        {
            get { return hasDefault; }
            set { hasDefault = value; }
        }


        bool _defaultOnMiddleClick = true;
        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("Tells if the Value is reset to default on middle click")]
        public bool DefaultOnMiddleClick
        {
            get { return _defaultOnMiddleClick; }
            set { _defaultOnMiddleClick = value; }
        }

        int defaultValue = 0;
        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("Default value")]
        public int DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("Double default value")]
        public double DoubleDefaultValue
        {
            get { return GetDoubleValue(defaultValue); }
            set { defaultValue = GetIntValue(value); }
        }

        // Additional display -------------------------------------------------

        bool displayFrames = true;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display start and end values")]
        public bool DisplayFrames
        {
            get { return displayFrames; }
            set { displayFrames = value; UpdateLabels(); }
        }

        double framesLabelsFrequency = 0;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display additional labels for intermediate values")]
        public double FramesLabelsFrequency
        {
            get { return framesLabelsFrequency; }
            set { framesLabelsFrequency = value; UpdateLabels(); }
        }

        bool framesLabelsDynamicFrequency = false;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display additional labels for intermediate values")]
        public bool FramesLabelsDynamicFrequency
        {
            get { return framesLabelsDynamicFrequency; }
            set { framesLabelsDynamicFrequency = value; UpdateLabels(); }
        }


        bool displayTexts = false;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display start and end texts")]
        public bool DisplayTexts
        {
            get { return displayTexts; }
            set { displayTexts = value; UpdateLabels(); }
        }

        string startText = "";
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Start text")]
        public string StartText
        {
            get { return startText; }
            set { startText = value; UpdateLabels(); }
        }

        string endText = "";
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("End text")]
        public string EndText
        {
            get { return endText; }
            set { endText = value; UpdateLabels(); }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Shows coloured intervals under the slider (need to be set programmatically using \"AddColorInterval\")")]
        public bool ShowIntervals
        {
            get { return arlequinPanel.Visible; }
            set { arlequinPanel.Visible = value; }
        }

        // ========================================================================================
        // Helpers
        // ========================================================================================

        private string PrintFrame(int frame)
        {
            return GetDoubleValue(frame).ToString();
        }

        private int GetValue(int xPos)
        {
            //Boundaries
            xPos -= BORDER;
            int value = (int)(((float)xPos / (float)(Width - 2 * BORDER)) * Range) + Minimum;
            return Math.Min(Maximum, Math.Max(Minimum, value));
        }

        private double GetDoubleValue(int Value)
        {
            return Math.Round((double)Value / Math.Pow(10.0, (double)decimals), decimals);
        }

        private int GetIntValue(double value)
        {
            return (int)(value * Math.Pow(10.0, (double)decimals));
        }

        public void ToDefault()
        {
            Value = defaultValue;
        }
    }
}
