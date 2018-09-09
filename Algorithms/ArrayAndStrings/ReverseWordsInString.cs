using System.Linq;

namespace Algorithms.ArrayAndStrings
{
    public class ReverseWordsInString
    {
        public string Solve1(string s) {
            return string.Join(" ", s.Trim().Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Reverse());
        }
    }
}