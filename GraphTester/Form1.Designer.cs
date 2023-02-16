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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.collapsibleGroup2 = new TK.GraphComponents.CollapsibleGroup();
            this.checkListEditorCtrl1 = new TK.GraphComponents.Check.CheckListEditorCtrl();
            this.completeSlider1 = new TK.GraphComponents.CompleteSlider();
            this.realSlider1 = new TK.GraphComponents.RealSlider();
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
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show Splash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hide Splash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(49, 191);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(428, 288);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Http request";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(106, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Show License";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(106, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Hide License";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(106, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 23);
            this.button6.TabIndex = 37;
            this.button6.Text = "Allow License";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(106, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 23);
            this.button7.TabIndex = 39;
            this.button7.Text = "Search License";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 20);
            this.textBox2.TabIndex = 42;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(428, 368);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(298, 23);
            this.button8.TabIndex = 43;
            this.button8.Text = "Get correlation";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(12, 385);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(159, 166);
            this.propertyGrid1.TabIndex = 45;
            // 
            // collapsibleGroup2
            // 
            this.collapsibleGroup2.AllowResize = true;
            this.collapsibleGroup2.Collapsed = false;
            this.collapsibleGroup2.CollapseOnClick = true;
            this.collapsibleGroup2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.collapsibleGroup2.DockingChanges = TK.GraphComponents.DockingPossibilities.All;
            this.collapsibleGroup2.Location = new System.Drawing.Point(0, 589);
            this.collapsibleGroup2.Name = "collapsibleGroup2";
            this.collapsibleGroup2.OpenedBaseHeight = 58;
            this.collapsibleGroup2.OpenedBaseWidth = 200;
            this.collapsibleGroup2.Size = new System.Drawing.Size(828, 59);
            this.collapsibleGroup2.TabIndex = 47;
            this.collapsibleGroup2.TabStop = false;
            this.collapsibleGroup2.Text = "collapsibleGroup2";
            // 
            // checkListEditorCtrl1
            // 
            this.checkListEditorCtrl1.Location = new System.Drawing.Point(255, 9);
            this.checkListEditorCtrl1.Name = "checkListEditorCtrl1";
            this.checkListEditorCtrl1.Size = new System.Drawing.Size(549, 267);
            this.checkListEditorCtrl1.TabIndex = 30;
            // 
            // completeSlider1
            // 
            this.completeSlider1.ButtonName = "sliderButton";
            this.completeSlider1.ButtonStatus = TK.GraphComponents.SliderButtonStatus.Empty;
            this.completeSlider1.Decimals = 0;
            this.completeSlider1.DefaultValue = 2;
            this.completeSlider1.DisplayDefault = false;
            this.completeSlider1.DisplayEditBox = true;
            this.completeSlider1.DisplayEditBoxBackColor = System.Drawing.SystemColors.Window;
            this.completeSlider1.DisplayEditButton = false;
            this.completeSlider1.DisplayFrames = true;
            this.completeSlider1.DisplayLabel = true;
            this.completeSlider1.DisplayTexts = true;
            this.completeSlider1.DoubleDefaultValue = 2D;
            this.completeSlider1.DoubleMaximum = 10D;
            this.completeSlider1.DoubleMinimum = 0D;
            this.completeSlider1.DoubleValue = 0D;
            this.completeSlider1.EndText = "";
            this.completeSlider1.FramesLabelsDynamicFrequency = false;
            this.completeSlider1.FramesLabelsFrequency = 10D;
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
            // realSlider1
            // 
            this.realSlider1.Decimals = 1;
            this.realSlider1.DefaultOnMiddleClick = true;
            this.realSlider1.DefaultValue = 5;
            this.realSlider1.DisplayDefault = true;
            this.realSlider1.DisplayFrames = true;
            this.realSlider1.DisplayTexts = false;
            this.realSlider1.DoubleDefaultValue = 0.5D;
            this.realSlider1.DoubleMaximum = 1D;
            this.realSlider1.DoubleMinimum = 0D;
            this.realSlider1.DoubleValue = 0D;
            this.realSlider1.EndText = "";
            this.realSlider1.FramesLabelsDynamicFrequency = false;
            this.realSlider1.FramesLabelsFrequency = 0D;
            this.realSlider1.HasDefault = false;
            this.realSlider1.Location = new System.Drawing.Point(49, 231);
            this.realSlider1.Name = "realSlider1";
            this.realSlider1.ShowIntervals = false;
            this.realSlider1.Size = new System.Drawing.Size(104, 45);
            this.realSlider1.SliderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.realSlider1.SliderForeColor = System.Drawing.Color.Gray;
            this.realSlider1.StartText = "";
            this.realSlider1.TabIndex = 26;
            // 
            // arlequinPanel1
            // 
            this.arlequinPanel1.Location = new System.Drawing.Point(222, 279);
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
            this.collapsibleGroup1.Location = new System.Drawing.Point(828, 0);
            this.collapsibleGroup1.Name = "collapsibleGroup1";
            this.collapsibleGroup1.OpenedBaseHeight = 150;
            this.collapsibleGroup1.OpenedBaseWidth = 200;
            this.collapsibleGroup1.Size = new System.Drawing.Size(346, 648);
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
            this.label3.Size = new System.Drawing.Size(340, 583);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 648);
            this.Controls.Add(this.collapsibleGroup2);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkListEditorCtrl1);
            this.Controls.Add(this.completeSlider1);
            this.Controls.Add(this.realSlider1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.arlequinPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.folderBrowserEdit1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tkDropDown1);
            this.Controls.Add(this.collapsibleGroup1);
            this.Name = "Form1";
            this.Text = "TchecKer BETA : New CheckList";
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
        private TK.GraphComponents.Check.CheckListEditorCtrl checkListEditorCtrl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private TK.GraphComponents.CollapsibleGroup collapsibleGroup2;
    }
}