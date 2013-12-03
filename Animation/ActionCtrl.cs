using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;
using TK.BaseLib.Animation;

namespace TK.GraphComponents.Animation
{
    public enum DisplayStyle
    {
        SmallIcons, LargeIcons, List
    }

    public partial class ActionCtrl : Panel
    {
        public ActionCtrl()
        {
            InitializeComponent();
        }

        public ActionCtrl(ActionsUI inUI,  TK_Action inAction)
        {
            InitializeComponent();
            UI = inUI;
            action = inAction;
            
            Style = DisplayStyle.SmallIcons;
        }

        private void SetImageDrawer()
        {
            double imgHeightRatio = 1;
            double imgWidthRatio = 1;

            int imgHeightOffset = 0;
            int imgWidthOffset = 0;

            if (action.Thumbnail.Width > action.Thumbnail.Height)
            {
                imgHeightRatio = (double)action.Thumbnail.Height / (double)action.Thumbnail.Width;
                imgHeightOffset = (int)((double)imgHeight * (1.0 - imgHeightRatio) / 2.0);
            }
            else
            {
                imgWidthRatio = (double)action.Thumbnail.Width / (double)action.Thumbnail.Height;
                imgWidthOffset = (int)((double)imgHeight * (1.0 - imgWidthRatio) / 2.0);
            }

            smallRect = new Rectangle(2 + imgWidthOffset, 2 + imgHeightOffset, (int)(100 * imgWidthRatio), (int)(100 * imgHeightRatio));
            bigRect = new Rectangle(2 + imgWidthOffset, 2 + imgHeightOffset, (int)(200 * imgWidthRatio), (int)(200 * imgHeightRatio));
        }

        private void SetSize()
        {
            Height = Width = 2 * imgBorder + imgHeight;
        }

        int imgHeight = 100;
        int imgBorder = 2;

        ActionsUI UI = null;
        Brush white50 = new SolidBrush(Color.FromArgb(128, 255, 255, 255));

        Point offset = new Point(2,2);
        Point textOffset = new Point(4, 3);

        Rectangle LabelRect;

        TK_Action action = null;
        public TK_Action Action
        {
            get { return action; }
            set { action = value; }
        }

        Rectangle smallRect = new Rectangle(2,2,100,100);
        Rectangle bigRect = new Rectangle(2, 2, 200, 200);

        public Rectangle ImageRectangle
        {
            get { return Style == DisplayStyle.LargeIcons ? bigRect : smallRect; }
        }

        bool selected = false;
        public bool Selected
        {
          get { return selected; }
          set { selected = value; Invalidate();}
        }

        DisplayStyle style = DisplayStyle.SmallIcons;
        public DisplayStyle Style
        {
            get { return style; }
            set
            {
                style = value;

                switch (value)
                {
                    case DisplayStyle.SmallIcons :
                            infoFont = new Font(infoFont.FontFamily.Name, 9f, infoFont.Style, GraphicsUnit.Pixel, 0, false);
                            Font = new Font(Font.FontFamily.Name, 12f, Font.Style, GraphicsUnit.Pixel, 0, false);
                            imgHeight = 100;
                        break;

                    case DisplayStyle.LargeIcons :
                            infoFont = new Font(infoFont.FontFamily.Name, 12f, infoFont.Style, GraphicsUnit.Pixel, 0, false);
                            Font = new Font(Font.FontFamily.Name, 14f, Font.Style, GraphicsUnit.Pixel, 0, false);
                            imgHeight = 200;
                        break;

                    case DisplayStyle.List :
                        infoFont = new Font(infoFont.FontFamily.Name, 12f, infoFont.Style, GraphicsUnit.Pixel, 0, false);
                        Font = new Font(Font.FontFamily.Name, 14f, Font.Style, GraphicsUnit.Pixel, 0, false);
                        imgHeight = 50;
                        break;
                }

                SetSize();
                SetImageDrawer();
            }
        }


        Font infoFont = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Pixel, 0, false);
        public Font InfoFont
        {
            get { return infoFont; }
            set { infoFont = value; }
        }

