
namespace TK.GraphComponents.Animation
{
    partial class MiniPlayerUCtrl
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
            this.ImageHolder = new StablePanel(this.components);
            this.fpsLabel = new System.Windows.Forms.Label();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.playerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImageHolder.SuspendLayout();
            this.playerLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageHolder
            // 
            this.ImageHolder.BackColor = System.Drawing.Color.Black;
            this.ImageHolder.Controls.Add(this.fpsLabel);
            this.ImageHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageHolder.Location = new System.Drawing.Point(40, 15);
            this.ImageHolder.Margin = new System.Windows.Forms.Padding(0);
            this.ImageHolder.Name = "ImageHolder";
            this.ImageHolder.Size = new System.Drawing.Size(300, 300);
            this.ImageHolder.TabIndex = 0;
            this.ImageHolder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MiniPlayerUCtrl_MouseMove);
            this.ImageHolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MiniPlayerUCtrl_MouseDown);
            this.ImageHolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MiniPlayerUCtrl_MouseUp);
            // 
            // fpsLabel
            // 
            this.fpsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.BackColor = System.Drawing.Color.Transparent;
            this.fpsLabel.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fpsLabel.Location = new System.Drawing.Point(14, 275);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(29, 12);
            this.fpsLabel.TabIndex = 0;
            this.fpsLabel.Text = "fps";
            this.fpsLabel.Visible = false;
            // 
            // PlayTimer
            // 
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
            // 
            // playerLayoutPanel
            // 
            this.playerLayoutPanel.ColumnCount = 3;
            this.playerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.playerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerLayoutPanel.Controls.Add(this.ImageHolder, 1, 1);
            this.playerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.playerLayoutPanel.Name = "playerLayoutPanel";
            this.playerLayoutPanel.RowCount = 3;
            this.playerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.playerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerLayoutPanel.Size = new System.Drawing.Size(380, 331);
            this.playerLayoutPanel.TabIndex = 1;
            // 
            // MiniPlayerUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.playerLayoutPanel);
            this.Name = "MiniPlayerUCtrl";
            this.Size = new System.Drawing.Size(380, 331);
            this.MouseLeave += new System.EventHandler(this.MiniPlayerUCtrl_MouseLeave);
            this.ImageHolder.ResumeLayout(false);
            this.ImageHolder.PerformLayout();
            this.playerLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private StablePanel ImageHolder;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.TableLayoutPanel playerLayoutPanel;
    }
}