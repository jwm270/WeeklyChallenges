using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals is null || vals.Length == 0) return false;
            return vals.Any(val => val == false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers is null) return false;
            var sum = numbers.Where(n => n % 2 == 0).Sum();
            return sum % 2 == 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            
            return hasUpper && hasLower && hasDigit;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val)) return '\0';
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val)) return '\0';
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0m;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums is null || nums.Length == 0) return 0;
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new int[50];
            for (int i = 0, v = 1; i < odds.Length; i++, v += 2)
                odds[i] = v;
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words is null) return;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
