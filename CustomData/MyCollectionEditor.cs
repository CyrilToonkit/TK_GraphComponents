using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.Windows.Forms;

//COMMENTS OK
namespace TK.GraphComponents.CustomData
{
    /// <summary>
    /// Class used to manage List editing through standard PropertyGrid
    /// Overriding the creation of the editor form, we could register the FormClosed Event to know when a change is made
    /// </summary>
    public class MyCollectionEditor : CollectionEditor
    {
        // == CONSTRUCTORS ================================================================

        public MyCollectionEditor(Type type) : base(type) { }

        // == MEMBERS =====================================================================

        /// <summary>
        /// Name of the property that has been edited
        /// </summary>
        public string propertyLabel = string.Empty;

        /// <summary>
        /// Indicates if the action was cancelled
        /// </summary>
        public bool Cancelled = false;

        /// <summary>
        /// Delegate for the custom Event MyFormClosed
        /// </summary>
        /// <param name="sender">The current collection Editor</param>
        /// <param name="e">The event arguments</param>
        public delegate void MyFormClosedEventHandler(object sender,
                                            FormClosedEventArgs e);

        /// <summary>
        /// The custom Event for Editor form closing
        /// </summary>
        public static event MyFormClosedEventHandler MyFormClosed;

        // == METHODS =====================================================================

        /// <summary>
        /// OverWritten CreateCollectionForm method, to add needed callbacks
        /// </summary>
        /// <returns>the created Form</returns>
        protected override CollectionForm CreateCollectionForm()
        {
            CollectionForm collectionForm = base.CreateCollectionForm();
            Button Ok = collectionForm.Controls[0].Controls[6].Controls[0] as Button;
            Ok.Click += new EventHandler(Ok_Click);
            collectionForm.FormClosed += new FormClosedEventHandler(collection_FormClosed);
            return collectionForm;
        }

        /// <summary>
        /// Workaround delegate to correctly set the dialog result to OK when OK button is clicked
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">The event arguments</param>
        void Ok_Click(object sender, EventArgs e)
        {
            Form colForm = (sender as Control).FindForm();
            colForm.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Delegate for the custom Event MyFormClosed
        /// </summary>
        /// <param name="sender">The current collection Editor</param>
        /// <param name="e">The event arguments</param>
        void collection_FormClosed(object sender, FormClosedEventArgs e)
        {
            CollectionForm collectionForm = sender as CollectionForm;
            propertyLabel = Context.PropertyDescriptor.Name;
            Cancelled = collectionForm.DialogResult == DialogResult.Cancel;

            if (MyFormClosed != null)
            {
                MyFormClosed(this, e);
            }
        }
    }
}
