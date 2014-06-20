namespace TK.GraphComponents.Dialogs
{
    partial class LongMessageForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageTB
            // 
            this.messageTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTB.Location = new System.Drawing.Point(0, 0);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.ReadOnly = true;
            this.messageTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTB.Size = new System.Drawing.Size(284, 262);
            this.messageTB.TabIndex = 0;
            // 
            // LongMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.messageTB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LongMessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LongMessageForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTB;
    }
}