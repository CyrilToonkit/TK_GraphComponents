using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;
using TK.BaseLib.Animation;

namespace TK.GraphComponents
{
    public partial class DraggableTBLineCollection : UserControl
    {
        public DraggableTBLineCollection()
        {
            InitializeComponent();
        }

        ControlsMap map = null;

        public void LoadMap(ControlsMap inMap)
        {
            map = inMap;
            Reload();
        }

        public void Reload()
        {
            if (map != null)
            {
                SuspendLayout();
                LinesPanel.SuspendLayout();
                items.Clear();
                LinesPanel.Controls.Clear();

                foreach (List<string> remaps in map.ControlMaps)
                { 
                    DraggableTBLine line = new DraggableTBLine();
                    foreach (string remap in remaps)
                    {
                        line.AddItem(remap);
                    }
                    line.Content.ControlAdded += new ControlEventHandler(Line_ControlAdded);
                    line.Content.ControlRemoved += new ControlEventHandler(line_ControlRemoved);
                    items.Add(line);
                    LinesPanel.Controls.Add(line);
                    line.Dock = DockStyle.Top;
                    line.BringToFront();
                }

                CreateEmptyLine();

                ResumeLayout();
                LinesPanel.ResumeLayout();
            }
        }

        private void CreateEmptyLine()
        {
            DraggableTBLine emptyLine = new DraggableTBLine();
            emptyLine.Content.ControlAdded += new ControlEventHandler(Line_ControlAdded);
            emptyLine.Content.ControlRemoved += new ControlEventHandler(line_ControlRemoved);
            LinesPanel.Controls.Add(emptyLine);
            emptyLine.Dock = DockStyle.Top;
            emptyLine.BringToFront();
        }

        void line_ControlRemoved(object sender, ControlEventArgs e)
        {
            DraggableTBLine line = (sender as Control).Parent as DraggableTBLine;
            if (line.MapItems.Count == 0)
            {
                //Remove line
                items.Remove(line);
                LinesPanel.Controls.Remove(line);
            }
        }

        void Line_ControlAdded(object sender, ControlEventArgs e)
        {
            DraggableTBLine line = (sender as Control).Parent as DraggableTBLine;
            if (line.MapItems.Count == 1)
            {
                //It was the empty line
                items.Add(line);
                LinesPanel.Controls.Add(line);
                line.Dock = DockStyle.Top;
                line.BringToFront();

                CreateEmptyLine();
            }
            else
            {
                //Normal line

            }
        }

        List<DraggableTBLine> items = new List<DraggableTBLine>();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<DraggableTBLine> LineItems
        {
            get { return items; }
            set { items = value; }
        }

        private void ReloadBT_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {

        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            map.ControlMaps = new List<List<string>>();
            foreach (DraggableTBLine line in items)
            {

            }
        }
    }
}
