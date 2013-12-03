using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TK.BaseLib;
using TGVExplore.FSClasses;
using TK.BaseLib.CustomData;

namespace TGVExplore
{
    public partial class TGVExploreForm : Form
    {
        public TGVExploreForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            List<ITGVNode> rootNodes = new List<ITGVNode>();

            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DirectoryInfo info = new DirectoryInfo(drive);
                if (info.Exists)
                {
                    rootNodes.Add(new TGVFolder(info));
                }
            }

            tgv1.tgvImagesLst.Images.Add("folder", TGVExplore.Properties.Resources.folder_icon);
            tgv1.tgvImagesLst.Images.Add("file", TGVExplore.Properties.Resources.File_icon);

            tgv1.Set(rootNodes);
        }
    }
}
