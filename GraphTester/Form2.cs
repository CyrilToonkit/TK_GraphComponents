using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TK.BaseLib.Checking;

namespace GraphTester
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //CheckList
            CheckList testList = new CheckList("Habiller le bas");

            Check check1 = new Check("Premier check", "Vérifier qu'on a mit son caleçon.");
            testList.Checks.Add(check1);

            Check check2 = new Check("Deuxième check", "Vérifier qu'on a mit son pantalon.");
            testList.Checks.Add(check2);

            Check check3 = new Check("Troisième check", "Vérifier qu'on a fermé sa braguette.");
            testList.Checks.Add(check3);

            checkListEditorCtrl1.LoadList(testList);
        }
    }
}
