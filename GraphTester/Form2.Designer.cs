namespace GraphTester
{
    partial class Form2
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
            this.checkListEditorCtrl1 = new TK.GraphComponents.Check.CheckListEditorCtrl();
            this.SuspendLayout();
            // 
            // checkListEditorCtrl1
            // 
            this.checkListEditorCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListEditorCtrl1.Location = new System.Drawing.Point(0, 0);
            this.checkListEditorCtrl1.Name = "checkListEditorCtrl1";
            this.checkListEditorCtrl1.Size = new System.Drawing.Size(606, 310);
            this.checkListEditorCtrl1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 310);
            this.Controls.Add(this.checkListEditorCtrl1);
            this.Name = "Form2";
            this.Text = "TchecKer BETA : New CheckList";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TK.GraphComponents.Check.CheckListEditorCtrl checkListEditorCtrl1;
    }
}