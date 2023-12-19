using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int answer = 0;

            if (numbers != null)
                foreach (int n in numbers)
                    if (n % 2 != 0)
                        answer += n;

            return answer % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;

            foreach(char c in password)
            {
                if (char.IsUpper(c))
                    upper = true;
                if (char.IsLower(c))
                    lower = true;
                if (char.IsDigit(c))
                    number = true;
            }

            return (upper && lower && number);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.LastOrDefault();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal answer = 0m;

            if (divisor != 0)
                answer = dividend / divisor;
            else
                answer = 0;

            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            int answer = nums[^1] - nums[0];

            return answer;
        }

        public int[] GetOddsBelow100()
        {
            var answer = new List<int>();

            for (int i = 0;  i < 100; i++)
                if (i %2 != 0)
                    answer.Add(i);

            return answer.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
