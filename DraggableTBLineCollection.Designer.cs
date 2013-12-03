namespace TK.GraphComponents
{
    partial class DraggableTBLineCollection
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
            this.LinesPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PickBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReloadBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.draggableTB1 = new DraggableTB();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinesPanel
            // 
            this.LinesPanel.AutoScroll = true;
            this.LinesPanel.BackColor = System.Drawing.Color.Transparent;
            this.LinesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LinesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinesPanel.Location = new System.Drawing.Point(0, 26);
            this.LinesPanel.MinimumSize = new System.Drawing.Size(15, 15);
            this.LinesPanel.Name = "LinesPanel";
            this.LinesPanel.Padding = new System.Windows.Forms.Padding(4);
            this.LinesPanel.Size = new System.Drawing.Size(503, 330);
            this.LinesPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopPanel.Controls.Add(this.PickBT);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.draggableTB1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(503, 26);
            this.TopPanel.TabIndex = 1;
            // 
            // PickBT
            // 
            this.PickBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PickBT.Location = new System.Drawing.Point(428, 0);
            this.PickBT.Name = "PickBT";
            this.PickBT.Size = new System.Drawing.Size(75, 26);
            this.PickBT.TabIndex = 3;
            this.PickBT.Text = "PICK";
            this.PickBT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ReloadBT);
            this.panel1.Controls.Add(this.CancelBT);
            this.panel1.Controls.Add(this.SaveBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 26);
            this.panel1.TabIndex = 2;
            // 
            // ReloadBT
            // 
            this.ReloadBT.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReloadBT.Location = new System.Drawing.Point(0, 0);
            this.ReloadBT.Name = "ReloadBT";
            this.ReloadBT.Size = new System.Drawing.Size(75, 26);
            this.ReloadBT.TabIndex = 2;
            this.ReloadBT.Text = "Reload";
            this.ReloadBT.UseVisualStyleBackColor = true;
            this.ReloadBT.Click += new System.EventHandler(this.ReloadBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBT.Location = new System.Drawing.Point(353, 0);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 26);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "CANCEL";
            this.CancelBT.UseVisualStyleBackColor = true;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveBT.Location = new System.Drawing.Point(428, 0);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(75, 26);
            this.SaveBT.TabIndex = 0;
            this.SaveBT.Text = "SAVE";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // draggableTB1
            // 
            this.draggableTB1.Location = new System.Drawing.Point(47, 3);
            this.draggableTB1.Name = "draggableTB1";
            this.draggableTB1.Size = new System.Drawing.Size(70, 20);
            this.draggableTB1.TabIndex = 0;
            this.draggableTB1.TBText = "";
            // 
            // DraggableTBLineCollection
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.BackgroundImage = global::TK.GraphComponents.Properties.Resources.AnimBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.LinesPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.Name = "DraggableTBLineCollection";
            this.Size = new System.Drawing.Size(503, 382);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LinesPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button PickBT;
        private System.Windows.Forms.Label label1;
        private DraggableTB draggableTB1;
        private System.Windows.Forms.Button ReloadBT;
        private System.Windows.Forms.Button CancelBT;
    }
}
