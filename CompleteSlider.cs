using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public enum SliderButtonStatus
    {
        Empty, Keyed, OnKey
    }

    public partial class CompleteSlider : UserControl
    {
        public event EventHandler ValueChanged;
        public event EventHandler StopValueChanged;
        public event EventHandler ButtonClicked;

        public virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged(this, e);
        }

        public virtual void OnStopValueChanged(EventArgs e)
        {
            StopValueChanged(this, e);
        }

        public CompleteSlider()
        {
            InitializeComponent();
            StopValueChanged += new EventHandler(CompleteSlider_StopValueChanged);
            ValueChanged += new EventHandler(CompleteSlider_ValueChanged);
            ButtonClicked += new EventHandler(CompleteSlider_ButtonClicked);
            mGraphics = Graphics.FromHwnd(base.Handle);
        }

        void CompleteSlider_ButtonClicked(object sender, EventArgs e)
        {

        }

        void CompleteSlider_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        void CompleteSlider_StopValueChanged(object sender, EventArgs e)
        {
            
        }
        
        const int EDITWIDTH = 40;
        private Graphics mGraphics = null;			// the graphics object for the base Control
        bool MuteEvents = false;

        public void AddColorInterval(Color inColor, double inValue, string inLabel)
        {
            realSlider.AddColorInterval(inColor, inValue, inLabel);
        }

        public void ClearIntervals()
        {
            realSlider.ClearIntervals();
        }

        // Additional display -------------------------------------------------

        [CategoryAttribute("Appearance")]
        public Font SliderFont
        {
            get { return realSlider.SliderFont; }
            set { realSlider.SliderFont = sliderBox.Font = sliderlabel.Font = value; }
        }

        [CategoryAttribute("Appearance")]
        public Color SliderForeColor
        {
            get { return realSlider.SliderForeColor; }
            set { realSlider.SliderForeColor = sliderBox.ForeColor = sliderlabel.ForeColor = value; }
        }

        string labelText = "Slider";
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Label Text")]
        public string LabelText
        {
            get { return labelText; }
            set { labelText = value; sliderlabel.Text = value; }
        }

        bool displayLabel = true;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display the slider Label")]
        public bool DisplayLabel
        {
            get { return displayLabel; }
            set { displayLabel = value; sliderlabel.Visible = value; }
        }

        bool displayEditBox = true;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display the slider EditBox")]
        public bool DisplayEditBox
        {
            get { return displayEditBox; }
            set { displayEditBox = value; sliderBox.Visible = value; }
        }

        bool displayEditButton = false;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display the additional button")]
        public bool DisplayEditButton
        {
            get { return displayEditButton; }
            set { displayEditButton = value; sliderButton.Visible = value; }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("The EditBox BackColor")]
        public Color DisplayEditBoxBackColor
        {
            get { return sliderBox.BackColor; }
            set { sliderBox.BackColor = value; }
        }

        public string ButtonName
        {
            get { return sliderButton.Name; }
            set { sliderButton.Name = value;}
        }

        SliderButtonStatus buttonStatus = SliderButtonStatus.Empty;
        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Status of the additional button")]
        public SliderButtonStatus ButtonStatus
        {
            get { return buttonStatus; }
            set
            {
                buttonStatus = value;
                switch (value)
                {
                    case SliderButtonStatus.Keyed :
                        sliderButton.BackgroundImage = global::TK.GraphComponents.Properties.Resources.Keying_Keyed;
                        break;

                    case SliderButtonStatus.OnKey :
                        sliderButton.BackgroundImage = global::TK.GraphComponents.Properties.Resources.Keying_OnKey;
                        break;

                    default :
                        sliderButton.BackgroundImage = global::TK.GraphComponents.Properties.Resources.Keying_Empty;
                        break;
                }
            }
        }

        // ========================================================================================
        // FROM REALSLIDER
        // ========================================================================================

        [CategoryAttribute("Behavior")]
        [DescriptionAttribute("The Ticks Frequency")]
        public int TickFrequency
        {
            get { return realSlider.TickFrequency; }
            set { realSlider.TickFrequency = value;}
        }

        [CategoryAttribute("Behavior")]
        [DescriptionAttribute("The minimum")]
        public int Minimum
        {
            get { return realSlider.Minimum; }
            set { realSlider.Minimum = value; realSlider.UpdateLabels(); }
        }

        [CategoryAttribute("Behavior")]
        [DescriptionAttribute("The maximum")]
        public int Maximum
        {
            get { return realSlider.Maximum; }
            set { realSlider.Maximum = value; realSlider.UpdateLabels(); }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The Double minimum")]
        public double DoubleMinimum
        {
            get { return realSlider.DoubleMinimum; }
            set { realSlider.DoubleMinimum = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The Double maximum")]
        public double DoubleMaximum
        {
            get { return realSlider.DoubleMaximum; }
            set { realSlider.DoubleMaximum = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The Double value")]
        public int Value
        {
            get { return realSlider.Value; }
            set { realSlider.Value = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The number of decimals for Double values (0 mean int)")]
        public int Decimals
        {
            get { return realSlider.Decimals; }
            set { realSlider.Decimals = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("The Double value")]
        public double DoubleValue
        {
            get { return realSlider.DoubleValue; }
            set { realSlider.DoubleValue = value; }
        }

        // Default -------------------------------------------------

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("Tells if the default is consistent")]
        public bool HasDefault
        {
            get { return realSlider.HasDefault; }
            set { realSlider.HasDefault = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("Default value")]
        public int DefaultValue
        {
            get { return realSlider.DefaultValue; }
            set { realSlider.DefaultValue = value; }
        }

        [CategoryAttribute("Additional Behavior")]
        [DescriptionAttribute("Double default value")]
        public double DoubleDefaultValue
        {
            get { return realSlider.DoubleDefaultValue; }
            set { realSlider.DoubleDefaultValue = value; }
        }

        // Additional display -------------------------------------------------

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display start and end values")]
        public bool DisplayFrames
        {
            get { return realSlider.DisplayFrames; }
            set { realSlider.DisplayFrames = value; }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display default value")]
        public bool DisplayDefault
        {
            get { return realSlider.DisplayDefault; }
            set { realSlider.DisplayDefault = value;}
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display additional labels for intermediate values")]
        public double FramesLabelsFrequency
        {
            get { return realSlider.FramesLabelsFrequency; }
            set { realSlider.FramesLabelsFrequency = value; }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display additional labels for intermediate values")]
        public bool FramesLabelsDynamicFrequency
        {
            get { return realSlider.FramesLabelsDynamicFrequency; }
            set { realSlider.FramesLabelsDynamicFrequency = value; }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Display start and end texts")]
        public bool DisplayTexts
        {
            get { return realSlider.DisplayTexts; }
            set { realSlider.DisplayTexts = value; }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Start text")]
        public string StartText
        {
            get { return realSlider.StartText; }
            set { realSlider.StartText = value; }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("End text")]
        public string EndText
        {
            get { return realSlider.EndText; }
            set { realSlider.EndText = value; }
        }

        [CategoryAttribute("Additional Display")]
        [DescriptionAttribute("Shows coloured intervals under the slider (need to be set programmatically using \"AddColorInterval\")")]
        public bool ShowIntervals
        {
            get { return realSlider.ShowIntervals; }
            set { realSlider.ShowIntervals = value; }
        }

        private void sliderBox_TextChanged(object sender, EventArgs e)
        {
            if (!MuteEvents)
            {
                int oldValue = (int)GetBoxValue(sliderBox, realSlider);
                if (oldValue <= realSlider.Maximum && oldValue >= realSlider.Minimum)
                {
                    MuteEvents = true;
                    realSlider.Value = oldValue;
                    MuteEvents = false;
                }
                else
                {
                    MuteEvents = true;
                    SetBoxValue(sliderBox, realSlider);
                    MuteEvents = false;
                }
            }
        }

        private double GetBoxValue(TextBox box, RealSlider track)
        {
            double oldValue = (double)track.Value;
            if (double.TryParse(box.Text, out oldValue))
            {
                return oldValue * Math.Pow(10, realSlider.Decimals);
            }

            return oldValue;
        }

        private void SetBoxValue(TextBox box, RealSlider track)
        {
            double value = track.DoubleValue;
            box.Text = String.Format("{0:0.##}", value);
        }

        private void realSlider_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(new EventArgs());

            if (!MuteEvents)
            {
                MuteEvents = true;
                SetBoxValue(sliderBox, realSlider);
                MuteEvents = false;
            }
        }

        private void realSlider_StopValueChanged(object sender, EventArgs e)
        {
            OnStopValueChanged(new EventArgs());
        }

        //Transfer basic mouse Events to Parent

        private void CompleteSlider_MouseUp(object sender, MouseEventArgs e)
        {
            Control senderCtrl = sender as Control;
            Point scaledPoint = PointToClient(senderCtrl.PointToScreen(e.Location));

            OnMouseUp(new MouseEventArgs(e.Button, e.Clicks, scaledPoint.X, scaledPoint.Y, e.Delta));
        }

        private void CompleteSlider_MouseDown(object sender, MouseEventArgs e)
        {
            Control senderCtrl = sender as Control;
            Point scaledPoint = PointToClient(senderCtrl.PointToScreen(e.Location));

            OnMouseDown(new MouseEventArgs(e.Button, e.Clicks, scaledPoint.X, scaledPoint.Y, e.Delta));
        }

        private void sliderButton_Click(object sender, EventArgs e)
        {
            ButtonClicked(sender, e);
        }
    }
}
