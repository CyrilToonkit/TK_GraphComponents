namespace GraphTester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.realSlider1 = new TK.GraphComponents.RealSlider();
            this.completeSlider1 = new TK.GraphComponents.CompleteSlider();
            this.arlequinPanel1 = new TK.GraphComponents.ArlequinPanel();
            this.folderBrowserEdit1 = new TK.GraphComponents.FolderBrowserEdit();
            this.tkDropDown1 = new TK.GraphComponents.TKDropDown();
            this.collapsibleGroup1 = new TK.GraphComponents.CollapsibleGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realSlider1)).BeginInit();
            this.collapsibleGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show Splash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hide Splash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(83, 231);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(677, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // realSlider1
            // 
            this.realSlider1.Decimals = 0;
            this.realSlider1.DefaultOnMiddleClick = true;
            this.realSlider1.DefaultValue = 0;
            this.realSlider1.DisplayFrames = true;
            this.realSlider1.DisplayTexts = false;
            this.realSlider1.DoubleDefaultValue = 0;
            this.realSlider1.DoubleMaximum = 10;
            this.realSlider1.DoubleMinimum = 0;
            this.realSlider1.DoubleValue = 0;
            this.realSlider1.EndText = "";
            this.realSlider1.FramesLabelsDynamicFrequency = false;
            this.realSlider1.FramesLabelsFrequency = 0;
            this.realSlider1.HasDefault = false;
            this.realSlider1.Location = new System.Drawing.Point(408, 219);
            this.realSlider1.Name = "realSlider1";
            this.realSlider1.ShowIntervals = true;
            this.realSlider1.Size = new System.Drawing.Size(104, 45);
            this.realSlider1.SliderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.realSlider1.SliderForeColor = System.Drawing.Color.Gray;
            this.realSlider1.StartText = "";
            this.realSlider1.TabIndex = 26;
            // 
            // completeSlider1
            // 
            this.completeSlider1.ButtonName = "sliderButton";
            this.completeSlider1.ButtonStatus = TK.GraphComponents.SliderButtonStatus.Empty;
            this.completeSlider1.Decimals = 0;
            this.completeSlider1.DefaultValue = 2;
            this.completeSlider1.DisplayEditBox = true;
            this.completeSlider1.DisplayEditBoxBackColor = System.Drawing.SystemColors.Window;
            this.completeSlider1.DisplayEditButton = false;
            this.completeSlider1.DisplayFrames = true;
            this.completeSlider1.DisplayLabel = true;
            this.completeSlider1.DisplayTexts = true;
            this.completeSlider1.DoubleDefaultValue = 2;
            this.completeSlider1.DoubleMaximum = 10;
            this.completeSlider1.DoubleMinimum = 0;
            this.completeSlider1.DoubleValue = 0;
            this.completeSlider1.EndText = "";
            this.completeSlider1.FramesLabelsDynamicFrequency = false;
            this.completeSlider1.FramesLabelsFrequency = 10;
            this.completeSlider1.HasDefault = true;
            this.completeSlider1.LabelText = "Slider";
            this.completeSlider1.Location = new System.Drawing.Point(501, 282);
            this.completeSlider1.Margin = new System.Windows.Forms.Padding(0);
            this.completeSlider1.Maximum = 10;
            this.completeSlider1.Minimum = 0;
            this.completeSlider1.Name = "completeSlider1";
            this.completeSlider1.ShowIntervals = true;
            this.completeSlider1.Size = new System.Drawing.Size(197, 52);
            this.completeSlider1.SliderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.completeSlider1.SliderForeColor = System.Drawing.Color.Gray;
            this.completeSlider1.StartText = "";
            this.completeSlider1.TabIndex = 28;
            this.completeSlider1.TickFrequency = 1;
            this.completeSlider1.Value = 0;
            this.completeSlider1.ValueChanged += new System.EventHandler(this.completeSlider1_ValueChanged);
            // 
            // arlequinPanel1
            // 
            this.arlequinPanel1.Location = new System.Drawing.Point(364, 27);
            this.arlequinPanel1.Name = "arlequinPanel1";
            this.arlequinPanel1.Size = new System.Drawing.Size(200, 100);
            this.arlequinPanel1.TabIndex = 24;
            // 
            // folderBrowserEdit1
            // 
            this.folderBrowserEdit1.AddMode = true;
            this.folderBrowserEdit1.FileMode = true;
            this.folderBrowserEdit1.Filter = "";
            this.folderBrowserEdit1.Label = "Tester :";
            this.folderBrowserEdit1.Location = new System.Drawing.Point(30, 9);
            this.folderBrowserEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.folderBrowserEdit1.Message = "Open a png file...";
            this.folderBrowserEdit1.Name = "folderBrowserEdit1";
            this.folderBrowserEdit1.Separator = ";";
            this.folderBrowserEdit1.Size = new System.Drawing.Size(222, 20);
            this.folderBrowserEdit1.TabIndex = 12;
            // 
            // tkDropDown1
            // 
            this.tkDropDown1.AllowCustomValue = false;
            this.tkDropDown1.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("tkDropDown1.Items")));
            this.tkDropDown1.Location = new System.Drawing.Point(53, 83);
            this.tkDropDown1.Name = "tkDropDown1";
            this.tkDropDown1.ReadOnly = true;
            this.tkDropDown1.SelectedIndex = -1;
            this.tkDropDown1.Size = new System.Drawing.Size(100, 20);
            this.tkDropDown1.TabIndex = 2;
            // 
            // collapsibleGroup1
            // 
            this.collapsibleGroup1.AllowResize = true;
            this.collapsibleGroup1.Collapsed = false;
            this.collapsibleGroup1.CollapseOnClick = true;
            this.collapsibleGroup1.Controls.Add(this.label3);
            this.collapsibleGroup1.Controls.Add(this.label2);
            this.collapsibleGroup1.Controls.Add(this.label1);
            this.collapsibleGroup1.Dock = System.Windows.Forms.DockStyle.Right;
            this.collapsibleGroup1.DockingChanges = TK.GraphComponents.DockingPossibilities.All;
            this.collapsibleGroup1.Location = new System.Drawing.Point(825, 0);
            this.collapsibleGroup1.Name = "collapsibleGroup1";
            this.collapsibleGroup1.OpenedBaseHeight = 150;
            this.collapsibleGroup1.OpenedBaseWidth = 200;
            this.collapsibleGroup1.Size = new System.Drawing.Size(349, 391);
            this.collapsibleGroup1.TabIndex = 1;
            this.collapsibleGroup1.TabStop = false;
            this.collapsibleGroup1.Text = "collapsibleGroup1";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 326);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 391);
            this.Controls.Add(this.realSlider1);
            this.Controls.Add(this.completeSlider1);
            this.Controls.Add(this.arlequinPanel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.folderBrowserEdit1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tkDropDown1);
            this.Controls.Add(this.collapsibleGroup1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realSlider1)).EndInit();
            this.collapsibleGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TK.GraphComponents.CollapsibleGroup collapsibleGroup1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TK.GraphComponents.TKDropDown tkDropDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private TK.GraphComponents.FolderBrowserEdit folderBrowserEdit1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private TK.GraphComponents.ArlequinPanel arlequinPanel1;
        private TK.GraphComponents.RealSlider realSlider1;
        private TK.GraphComponents.CompleteSlider completeSlider1;



    }
}