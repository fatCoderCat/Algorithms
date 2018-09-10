using System.Linq;

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
    }
}