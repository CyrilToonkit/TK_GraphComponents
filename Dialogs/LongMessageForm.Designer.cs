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
            this.okButton = new System.Windows.Forms.Button();
            this.buttonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.optionButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageTB
            // 
            this.messageTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.messageTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.messageTB.Location = new System.Drawing.Point(0, 0);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.ReadOnly = true;
            this.messageTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTB.Size = new System.Drawing.Size(301, 245);
            this.messageTB.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.okButton.Location = new System.Drawing.Point(0, 0);
            this.okButton.Margin = new System.Windows.Forms.Padding(0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonsLayout
            // 
            this.buttonsLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonsLayout.ColumnCount = 3;
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsLayout.Controls.Add(this.cancelButton, 2, 0);
            this.buttonsLayout.Controls.Add(this.optionButton, 1, 0);
            this.buttonsLayout.Controls.Add(this.okButton, 0, 0);
            this.buttonsLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsLayout.Location = new System.Drawing.Point(0, 245);
            this.buttonsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsLayout.Name = "buttonsLayout";
            this.buttonsLayout.RowCount = 1;
            this.buttonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsLayout.Size = new System.Drawing.Size(301, 28);
            this.buttonsLayout.TabIndex = 1;
            this.buttonsLayout.Visible = false;
            // 
            // optionButton
            // 
            this.optionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.optionButton.Location = new System.Drawing.Point(100, 0);
            this.optionButton.Margin = new System.Windows.Forms.Padding(0);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(100, 28);
            this.optionButton.TabIndex = 1;
            this.optionButton.Text = "Option";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.Location = new System.Drawing.Point(200, 0);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 28);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LongMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(301, 273);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.buttonsLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LongMessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LongMessageForm";
            this.TopMost = true;
            this.buttonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TableLayoutPanel buttonsLayout;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button optionButton;
    }
}