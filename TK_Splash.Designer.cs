namespace TK.GraphComponents
{
    partial class TK_Splash
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BG = new TK.GraphComponents.StablePanel(this.components);
            this.FG = new TK.GraphComponents.StablePanel(this.components);
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HostLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ExpiresLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RemainingLabel = new System.Windows.Forms.Label();
            this.BG.SuspendLayout();
            this.FG.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BG
            // 
            this.BG.BackgroundImage = global::TK.GraphComponents.Properties.Resources.SplashBack;
            this.BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BG.Controls.Add(this.FG);
            this.BG.Location = new System.Drawing.Point(0, 0);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(500, 489);
            this.BG.TabIndex = 9;
            // 
            // FG
            // 
            this.FG.BackColor = System.Drawing.Color.Transparent;
            this.FG.BackgroundImage = global::TK.GraphComponents.Properties.Resources.Splash_2011;
            this.FG.Controls.Add(this.OwnerLabel);
            this.FG.Controls.Add(this.label3);
            this.FG.Controls.Add(this.label1);
            this.FG.Controls.Add(this.HostLabel);
            this.FG.Controls.Add(this.progressBar1);
            this.FG.Controls.Add(this.ExpiresLabel);
            this.FG.Controls.Add(this.label2);
            this.FG.Controls.Add(this.VersionLabel);
            this.FG.Controls.Add(this.label4);
            this.FG.Controls.Add(this.RemainingLabel);
            this.FG.Location = new System.Drawing.Point(0, 0);
            this.FG.Name = "FG";
            this.FG.Size = new System.Drawing.Size(500, 271);
            this.FG.TabIndex = 0;
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.OwnerLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerLabel.Location = new System.Drawing.Point(92, 156);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(14, 15);
            this.OwnerLabel.TabIndex = 10;
            this.OwnerLabel.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Owner :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version :";
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.BackColor = System.Drawing.Color.Transparent;
            this.HostLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostLabel.Location = new System.Drawing.Point(92, 204);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(14, 15);
            this.HostLabel.TabIndex = 8;
            this.HostLabel.Text = "V";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(413, 22);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // ExpiresLabel
            // 
            this.ExpiresLabel.AutoSize = true;
            this.ExpiresLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExpiresLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiresLabel.Location = new System.Drawing.Point(279, 156);
            this.ExpiresLabel.Name = "ExpiresLabel";
            this.ExpiresLabel.Size = new System.Drawing.Size(14, 15);
            this.ExpiresLabel.TabIndex = 7;
            this.ExpiresLabel.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expires on :";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(92, 180);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(14, 15);
            this.VersionLabel.TabIndex = 6;
            this.VersionLabel.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Host :";
            // 
            // RemainingLabel
            // 
            this.RemainingLabel.AutoSize = true;
            this.RemainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.RemainingLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLabel.ForeColor = System.Drawing.Color.Black;
            this.RemainingLabel.Location = new System.Drawing.Point(195, 180);
            this.RemainingLabel.Name = "RemainingLabel";
            this.RemainingLabel.Size = new System.Drawing.Size(141, 15);
            this.RemainingLabel.TabIndex = 5;
            this.RemainingLabel.Text = "Framework available for ";
            // 
            // TK_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 271);
            this.Controls.Add(this.BG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TK_Splash";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TK_Splash";
            this.TopMost = true;
            this.BG.ResumeLayout(false);
            this.FG.ResumeLayout(false);
            this.FG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RemainingLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label ExpiresLabel;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Timer timer1;
        private StablePanel BG;
        private StablePanel FG;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.Label label3;
    }
}