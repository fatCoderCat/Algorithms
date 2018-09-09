namespace Algorithms.ArrayAndStrings
{
    public class ReverseString
    {
        public string Solve(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;
            var i = 0;
            var j = s.Length - 1;
            var res = new char[s.Length];
            
            while (i <= j)
            {
                res[i] = s[j];
                res[j] = s[i];

                i++;
                j--;
            }

            return new string(res);
        }
    }
}