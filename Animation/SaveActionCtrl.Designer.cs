namespace TK.GraphComponents.Animation
{
    partial class SaveActionCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveActionCtrl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryTB = new System.Windows.Forms.TextBox();
            this.endFrameN = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.startFrameN = new System.Windows.Forms.NumericUpDown();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.KeyAllCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OnlySelectedCB = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.storeBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.captureDD = new TKDropDown();
            this.typeDD = new TKDropDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endFrameN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFrameN)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.captureDD, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.categoryTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.endFrameN, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.typeDD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startFrameN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.KeyAllCB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.OnlySelectedCB, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // categoryTB
            // 
            this.categoryTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTB.Location = new System.Drawing.Point(111, 111);
            this.categoryTB.Name = "categoryTB";
            this.categoryTB.Size = new System.Drawing.Size(138, 20);
            this.categoryTB.TabIndex = 15;
            this.categoryTB.Text = "Undefined";
            this.categoryTB.TextChanged += new System.EventHandler(this.categoryTB_TextChanged);
            // 
            // endFrameN
            // 
            this.endFrameN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endFrameN.Location = new System.Drawing.Point(111, 84);
            this.endFrameN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.endFrameN.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.endFrameN.Name = "endFrameN";
            this.endFrameN.Size = new System.Drawing.Size(138, 20);
            this.endFrameN.TabIndex = 13;
            this.endFrameN.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.endFrameN.ValueChanged += new System.EventHandler(this.endFrameN_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "End frame :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start frame :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTB
            // 
            this.nameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTB.Location = new System.Drawing.Point(111, 3);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(138, 20);
            this.nameTB.TabIndex = 9;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // startFrameN
            // 
            this.startFrameN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startFrameN.Location = new System.Drawing.Point(111, 57);
            this.startFrameN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.startFrameN.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.startFrameN.Name = "startFrameN";
            this.startFrameN.Size = new System.Drawing.Size(138, 20);
            this.startFrameN.TabIndex = 12;
            this.startFrameN.ValueChanged += new System.EventHandler(this.startFrameN_ValueChanged);
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLbl.Location = new System.Drawing.Point(3, 108);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(102, 27);
            this.CategoryLbl.TabIndex = 14;
            this.CategoryLbl.Text = "Category :";
            this.CategoryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "KeyAll Start&&End :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeyAllCB
            // 
            this.KeyAllCB.AutoSize = true;
            this.KeyAllCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyAllCB.Location = new System.Drawing.Point(111, 192);
            this.KeyAllCB.Name = "KeyAllCB";
            this.KeyAllCB.Size = new System.Drawing.Size(138, 23);
            this.KeyAllCB.TabIndex = 11;
            this.KeyAllCB.UseVisualStyleBackColor = true;
            this.KeyAllCB.CheckedChanged += new System.EventHandler(this.KeyAllCB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Only Selected :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OnlySelectedCB
            // 
            this.OnlySelectedCB.AutoSize = true;
            this.OnlySelectedCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlySelectedCB.Location = new System.Drawing.Point(111, 165);
            this.OnlySelectedCB.Name = "OnlySelectedCB";
            this.OnlySelectedCB.Size = new System.Drawing.Size(138, 21);
            this.OnlySelectedCB.TabIndex = 17;
            this.OnlySelectedCB.UseVisualStyleBackColor = true;
            this.OnlySelectedCB.CheckedChanged += new System.EventHandler(this.OnlySelectedCB_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 248);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.storeBT, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 224);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(258, 24);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // storeBT
            // 
            this.storeBT.BackgroundImage = global::TK.GraphComponents.Properties.Resources.Store;
            this.storeBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.storeBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeBT.FlatAppearance.BorderSize = 0;
            this.storeBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.storeBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.storeBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeBT.Location = new System.Drawing.Point(102, 1);
            this.storeBT.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.storeBT.Name = "storeBT";
            this.storeBT.Size = new System.Drawing.Size(54, 21);
            this.storeBT.TabIndex = 0;
            this.storeBT.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Capture mode :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captureDD
            // 
            this.captureDD.AllowCustomValue = false;
            this.captureDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureDD.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("captureDD.Items")));
            this.captureDD.Location = new System.Drawing.Point(111, 138);
            this.captureDD.Name = "captureDD";
            this.captureDD.ReadOnly = true;
            this.captureDD.SelectedIndex = -1;
            this.captureDD.Size = new System.Drawing.Size(138, 20);
            this.captureDD.TabIndex = 19;
            this.captureDD.TextChanged += new System.EventHandler(this.captureDD_TextChanged);
            // 
            // typeDD
            // 
            this.typeDD.AllowCustomValue = false;
            this.typeDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeDD.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("typeDD.Items")));
            this.typeDD.Location = new System.Drawing.Point(111, 30);
            this.typeDD.Name = "typeDD";
            this.typeDD.ReadOnly = true;
            this.typeDD.SelectedIndex = -1;
            this.typeDD.Size = new System.Drawing.Size(138, 20);
            this.typeDD.TabIndex = 10;
            this.typeDD.TextChanged += new System.EventHandler(this.typeDD_TextChanged);
            // 
            // SaveActionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "SaveActionCtrl";
            this.Size = new System.Drawing.Size(258, 248);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endFrameN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFrameN)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private TKDropDown typeDD;
        private System.Windows.Forms.NumericUpDown endFrameN;
        private System.Windows.Forms.CheckBox KeyAllCB;
        private System.Windows.Forms.NumericUpDown startFrameN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button storeBT;
        private System.Windows.Forms.TextBox categoryTB;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox OnlySelectedCB;
        private System.Windows.Forms.Label label4;
        private TKDropDown captureDD;
    }
}
