using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib;

//COMMENTS OK
namespace TK.GraphComponents.CustomData
{
    /// <summary>
    /// Precursor for UserControls which edits SaveAbleData
    /// </summary>
    public class AlternateSaveAbleEditor : UserControl
    {
        // == CONSTRUCTORS ================================================================

        public AlternateSaveAbleEditor()
        {

        }

        // == MEMBERS =====================================================================

        /// <summary>
        /// The data which is edited
        /// </summary>
        protected SaveableData mData;

        /// <summary>
        /// Virtual to init the editor
        /// </summary>
        /// <param name="inData">The data to edit</param>
        public virtual void Init(SaveableData inData)
        {
            mData = inData;
        }

        /// <summary>
        /// Virtual to read values from the SaveableData
        /// </summary>
        public virtual void RefreshValues()
        {
            
        }

        /// <summary>
        /// Tells if the editor allows managing defaults
        /// </summary>
        /// <returns>True if editor manage defaults</returns>
        public virtual bool HasDefaults()
        {
            return true;
        }

        /// <summary>
        /// Tells if the editor allows saving multiple files as presets
        /// </summary>
        /// <returns>True if editor manage presets</returns>
        public virtual bool AllowPresets()
        {
            return true;
        }
    }
}
