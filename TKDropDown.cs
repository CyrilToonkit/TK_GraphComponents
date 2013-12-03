using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TK.GraphComponents
{
    public class TKDropDown : TextBox
    {
        public TKDropDown()
        {
            ParentChanged += new EventHandler(TKDropDown_ParentChanged);
            ReadOnly = true;
            internalLB.Visible = false;
            MouseUp += new MouseEventHandler(TKDropDown_MouseUp);
            internalLB.SelectedIndexChanged += new EventHandler(internalLB_SelectedIndexChanged);
            TextChanged += new EventHandler(TKDropDown_TextChanged);
        }

        public FloatingListBox InternalLB
        {
            get { return internalLB; }
            set { internalLB = value; }
        }

        void TKDropDown_TextChanged(object sender, EventArgs e)
        {
            if (mAllowCustomValue)
            {
                mCustomValue = Text;
            }
        }

        void internalLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = internalLB.SelectedIndex;
            if (mAllowCustomValue && SelectedIndex == mItems.Count - 1)
            {
                ReadOnly = false;
            }
            else
            {
                ReadOnly = true;
            }

            internalLB.Visible = false;
        }

        void TKDropDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (internalLB.Parent == null)
            {
                TKDropDown_ParentChanged(null, new EventArgs());
            }

            if(internalLB.Parent != null)
            {
                Point ScreenLoc = Parent.PointToScreen(new Point(Location.X, Location.Y + Height));
                internalLB.Location = internalLB.Parent.PointToClient(ScreenLoc);
                internalLB.Width = Width;
                internalLB.Height = internalLB.Items.Count * 20;

                //If bottom of Form, display on top
                Form parentForm = FindForm();
                if (parentForm != null)
                {
                    if (parentForm.Location.Y + parentForm.Height <= ScreenLoc.Y + internalLB.Height)
                    {
                        ScreenLoc.Y -= internalLB.Height + Height;
                        internalLB.Location = internalLB.Parent.PointToClient(ScreenLoc);
                    }
                }

                internalLB.Visible = true;
                internalLB.BringToFront();
            }
        }

        void TKDropDown_ParentChanged(object sender, EventArgs e)
        {
            if (internalLB.Parent != null)
            {
                internalLB.Parent.Controls.Remove(internalLB);
            }

            Form parentForm = FindForm();
            if (parentForm != null)
            {
                parentForm.Controls.Add(internalLB);
                internalLB.BringToFront();
            }
        }

        bool mAllowCustomValue = false;
        public bool AllowCustomValue
        {
            get { return mAllowCustomValue; }
            set { mAllowCustomValue = value; }
        }

        string mCustomValue = "";

        int mSelectedIndex = -1;
        public int SelectedIndex
        {
            get { return mSelectedIndex; }
            set
            {
                mSelectedIndex = value;
                internalLB.SelectedIndex = value;
                Text = "";
                if (internalLB.SelectedItem != null)
                {
                    Text = internalLB.SelectedItem.ToString();
                }
            }
        }

        public object SelectedItem
        {
            get
            {
                if (SelectedIndex == -1 || SelectedIndex >= Items.Count)
                {
                    return null;
                }

                return Items[SelectedIndex];
            }
        }

        List<object> mItems = new List<object>();
        public List<object> Items
        {
            get { return mItems; }
            set
            {
                mItems = value;
                internalLB.Items.Clear();

                foreach (object val in mItems)
                {
                    internalLB.Items.Add(val);
                }

                if (mAllowCustomValue)
                {
                    internalLB.Items.Add(mCustomValue);
                }
            }
        }

        FloatingListBox internalLB = new FloatingListBox();
    }
}
