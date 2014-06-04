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
    public partial class SaveActionCtrl : UserControl
    {
        public SaveActionCtrl()
        {
            InitializeComponent();

            List<object> items = new List<object>();

            //TYPEDD
            items.Add("Pose");
            items.Add("Animation");
            items.Add("Cycle");

            typeDD.Items = items;
            typeDD.SelectedIndex = 1;

            items.Clear();
            //CAPTUREDD
            items.Add("shaded");
            items.Add("texturedecal");
            items.Add("textured");
            items.Add("OpenGL");

            captureDD.Items = items;
            captureDD.SelectedIndex = 1;
        }

        bool muteEvents = false;

        string actionName = "";
        public string ActionName
        {
            get { return actionName; }
            set { actionName = value; nameTB.Text = value; }
        }

        string category = "Undefined";
        public string Category
        {
            get { return category; }
            set { category = value; categoryTB.Text = value; }
        }

        ActionTypes type = ActionTypes.Anim;
        public ActionTypes Type
        {
            get { return type; }
            set
            {
                type = value;

                switch(value)
                {
                    case ActionTypes.Anim :
                        typeDD.SelectedIndex = 1;
                        break;
                    case ActionTypes.Cycle:
                        typeDD.SelectedIndex = 2;
                        break;
                    default :
                        typeDD.SelectedIndex = 0;
                        break;
                }
            }
        }

        string captureMode = "textureddecal";
        public string CaptureMode
        {
            get { return captureMode; }
            set
            {
                switch(value)
                {
                    case "textureddecal" :
                        captureMode = "textureddecal";
                        captureDD.SelectedIndex = 1;
                        break;
                    case "textured":
                        captureMode = "textured";
                        captureDD.SelectedIndex = 2;
                        break;
                    case "OpenGL":
                        captureMode = "OpenGL";
                        captureDD.SelectedIndex = 3;
                        break;
                    default :
                        captureMode = "shaded";
                        captureDD.SelectedIndex = 0;
                        break;
                }
            }
        }

        double start = 0;
        public double Start
        {
            get { return start; }
            set { start = value; startFrameN.Value = (decimal)value; }
        }

        double end = 0;
        public double End
        {
            get { return end; }
            set { end = value; endFrameN.Value = (decimal)value; }
        }

        bool keyAll = false;
        public bool KeyAll
        {
            get { return keyAll; }
            set { keyAll = value; KeyAllCB.Checked = value; }
        }

        bool onlySelected = false;
        public bool OnlySelected
        {
            get { return onlySelected; }
            set { onlySelected = value; OnlySelectedCB.Checked = value; }
        }


        public Button StoreBT
        {
            get { return storeBT; }
        }

        private void startFrameN_ValueChanged(object sender, EventArgs e)
        {
            if (!muteEvents)
            {
                muteEvents = true;
                if (type == ActionTypes.Pose)
                {
                    endFrameN.Value = startFrameN.Value;
                }
                else
                {
                    if (endFrameN.Value < startFrameN.Value)
                    {
                        endFrameN.Value = startFrameN.Value + 1;
                    }
                }
                muteEvents = false;
            }

            start = decimal.ToDouble(startFrameN.Value);
        }

        private void endFrameN_ValueChanged(object sender, EventArgs e)
        {
            if (!muteEvents)
            {
                muteEvents = true;
                if (type == ActionTypes.Pose)
                {
                    startFrameN.Value = endFrameN.Value;
                }
                else
                {
                    if (endFrameN.Value < startFrameN.Value)
                    {
                        startFrameN.Value = endFrameN.Value - 1;
                    }
                }
                muteEvents = false;
            }

            end = decimal.ToDouble(endFrameN.Value);
        }

        private void OnlySelectedCB_CheckedChanged(object sender, EventArgs e)
        {
            onlySelected = OnlySelectedCB.Checked;
        }

        private void KeyAllCB_CheckedChanged(object sender, EventArgs e)
        {
            keyAll = KeyAllCB.Checked;
        }

        private void typeDD_TextChanged(object sender, EventArgs e)
        {
            switch (typeDD.SelectedIndex)
            {
                case 1:
                    type = ActionTypes.Anim;
                    break;
                case 2:
                    type = ActionTypes.Cycle;
                    break;
                default:
                    type = ActionTypes.Pose;
                    End = start;
                    break;
            }
        }

        private void captureDD_TextChanged(object sender, EventArgs e)
        {
            captureMode = captureDD.Text;
        }

        private void categoryTB_TextChanged(object sender, EventArgs e)
        {
            category = categoryTB.Text;
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            actionName = nameTB.Text;
        }

        private void storeBT_Click(object sender, EventArgs e)
        {

        }
    }
}
