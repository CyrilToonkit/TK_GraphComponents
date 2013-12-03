using System;
using System.Collections.Generic;
using System.Text;
using TK.BaseLib;
using System.IO;
using TK.BaseLib.CustomData;

namespace TGVExplore.FSClasses
{
    public class TGVFolder : ITGVNode
    {
        DirectoryInfo info;
        List<string> fields = new List<string>();
        List<ITGVNode> children = new List<ITGVNode>();

        public TGVFolder(DirectoryInfo inInfo)
        {
            info = inInfo;
            fields.Add("Type");
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
            get { return "folder"; }
        }

        bool Expanded = false;
        public bool ITGV_Expanded
        {
            get
            {
                return Expanded;
            }
            set
            {
                Expanded = value;
            }
        }

        public bool ITGV_HasChildren()
        {
            return true;
        }

        public List<ITGVNode> ITGV_GetChildren()
        {
            List<ITGVNode> newChildren = new List<ITGVNode>();
            bool found = false;

            foreach (DirectoryInfo dInf in info.GetDirectories())
            {
                try
                {
                    //let .NET throw an exceptions if we don't have access...
                    found = dInf.GetDirectories().Length > 0 && dInf.GetFiles().Length > 0;
                    found = false;
                    foreach (ITGVNode node in children)
                    {
                        TGVFolder folder = node as TGVFolder;
                        if (folder != null && folder.info.Name == dInf.Name)
                        {
                            folder.info = dInf;
                            newChildren.Add(folder);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        newChildren.Add(new TGVFolder(dInf));
                    }
                }
                catch (Exception) { }
            }

            foreach (FileInfo fInf in info.GetFiles())
            {
                found = false;
                foreach (ITGVNode node in children)
                {
                    TGVFile file = node as TGVFile;
                    if (file != null && file.info.Name == fInf.Name)
                    {
                        file.info = fInf;
                        newChildren.Add(file);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    newChildren.Add(new TGVFile(fInf));
                }
            }

            children = newChildren;

            return children;
        }

        public List<string> ITGV_GetFields()
        {
           return fields;
        }

        public object ITGV_GetFieldValue(string field)
        {
            if (field == "Type")
            {
                return "Folder";
            }

            return null;
        }

        public void ITGV_SetFieldValue(string field, object value)
        {
        }

        #endregion
    }
}
