namespace TK.GraphComponents
{
    partial class CompleteSlider
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
            this.sliderBox = new System.Windows.Forms.TextBox();
            this.sliderlabel = new System.Windows.Forms.Label();
            this.sliderButton = new System.Windows.Forms.Button();
            this.realSlider = new TK.GraphComponents.RealSlider();
            ((System.ComponentModel.ISupportInitialize)(this.realSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // sliderBox
            // 
            this.sliderBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.sliderBox.Location = new System.Drawing.Point(167, 0);
            this.sliderBox.Name = "sliderBox";
            this.sliderBox.Size = new System.Drawing.Size(30, 20);
            this.sliderBox.TabIndex = 1;
            this.sliderBox.Text = "0";
            this.sliderBox.TextChanged += new System.EventHandler(this.sliderBox_TextChanged);
            this.sliderBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompleteSlider_MouseDown);
            this.sliderBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CompleteSlider_MouseUp);
            // 
            // sliderlabel
            // 
            this.sliderlabel.AutoSize = true;
            this.sliderlabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliderlabel.Location = new System.Drawing.Point(20, 0);
            this.sliderlabel.Margin = new System.Windows.Forms.Padding(3);
            this.sliderlabel.Name = "sliderlabel";
            this.sliderlabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.sliderlabel.Size = new System.Drawing.Size(33, 16);
            this.sliderlabel.TabIndex = 2;
            this.sliderlabel.Text = "Slider";
            this.sliderlabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompleteSlider_MouseDown);
            this.sliderlabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CompleteSlider_MouseUp);
            // 
            // sliderButton
            // 
            this.sliderButton.BackgroundImage = global::TK.GraphComponents.Properties.Resources.Keying_Empty;
            this.sliderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sliderButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sliderButton.FlatAppearance.BorderSize = 0;
            this.sliderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sliderButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sliderButton.Location = new System.Drawing.Point(0, 0);
            this.sliderButton.Name = "sliderButton";
            this.sliderButton.Size = new System.Drawing.Size(20, 38);
            this.sliderButton.TabIndex = 3;
            this.sliderButton.UseVisualStyleBackColor = true;
            this.sliderButton.Visible = false;
            this.sliderButton.Click += new System.EventHandler(this.sliderButton_Click);
            // 
            // realSlider
            // 
            this.realSlider.AutoSize = false;
            this.realSlider.Decimals = 0;
            this.realSlider.DefaultOnMiddleClick = true;
            this.realSlider.DefaultValue = 0;
            this.realSlider.DisplayDefault = false;
            this.realSlider.DisplayFrames = true;
            this.realSlider.DisplayTexts = false;
            this.realSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realSlider.DoubleDefaultValue = 0;
            this.realSlider.DoubleMaximum = 10;
            this.realSlider.DoubleMinimum = 0;
            this.realSlider.DoubleValue = 0;
            this.realSlider.EndText = "";
            this.realSlider.FramesLabelsDynamicFrequency = false;
            this.realSlider.FramesLabelsFrequency = 0;
            this.realSlider.HasDefault = false;
            this.realSlider.LargeChange = 0;
            this.realSlider.Location = new System.Drawing.Point(53, 0);
            this.realSlider.Margin = new System.Windows.Forms.Padding(0);
            this.realSlider.Name = "realSlider";
            this.realSlider.ShowIntervals = true;
            this.realSlider.Size = new System.Drawing.Size(114, 38);
            this.realSlider.SliderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.realSlider.SliderForeColor = System.Drawing.Color.Gray;
            this.realSlider.StartText = "";
            this.realSlider.TabIndex = 0;
            this.realSlider.StopValueChanged += new System.EventHandler(this.realSlider_StopValueChanged);
            this.realSlider.ValueChanged += new System.EventHandler(this.realSlider_ValueChanged);
            this.realSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CompleteSlider_MouseDown);
            this.realSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CompleteSlider_MouseUp);
            // 
            // CompleteSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.realSlider);
            this.Controls.Add(this.sliderlabel);
            this.Controls.Add(this.sliderBox);
            this.Controls.Add(this.sliderButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CompleteSlider";
            this.Size = new System.Drawing.Size(197, 38);
            ((System.ComponentModel.ISupportInitialize)(this.realSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RealSlider realSlider;
        private System.Windows.Forms.TextBox sliderBox;
        private System.Windows.Forms.Label sliderlabel;
        private System.Windows.Forms.Button sliderButton;
    }
}
