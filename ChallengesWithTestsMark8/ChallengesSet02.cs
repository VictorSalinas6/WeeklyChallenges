using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int answer = 0;
            foreach(string val in vals)
            {
                answer++;
            }

            return (answer % 2 == 0);

        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double maxn = 0;
            double minn = 0;

            if (numbers != null)
            {

                foreach (double number in numbers)
                {
                    if (maxn < number)
                        maxn = number;

                    if (minn > number)
                        minn = number;
                }
                if (numbers.Count() == 1)
                {
                    minn = maxn;
                }
            }
            return maxn + minn;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int answer = 0;

            if (numbers != null)
                foreach (int number in numbers)
                {
                    answer += number;
                }

            return answer;
        }

        public int SumEvens(int[] numbers)
        {
            int answer = 0;

            if (numbers != null)
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                        answer += number;
                }

            return answer;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int answer = 0;

            if (numbers != null)
                foreach (int number in numbers)
                {
                    answer += number;
                }

            return answer % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long answer = 0;

            for (long i = number-1; i > 0; i--)
            {
                if ((i % 2) != 0)
                {
                    answer ++;
                }
            }

            return answer;
        }
    }
}
