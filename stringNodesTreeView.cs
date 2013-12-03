using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;
using System.Drawing;
using TK.BaseLib.CustomData;

namespace TK.GraphComponents
{
    public partial class stringNodesTreeView : TreeView
    {
        #region Events
        public event NodeRenamedEventHandler NodeRenamedEvent;
        public event NodeAddedEventHandler NodeAddedEvent;
        public event NodeRemovedEventHandler NodeRemovedEvent;
        public event NodeMovedEventHandler NodeMovedEvent;

        public virtual void OnNodeRenamed(NodeRenamedEventArgs e)
        {
            NodeRenamedEvent(this, e);
        }

        public virtual void OnNodeAdded(NodeAddedEventArgs e)
        {
            NodeAddedEvent(this, e);
        }

        public virtual void OnNodeRemoved(NodeRemovedEventArgs e)
        {
            NodeRemovedEvent(this, e);
        }

        public virtual void OnNodeMoved(NodeMovedEventArgs e)
        {
            NodeMovedEvent(this, e);
        }
        #endregion

        public stringNodesTreeView()
        {
            InitializeComponent();
            
            InitEvents();

            if (EnableReorderNodes)
            {
                AllowDrop = true;
            }
        }

        public stringNodesTreeView(IContainer container)
        {
            container.Add(this);
            InitializeComponent();

            InitEvents();

            if (EnableReorderNodes)
            {
                AllowDrop = true;
            }
        }

        private void InitEvents()
        {
            ParentChanged += new EventHandler(stringNodesTreeView_ParentChanged);
            MouseUp += new MouseEventHandler(stringNodesTreeView_MouseUp);
            mNameBox.TextChanged += new EventHandler(mNameBox_TextChanged);
            mNameBox.KeyUp += new KeyEventHandler(mNameBox_KeyUp);
            KeyUp += new KeyEventHandler(stringNodesTreeView_KeyUp);

            NodeRenamedEvent += new NodeRenamedEventHandler(stringNodesTreeView_NodeRenamedEvent);
            NodeAddedEvent += new NodeAddedEventHandler(stringNodesTreeView_NodeAddedEvent);
            NodeRemovedEvent += new NodeRemovedEventHandler(stringNodesTreeView_NodeRemovedEvent);
            NodeMovedEvent += new NodeMovedEventHandler(stringNodesTreeView_NodeMovedEvent);

            ItemDrag += new ItemDragEventHandler(stringNodesTreeView_ItemDrag);
            DragEnter += new DragEventHandler(stringNodesTreeView_DragEnter);
            DragOver += new DragEventHandler(stringNodesTreeView_DragOver);
            DragDrop += new DragEventHandler(stringNodesTreeView_DragDrop);

        }

        void stringNodesTreeView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

            Point clientHit = PointToClient(new Point(e.X, e.Y));
            TreeNode destination = HitTest(clientHit).Node;
            TreeNode Dropped = null;

            if (destination == null)
            {
                stringNode last = StringNodeRoot.Nodes[StringNodeRoot.Nodes.Count - 1];
                if (nodesDic.ContainsKey(last.Name))
                {
                    destination = nodesDic[last.Name];
                }
            }

            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                Dropped = (TreeNode)e.Data.GetData(typeof(TreeNode));
            }
            else
            {
                if (e.Data.GetDataPresent(typeof(string)))
                {
                    string droppedStr = (string)e.Data.GetData(typeof(string));
                    if (!string.IsNullOrEmpty(droppedStr))
                    {
                        Dropped = new TreeNode(droppedStr);
                        IsAdding = true;
                    }
                }
            }


