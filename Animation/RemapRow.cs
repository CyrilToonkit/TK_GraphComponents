using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace TK.GraphComponents.Animation
{
    public class RemapRow
    {
        public RemapRow(string inType, string inOriginal, string inRetarget)
        {
            type = inType;
            original = inOriginal;
            retarget = originalRetarget = inRetarget;
        }
        
        string type = "Control";
        [ReadOnlyAttribute(true)]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        string original = "";
        [ReadOnlyAttribute(true)]
        public string Original
        {
            get { return original; }
            set { original = value; }
        }

        string retarget = "";
        public string Retarget
        {
            get { return retarget; }
            set { retarget = value; }
        }

        string originalRetarget = "";
        [BrowsableAttribute(false)]
        public string OriginalRetarget
        {
            get { return originalRetarget; }
            set { originalRetarget = value; }
        }
    }
}
