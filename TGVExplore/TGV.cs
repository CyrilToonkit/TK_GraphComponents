using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;
using System.Runtime.InteropServices;
using TK.BaseLib.CustomData;

namespace TGVExplore
{
    public partial class TGV : UserControl
    {
        // == CONSTRUCTORS ================================================================

        public TGV()
        {
            InitializeComponent();
            newNodes = new List<TreeNode>();


            tgvTreeView.ItemHeight = mRowHeight;
            MasterGrid.RowTemplate.Height = mRowHeight;

            foreach(Control c in MasterGrid.Controls)
            {
                if(c is VScrollBar)
                {
                    vScroller = (VScrollBar)c;
                    break;
                }
            }

            Resize += new EventHandler(TGV_Resize);
            vScroller.VisibleChanged += new EventHandler(vScroller_VisibleChanged);
            MasterGrid.Scroll += new ScrollEventHandler(MasterGrid_Scroll);
            tgvTreeView.MouseWheel += new MouseEventHandler(tgvTreeView_MouseWheel);
        }

        // == MEMBERS ================================================================

        List<string> Columns = new List<string>();
        List<ITGVNode> Rows = new List<ITGVNode>();

        bool MuteEvents = false;
        bool ExpandAll = false;
        List<TreeNode> newNodes;

        private const int WM_VSCROLL = 277; // Vertical scroll
        private const int SB_LINEUP = 0; // Scrolls one line up
        private const int SB_LINEDOWN = 1; // Scrolls one line down
        private const int SB_ENDSCROLL = 8; // Ends scroll

        private const int BORDERWIDTH = 30;
        private const string FAKENODENAME = "TGVV";

        VScrollBar vScroller = null;
        int OldScroll = 0;

        int MaxRecur = 1000;
        int Recur = -1;

        // == PROPERTIES ================================================================

        private int mRowHeight = 20;
        public int RowHeight
        {
            get { return mRowHeight; }
            set
            {
                tgvTreeView.ItemHeight = value;
                MasterGrid.RowTemplate.Height = value;

                foreach (DataGridViewRow row in MasterGrid.Rows)
                    if (row.Height != mRowHeight) row.Height = value;

                mRowHeight = value;
            }
        }

        // == METHODS ================================================================

        public void Set(List<ITGVNode> nodes)
        {
            tgvTreeView.Nodes.Clear();
            Columns.Clear();
            Rows.Clear();

            foreach (ITGVNode node in nodes)
            {
                AddNode(null, node);
            }

            RefreshWidth(true);
        }

        public void AddNode(TreeNode parent, ITGVNode child)
        {
            TreeNode newNode = null;

            if (parent == null)
            {
                newNode = tgvTreeView.Nodes.Add(child.ITGV_UniqueName, child.ITGV_Name, child.ITGV_Type, child.ITGV_Type);
                newNode.Tag = child;
                Rows.Add(child);
            }
            else
            {
                newNode = parent.Nodes.Add(child.ITGV_UniqueName, child.ITGV_Name, child.ITGV_Type, child.ITGV_Type);
                newNode.Tag = child;

                int index = Rows.IndexOf(parent.Tag as ITGVNode);
                if (index != -1)
                {
                    Rows.Insert(index + parent.Nodes.Count, child);
                }
                else
                {
                    MessageBox.Show("Error getting " + parent.Text + " index in rows !");
                }
            }

            List<string> fields = child.ITGV_GetFields();
            foreach (string field in fields)
            {
                if (!Columns.Contains(field))
                {
                    Columns.Add(field);
                }
            }

            newNodes.Add(newNode);

            if (child.ITGV_HasChildren())
            {
                newNode.Nodes.Add(FAKENODENAME);
            }
        }

        // == SYNC CALLBACKS ================================================================
        
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        void TGV_Resize(object sender, EventArgs e)
        {
            RefreshScroll(vScroller.Value);
        }

        void tgvTreeView_MouseWheel(object sender, MouseEventArgs e)
        {
            ScrollGrid(vScroller.Value - (e.Delta / 40) * RowHeight);
        }

        void vScroller_VisibleChanged(object sender, EventArgs e)
        {
            if (!vScroller.Visible)
            {
                RefreshScroll(0);
                OldScroll = 0;
            }
        }

        void MasterGrid_Scroll(object sender, ScrollEventArgs e)
        {
            RefreshScroll(e.NewValue * RowHeight);
        }

        private void RefreshScroll(int ScrollValue)
        {
            int pixelsScrolled = ScrollValue;

            tgvTreeView.Location = new Point(tgvTreeView.Location.X, 21 - pixelsScrolled);
            tgvTreeView.Height = MainLayoutPanel.Height - 21 + pixelsScrolled;
        }

        private void ScrollGrid(int value)
        {
            int toScroll = value - vScroller.Value;
            IntPtr Ptr = (IntPtr)(toScroll > 0 ? SB_LINEDOWN : SB_LINEUP);

            toScroll = (Math.Abs(toScroll) + 1) / RowHeight;

            for (; toScroll > 0; toScroll--)
            {
                SendMessage(MasterGrid.Handle, WM_VSCROLL, Ptr, vScroller.Handle);
            }
        }

