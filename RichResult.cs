using System;
using System.Collections.Generic;
using System.Text;

namespace TK.GraphComponents
{
    public class RichResult
    {
        public RichResult(bool inResult)
        {
            Result = inResult;
        }

        bool result = false;
        public bool Result
        {
            get { return result; }
            set { result = value; }
        }
    }
}
