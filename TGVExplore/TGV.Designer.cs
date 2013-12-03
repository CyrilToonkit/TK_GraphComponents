using TK.GraphComponents;
namespace TGVExplore
{
    partial class TGV
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode8,
            treeNode9});
            this.tgvImagesLst = new System.Windows.Forms.ImageList(this.components);
            this.MasterGrid = new System.Windows.Forms.DataGridView();
            this.defCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NodeHeaderGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvTreeView = new stringNodesTreeView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodeHeaderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tgvImagesLst
            // 
            this.tgvImagesLst.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.tgvImagesLst.ImageSize = new System.Drawing.Size(16, 16);
            this.tgvImagesLst.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MasterGrid
            // 
            this.MasterGrid.AllowUserToAddRows = false;
            this.MasterGrid.AllowUserToDeleteRows = false;
            this.MasterGrid.AllowUserToOrderColumns = true;
            this.MasterGrid.AllowUserToResizeRows = false;
            this.MasterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MasterGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MasterGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MasterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.defCol});
            this.MasterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.MasterGrid.Location = new System.Drawing.Point(105, 1);
            this.MasterGrid.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.MasterGrid.Name = "MasterGrid";
            this.MasterGrid.RowHeadersVisible = false;
            this.MasterGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MasterGrid.RowTemplate.Height = 20;
            this.MasterGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MasterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MasterGrid.Size = new System.Drawing.Size(356, 374);
            this.MasterGrid.TabIndex = 2;
            // 
            // defCol
            // 
            this.defCol.HeaderText = "-No valid fields";
            this.defCol.Name = "defCol";
            this.defCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.MasterGrid, 1, 0);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 1;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(461, 375);
            this.MainLayoutPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NodeHeaderGV);
            this.panel1.Controls.Add(this.tgvTreeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 375);
            this.panel1.TabIndex = 3;
            // 
            // NodeHeaderGV
            // 
            this.NodeHeaderGV.AllowUserToAddRows = false;
            this.NodeHeaderGV.AllowUserToDeleteRows = false;
            this.NodeHeaderGV.AllowUserToOrderColumns = true;
            this.NodeHeaderGV.AllowUserToResizeRows = false;
            this.NodeHeaderGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NodeHeaderGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NodeHeaderGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.NodeHeaderGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NodeHeaderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NodeHeaderGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.NodeHeaderGV.Location = new System.Drawing.Point(0, 1);
            this.NodeHeaderGV.Margin = new System.Windows.Forms.Padding(0);
            this.NodeHeaderGV.Name = "NodeHeaderGV";
            this.NodeHeaderGV.RowHeadersVisible = false;
            this.NodeHeaderGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.NodeHeaderGV.RowTemplate.Height = 20;
            this.NodeHeaderGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NodeHeaderGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NodeHeaderGV.Size = new System.Drawing.Size(105, 21);
            this.NodeHeaderGV.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nodes";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tgvTreeView
            // 
            this.tgvTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tgvTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tgvTreeView.CreateRoot = false;
            this.tgvTreeView.DrawGrid = true;
            this.tgvTreeView.EnableManageNodes = false;
            this.tgvTreeView.EnableRenameNode = false;
            this.tgvTreeView.EnableReorderNodes = false;
            this.tgvTreeView.FullRowSelect = true;
            this.tgvTreeView.HideSelection = false;
            this.tgvTreeView.ImageIndex = 0;
            this.tgvTreeView.ImageList = this.tgvImagesLst;
            this.tgvTreeView.ItemHeight = 20;
            this.tgvTreeView.Location = new System.Drawing.Point(0, 21);
            this.tgvTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.tgvTreeView.Name = "tgvTreeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node2";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Node9";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Node8";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Node6";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Node7";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            this.tgvTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode10});
            this.tgvTreeView.Rows = 10000;
            this.tgvTreeView.Scrollable = false;
            this.tgvTreeView.SelectedImageIndex = 0;
            this.tgvTreeView.Size = new System.Drawing.Size(105, 354);
            this.tgvTreeView.TabIndex = 0;
            this.tgvTreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tgvTreeView_AfterCollapse);
            this.tgvTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tgvTreeView_BeforeExpand);
            this.tgvTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tgvTreeView_BeforeCollapse);
            this.tgvTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tgvTreeView_AfterExpand);
            // 
            // TGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "TGV";
            this.Size = new System.Drawing.Size(461, 375);
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodeHeaderGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private stringNodesTreeView tgvTreeView;
        private System.Windows.Forms.DataGridView MasterGrid;
        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        public System.Windows.Forms.ImageList tgvImagesLst;
        private System.Windows.Forms.DataGridViewTextBoxColumn defCol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView NodeHeaderGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
