using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TK.BaseLib;
using TK.GraphComponents.Dialogs;

//COMMENTS OK
namespace TK.GraphComponents.CustomData
{
    /// <summary>
    /// Base form used to edit SaveAbleData
    /// Basically displays a PropertyGrid for the SaveAbleData and Save, Load, Reset Defaults buttons
    /// Alternatively we can use an AlternateSaveAbleEditor in place of the propertyGrid
    /// </summary>
    public partial class PreferencesForm : Form
    {
        // == CONSTRUCTORS ================================================================

        public PreferencesForm()
        {
            InitializeComponent();

            MyCollectionEditor.MyFormClosed += new MyCollectionEditor.MyFormClosedEventHandler(MyCollectionEditor_MyFormClosed);
            PrefPropertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(PrefPropertyGrid_PropertyValueChanged);
            PrefChanged += new PrefChangedEventHandler(PreferencesForm_PrefChanged);
            FormClosing += new FormClosingEventHandler(PreferencesForm_FormClosing);
        }

        // == MEMBERS =====================================================================

        public delegate void PrefChangedEventHandler(object sender,
                                            PropertyChangedEventArgs e);

        public event PrefChangedEventHandler PrefChanged;

        /// <summary>
        /// Tells if we made a change in the preferences and ask for saving
        /// </summary>
        bool Changed = false;

        /// <summary>
        /// The data being edited
        /// </summary>
        SaveableData Data;

        /// <summary>
        /// The AlternateSaveAbleEditor if we need specific UI
        /// </summary>
        AlternateSaveAbleEditor alternateContent = null;

        /// <summary>
        /// Base folder for saving files
        /// </summary>
        string BaseFolder;

        /// <summary> 
        /// Base FileName for saving files
        /// </summary>
        string BaseFileName;

        /// <summary>
        /// Accessor for the propertyGrid
        /// </summary>
        public PropertyGrid PropGrid
        {
            get { return PrefPropertyGrid; }
        }

        /// <summary>
        /// Simple setter for the defaults button visibility
        /// </summary>
        public bool HasDefaults
        {
            set { revertToDefaultsToolStripMenuItem.Visible = value; }
        }

        /// <summary>
        /// Simple setter for save & load items visibility
        /// </summary>
        public bool AllowPresets
        {
            set { saveAsToolStripMenuItem.Visible = value; loadToolStripMenuItem.Visible = value; }
        }

        // == METHODS =====================================================================

        /// <summary>
        /// Initialize the preference form using default PropertyGrid
        /// </summary>
        /// <param name="inName">Name of the preference to edit</param>
        /// <param name="inPrefObject">The SaveableData, as an object to keep it undetermined for PropertyGrid</param>
        /// <param name="baseFolder">Base folder for saving files</param>
        /// <param name="baseFileName">Base File Name for saving files</param>
        public void Init(string inName, object inPrefObject, string baseFolder, string baseFileName)
        {
            Init(inName, inPrefObject, baseFolder, baseFileName, null);
        }

        /// <summary>
        /// Initialize the preference form
        /// </summary>
        /// <param name="inName">Name of the preference to edit</param>
        /// <param name="inPrefObject">The SaveableData, as an object to keep it undetermined for PropertyGrid</param>
        /// <param name="baseFolder">Base folder for saving files</param>
        /// <param name="baseFileName">Base File Name for saving files</param>
        /// <param name="alternateContent">Alternate editor for the preference</param>
        public void Init(string inName, object inPrefObject, string baseFolder, string baseFileName, AlternateSaveAbleEditor alternateContent)
        {
            Data = inPrefObject as SaveableData;
            DirectoryInfo baseFolderInfo = new DirectoryInfo(baseFolder);

            if (!baseFolderInfo.Exists)
            {
                baseFolderInfo.Create();
            }

            if (Data != null && baseFolderInfo.Exists)
            {
                BaseFolder = baseFolder;
                BaseFileName = baseFileName;

                Text = inName;
                if (alternateContent != null)
                {
                    HasDefaults = alternateContent.HasDefaults();
                    AllowPresets = alternateContent.AllowPresets();

                    PrefPropertyGrid.Visible = false;
                    alternateContent.Init(Data);
                    Width = alternateContent.Width;
                    Height = alternateContent.Height;
                    Controls.Add(alternateContent);
                    alternateContent.Dock = DockStyle.Fill;
                    alternateContent.BringToFront();
                }
                else
                {
                    PrefPropertyGrid.Visible = true;
                    PrefPropertyGrid.SelectedObject = inPrefObject;
                }
            }

            Changed = false;
        }

        /// <summary>
        /// Save the Preference to the default location
        /// </summary>
        private void Save()
        {
            Data.Save(BaseFolder + "\\" + BaseFileName);
            Changed = false;
        }

        /// <summary>
        /// FormClosing callback to ask for saving if unsaved changes have been made
        /// </summary>
        /// <param name="sender">The form</param>
        /// <param name="e">event arguments</param>
        void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Changed)
            {
                DialogResult rslt = MessageBox.Show("Unsaved hanges have been made, save as current preferences ?", "Preference changed", MessageBoxButtons.YesNoCancel);
                if(rslt == DialogResult.Yes)
                {
                    Save();
                }
                else
                {
                    if(rslt == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        /// <summary>
        /// FormClosing callback for List editor, to track changes in subLists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MyCollectionEditor_MyFormClosed(object sender, FormClosedEventArgs e)
        {
            MyCollectionEditor closedCollection = sender as MyCollectionEditor;
            PrefChanged(PrefPropertyGrid, new PropertyChangedEventArgs(closedCollection.propertyLabel));
        }

        /// <summary>
        /// Callback to keep track of changes to warn user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PreferencesForm_PrefChanged(object sender, PropertyChangedEventArgs e)
        {
            Changed = true;
        }

        /// <summary>
        /// Callback to keep track of changes inside the propertyGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PrefPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            PrefChanged(s, new PropertyChangedEventArgs(e.ChangedItem.Label));
        }

        /// <summary>
        /// Clicking "Save"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Clicking "Save as"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = BaseFolder;
            saveFileDialog1.FileName = "NewPref";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Data.Save(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Clicking "Load"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = BaseFolder;
            openFileDialog1.FileName = string.Empty;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Data.Load(openFileDialog1.FileName))
                {
                    if (alternateContent != null)
                    {
                        alternateContent.Init(Data);
                        alternateContent.RefreshValues();
                        PrefChanged(PrefPropertyGrid, new PropertyChangedEventArgs("All"));
                    }
                    else
                    {
                        PrefPropertyGrid.Refresh();
                        PrefChanged(PrefPropertyGrid, new PropertyChangedEventArgs("All"));
                    }
                }
                else
                {
                    TKMessageBox.ShowError("Can't load selected Preference !", "Preference error");
                }
            }
        }

        /// <summary>
        /// Clicking "Defaults"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revertToDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.Load(BaseFolder + "\\Default.xml"))
            {
                if (alternateContent != null)
                {
                    alternateContent.RefreshValues();
                    PrefChanged(alternateContent, new PropertyChangedEventArgs("All"));
                }
                else
                {
                    PrefPropertyGrid.Refresh();
                    PrefChanged(PrefPropertyGrid, new PropertyChangedEventArgs("All"));
                }
            }
            else
            {
                MessageBox.Show("Can't load Default Preference !", "Preference error");
            }
        }
    }
}
