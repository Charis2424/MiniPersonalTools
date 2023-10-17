using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPersonalTools.Services
{
    public class AnagramValidator
    {
       
        public AnagramValidator() { }
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            else
            {

                var newt = t.ToCharArray();

                for (int i = 0; i < s.Length; i++)
                {
                    char letter = s[i];
                    int index = Array.IndexOf(newt, letter);
                    if (index >= 0)
                    {
                        newt[index] = ' ';
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
