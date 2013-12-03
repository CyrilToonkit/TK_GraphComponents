using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;
using System.IO;
using System.Diagnostics;
using TK.BaseLib.Animation;
using TK.GraphComponents.Dialogs;

namespace TK.GraphComponents.Animation
{
    public enum Fields
    {
        Name,Type,Date,Length,User
    }

    public partial class ActionsUI : UserControl
    {
        public ActionsUI()
        {
            InitializeComponent();
        }

        public ActionsUI(TK_ActionLibrary inLibrary)
        {
            InitializeComponent();
            library = inLibrary;
            icons.Add(ActionTypes.Pose, global::TK.GraphComponents.Properties.Resources.Pose);
            icons.Add(ActionTypes.Anim, global::TK.GraphComponents.Properties.Resources.Anim);
            icons.Add(ActionTypes.Cycle, global::TK.GraphComponents.Properties.Resources.Cycle);

            SetTags();
            LoadPoses();
            LoadInfos();
        }

        private void SetTags()
        {
            SortDropDownButton.DropDownItems[0].Tag = Fields.Name;
            SortDropDownButton.DropDownItems[1].Tag = Fields.Type;
            SortDropDownButton.DropDownItems[2].Tag = Fields.Date;
            SortDropDownButton.DropDownItems[3].Tag = Fields.Length;
            SortDropDownButton.DropDownItems[4].Tag = Fields.User;
        }

        public void LoadPoses()
        {
            Ctrls.Clear();

            foreach(TK_Action action in library.Actions)
            {
                ActionCtrl ctrl = new ActionCtrl(this, action);
                ctrl.MouseClick += new MouseEventHandler(ctrl_MouseClick);
                ctrl.MouseDoubleClick += new MouseEventHandler(ctrl_MouseDoubleClick);
                Ctrls.Add(ctrl);

                if (!categories.ContainsKey(action.Category))
                {
                    ToolStripMenuItem item = CategDropDownButton.DropDownItems.Add(action.Category) as ToolStripMenuItem;
                    item.CheckOnClick = true;
                    item.Checked = true;
                    item.CheckedChanged += new EventHandler(item_CheckedChanged);
                    categories.Add(action.Category, true);
                }
            }

            SortControls();
            ResetVisibilities();
            UpdateDisplays();
            SetDisplayStates();
        }

        void item_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            categories[item.Text] = item.Checked;

            if (!MuteEvents)
            {
                ResetVisibilities();

                if (ModifierKeys == Keys.Shift)
                {
                    CategDropDownButton.ShowDropDown();
                }
            }
        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MuteEvents = true;
            for (int i = 5; i < CategDropDownButton.DropDownItems.Count; i++)
            {
                (CategDropDownButton.DropDownItems[i] as ToolStripMenuItem).Checked = true;
            }
            MuteEvents = false;
            ResetVisibilities();
            CategDropDownButton.ShowDropDown();
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuteEvents = true;
            for (int i = 5; i < CategDropDownButton.DropDownItems.Count; i++)
            {
                (CategDropDownButton.DropDownItems[i] as ToolStripMenuItem).Checked = false;
            }
            MuteEvents = false;
            ResetVisibilities();
            CategDropDownButton.ShowDropDown();
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuteEvents = true;
            for (int i = 5; i < CategDropDownButton.DropDownItems.Count; i++)
            {
                ToolStripMenuItem item = CategDropDownButton.DropDownItems[i] as ToolStripMenuItem;
                item.Checked = !item.Checked;
            }
            MuteEvents = false;
            ResetVisibilities();
            CategDropDownButton.ShowDropDown();
        }

        public void LoadInfos()
        {
            string oldText = AdvModelsDD.Text;
            bool exists = oldText == "Ref" ? true : false;
            AdvModelsDD.DropDownItems.Clear();

            AdvModelsDD.DropDownItems.Add("Ref",null, new EventHandler(ModelInfoChange));
            AdvModelsDD.DropDownItems.Add(new ToolStripSeparator());

            foreach(string info in library.ModelInfos.Keys)
            {
                if (oldText == info)
                {
                    exists = true;
                }
                AdvModelsDD.DropDownItems.Add(info, null, new EventHandler(ModelInfoChange));
            }

            if (!exists)
            {
                AdvModelsDD.Text = "Ref";
            }
        }

