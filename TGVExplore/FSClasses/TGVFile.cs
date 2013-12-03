using System;
using System.Collections.Generic;
using System.Text;
using TK.BaseLib;
using System.IO;
using TK.BaseLib.CustomData;

namespace TGVExplore.FSClasses
{
    public class TGVFile : ITGVNode
    {
        public FileInfo info;
        List<string> fields = new List<string>();

        public TGVFile(FileInfo inInfo)
        {
            info = inInfo;
            fields.Add("Type");
            fields.Add("Modified");
            fields.Add("Extension");
            fields.Add("Size");
        }

        #region ITGVNode Members

        public string ITGV_UniqueName
        {
            get { return info.FullName; }
        }

        public string ITGV_Name
        {
            get
            {
                return info.Name;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ITGV_Description
        {
            get { return ""; }
        }

        public string ITGV_Type
        {
            get { return "file"; }
        }

        public bool ITGV_Expanded
        {
            get
            {
                return false;
            }
            set
            {

            }
        }

        public bool ITGV_HasChildren()
        {
            return false;
        }

        public List<ITGVNode> ITGV_GetChildren()
        {
            return new List<ITGVNode>();
        }

        public List<string> ITGV_GetFields()
        {
            return fields;
        }

        public object ITGV_GetFieldValue(string field)
        {
            switch (field)
            {
                case "Type":
                    return "File";

                case "Modified" :
                    return info.LastWriteTime;

                case "Extension":
                    return info.Extension;

                case "Size":
                    return info.Length;
            }

            return null;
        }

        public void ITGV_SetFieldValue(string field, object value)
        {

        }

        #endregion
    }
}