        Color selectedColor = SystemColors.Highlight;
        public Color SelectedColor
        {
            get { return selectedColor; }
            set { selectedColor = value; }
        }

        bool showIcon = true;
        public bool ShowIcon
        {
            get { return showIcon; }
            set { showIcon = value; Invalidate(); }
        }

        bool showCategory = false;
        public bool ShowCategory
        {
            get { return showCategory; }
            set { showCategory = value; }
        }

        bool showProject = false;
        public bool ShowProject
        {
            get { return showProject; }
            set { showProject = value; }
        }

        bool showModel = false;
        public bool ShowModel
        {
            get { return showModel; }
            set { showModel = value; }
        }

        bool showDate = false;
        public bool ShowDate
        {
            get { return showDate; }
            set { showDate = value; }
        }

        bool showLength = false;
        public bool ShowLength
        {
            get { return showLength; }
            set { showLength = value; }
        }

        bool showUser = false;
        public bool ShowUser
        {
            get { return showUser; }
            set { showUser = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(selected ? selectedColor :BackColor);

            if (action != null)
            {
                e.Graphics.DrawImage(action.Thumbnail, ImageRectangle);

                float heigth = e.Graphics.MeasureString("ABC", Font).Height + 2f;
                LabelRect = new Rectangle(imgBorder, imgBorder, imgHeight, (int)heigth);
                e.Graphics.FillRectangle(white50, LabelRect);

                e.Graphics.DrawString(action.Name, Font, Brushes.Black, textOffset);

                heigth = e.Graphics.MeasureString("ABC", infoFont).Height + 1f;

                if (ShowIcon)
                { e.Graphics.DrawImage(UI.Icons[action.Type], (2 * imgBorder + imgHeight) - 28, 2, 26, 26); }

                //Extra infos
                float offset = imgBorder + imgHeight;

                if (showCategory)
                { offset -= heigth; }
                if (showProject)
                { offset -= heigth; }
                if (showModel)
                { offset -= heigth; }
                if (showDate)
                { offset -= heigth; }
                if (showLength)
                { offset -= heigth; }
                if (showUser)
                { offset -= heigth; }

                if (offset < imgBorder + imgHeight)
                {
                    e.Graphics.FillRectangle(white50, new Rectangle(imgBorder, (int)offset - imgBorder, imgHeight, (2 * imgBorder + imgHeight) - (int)offset));

                    if (showCategory)
                    {
                        e.Graphics.DrawString("Category :  " + action.Category, infoFont, Brushes.Black, new PointF(6, offset));
                        offset += heigth;
                    }

                    if (showProject)
                    {
                        e.Graphics.DrawString("Project :  " + action.Project, infoFont, Brushes.Black, new PointF(6, offset));
                        offset += heigth;
                    }

                    if (showModel)
                    {
                        e.Graphics.DrawString("Model :  " + action.Model, infoFont, Brushes.Black, new PointF(6, offset));
                        offset += heigth;
                    }

                    if (showDate)
                    {
                        e.Graphics.DrawString("Date :  " + action.Birth.ToShortDateString(), infoFont, Brushes.Black, new PointF(6, offset));
                        offset += heigth;
                    }

                    if (showLength)
                    {
                        e.Graphics.DrawString("Length :  " + action.Duration.ToString() + " frames", infoFont, Brushes.Black, new PointF(6, offset));
                        offset += heigth;
                    }

                    if (showUser)
                    {
                        e.Graphics.DrawString("User :  " + action.CreatorName.ToString(), infoFont, Brushes.Black, new PointF(6, offset));
                    }
                }
            }
        }

        private void ActionCtrl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (ModifierKeys)
                {
                    case Keys.Shift:
                        UI.AddToSelection(this);
                        break;
                    case Keys.Control:
                        UI.ToggleSelection(this);
                        break;
                    case Keys.Alt:
                        UI.RemoveFromSelection(this);
                        break;
                    default:
                        UI.Select(this);
                        break;
                }
            }
        }
    }
}
