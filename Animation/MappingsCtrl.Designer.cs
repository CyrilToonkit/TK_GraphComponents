namespace TK.GraphComponents.Animation
{
    partial class MappingsCtrl
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
            this.ControlsView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKBT = new System.Windows.Forms.Button();
            this.PickBT = new System.Windows.Forms.Button();
            this.SaveChangesCB = new System.Windows.Forms.CheckBox();
            this.SaveNewCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ControlsView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsView
            // 
            this.ControlsView.AllowUserToResizeColumns = false;
            this.ControlsView.AllowUserToResizeRows = false;
            this.ControlsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ControlsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ControlsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsView.Location = new System.Drawing.Point(0, 0);
            this.ControlsView.MultiSelect = false;
            this.ControlsView.Name = "ControlsView";
            this.ControlsView.RowHeadersVisible = false;
            this.ControlsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ControlsView.Size = new System.Drawing.Size(381, 321);
            this.ControlsView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveChangesCB);
            this.panel1.Controls.Add(this.PickBT);
            this.panel1.Controls.Add(this.SaveNewCB);
            this.panel1.Controls.Add(this.OKBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 23);
            this.panel1.TabIndex = 1;
            // 
            // OKBT
            // 
            this.OKBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OKBT.Location = new System.Drawing.Point(301, 0);
            this.OKBT.Name = "OKBT";
            this.OKBT.Size = new System.Drawing.Size(80, 23);
            this.OKBT.TabIndex = 0;
            this.OKBT.Text = "OK";
            this.OKBT.UseVisualStyleBackColor = true;
            // 
            // PickBT
            // 
            this.PickBT.Dock = System.Windows.Forms.DockStyle.Left;
            this.PickBT.Location = new System.Drawing.Point(0, 0);
            this.PickBT.Name = "PickBT";
            this.PickBT.Size = new System.Drawing.Size(80, 23);
            this.PickBT.TabIndex = 1;
            this.PickBT.Text = "Pick";
            this.PickBT.UseVisualStyleBackColor = true;
            // 
            // SaveChangesCB
            // 
            this.SaveChangesCB.AutoSize = true;
            this.SaveChangesCB.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveChangesCB.Location = new System.Drawing.Point(98, 0);
            this.SaveChangesCB.Name = "SaveChangesCB";
            this.SaveChangesCB.Size = new System.Drawing.Size(95, 23);
            this.SaveChangesCB.TabIndex = 2;
            this.SaveChangesCB.Text = "Save changes";
            this.SaveChangesCB.UseVisualStyleBackColor = true;
            // 
            // SaveNewCB
            // 
            this.SaveNewCB.AutoSize = true;
            this.SaveNewCB.Checked = true;
            this.SaveNewCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveNewCB.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveNewCB.Location = new System.Drawing.Point(193, 0);
            this.SaveNewCB.Name = "SaveNewCB";
            this.SaveNewCB.Size = new System.Drawing.Size(108, 23);
            this.SaveNewCB.TabIndex = 3;
            this.SaveNewCB.Text = "Save new entries";
            this.SaveNewCB.UseVisualStyleBackColor = true;
            // 
            // MappingsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.Controls.Add(this.ControlsView);
            this.Controls.Add(this.panel1);
            this.Name = "MappingsCtrl";
            this.Size = new System.Drawing.Size(381, 344);
            ((System.ComponentModel.ISupportInitialize)(this.ControlsView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ControlsView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKBT;
        private System.Windows.Forms.Button PickBT;
        private System.Windows.Forms.CheckBox SaveChangesCB;
        private System.Windows.Forms.CheckBox SaveNewCB;
    }
}
