namespace TK.GraphComponents.Animation
{
    partial class RetimeCtrl
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importWarpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWarpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.warpInXSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapOnFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.playControlsLP = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.warpedBox = new System.Windows.Forms.TextBox();
            this.warpBarP = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.miniPlayerUCtrl1 = new TK.GraphComponents.Animation.MiniPlayerUCtrl();
            this.warpBar1 = new TK.GraphComponents.Animation.WarpBar(this.components);
            this.timeLineTB = new TK.GraphComponents.CompleteSlider();
            this.completeSlider2 = new TK.GraphComponents.CompleteSlider();
            this.mainMenuStrip.SuspendLayout();
            this.playControlsLP.SuspendLayout();
            this.warpBarP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(641, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.importWarpToolStripMenuItem,
            this.saveWarpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.warpInXSIToolStripMenuItem,
            this.snapOnFrameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openToolStripMenuItem.Text = "Open Sequence";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // importWarpToolStripMenuItem
            // 
            this.importWarpToolStripMenuItem.Name = "importWarpToolStripMenuItem";
            this.importWarpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.importWarpToolStripMenuItem.Text = "Import Warp";
            // 
            // saveWarpToolStripMenuItem
            // 
            this.saveWarpToolStripMenuItem.Name = "saveWarpToolStripMenuItem";
            this.saveWarpToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveWarpToolStripMenuItem.Text = "Save Warp";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // warpInXSIToolStripMenuItem
            // 
            this.warpInXSIToolStripMenuItem.Name = "warpInXSIToolStripMenuItem";
            this.warpInXSIToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.warpInXSIToolStripMenuItem.Text = "Warp in XSI";
            this.warpInXSIToolStripMenuItem.Click += new System.EventHandler(this.warpInXSIToolStripMenuItem_Click);
            // 
            // snapOnFrameToolStripMenuItem
            // 
            this.snapOnFrameToolStripMenuItem.Checked = true;
            this.snapOnFrameToolStripMenuItem.CheckOnClick = true;
            this.snapOnFrameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.snapOnFrameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.snapOnFrameToolStripMenuItem.Name = "snapOnFrameToolStripMenuItem";
            this.snapOnFrameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.snapOnFrameToolStripMenuItem.Text = "Snap on frame";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loopToolStripMenuItem,
            this.warpToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.Checked = true;
            this.loopToolStripMenuItem.CheckOnClick = true;
            this.loopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.loopToolStripMenuItem.Text = "Loop";
            this.loopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.loopToolStripMenuItem_CheckedChanged);
            // 
            // warpToolStripMenuItem1
            // 
            this.warpToolStripMenuItem1.Checked = true;
            this.warpToolStripMenuItem1.CheckOnClick = true;
            this.warpToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warpToolStripMenuItem1.Name = "warpToolStripMenuItem1";
            this.warpToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.warpToolStripMenuItem1.Text = "Warp";
            this.warpToolStripMenuItem1.CheckedChanged += new System.EventHandler(this.warpToolStripMenuItem1_CheckedChanged);
            // 
            // playControlsLP
            // 
            this.playControlsLP.ColumnCount = 5;
            this.playControlsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.playControlsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playControlsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playControlsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.playControlsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.playControlsLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playControlsLP.Controls.Add(this.completeSlider2, 3, 0);
            this.playControlsLP.Controls.Add(this.button3, 2, 0);
            this.playControlsLP.Controls.Add(this.button1, 1, 0);
            this.playControlsLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playControlsLP.Location = new System.Drawing.Point(0, 395);
            this.playControlsLP.Name = "playControlsLP";
            this.playControlsLP.RowCount = 1;
            this.playControlsLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playControlsLP.Size = new System.Drawing.Size(641, 38);
            this.playControlsLP.TabIndex = 2;
            this.playControlsLP.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(191, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "||";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(171, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warpedBox
            // 
            this.warpedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.warpedBox.Location = new System.Drawing.Point(598, 0);
            this.warpedBox.Name = "warpedBox";
            this.warpedBox.ReadOnly = true;
            this.warpedBox.Size = new System.Drawing.Size(40, 20);
            this.warpedBox.TabIndex = 5;
            this.warpedBox.Text = "0";
            // 
            // warpBarP
            // 
            this.warpBarP.Controls.Add(this.warpBar1);
            this.warpBarP.Controls.Add(this.warpedBox);
            this.warpBarP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.warpBarP.Location = new System.Drawing.Point(0, 330);
            this.warpBarP.Margin = new System.Windows.Forms.Padding(0);
            this.warpBarP.Name = "warpBarP";
            this.warpBarP.Size = new System.Drawing.Size(641, 20);
            this.warpBarP.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(100, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "||";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(80, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 0;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // miniPlayerUCtrl1
            // 
            this.miniPlayerUCtrl1.AbsFrame = 0;
            this.miniPlayerUCtrl1.BackColor = System.Drawing.Color.Black;
            this.miniPlayerUCtrl1.CurrentFrame = 0;
            this.miniPlayerUCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miniPlayerUCtrl1.Factor = 1;
            this.miniPlayerUCtrl1.Fps = 24;
            this.miniPlayerUCtrl1.Loaded = false;
            this.miniPlayerUCtrl1.Location = new System.Drawing.Point(0, 24);
            this.miniPlayerUCtrl1.Loop = true;
            this.miniPlayerUCtrl1.Name = "miniPlayerUCtrl1";
            this.miniPlayerUCtrl1.Playing = false;
            this.miniPlayerUCtrl1.Size = new System.Drawing.Size(641, 306);
            this.miniPlayerUCtrl1.TabIndex = 0;
            this.miniPlayerUCtrl1.Warp = null;
            this.miniPlayerUCtrl1.Warped = false;
            // 
            // warpBar1
            // 
            this.warpBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.warpBar1.Location = new System.Drawing.Point(9, 0);
            this.warpBar1.Name = "warpBar1";
            this.warpBar1.Size = new System.Drawing.Size(582, 20);
            this.warpBar1.TabIndex = 4;
            // 
            // timeLineTB
            // 
            this.timeLineTB.ButtonName = "sliderButton";
            this.timeLineTB.ButtonStatus = TK.GraphComponents.SliderButtonStatus.Empty;
            this.timeLineTB.Decimals = 0;
            this.timeLineTB.DefaultValue = 0;
            this.timeLineTB.DisplayDefault = false;
            this.timeLineTB.DisplayEditBox = true;
            this.timeLineTB.DisplayEditBoxBackColor = System.Drawing.SystemColors.Window;
            this.timeLineTB.DisplayEditButton = false;
            this.timeLineTB.DisplayFrames = true;
            this.timeLineTB.DisplayLabel = false;
            this.timeLineTB.DisplayTexts = false;
            this.timeLineTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeLineTB.DoubleDefaultValue = 0;
            this.timeLineTB.DoubleMaximum = 10;
            this.timeLineTB.DoubleMinimum = 0;
            this.timeLineTB.DoubleValue = 0;
            this.timeLineTB.EndText = "";
            this.timeLineTB.FramesLabelsDynamicFrequency = false;
            this.timeLineTB.FramesLabelsFrequency = 0;
            this.timeLineTB.HasDefault = false;
            this.timeLineTB.LabelText = "Slider";
            this.timeLineTB.Location = new System.Drawing.Point(0, 350);
            this.timeLineTB.Margin = new System.Windows.Forms.Padding(0);
            this.timeLineTB.Maximum = 10;
            this.timeLineTB.Minimum = 0;
            this.timeLineTB.Name = "timeLineTB";
            this.timeLineTB.ShowIntervals = true;
            this.timeLineTB.Size = new System.Drawing.Size(641, 45);
            this.timeLineTB.SliderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timeLineTB.SliderForeColor = System.Drawing.Color.Gray;
            this.timeLineTB.StartText = "";
            this.timeLineTB.TabIndex = 3;
            this.timeLineTB.TickFrequency = 1;
            this.timeLineTB.Value = 0;
            this.timeLineTB.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.timeLineTB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // completeSlider2
            // 
            this.completeSlider2.ButtonName = "sliderButton";
            this.completeSlider2.ButtonStatus = TK.GraphComponents.SliderButtonStatus.Empty;
            this.completeSlider2.Decimals = 2;
            this.completeSlider2.DefaultValue = 100;
            this.completeSlider2.DisplayDefault = true;
            this.completeSlider2.DisplayEditBox = true;
            this.completeSlider2.DisplayEditBoxBackColor = System.Drawing.SystemColors.Window;
            this.completeSlider2.DisplayEditButton = false;
            this.completeSlider2.DisplayFrames = true;
            this.completeSlider2.DisplayLabel = true;
            this.completeSlider2.DisplayTexts = false;
            this.completeSlider2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completeSlider2.DoubleDefaultValue = 1;
            this.completeSlider2.DoubleMaximum = 5;
            this.completeSlider2.DoubleMinimum = 0.1;
            this.completeSlider2.DoubleValue = 1;
            this.completeSlider2.EndText = "";
            this.completeSlider2.FramesLabelsDynamicFrequency = false;
            this.completeSlider2.FramesLabelsFrequency = 0.1;
            this.completeSlider2.HasDefault = true;
            this.completeSlider2.LabelText = "Speed :";
            this.completeSlider2.Location = new System.Drawing.Point(211, 0);
            this.completeSlider2.Margin = new System.Windows.Forms.Padding(0);
            this.completeSlider2.Maximum = 500;
            this.completeSlider2.Minimum = 10;
            this.completeSlider2.Name = "completeSlider2";
            this.completeSlider2.ShowIntervals = false;
            this.completeSlider2.Size = new System.Drawing.Size(257, 38);
            this.completeSlider2.SliderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.completeSlider2.SliderForeColor = System.Drawing.Color.Gray;
            this.completeSlider2.StartText = "";
            this.completeSlider2.TabIndex = 5;
            this.completeSlider2.TickFrequency = 50;
            this.completeSlider2.Value = 100;
            this.completeSlider2.ValueChanged += new System.EventHandler(this.completeSlider2_ValueChanged);
            // 
            // RetimeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.miniPlayerUCtrl1);
            this.Controls.Add(this.warpBarP);
            this.Controls.Add(this.timeLineTB);
            this.Controls.Add(this.playControlsLP);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "RetimeCtrl";
            this.Size = new System.Drawing.Size(641, 433);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.playControlsLP.ResumeLayout(false);
            this.warpBarP.ResumeLayout(false);
            this.warpBarP.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MiniPlayerUCtrl miniPlayerUCtrl1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel playControlsLP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private CompleteSlider timeLineTB;
        private WarpBar warpBar1;
        private System.Windows.Forms.TextBox warpedBox;
        private System.Windows.Forms.Panel warpBarP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importWarpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWarpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem warpInXSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem snapOnFrameToolStripMenuItem;
        private CompleteSlider completeSlider2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;




    }
}