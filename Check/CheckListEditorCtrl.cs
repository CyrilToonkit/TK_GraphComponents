using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib.Checking;

namespace TK.GraphComponents.Check
{
    public partial class CheckListEditorCtrl : UserControl
    {
        string _loadedpath = "";
        bool muteEvents = false;
        CheckList _loadedList = null;
        public CheckList LoadedList
        {
            get { return _loadedList; }
        }

        public CheckListEditorCtrl()
        {
            InitializeComponent();
        }

        private void CheckListEditorCtrl_Load(object sender, EventArgs e)
        {
            LoadList(new CheckList());
        }

        public void LoadList(CheckList checkList)
        {
            _loadedList = checkList;
            if (ParentForm != null)
            {
                string txt = "TchecKer BETA : " + checkList.Name;
                if(!string.IsNullOrEmpty(_loadedpath))
                {
                    saveToolStripMenuItem.Enabled = true;
                    txt += " (" + _loadedpath + ")";
                }
                ParentForm.Text = txt;
            }

            muteEvents = true;
            nameTB.Text = checkList.Name;
            muteEvents = false;

            UpdateLB();
        }

        public void Open(string inPath)
        {
            CheckList check = CheckHelper.Load(inPath);
            if (check != null)
            {
                _loadedpath = inPath;
                LoadList(check);
            }
            else
            {
                MessageBox.Show("Cannot open the file as a CheckList", "Open failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Save(string inPath)
        {
            if (CheckHelper.Save(_loadedList, inPath, true))
            {
                _loadedpath = inPath;
                LoadList(_loadedList);
            }
            else
            {
                MessageBox.Show("Cannot save the CheckList !", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLB()
        {
            checkLB.DataSource = null;
            checkLB.DataSource = _loadedList.Checks;
        }

        private void checkLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPG.SelectedObject = checkLB.SelectedItem;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loadedpath = "";
            LoadList(new CheckList());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Open(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_loadedpath))
            {
                Save(_loadedpath);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Save(saveFileDialog1.FileName);
            }
        }

        private void checkPG_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            UpdateLB();
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            if (!muteEvents)
            {
                _loadedList.Name = nameTB.Text;
                LoadList(_loadedList);
            }
        }

        private void newCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loadedList.Checks.Add(new TK.BaseLib.Checking.Check());
            UpdateLB();
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkLB.SelectedItems.Count > 0)
            {
                TK.BaseLib.Checking.Check targetCheck = checkLB.SelectedItems[0] as TK.BaseLib.Checking.Check;

                TK.BaseLib.Checking.Check newCheck = new TK.BaseLib.Checking.Check();
                newCheck.Copy(targetCheck);

                _loadedList.Checks.Add(newCheck);
                UpdateLB();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkLB.SelectedItems.Count > 0)
            {
                TK.BaseLib.Checking.Check targetCheck = checkLB.SelectedItems[0] as TK.BaseLib.Checking.Check;

                _loadedList.Checks.Remove(targetCheck);
                UpdateLB();
            }
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkLB.SelectedItems.Count > 0)
            {
                TK.BaseLib.Checking.Check targetCheck = checkLB.SelectedItems[0] as TK.BaseLib.Checking.Check;
                int idx = _loadedList.Checks.IndexOf(targetCheck);
                if (idx > 0)
                {
                    _loadedList.Checks.Remove(targetCheck);
                    _loadedList.Checks.Insert(idx - 1, targetCheck);
                    UpdateLB();
                }
            }
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkLB.SelectedItems.Count > 0)
            {
                TK.BaseLib.Checking.Check targetCheck = checkLB.SelectedItems[0] as TK.BaseLib.Checking.Check;
                int idx = _loadedList.Checks.IndexOf(targetCheck);
                if (idx < _loadedList.Checks.Count - 1)
                {
                    _loadedList.Checks.Remove(targetCheck);
                    _loadedList.Checks.Insert(idx + 1, targetCheck);
                    UpdateLB();
                }
            }
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( _loadedList != null)
            {
                Form testform = new Form();

                CheckListCtrl clCtrl = new CheckListCtrl();
                clCtrl.Active = false;
                clCtrl.InitCheckList(_loadedList);
                testform.Controls.Add(clCtrl);
                clCtrl.Dock = DockStyle.Fill;
                testform.Text = _loadedList.Name;
                testform.Show();
            }
        }
    }
}
