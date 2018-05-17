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
    public partial class MappingUCtrl : UserControl
    {
        public MappingUCtrl()
        {
            InitializeComponent();

            mappingsGridView.BackgroundColor = Color.FromArgb(255,120,120,120);
            mappingsGridView.DataBindings.Add(new Binding("BackgroundColor", this, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        Mapping _mapping;

        public void Init(Mapping inMapping)
        {
            _mapping = inMapping;
            LoadUI();
        }

        public void LoadUI()
        {
            mappingsGridView.DataSource = null;
            mappingsGridView.DataSource = _mapping.ToItems();
        }
    }
}
