using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0) return 0;

            int total = 0;
            foreach (var n in numbers)
            {
                if (n % 2 == 0) total += n;
                else total -= n;
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = { str1?.Length ?? 0, str2?.Length ?? 0, str3?.Length ?? 0, str4?.Length ?? 0 };
            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0) return false;

            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs is null || objs.Length == 0) return false;

            int nullCount = objs.Count(o => o == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers is null) return 0;

            var evens = numbers.Where(n => n % 2 == 0).ToArray();
            if (evens.Length == 0) return 0;

            return evens.Average();
        }

        public int Factorial(int number)
        
        //Factorial Definition: the product of a positive integer and all the integers below it; e.g. factorial four (4!) is equal to 24.
        //Assert.Throws<ArgumentOutOfRangeException>(actual1);
        
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Factorial is not defined for negative numbers.");

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