            if (Dropped != null && destination != null)
            {
                DropLocation newDrop;

                int deadZone = destination.Bounds.Height / 4;

                if ((clientHit.Y - destination.Bounds.Y) < deadZone)
                {
                    newDrop = DropLocation.Top;
                }
                else
                {
                    if ((clientHit.Y - destination.Bounds.Y) > (3 * deadZone))
                    {
                        newDrop = DropLocation.Bottom;
                    }
                    else
                    {
                        newDrop = DropLocation.On;
                    }
                }

                if (newDrop != DropMode || RefNode != destination)
                {
                    RefNode = destination;
                    DropMode = newDrop;
                    Invalidate();
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
                RefNode = null;
                IsAdding = false;
            }
        }

        int rows = 10000;
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        bool mDrawGrid = false;
        public bool DrawGrid
        {
            get { return mDrawGrid; }
            set { mDrawGrid = value; }
        }

        void stringNodesTreeView_DragDrop(object sender, DragEventArgs e)
        {
            if (IsAdding)
            {
                if (e.Data.GetDataPresent(typeof(string)))
                {
                    AddNewNode((string)e.Data.GetData(typeof(string)), RefNode.Tag as stringNode);
                }
            }
            else
            {
                if (e.Data.GetDataPresent(typeof(TreeNode)))
                {
                    TreeNode Dropped = (TreeNode)e.Data.GetData(typeof(TreeNode));

                    stringNode realParent = null;
                    stringNode refParent = null;

                    stringNode realDropped = null;
                    stringNode realRef = null;

                    int index = 0;

                    if (Dropped != null && RefNode != null)
                    {
                        realDropped = Dropped.Tag as stringNode;
                        realRef = RefNode.Tag as stringNode;

                        if (!realRef.IsChildOf(realDropped))
                        {

                            switch (DropMode)
                            {
                                case DropLocation.Top:

                                    if (Dropped.Parent != null)
                                    {
                                        realParent = Dropped.Parent.Tag as stringNode;
                                    }
                                    else
                                    {
                                        realParent = StringNodeRoot;
                                    }

                                    if (RefNode.Parent != null)
                                    {
                                        refParent = RefNode.Parent.Tag as stringNode;
                                    }
                                    else
                                    {
                                        refParent = StringNodeRoot;
                                    }

                                    realParent.Nodes.Remove(realDropped);

                                    index = 0;
                                    foreach (stringNode child in refParent.Nodes)
                                    {
                                        if (child == realRef)
                                        {
                                            break;
                                        }
                                        index++;
                                    }

                                    refParent.Nodes.Insert(index, realDropped);
                                    realDropped.Parent = refParent;
                                    Reset();
                                    OnNodeMoved(new NodeMovedEventArgs(realDropped, realParent, refParent, index));

                                    break;

                                case DropLocation.Bottom:

                                    if (Dropped.Parent != null)
                                    {
                                        realParent = Dropped.Parent.Tag as stringNode;
                                    }
                                    else
                                    {
                                        realParent = StringNodeRoot;
                                    }

                                    if (RefNode.Parent != null)
                                    {
                                        refParent = RefNode.Parent.Tag as stringNode;
                                    }
                                    else
                                    {
                                        refParent = StringNodeRoot;
                                    }

                                    realParent.Nodes.Remove(realDropped);

                                    index = 0;
                                    foreach (stringNode child in refParent.Nodes)
                                    {
                                        if (child == realRef)
                                        {
                                            index++;
                                            break;
                                        }
                                        index++;
                                    }

                                    refParent.Nodes.Insert(index, realDropped);
                                    realDropped.Parent = refParent;
                                    Reset();
                                    OnNodeMoved(new NodeMovedEventArgs(realDropped, realParent, refParent, index));

                                    break;

                                default:
                                    if (Dropped != RefNode)
                                    {
                                        if (Dropped.Parent != null)
                                        {
                                            realParent = Dropped.Parent.Tag as stringNode;
                                        }
                                        else
                                        {
                                            realParent = StringNodeRoot;
                                        }

                                        realRef.AddNode(realDropped);
                                        Reset();
                                        OnNodeMoved(new NodeMovedEventArgs(realDropped, realParent, realRef, realRef.Nodes.Count - 1));
                                    }
                                    break;
                            }
                        }
                    }
                }
            }

            Invalidate();
            RefNode = null;
            IsAdding = false;
        }

