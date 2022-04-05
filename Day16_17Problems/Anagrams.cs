using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class Anagrams
    {
        public bool areAnagram(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
            //Convert string to character array  
            char[] firstCharsArray = firstString.ToLower().ToCharArray();
            char[] secondCharsArray = secondString.ToLower().ToCharArray();
            //Sort array  
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);
            //Check each character and position.  
            for (int i = 0; i < firstCharsArray.Length; i++)
            {
                if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
    }
}
