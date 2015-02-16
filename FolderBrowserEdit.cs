using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;

namespace TK.GraphComponents
{
    public partial class FolderBrowserEdit : UserControl
    {
        public FolderBrowserEdit()
        {
            InitializeComponent();
        }

        string _separator = ";";
        public string Separator
        {
            get { return _separator; }
            set { _separator = value; }
        }

        bool _fileMode;
        public bool FileMode
        {
            get { return _fileMode; }
            set { _fileMode = value; }
        }

        string _message = "Open" ;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                openFileDialog1.Title = _message;
                folderBrowserDialog1.Description = _message;
            }
        }

        public string Label
        {
            get { return label1.Text; }
            set
            {
                if (value == "")
                {
                    tableLayoutPanel1.ColumnStyles[0].Width = 0;
                }
                else
                {
                    tableLayoutPanel1.ColumnStyles[0].Width = 8 + value.Length * 6;
                }

                label1.Text = value;
            }
        }

        bool _addMode;
        public bool AddMode
        {
            get { return _addMode; }
            set { _addMode = value; }
        }

        public List<string> GetPaths()
        {
            return TypesHelper.StringSplit(Text, _separator, true, true);
        }

        private void BrowseBT_Click(object sender, EventArgs e)
        {
            if (_fileMode)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (_addMode)
                    {
                        List<string> oldTexts = GetPaths();
                        if (!oldTexts.Contains(openFileDialog1.FileName))
                        {
                            oldTexts.Add(openFileDialog1.FileName);
                        }

                        Text = TypesHelper.Join(oldTexts, ";");
                    }
                    else
                    {
                        Text = openFileDialog1.FileName;
                    }
                }
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (_addMode)
                    {
                        List<string> oldTexts = GetPaths();
                        if (!oldTexts.Contains(folderBrowserDialog1.SelectedPath))
                        {
                            oldTexts.Add(openFileDialog1.FileName);
                        }

                        Text = TypesHelper.Join(oldTexts, ";");
                    }
                    else
                    {
                        Text = folderBrowserDialog1.SelectedPath;
                    }
                }
            }
        }

        public new string Text
        {
            get { return PathTB.Text; }
            set { PathTB.Text = value; }
        }

        public string Filter
        {
            get { return openFileDialog1.Filter; }
            set { openFileDialog1.Filter = value; }
        }
    }
}
