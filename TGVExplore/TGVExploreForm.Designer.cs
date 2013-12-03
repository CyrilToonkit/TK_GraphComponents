namespace TGVExplore
{
    partial class TGVExploreForm
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
            this.tgv1 = new TGV();
            this.SuspendLayout();
            // 
            // tgv1
            // 
            this.tgv1.BackColor = System.Drawing.SystemColors.Window;
            this.tgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgv1.Location = new System.Drawing.Point(0, 0);
            this.tgv1.Name = "tgv1";
            this.tgv1.Size = new System.Drawing.Size(501, 448);
            this.tgv1.TabIndex = 0;
            // 
            // TGVExploreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 448);
            this.Controls.Add(this.tgv1);
            this.Name = "TGVExploreForm";
            this.Text = "TGV Explore";
            this.ResumeLayout(false);

        }

        #endregion

        private TGV tgv1;
    }
}

