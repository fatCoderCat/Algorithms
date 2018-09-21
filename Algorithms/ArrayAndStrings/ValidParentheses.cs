using System.Collections.Generic;
using System.Linq;

namespace Algorithms.ArrayAndStrings
{
    public class ValidParentheses
    {
        public bool IsValid(string s) {
            var stack = new Stack<char>();
            
            foreach (var element in s)
            {
                if (_openingParentheses.Contains(element))
                    stack.Push(element);
                else if (!stack.Any() || stack.Any() && stack.Pop() != _reversePairs[element])
                    return false;
            }

            return stack.Count == 0;
        }

        private HashSet<char> _openingParentheses = new HashSet<char>{'(', '{', '['};
        
        private Dictionary<char, char> _reversePairs = new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
    }
}