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
using System.Net;
using System.IO;
using System.Management;
using System.Reflection;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Security.Principal;  // for class Encoding

namespace GraphTester
{
    public partial class Form1 : Form
    {
        TK_Splash splash = null;

        TK_SplashLicense splashl = null;

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

            //retimeCtrl1.OpenSequence("Z:\\0004_Triples\\LES_TRIPLES\\04_LT_Work\\Actions\\Gigote\\Sequence", true, false);
            //retimeCtrl1.Factor = 2;

            Mapping map = new Mapping("Toto", new List<string> { "Toto", "Titi", "Tutu" }, "Titi", new List<string> { "Toto", "Titi", "Tutu" });

            propertyGrid1.SelectedObject = new MappingItem(map, "Toto", "Titi");
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

        public string GetIP()
        {
            int tries = 3;

            string externalIP = "IP not found";

            for (int i = tries; i > 0; i--)
            {
                try
                {
                    externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/");
                    externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();
                    break;
                }
                catch { }
            }

            return externalIP;
        }

        public string GetProcID()
        {
            ManagementObjectSearcher searcher = 
                 new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor"); 

             foreach (ManagementObject queryObj in searcher.Get())
             {
                 if (queryObj["ProcessorId"] != null)
                 {
                     return queryObj["ProcessorId"].ToString();
                 }
             }

             return "ProcessorId not found";
        }

        public string GetMac()
        {
            ManagementClass oMClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection colMObj = oMClass.GetInstances();
            foreach (ManagementObject objMO in colMObj)
            {
                if (objMO["MacAddress"] != null)
                {
                    return objMO["MacAddress"].ToString();
                }
            }

            return "MacAddress not found";
        }

        public bool postEntry(string user, string ip, string domain, string procID, string mac, string version, string project)
        {
            string formUrl = "https://docs.google.com/forms/d/e/1FAIpQLSd8JS4niI317jqmTXm-LtkgFbgDmFSJ1N1LI7njDTUyKaZz2Q/formResponse";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(formUrl);

            Dictionary<string, string> fieldValues = new Dictionary<string, string>();

            fieldValues.Add("entry_1385243592", user);
            fieldValues.Add("entry_2102627521", ip);
            fieldValues.Add("entry_1599095637", domain);
            fieldValues.Add("entry_1237369755", procID);
            fieldValues.Add("entry_571267387", mac);
            fieldValues.Add("entry_1943528130", version);
            fieldValues.Add("entry_107462746", project);

            List<string> postData = new List<string>();

            foreach (string key in fieldValues.Keys)
            {
                postData.Add(key + "=" + fieldValues[key]);
            }

            byte[] data = Encoding.ASCII.GetBytes(TypesHelper.Join(postData, "&"));

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            try
            {
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                WebResponse response = null;

                int tries = 3;
                for (int i = tries; i > 0; i--)
                {
                    try
                    {
                        response = (HttpWebResponse)request.GetResponse();
                        break;
                    }
                    catch { }
                }

                if (response != null)
                {
                    string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }

                return true;
            }
            catch{}

            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] id = WindowsIdentity.GetCurrent().Name.Split("\\".ToCharArray());
            System.Version v = Assembly.GetExecutingAssembly().GetName().Version;

            bool rslt = postEntry(id[1], GetIP(), id[0], GetProcID(), GetMac(), string.Format(CultureInfo.InvariantCulture, "{0}.{1}.{2} (r{3})", v.Major, v.Minor, v.Build, v.Revision), "CurrentProject from C#");

            MessageBox.Show(rslt ? "OK" : "KO");
        }

        RichResult result = new RichResult(false);

        private void button4_Click(object sender, EventArgs e)
        {
            splashl = new TK_SplashLicense();
            System.Version v = Assembly.GetExecutingAssembly().GetName().Version;
            splashl.ShowSplash(string.Format(CultureInfo.InvariantCulture, "{0}.{1}.{2} (r{3})", v.Major, v.Minor, v.Build, v.Revision), result);

            splashl.FormClosed += splashl_FormClosed;
        }

