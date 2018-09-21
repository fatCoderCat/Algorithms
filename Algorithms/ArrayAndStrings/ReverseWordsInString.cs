using System;
using System.Linq;

namespace Algorithms.ArrayAndStrings
{
    public class ReverseWordsInString
    {
        public string Solve1(string s) {
            return string.Join(" ", s.Trim().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Reverse());
        }
        
        public string Solve2(string s)
        {
            var words = s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            
            var i = 0;
            var j = words.Length - 1;
            var res = new string[words.Length];
            
            while (i <= j)
            {
                res[i] = words[j];
                res[j] = words[i];

                i++;
                j--;
            }

            return string.Join(" ", res);
        }
    }
}