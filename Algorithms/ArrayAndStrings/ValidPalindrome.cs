using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Algorithms.ArrayAndStrings
{
    public class ValidPalindrome
    {
        public bool Solution(string s)
        {
            if(s.Length < 2)
                return true;
            
            var tmp = string.Join("", s.ToLower().Where(x => char.IsLetter(x) || char.IsDigit(x)));
            int midpoint = tmp.Length / 2;
             
            return string.Join("", tmp.Substring(midpoint + tmp.Length % 2).Reverse()) == tmp.Substring(0, midpoint);
        }

        public bool Solution1(string s)
        {
            if(s.Length < 2)
                return true;
            
            var i = 0;
            var j = s.Length - 1;
            
            while (i <= j)
            {
                var passI = !char.IsLetter(s[i]) && !char.IsDigit(s[i]);
                var passJ = !char.IsLetter(s[j]) && !char.IsDigit(s[j]);
                
                if (passJ && passI)
                {
                    i++;
                    j--;
                    continue;
                }
                if (passI)
                {
                    i++;
                    continue;
                }
                if (passJ)
                {
                    j--;
                    continue;
                }

                if(char.ToLower(s[i]) != char.ToLower(s[j]))
                    return false;
                
                i++;
                j--;
            }

            return true;
        }
    }
}