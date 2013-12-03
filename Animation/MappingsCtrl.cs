using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TK.GraphComponents.Animation
{
    public partial class MappingsCtrl : UserControl
    {
        public MappingsCtrl()
        {
            InitializeComponent();
        }

        List<RemapRow> rows = new List<RemapRow>();
        public List<RemapRow> Rows
        {
            get { return rows; }
            set { rows = value; RefreshSource(); }
        }

        public void RefreshSource()
        {
            ControlsView.DataSource = rows;
        }

        public bool SaveChanges
        {
            get { return SaveChangesCB.Checked; }
            set { SaveChangesCB.Checked = value; }
        }

        public bool SaveNewEntries
        {
            get { return SaveNewCB.Checked; }
            set { SaveNewCB.Checked = value; }
        }

        public Button PickButton
        {
            get { return PickBT; }
            set { PickBT = value;}
        }

        public Button OKButton
        {
            get { return OKBT; }
            set { OKBT = value; }
        }

        public RemapRow SelectedRow
        {
            get
            {
                if(ControlsView.SelectedCells.Count > 0)
                {
                    return rows[ControlsView.SelectedCells[0].RowIndex];
                }

                return null;
            }
        }

        public string SelectedValue
        {
            get
            {
                RemapRow sel = SelectedRow;
                if (sel != null)
                {
                    return sel.Retarget;
                }

                return "#VOID";
            }

            set
            {
                RemapRow sel = SelectedRow;
                if (sel != null)
                {
                    sel.Retarget = value;
                    ControlsView.Invalidate();
                }
            }
        }
    }
}
