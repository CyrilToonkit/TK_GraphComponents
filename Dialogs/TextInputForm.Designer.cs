namespace TK.GraphComponents.Dialogs
{
    partial class TextInputForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBT = new System.Windows.Forms.Button();
            this.okBT = new System.Windows.Forms.Button();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cancelBT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.okBT, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cancelBT
            // 
            this.cancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBT.Location = new System.Drawing.Point(170, 3);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(161, 29);
            this.cancelBT.TabIndex = 1;
            this.cancelBT.Text = "Cancel";
            this.cancelBT.UseVisualStyleBackColor = true;
            // 
            // okBT
            // 
            this.okBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okBT.Location = new System.Drawing.Point(3, 3);
            this.okBT.Name = "okBT";
            this.okBT.Size = new System.Drawing.Size(161, 29);
            this.okBT.TabIndex = 0;
            this.okBT.Text = "OK";
            this.okBT.UseVisualStyleBackColor = true;
            this.okBT.Click += new System.EventHandler(this.okBT_Click);
            // 
            // messageTB
            // 
            this.messageTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageTB.Location = new System.Drawing.Point(0, 0);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.ReadOnly = true;
            this.messageTB.Size = new System.Drawing.Size(334, 33);
            this.messageTB.TabIndex = 1;
            // 
            // inputTB
            // 
            this.inputTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTB.Location = new System.Drawing.Point(0, 33);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(334, 20);
            this.inputTB.TabIndex = 2;
            // 
            // TextInputForm
            // 
            this.AcceptButton = this.okBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBT;
            this.ClientSize = new System.Drawing.Size(334, 98);
            this.ControlBox = false;
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TextInputForm";
            this.ShowIcon = false;
            this.Text = "TextInputForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Button okBT;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.TextBox inputTB;
    }
}