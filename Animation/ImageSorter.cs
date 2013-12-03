using System;
using System.Collections.Generic;
using System.Text;

namespace TK.GraphComponents.Animation
{
    class ImageSorter : IComparer<string>
    {
        public int Compare(string imageName1, string imageName2)
        {
            int imageNumber1 = GetNumber(imageName1);
            int imageNumber2 = GetNumber(imageName2);

            if (imageNumber1 != imageNumber2)
            {
                return imageNumber1.CompareTo(imageNumber2);
            }

            return imageName1.CompareTo(imageName2);
        }

        internal static int GetNumber(string imageName1)
        {
            int number = 0;
            int pointer = 0;
            imageName1 = imageName1.Substring(0, imageName1.LastIndexOf("."));
            string lastChar = imageName1.Substring(imageName1.Length - pointer - 1, 1);

            while (IsParsable(lastChar))
            {
                if (lastChar == "-")
                {
                    number *= -1;
                    break;
                }
                else
                {
                    int value = 0;
                    if (int.TryParse(lastChar, out value))
                    {
                        number += (int)(value * Math.Pow(10, pointer));
                    }
                }

                pointer++;
                lastChar = imageName1.Substring(imageName1.Length - pointer - 1, 1);
            }

            return number;
        }

        private static bool IsParsable(string lastChar)
        {
            return (lastChar == "-" || lastChar == "0" || lastChar == "1" || lastChar == "2" || lastChar == "3" || lastChar == "4" || lastChar == "5" || lastChar == "6" || lastChar == "7" || lastChar == "8" || lastChar == "9");
        }
    }
}


