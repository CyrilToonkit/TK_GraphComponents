using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents
{
    public partial class DraggableTB : UserControl
    {
        public DraggableTB()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        Graphics graphics = null;
        Point RefPoint = new Point();
        bool isDragging = false;

        public TextBox textBox
        {
            get { return TB; }
            set { TB = value; }
        }

        public string TBText
        {
            get { return TB.Text; }
            set { TB.Text = value; }
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            Width = 20 + Math.Max(50,(int)graphics.MeasureString(TB.Text, TB.Font).Width + 13);
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            RefPoint = e.Location;
            isDragging = true;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                if (Math.Abs(e.X - RefPoint.X) > 2 || Math.Abs(e.Y - RefPoint.Y) > 2)
                {
                    isDragging = false;
                    DoDragDrop(TBText, DragDropEffects.Copy);
                }
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //ContextMenu
                contextMenuStrip1.Show(Cursor.Position);
            }

            isDragging = false;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDroppableCollection ctrl = Parent.Parent as IDroppableCollection;
            if (ctrl != null)
            {
                ctrl.RemoveItem(TBText);
            }
        }
    }
}