        void ModelInfoChange(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item != null)
            {
                AdvModelsDD.Text = item.Text;
            }
        }

        void ctrl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ActionCtrl actionCtrl = sender as ActionCtrl;
            if (actionCtrl.Action.Type != ActionTypes.Pose)
            {
                library.ShowSequence(actionCtrl.Action);
            }
        }

        void ctrl_MouseClick(object sender, MouseEventArgs e)
        {
            Control actionCtrl = sender as Control;

            if (e.Button == MouseButtons.Right)
            {
                actionsContext.Show(Cursor.Position);
            }
        }

        private void SortControls()
        {
            Ctrls.Sort(sorter);
            ActionsFlow.Controls.Clear();

            foreach (ActionCtrl action in Ctrls)
            {
                ActionsFlow.Controls.Add(action);
            }
        }

        Dictionary<string, bool> categories = new Dictionary<string, bool>();
        List<ActionCtrl> Ctrls = new List<ActionCtrl>();
        ActionSorter sorter = new ActionSorter(Fields.Name);
        TK_ActionLibrary library = null;
        Dictionary<ActionTypes, Image> icons = new Dictionary<ActionTypes, Image>();
        bool MuteEvents = false;
        public Dictionary<ActionTypes, Image> Icons
        {
            get { return icons; }
            set { icons = value; }
        }

        ApplyMode mode = ApplyMode.All;
        public ApplyMode Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        double frame = 0;
        public double Frame
        {
            get { return useCurrentFrameToolStripMenuItem.Checked ? double.MinValue : frame; }
            set { frame = value; }
        }

        public double Retime
        {
            get { return decimal.ToDouble(AdvRetimeNUD.Value); }
            set { AdvRetimeNUD.Value = (decimal)value; }
        }

        //Selection handling
        List<ActionCtrl> selectedActionCtrls = new List<ActionCtrl>();

        private List<TK_Action> GetSelectedActions()
        {
            List<TK_Action> actions = new List<TK_Action>();
            foreach (ActionCtrl ctrl in selectedActionCtrls)
            {
                actions.Add(ctrl.Action);
            }

            return actions;
        }

        internal void AddToSelection(ActionCtrl actionCtrl)
        {
            if (!actionCtrl.Selected)
            {
                actionCtrl.Selected = true;
                selectedActionCtrls.Add(actionCtrl);
            }
        }

        internal void ToggleSelection(ActionCtrl actionCtrl)
        {
            if (!actionCtrl.Selected)
            {
                actionCtrl.Selected = true;
                selectedActionCtrls.Add(actionCtrl);
            }
            else
            {
                actionCtrl.Selected = false;
                selectedActionCtrls.Remove(actionCtrl);
            }
        }

        internal void RemoveFromSelection(ActionCtrl actionCtrl)
        {
            if (actionCtrl.Selected)
            {
                actionCtrl.Selected = false;
                selectedActionCtrls.Remove(actionCtrl);
            }
        }

        internal void Select(ActionCtrl actionCtrl)
        {
            DeselectAll();
            actionCtrl.Selected = true;
            selectedActionCtrls.Add(actionCtrl);
        }

        internal void DeselectAll()
        {
            foreach (ActionCtrl ctrl in selectedActionCtrls)
            {
                ctrl.Selected = false;
            }

            selectedActionCtrls.Clear();
        }

        //Display

        private void ResetVisibilities()
        {
            foreach (ActionCtrl actionCtrl in Ctrls)
            {
                TK_Action action = actionCtrl.Action;

                //Types
                if (action.Type == ActionTypes.Pose && !posesToolStripMenuItem.Checked)
                {
                    actionCtrl.Visible = false;
                    continue;
                }
                if (action.Type == ActionTypes.Anim && !animationsToolStripMenuItem.Checked)
                {
                    actionCtrl.Visible = false;
                    continue;
                }
                if (action.Type == ActionTypes.Cycle && !cyclesToolStripMenuItem.Checked)
                {
                    actionCtrl.Visible = false;
                    continue;
                }

                //QuickFind
                if (quickFindTB.Text != "" && !action.Name.ToLower().Contains(quickFindTB.Text.ToLower()))
                {
                    actionCtrl.Visible = false;
                    continue;
                }

                //Categories
                if (!categories[actionCtrl.Action.Category])
                {
                    actionCtrl.Visible = false;
                    continue;
                }

                actionCtrl.Visible = true;
            }
        }

        private void UpdateDisplays()
        {
            foreach (ActionCtrl actionCtrl in Ctrls)
            {
                actionCtrl.ShowIcon = icontoolStripMenuItemDisp.Checked;
                actionCtrl.ShowCategory = categoryToolStripMenuItem.Checked;
                actionCtrl.ShowProject = projectToolStripMenuItem.Checked;
                actionCtrl.ShowModel = modelToolStripMenuItem.Checked;
                actionCtrl.ShowIcon = icontoolStripMenuItemDisp.Checked;
                actionCtrl.ShowUser = usertoolStripMenuItemDisp.Checked;
                actionCtrl.ShowDate = datetoolStripMenuItemDisp.Checked;
                actionCtrl.ShowLength = lengthtoolStripMenuItemDisp.Checked;
            }
        }

        private void SetDisplayStates()
        {
            foreach (ActionCtrl actionCtrl in Ctrls)
            {
                actionCtrl.Style = smallIconsToolStripMenuItem.Checked ? DisplayStyle.SmallIcons : DisplayStyle.LargeIcons;
            }
        }

        //Callbacks

        private void ActionsFlow_Click(object sender, EventArgs e)
        {
            DeselectAll();
        }

        private void posesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            string title = "Types : ";
            bool atLeastOne = false;

            if (!posesToolStripMenuItem.Checked && !animationsToolStripMenuItem.Checked && !cyclesToolStripMenuItem.Checked)
            {
                (sender as ToolStripMenuItem).Checked = true;
            }

            if (posesToolStripMenuItem.Checked && animationsToolStripMenuItem.Checked && cyclesToolStripMenuItem.Checked)
            {
                title += "All";
            }
            else
            {
                if (posesToolStripMenuItem.Checked)
                {
                    title += "Poses";
                    atLeastOne = true;
                }

                if (animationsToolStripMenuItem.Checked)
                {
                    title += atLeastOne ? " && Anims" : "Anims";
                    atLeastOne = true;
                }

                if (cyclesToolStripMenuItem.Checked)
                {
                    title += atLeastOne ? " && Cycles" : "Cycles";
                }
            }

            TypesDropDownButton.Text = title;
            ResetVisibilities();

            if (ModifierKeys == Keys.Shift)
            {
                TypesDropDownButton.ShowDropDown();
            }
        }

        //Apply Action

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (selectedActionCtrls.Count > 0)
            {
                List<TK_Action> actions = GetSelectedActions();

                library.ApplyActions(actions, Frame, mode, Retime);
            }
            else
            {
                MessageBox.Show("Please select an action to apply !");
            }
        }

        private void applyAllToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!MuteEvents)
            {
                MuteEvents = true;
                string title = "";
                ToolStripMenuItem item = sender as ToolStripMenuItem;

                if (!item.Checked)
                {
                    item.Checked = true;
                }
                else
                {
                    switch (item.Name)
                    {
                        case "applyIgnoringSelectionToolStripMenuItem":
                            title = "(ignore selection)";
                            applyOnSelectionToolStripMenuItem.Checked = false;
                            applyAllToolStripMenuItem.Checked = false;

                            mode = ApplyMode.IgnoreSelection;
                            break;

                        case "applyOnSelectionToolStripMenuItem":
                            title = "(on selection)";
                            applyIgnoringSelectionToolStripMenuItem.Checked = false;
                            applyAllToolStripMenuItem.Checked = false;
                            mode = ApplyMode.OnSelection;
                            break;

                        default:
                            title = "(all)";
                            applyIgnoringSelectionToolStripMenuItem.Checked = false;
                            applyOnSelectionToolStripMenuItem.Checked = false;
                            mode = ApplyMode.All;
                            break;
                    }

                    applyToolStrip.Text = title;
                }

                MuteEvents = false;

                if (ModifierKeys == Keys.Shift)
                {
                    applyToolStrip.ShowDropDown();
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            ResetVisibilities();
        }

        private void nameToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!MuteEvents)
            {
                MuteEvents = true;

                ToolStripMenuItem changedItem = sender as ToolStripMenuItem;

                if (changedItem.Checked == false)
                {
                    changedItem.Checked = true;
                }
                else
                {
                    foreach (ToolStripMenuItem item in SortDropDownButton.DropDownItems)
                    {
                        if (item != changedItem)
                        {
                            item.Checked = false;
                        }
                    }

                    Fields field = (Fields)changedItem.Tag;

                    if (sorter.Field != field)
                    {
                        sorter.Field = field;
                        SortControls();
                        SortDropDownButton.Text = "Sort by : " + field.ToString();
                    }
                }

                MuteEvents = false;
            }

            if (ModifierKeys == Keys.Shift)
            {
                SortDropDownButton.ShowDropDown();
            }
        }

        private void datetoolStripMenuItemDisp_CheckedChanged(object sender, EventArgs e)
        {
            if (!MuteEvents)
            {
                UpdateDisplays();
            }
        }

 
        private void nothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuteEvents = true;
            projectToolStripMenuItem.Checked = false;
            modelToolStripMenuItem.Checked = false;
            usertoolStripMenuItemDisp.Checked = false;
            datetoolStripMenuItemDisp.Checked = false;
            lengthtoolStripMenuItemDisp.Checked = false;

            MuteEvents = false;

            UpdateDisplays();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuteEvents = true;

            projectToolStripMenuItem.Checked = true;
            modelToolStripMenuItem.Checked = true;
            usertoolStripMenuItemDisp.Checked = true;
            datetoolStripMenuItemDisp.Checked = true;
            lengthtoolStripMenuItemDisp.Checked = true;

            MuteEvents = false;

            UpdateDisplays();
        }

        private void smallIconsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!MuteEvents)
            {
                MuteEvents = true;

                ToolStripMenuItem changedItem = sender as ToolStripMenuItem;

                if (changedItem.Checked == false)
                {
                    changedItem.Checked = true;
                }
                else
                {
                    foreach (ToolStripMenuItem item in styleToolStrip.DropDownItems)
                    {
                        if (item != changedItem)
                        {
                            item.Checked = false;
                        }
                    }

                    SetDisplayStates();
                }

                MuteEvents = false;
            }

            if (ModifierKeys == Keys.Shift)
            {
                styleToolStrip.ShowDropDown();
            }
        }

        // *** ContextMenu ***

        private void deleteActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<TK_Action> actions = GetSelectedActions();
            if (actions.Count > 0)
            {
                string actionsList = actions[0].Name;

                for (int i = 1; i < actions.Count; i++)
                {
                    actionsList += "," + actions[i].Name;
                }

                string potentialS = actions.Count > 1 ? "s" : "";

                if (TKMessageBox.Confirm("Are you sure you want to delete the action" + potentialS + " : " + actionsList + " ?", "Delete Action" + potentialS) == DialogResult.OK)
                {
                    DeselectAll();

                    for (int i = 0; i < actions.Count; i++)
                    {
                        library.DeleteAction(actions[i]);
                    }

                    LoadPoses();
                }
            }
            else
            {
                MessageBox.Show("Select some actions to delete");
            }
        }

        private void refreshPosesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeselectAll();
            library.Load();
            LoadPoses();
            LoadInfos();

            TK_EmptyForm form = (ParentForm as TK_EmptyForm);
            if (form != null)
            {
                form.Title = library.GetName();
            }
        }

        private void exploreActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", library.GetRepository());
        }

        private void useCurrentFrameToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (useCurrentFrameToolStripMenuItem.Checked)
            {
                frameTB.Visible = false;
                applyFrameModeToolStrip.Text = "Apply at current frame";
            }
            else
            {
                frameTB.Visible = true;
                applyFrameModeToolStrip.Text = "Apply at frame : ";
            }
        }

        private void frameTB_TextChanged(object sender, EventArgs e)
        {
            double val = frame;
            if (!double.TryParse(frameTB.Text, out val))
            {
                frameTB.Text = "0";
            }
            else
            {
                frame = val;
            }
        }

        private void createNewActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.StoreAction();
        }

        // ADVANCED OPTIONS CHANGED

        private void AdvKeyPosesCheck_CheckedChanged(object sender, EventArgs e)
        {
            library.Options.AutoKeyPose = AdvKeyPosesCheck.Checked;
        }

        private void AdvRetargetCB_CheckedChanged(object sender, EventArgs e)
        {
            library.Options.Retarget = AdvRetargetCB.Checked;
        }

        private void AdvPopupCB_CheckedChanged(object sender, EventArgs e)
        {
            library.Options.OpenRemapper = AdvPopupCB.Checked;
        }

        private void AdvOpenCompleteCB_CheckedChanged(object sender, EventArgs e)
        {
            library.Options.AlwaysOpenRemapper = AdvOpenCompleteCB.Checked;
        }

        private void AdvResizeCB_CheckedChanged(object sender, EventArgs e)
        {
            library.Options.Resize = AdvResizeCB.Checked;
        }

        private void AdvForceResize_CheckedChanged(object sender, EventArgs e)
        {
            library.Options.ForceResize = AdvForceResize.Checked;
        }

        private void AdvCleanKeysCheck_CheckedChanged(object sender, EventArgs e)
        {
            library.Options.Clean = AdvCleanKeysCheck.Checked;
        }

        private void AdvMarginNUD_ValueChanged(object sender, EventArgs e)
        {
            library.Options.CleanMargin = decimal.ToInt32(AdvMarginNUD.Value);
        }

        private void AdvEditMapsBT_Click(object sender, EventArgs e)
        {
            library.EditMaps();
        }

        private void AdvEditInfosBT_Click(object sender, EventArgs e)
        {
            if (AdvModelsDD.Text != "- select a model")
            {
                library.EditModelInfo(AdvModelsDD.Text);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string target = "https://docs.google.com/document/pub?id=1kyKOeIGpNVTzYJ_MJwqI3KoIMqnJPH9JBmuD7HD4iNU";

            try
            {
                System.Diagnostics.Process.Start(target);
            }

            catch(System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }

            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void AdvForcedResizing_ValueChanged(object sender, EventArgs e)
        {
            library.Options.ForcedResizing = decimal.ToDouble(AdvForcedResizing.Value);
        }
    }
}