        void stringNodesTreeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void stringNodesTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (EnableReorderNodes && (e.Item as TreeNode).Tag is stringNode)
            {
                mNameBox.DoDragDrop(e.Item as TreeNode, DragDropEffects.Copy);
            }
        }

        void stringNodesTreeView_NodeMovedEvent(object sender, NodeMovedEventArgs e)
        {
        }

        void stringNodesTreeView_NodeRemovedEvent(object sender, NodeRemovedEventArgs e)
        {
        }

        void stringNodesTreeView_NodeAddedEvent(object sender, NodeAddedEventArgs e)
        {
        }

        void stringNodesTreeView_NodeRenamedEvent(object sender, NodeRenamedEventArgs e)
        {
        }

        Dictionary<string, TreeNode> nodesDic = new Dictionary<string, TreeNode>();
        stringNode StringNodeRoot;
        DropLocation DropMode = DropLocation.On;
        TreeNode RefNode = null;
        bool IsAdding = false;

        bool mEnableRenameNode = false;
        public bool EnableRenameNode
        {
            get { return mEnableRenameNode; }
            set { mEnableRenameNode = value; }
        }

        bool mCreateRoot = false;
        public bool CreateRoot
        {
            get { return mCreateRoot; }
            set { mCreateRoot = value; }
        }

        bool mEnableManageNodes = false;
        public bool EnableManageNodes
        {
            get { return mEnableManageNodes; }
            set { mEnableManageNodes = value; }
        }

        bool mEnableReorderNodes = false;
        public bool EnableReorderNodes
        {
            get { return mEnableReorderNodes; }
            set { mEnableReorderNodes = value; }
        }

        TextBox mNameBox = new TextBox();

        void stringNodesTreeView_KeyUp(object sender, KeyEventArgs e)
        {
            if (EnableRenameNode && SelectedNode != null && e.KeyData == Keys.F2)
            {
                ShowContextMenu(PointToClient(Cursor.Position), SelectedNode, true, false);
            }
        }

        void stringNodesTreeView_ParentChanged(object sender, EventArgs e)
        {
            if (mNameBox.Parent != null)
            {
                mNameBox.Parent.Controls.Remove(mNameBox);
            }

            Control parent = Parent;
            if (Parent != null)
            {
                parent.Controls.Add(mNameBox);
                mNameBox.Visible = false;
            }
        }

        void stringNodesTreeView_MouseUp(object sender, MouseEventArgs e)
        {
            if (mNameBox.Visible)
            {
                mNameBox.Visible = false;
            }

            if (e.Button == MouseButtons.Right && (mEnableRenameNode || mEnableManageNodes))
            {
                TreeViewHitTestInfo test = HitTest(e.Location);

                if (test.Node == null && mEnableManageNodes)
                {

                }
                else
                {
                    if (mEnableRenameNode || mEnableManageNodes)
                    {
                        ShowContextMenu(e.Location, test.Node, mEnableRenameNode, mEnableManageNodes);
                    }
                }
            }
        }

        private void ShowContextMenu(Point point, TreeNode node, bool rename, bool delete)
        {
            ContextMenu menu = new ContextMenu();
            if (rename)
            {
                MenuItem renameItem = new MenuItem("Rename node", RenameNode, Shortcut.F2);
                mNameBox.Tag = node;
                menu.MenuItems.Add(renameItem);
            }

            if (delete)
            {
                MenuItem deleteItem = new MenuItem("Delete node", DeleteNode, Shortcut.Del);
                deleteItem.Tag = node;
                menu.MenuItems.Add(deleteItem);

                MenuItem addItem = new MenuItem("Add node", AddNode, Shortcut.CtrlN);
                addItem.Tag = node;
                menu.MenuItems.Add(addItem);
            }

            menu.Show(this, point);
        }

        void RenameNode(object sender, EventArgs e)
        {
            TreeNode node = mNameBox.Tag as TreeNode;

            if (node != null)
            {
                mNameBox.Text = node.Text;
                mNameBox.Location = Parent.PointToClient(PointToScreen(node.Bounds.Location));
                mNameBox.Visible = true;
                mNameBox.BringToFront();
            }
        }

        void DeleteNode(object sender, EventArgs e)
        {
            MenuItem item = sender as MenuItem;

            if (item != null)
            {
                TreeNode node = item.Tag as TreeNode;

                if (node != null)
                {
                    stringNode realRemoved = node.Tag as stringNode;

                    //Reparent children

                    stringNode realRoot = null;
                    TreeNode parent = node.Parent;

                    if (parent != null)
                    {
                        realRoot = parent.Tag as stringNode;
                    }
                    else
                    {
                        realRoot = StringNodeRoot;
                    }

                    foreach (TreeNode subNode in node.Nodes)
                    {
                        stringNode realNode = subNode.Tag as stringNode;
                        realRoot.AddNode(realNode);
                    }

                    realRoot.Nodes.Remove(node.Tag as stringNode);

                    Reset();
                    OnNodeRemoved(new NodeRemovedEventArgs(realRemoved, realRoot));
                }
            }
        }

        void AddNode(object sender, EventArgs e)
        {
           MenuItem item = sender as MenuItem;

            if (item != null)
            {
                TreeNode node = item.Tag as TreeNode;

                if (node != null)
                {
                    IsAdding = true;

                    mNameBox.Text = "New node";
                    mNameBox.Location = Parent.PointToClient(PointToScreen(new Point(node.Bounds.Location.X + 15, node.Bounds.Location.Y + 15)));
                    mNameBox.Visible = true;
                    mNameBox.BringToFront();
                }
            }
        }

        void mNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        void mNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TreeNode node = mNameBox.Tag as TreeNode;

                if (node != null)
                {
                    if (!nodesDic.ContainsKey(mNameBox.Text))
                    {
                        stringNode realNode = node.Tag as stringNode;

                        if (!IsAdding)
                        {
                            NodeRenamedEventArgs args = new NodeRenamedEventArgs(realNode, node.Text);

                            realNode.Name = mNameBox.Text;
                            node.Name = mNameBox.Text;
                            node.Text = mNameBox.Text;

                            OnNodeRenamed(args);
                        }
                        else
                        {
                            AddNewNode(mNameBox.Text, realNode);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Node " + mNameBox.Text + " already exist !");
                    }
                }
                IsAdding = false;
                mNameBox.Visible = false;
            }
        }

        private void AddNewNode(string inName, stringNode parent)
        {
            if (!nodesDic.ContainsKey(inName))
            {
                stringNode newNode = new stringNode(inName);
                parent.AddNode(newNode);

                Reset();
                OnNodeAdded(new NodeAddedEventArgs(newNode, parent));
            }
            else
            {
                MessageBox.Show("Node " + inName + " already exist !");
            }
        }

        private void Reset()
        {
            Set(StringNodeRoot, CreateRoot);
        }

        public void Set(stringNode Root, bool createRoot)
        {
            Nodes.Clear();
            nodesDic.Clear();

            StringNodeRoot = Root;
            CreateRoot = createRoot;

            if (createRoot)
            {
                TreeNode root = new TreeNode(Root.Name);

                Nodes.Add(root);
                nodesDic.Add(Root.Name, root);

                root.SelectedImageIndex = 2;
                root.ImageIndex = 2;

                root.Tag = Root;

                Set(Root, root);
            }
            else
            {
                foreach (stringNode node in Root.Nodes)
                {
                    TreeNode categNode = new TreeNode(node.Name);
                    Nodes.Add(categNode);
                    nodesDic.Add(node.Name, categNode);

                    categNode.ImageIndex = 2;
                    categNode.SelectedImageIndex = 2;
                    categNode.ToolTipText = node.Description;
                    categNode.Tag = node;
                    Set(node, categNode);
                }
            }

            ExpandAll();
        }

        private void Set(stringNode inNode, TreeNode parentNode)
        {
            foreach (stringNode node in inNode.Nodes)
            {
                TreeNode categNode = new TreeNode(node.Name);
                parentNode.Nodes.Add(categNode);
                nodesDic.Add(node.Name, categNode);

                categNode.ImageIndex = 2;
                categNode.SelectedImageIndex = 2;
                categNode.ToolTipText = node.Description;
                categNode.Tag = node;
                Set(node, categNode);
            }
        }

        protected override void  OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if(RefNode != null)
            {
                switch(DropMode)
                {
                    case DropLocation.Top :
                        e.Graphics.DrawLine(Pens.Black, RefNode.Bounds.Location, new Point(RefNode.Bounds.X + RefNode.Bounds.Width, RefNode.Bounds.Y));
                        break;

                    case DropLocation.Bottom:
                        e.Graphics.DrawLine(Pens.Black, new Point(RefNode.Bounds.X, RefNode.Bounds.Y + RefNode.Bounds.Height), new Point(RefNode.Bounds.X + RefNode.Bounds.Width, RefNode.Bounds.Y + RefNode.Bounds.Height));
                        break;
                    
                    default :
                        e.Graphics.DrawRectangle(Pens.Black, RefNode.Bounds);
                        break;
                }
            }

            if (DrawGrid)
            {
                int y = 0;

                while (y < Height && y <= Rows * ItemHeight)
                {
                    e.Graphics.DrawLine(Pens.Gainsboro, new Point(0, y), new Point(Width, y));
                    y += ItemHeight;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case (15):
                    {
                        PaintEventArgs pae = new PaintEventArgs(
                        Graphics.FromHwnd((m.HWnd)),
                        new Rectangle(0, 0, this.Width, this.Height));

                        OnPaint(pae);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }

    #region Events Handlers
    public delegate void NodeRenamedEventHandler(object sender, NodeRenamedEventArgs e);

    public class NodeRenamedEventArgs : EventArgs
    {
        public NodeRenamedEventArgs(stringNode RenamedNode, string oldName)
        {
            Node = RenamedNode;
            OldName = oldName;
        }

        public stringNode Node;
        public string OldName;
    }

    public delegate void NodeAddedEventHandler(object sender, NodeAddedEventArgs e);

    public class NodeAddedEventArgs : EventArgs
    {
        public NodeAddedEventArgs(stringNode AddedNode, stringNode inParent)
        {
            Node = AddedNode;
            Parent = inParent;
        }

        public stringNode Node;
        public stringNode Parent;
    }

    public delegate void NodeRemovedEventHandler(object sender, NodeRemovedEventArgs e);

    public class NodeRemovedEventArgs : EventArgs
    {
        public NodeRemovedEventArgs(stringNode RemovedNode, stringNode inParent)
        {
            Node = RemovedNode;
            Parent = inParent;
        }

        public stringNode Node;
        public stringNode Parent;
    }

    public delegate void NodeMovedEventHandler(object sender, NodeMovedEventArgs e);

    public class NodeMovedEventArgs : EventArgs
    {
        public NodeMovedEventArgs(stringNode MovedNode, stringNode inOldParent, stringNode inNewParent, int index)
        {
            Node = MovedNode;
            OldParent = inOldParent;
            NewParent = inNewParent;
            Index = index;
        }

        public stringNode Node;
        public stringNode OldParent;
        public stringNode NewParent;
        public int Index;
    }

    #endregion

    public enum DropLocation
    {
        On, Top, Bottom
    }
}