        private void splashl_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            MessageBox.Show(result.Result ? "OK" : "KO");
            result.Result = false;
            splashl = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (splashl != null)
            {
                splashl.SetClosed = true;
                splashl = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (splashl != null)
            {
                splashl.SetAllowed = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (splashl != null)
            {
                splashl.SetToken = true;
            }
        }

        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        double GetSimilarityRatio(String FullString1, String FullString2, out double WordsRatio, out double RealWordsRatio)
        {
            double theResult = 0;
            String[] Splitted1 = FullString1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] Splitted2 = FullString2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (Splitted1.Length < Splitted2.Length)
            {
                String[] Temp = Splitted2;
                Splitted2 = Splitted1;
                Splitted1 = Temp;
            }
            int[,] theScores = new int[Splitted1.Length, Splitted2.Length];//Keep the best scores for each word.0 is the best, 1000 is the starting.
            int[] BestWord = new int[Splitted1.Length];//Index to the best word of Splitted2 for the Splitted1.

            for (int loop = 0; loop < Splitted1.Length; loop++)
            {
                for (int loop1 = 0; loop1 < Splitted2.Length; loop1++) theScores[loop, loop1] = 1000;
                BestWord[loop] = -1;
            }
            int WordsMatched = 0;
            for (int loop = 0; loop < Splitted1.Length; loop++)
            {
                String String1 = Splitted1[loop];
                for (int loop1 = 0; loop1 < Splitted2.Length; loop1++)
                {
                    String String2 = Splitted2[loop1];
                    int LevenshteinDistance = Compute(String1, String2);
                    theScores[loop, loop1] = LevenshteinDistance;
                    if (BestWord[loop] == -1 || theScores[loop, BestWord[loop]] > LevenshteinDistance) BestWord[loop] = loop1;
                }
            }

            for (int loop = 0; loop < Splitted1.Length; loop++)
            {
                if (theScores[loop, BestWord[loop]] == 1000) continue;
                for (int loop1 = loop + 1; loop1 < Splitted1.Length; loop1++)
                {
                    if (theScores[loop1, BestWord[loop1]] == 1000) continue;//the worst score available, so there are no more words left
                    if (BestWord[loop] == BestWord[loop1])//2 words have the same best word
                    {
                        //The first in order has the advantage of keeping the word in equality
                        if (theScores[loop, BestWord[loop]] <= theScores[loop1, BestWord[loop1]])
                        {
                            theScores[loop1, BestWord[loop1]] = 1000;
                            int CurrentBest = -1;
                            int CurrentScore = 1000;
                            for (int loop2 = 0; loop2 < Splitted2.Length; loop2++)
                            {
                                //Find next bestword
                                if (CurrentBest == -1 || CurrentScore > theScores[loop1, loop2])
                                {
                                    CurrentBest = loop2;
                                    CurrentScore = theScores[loop1, loop2];
                                }
                            }
                            BestWord[loop1] = CurrentBest;
                        }
                        else//the latter has a better score
                        {
                            theScores[loop, BestWord[loop]] = 1000;
                            int CurrentBest = -1;
                            int CurrentScore = 1000;
                            for (int loop2 = 0; loop2 < Splitted2.Length; loop2++)
                            {
                                //Find next bestword
                                if (CurrentBest == -1 || CurrentScore > theScores[loop, loop2])
                                {
                                    CurrentBest = loop2;
                                    CurrentScore = theScores[loop, loop2];
                                }
                            }
                            BestWord[loop] = CurrentBest;
                        }

                        loop = -1;
                        break;//recalculate all
                    }
                }
            }
            for (int loop = 0; loop < Splitted1.Length; loop++)
            {
                if (theScores[loop, BestWord[loop]] == 1000) theResult += Splitted1[loop].Length;//All words without a score for best word are max failures
                else
                {
                    theResult += theScores[loop, BestWord[loop]];
                    if (theScores[loop, BestWord[loop]] == 0) WordsMatched++;
                }
            }
            int theLength = (FullString1.Replace(" ", "").Length > FullString2.Replace(" ", "").Length) ? FullString1.Replace(" ", "").Length : FullString2.Replace(" ", "").Length;
            if (theResult > theLength) theResult = theLength;
            theResult = (1 - (theResult / theLength)) * 100;
            WordsRatio = ((double)WordsMatched / (double)Splitted2.Length) * 100;
            RealWordsRatio = ((double)WordsMatched / (double)Splitted1.Length) * 100;
            return theResult;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double WordsRatio = 0.0;
            double RealWordsRatio = 0.0;
            double ratio = GetSimilarityRatio(textBox1.Text, textBox2.Text, out WordsRatio, out RealWordsRatio);

            MessageBox.Show(string.Format("Result '{0}' (WordsRatio '{1}', RealWordsRatio '{2}')", ratio, WordsRatio, RealWordsRatio));
        }
    }
}
