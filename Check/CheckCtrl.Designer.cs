namespace TK.GraphComponents.Check
{
    partial class CheckCtrl
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
            this.checkCB = new System.Windows.Forms.CheckBox();
            this.descTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkCB
            // 
            this.checkCB.AutoSize = true;
            this.checkCB.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkCB.Location = new System.Drawing.Point(2, 2);
            this.checkCB.Name = "checkCB";
            this.checkCB.Size = new System.Drawing.Size(70, 32);
            this.checkCB.TabIndex = 0;
            this.checkCB.Text = "checkCB";
            this.checkCB.UseVisualStyleBackColor = true;
            // 
            // descTB
            // 
            this.descTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descTB.Enabled = false;
            this.descTB.Location = new System.Drawing.Point(72, 2);
            this.descTB.Multiline = true;
            this.descTB.Name = "descTB";
            this.descTB.Size = new System.Drawing.Size(354, 32);
            this.descTB.TabIndex = 1;
            // 
            // CheckCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.descTB);
            this.Controls.Add(this.checkCB);
            this.Name = "CheckCtrl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(428, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkCB;
        private System.Windows.Forms.TextBox descTB;
    }
}
