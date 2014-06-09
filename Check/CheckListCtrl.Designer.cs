namespace TK.GraphComponents.Check
{
    partial class CheckListCtrl
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
            this.checkListPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.autoCheckBT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkListPanel
            // 
            this.checkListPanel.BackColor = System.Drawing.Color.DarkGray;
            this.checkListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListPanel.Location = new System.Drawing.Point(0, 0);
            this.checkListPanel.Name = "checkListPanel";
            this.checkListPanel.Size = new System.Drawing.Size(400, 287);
            this.checkListPanel.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(102, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(295, 30);
            this.progressBar1.TabIndex = 1;
            // 
            // autoCheckBT
            // 
            this.autoCheckBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoCheckBT.Location = new System.Drawing.Point(1, 1);
            this.autoCheckBT.Margin = new System.Windows.Forms.Padding(1);
            this.autoCheckBT.Name = "autoCheckBT";
            this.autoCheckBT.Size = new System.Drawing.Size(97, 34);
            this.autoCheckBT.TabIndex = 2;
            this.autoCheckBT.Text = "AutoCheck all";
            this.autoCheckBT.UseVisualStyleBackColor = true;
            this.autoCheckBT.Click += new System.EventHandler(this.autoCheckBT_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.autoCheckBT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 287);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 36);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // CheckListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkListPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CheckListCtrl";
            this.Size = new System.Drawing.Size(400, 323);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel checkListPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button autoCheckBT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
