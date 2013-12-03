using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public partial class DraggableTBLine : UserControl, IDroppableCollection
    {
        public DraggableTBLine()
        {
            InitializeComponent();
        }

        private void DraggableTBLine_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));
            if(data != "")
            {
                AddItem(data);
            }
        }

        public bool HasItem(string data)
        {
            foreach (DraggableTB tb in items)
            {
                if (tb.TBText == data)
                {
                    return true;
                }
            }

            return false;
        }

        public DraggableTB GetItem(string data)
        {
            foreach (DraggableTB tb in items)
            {
                if (tb.TBText == data)
                {
                    return tb;
                }
            }

            return null;
        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            DraggableTB tb = GetItem(box.Text);

            if (box.Text == "" || (tb != null && tb.textBox != box))
            {
                box.BackColor = Color.Red;
            }
            else
            {
                box.BackColor = SystemColors.Window;
            }
        }

        private void DraggableTBLine_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public Panel Content
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }


        List<DraggableTB> items = new List<DraggableTB>();

        #region IDroppableCollection Members
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<DraggableTB> MapItems
        {
            get{return items;}
            set{items = value;}
        }

        public void RemoveItem(string TBText)
        {
            DraggableTB tb = GetItem(TBText);

            if (tb != null)
            {
                items.Remove(tb);
                ContentPanel.Controls.Remove(tb);
            }
        }

        public void AddItem(string TBText)
        {
            if (!HasItem(TBText))
            {
                DraggableTB tb = new DraggableTB();
                tb.TBText = TBText;
                tb.textBox.TextChanged += new EventHandler(textBox_TextChanged);
                items.Add(tb);
                ContentPanel.Controls.Add(tb);
                tb.Dock = DockStyle.Left;
                tb.BringToFront();
            }
        }

        #endregion
    }
}
