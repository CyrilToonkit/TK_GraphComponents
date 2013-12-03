using System;
using System.Collections.Generic;
using System.Text;

namespace TK.GraphComponents.Animation
{
    public class PictureDimensions
    {
        public PictureDimensions(int inWidth, int inHeight)
        {
            width = inWidth;
            height = inHeight;
        }

        int width = 0;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        int height = 0;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override bool Equals(object obj)
        {
            PictureDimensions otherDim = obj as PictureDimensions;
            if (otherDim != null)
            {
                return width == otherDim.Width && height == otherDim.Height;
            }
            
            return false;
        }

        // Override the Object.GetHashCode() method:
        public override int GetHashCode()
        {
            return width * 1000000 + height;
        }
    }
}
