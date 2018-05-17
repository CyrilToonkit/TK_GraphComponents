namespace TK.GraphComponents
{
    partial class TK_SplashLicense
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
            this.VersionLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.licenseInfo = new System.Windows.Forms.Label();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.messageLabel2 = new System.Windows.Forms.Label();
            this.licenseTypeLabel = new System.Windows.Forms.Label();
            this.licenseType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.VersionLabel.Location = new System.Drawing.Point(578, 53);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(16, 17);
            this.VersionLabel.TabIndex = 6;
            this.VersionLabel.Text = "V";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(366, 211);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 22);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // licenseInfo
            // 
            this.licenseInfo.AutoSize = true;
            this.licenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.licenseInfo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.licenseInfo.Location = new System.Drawing.Point(363, 142);
            this.licenseInfo.Name = "licenseInfo";
            this.licenseInfo.Size = new System.Drawing.Size(106, 17);
            this.licenseInfo.TabIndex = 9;
            this.licenseInfo.Text = "Reading token...";
            // 
            // messageLabel1
            // 
            this.messageLabel1.AutoSize = true;
            this.messageLabel1.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.messageLabel1.Location = new System.Drawing.Point(363, 168);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(278, 17);
            this.messageLabel1.TabIndex = 10;
            this.messageLabel1.Text = "OSCAR is still free to use in this \"Limited\" version";
            this.messageLabel1.Visible = false;
            // 
            // messageLabel2
            // 
            this.messageLabel2.AutoSize = true;
            this.messageLabel2.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.messageLabel2.Location = new System.Drawing.Point(363, 185);
            this.messageLabel2.Name = "messageLabel2";
            this.messageLabel2.Size = new System.Drawing.Size(253, 17);
            this.messageLabel2.TabIndex = 11;
            this.messageLabel2.Text = "Future versions may require license tokens !";
            this.messageLabel2.Visible = false;
            // 
            // licenseTypeLabel
            // 
            this.licenseTypeLabel.AutoSize = true;
            this.licenseTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.licenseTypeLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.licenseTypeLabel.Location = new System.Drawing.Point(363, 120);
            this.licenseTypeLabel.Name = "licenseTypeLabel";
            this.licenseTypeLabel.Size = new System.Drawing.Size(88, 17);
            this.licenseTypeLabel.TabIndex = 12;
            this.licenseTypeLabel.Text = "License type :";
            // 
            // licenseType
            // 
            this.licenseType.AutoSize = true;
            this.licenseType.BackColor = System.Drawing.Color.Transparent;
            this.licenseType.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.licenseType.Location = new System.Drawing.Point(457, 120);
            this.licenseType.Name = "licenseType";
            this.licenseType.Size = new System.Drawing.Size(61, 17);
            this.licenseType.TabIndex = 13;
            this.licenseType.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(513, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Version :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(528, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Toonkit - 2017 - All rights reserved";
            this.label3.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.okButton.Location = new System.Drawing.Point(366, 211);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(219, 22);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.quitButton.Location = new System.Drawing.Point(591, 211);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(82, 22);
            this.quitButton.TabIndex = 17;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Visible = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // TK_SplashLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TK.GraphComponents.Properties.Resources.Oscar_LD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 259);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licenseType);
            this.Controls.Add(this.licenseTypeLabel);
            this.Controls.Add(this.messageLabel2);
            this.Controls.Add(this.licenseInfo);
            this.Controls.Add(this.messageLabel1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TK_SplashLicense";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TK_Splash";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label licenseInfo;
        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.Label messageLabel2;
        private System.Windows.Forms.Label licenseTypeLabel;
        private System.Windows.Forms.Label licenseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button quitButton;
    }
}