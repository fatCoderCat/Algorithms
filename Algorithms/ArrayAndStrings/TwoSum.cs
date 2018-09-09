using System;
using System.Collections.Generic;

namespace Algorithms.ArrayAndStrings
{
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target) {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dictionary.ContainsKey(complement))
                    return new []{dictionary[complement], i};
                
                dictionary.TryAdd(nums[i], i);
            }
                    
            throw new Exception();
        }
    }
}