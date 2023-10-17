using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPersonalTools.Services
{
    public class StringModifier
    {
        public StringModifier() { }

        public StringModifier(string stringSequence, string stringSeparator) 
        {
        //SplitWay
            string[] lines = stringSequence.Split(new[] {stringSeparator }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Join(",", lines);
            Console.WriteLine("\r\nSplit Way for Replace a string Sequence");
            Console.WriteLine(result);
            
        //ReplaceWay
            string newStringSequence = stringSequence.Replace(stringSeparator, ",");
            Console.WriteLine("\r\nReplace Way for Replace a string Sequence");
            Console.Write(newStringSequence);
        }
    }
}
