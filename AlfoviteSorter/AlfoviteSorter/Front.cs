using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfoviteSorter
{
    public class Front
    {
        string TextIn;

        public Front(string text)
        {
            text.ToLower();
            TextIn = text;

        }

        public string TextOut()
        {
            string OutLine = TextIn;
            return OutLine;
        }
    }
}