        public void RefreshWidth(bool shrink)
        {
            if (!ExpandAll)
            {
                int panelWidth = shrink ? 0 : (int)MainLayoutPanel.ColumnStyles[0].Width - BORDERWIDTH;
                foreach (TreeNode tn in newNodes)
                {
                    if (tn.Bounds.Right > panelWidth)
                    {
                        panelWidth = tn.Bounds.Right;
                    }
                }

                MainLayoutPanel.ColumnStyles[0].Width = panelWidth + BORDERWIDTH;
                tgvTreeView.Width = panelWidth + BORDERWIDTH;
                newNodes.Clear();

                RefreshGrid();
                tgvTreeView.Rows = Rows.Count;
            }
        }

        private void RefreshGrid()
        {
            MasterGrid.Rows.Clear();
            MasterGrid.Columns.Clear();
            
            if (Columns.Count > 0)
            {
                foreach (string col in Columns)
                {
                    MasterGrid.Columns[MasterGrid.Columns.Add(col, col)].SortMode = DataGridViewColumnSortMode.Programmatic;
                }

                foreach (ITGVNode node in Rows)
                {
                    object[] values = new object[Columns.Count];

                    int counter = 0;
                    foreach (string col in Columns)
                    {
                        values[counter] = node.ITGV_GetFieldValue(col);
                        counter++;
                    }

                    MasterGrid.Rows[MasterGrid.Rows.Add(values)].DefaultCellStyle.BackColor = node.ITGV_Type == "folder" ? Color.Cornsilk : Color.AliceBlue;
                }

                ScrollGrid(OldScroll);
            }
            else
            {
                MasterGrid.Columns.Add("default", "- No valid fields");
            }
        }

        //Expanding / Collapsing

        private void tgvTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            OldScroll = vScroller.Value;

            TreeNode ExNode = e.Node;
            if (ExNode.Nodes.Count == 1)
            {
                TreeNode child = e.Node.Nodes[0];
                if (child.Text == FAKENODENAME)
                {
                    List<ITGVNode> children = (ExNode.Tag as ITGVNode).ITGV_GetChildren();

                    if (children.Count > 0)
                    {
                        e.Node.Nodes.Remove(child);

                        foreach (ITGVNode node in children)
                        {
                            AddNode(ExNode, node);
                        }
                    }
                }
            }
        }

        private void tgvTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            bool expandAsked = false;
            if (!ExpandAll && ModifierKeys == Keys.Shift)
            {
                Recur = MaxRecur;
                expandAsked = true;
                ExpandAll = true;
            }

            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == FAKENODENAME)
            {
                MuteEvents = true;
                e.Node.Collapse();
                MuteEvents = false;
            }
            else
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    if ((ExpandAll && Recur > 0) || (node.Tag as ITGVNode).ITGV_Expanded)
                    {
                        node.Expand();
                        Recur--;
                    }
                }

                (e.Node.Tag as ITGVNode).ITGV_Expanded = true;
                if (!ExpandAll)
                {
                    RefreshWidth(false);
                }
            }

            if (expandAsked)
            {
                ExpandAll = false;
                RefreshWidth(false);
            }
        }

        private void tgvTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            OldScroll = vScroller.Value;

            if (!MuteEvents)
            {
                TreeNode ExNode = e.Node;
                bool expandAsked = false;
                if (!ExpandAll && ModifierKeys == Keys.Shift)
                {
                    expandAsked = true;
                    ExpandAll = true;
                }
                
                foreach (TreeNode node in ExNode.Nodes)
                {
                    ITGVNode tgvNode = node.Tag as ITGVNode;

                    Rows.Remove(tgvNode);

                    if (ExpandAll)
                    {
                        node.Collapse();
                    }
                    else
                    {
                        RemoveRows(node);
                    }
                }

                ExNode.Nodes.Clear();
                ExNode.Nodes.Add(FAKENODENAME);

                if (expandAsked)
                {
                    ExpandAll = false;
                }
            }
        }

        private void tgvTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (!MuteEvents)
            {
                (e.Node.Tag as ITGVNode).ITGV_Expanded = false;

                CollectNodes(tgvTreeView.Nodes);

                if (!ExpandAll)
                {
                    RefreshWidth(true);
                }
            }
        }

        private void CollectNodes(TreeNodeCollection treeNodeCollection)
        {
            foreach (TreeNode tn in treeNodeCollection)
            {
                if (tn.Text != FAKENODENAME)
                {
                    newNodes.Add(tn);
                    CollectNodes(tn.Nodes);
                }
            }
        }

        private void RemoveRows(TreeNode inNode)
        {
            if (inNode.Nodes.Count > 0 && inNode.Nodes[0].Text != FAKENODENAME)
            {
                foreach (TreeNode node in inNode.Nodes)
                {
                    Rows.Remove(node.Tag as ITGVNode);
                    RemoveRows(node);
                }
            }
        }
    }
}
