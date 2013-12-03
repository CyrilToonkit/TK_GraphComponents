using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TK.GraphComponents;
using TK.BaseLib;
using TK.BaseLib.Picture;

namespace GraphTester
{
    public partial class Form1 : Form
    {
        TK_Splash splash = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            ControlsMap map = new ControlsMap();
            
            List<string> maps = new List<string>();
            maps.Add("Bozo");
            maps.Add("Chokel");
            maps.Add("Joker");
            map.ControlMaps.Add(maps);

            maps = new List<string>();
            maps.Add("Coco");
            maps.Add("Pioupiou");
            map.ControlMaps.Add(maps);

            maps = new List<string>();
            maps.Add("Cyril");
            maps.Add("Nicolas");
            maps.Add("François");
            maps.Add("Jean-marie");
            map.ControlMaps.Add(maps);
            */
            //draggableTBLineCollection2.LoadMap(map);

            List<object> objs = new List<object> { "Coco", "Limbo", "Bozo" };
            tkDropDown1.Items = objs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splash = new TK_Splash();
            splash.Check("Coco", "1.0", "Maison", DateTime.Now, 60, true, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (splash != null)
            {
                splash.CallClose();
                splash = null;
            }
        }

        private void completeSlider1_StopValueChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            realSlider1.FramesLabelsDynamicFrequency = checkBox1.Checked;
        }

        private void completeSlider1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bah si pourtant ça marche !!");
        }
        
    }
}
