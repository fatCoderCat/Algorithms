using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.ArrayAndStrings
{
    public class StringToInteger
    {
        public int MyAtoi(string str)
        {
            var accumulator = new List<char>();
            
            var isNumber = false;
            
            foreach (var s in str)
            {
                if (!isNumber)
                {
                    if(s == ' ')
                        continue;
                    if (s == '+')
                    {
                        isNumber = true;
                        continue;
                    }
                    if (s == '-' || char.IsNumber(s))
                    {
                        accumulator.Add(s);
                        isNumber = true;
                        continue;
                    }
                    break;
                }
                else if (isNumber)
                {
                    if (char.IsDigit(s))
                        accumulator.Add(s);
                    else
                        break;
                }
            }
            
            var strInt = string.Join("", accumulator);


            if (string.IsNullOrEmpty(strInt))
                return 0;

            if (strInt.Length <= 1 && (strInt.FirstOrDefault() == '-' || strInt.FirstOrDefault() == '+'))
                return 0;
            
            if (Int32.TryParse(strInt, out int result))
                return result;

            if (strInt.Length <= 1)
                return 0;
            
            if (strInt.StartsWith("-") && strInt.Length > 1)
                return int.MinValue;

            return int.MaxValue;
        }
    }
}