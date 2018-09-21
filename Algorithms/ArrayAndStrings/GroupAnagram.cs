using System.Collections.Generic;
using System.Linq;

namespace Algorithms.ArrayAndStrings
{
    public class GroupAnagram
    {
        public IList<IList<string>> Solve(string[] strs)
        {
            var dictionary = new Dictionary<int, List<string>>();
            foreach (var d in strs)
            {
                var key = string.Join(string.Empty, d.OrderBy(x => x)).GetHashCode();
                if (dictionary.ContainsKey(key))
                    dictionary[key].Add(d);
                else
                    dictionary.Add(key, new List<string> {d});
            }

            return dictionary.Select(x => (IList<string>)x.Value).ToList();
        }
    }
}