using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool check = false;


            if (words == null)
                return false;

            foreach (string sWord in words)
            {
                if (sWord == null)
                    return false;

                if (ignoreCase)
                {
                    if (sWord.ToLower() == word)
                        check = true;
                }
                else
                {
                    if (sWord == word)
                        check = true;
                }
            }

            return check;
        }

        public bool IsPrimeNumber(int num)
        {

            int checkDivided = 0;


            if (num > 1)
            {
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"num {num} / i = {i} = {num / i}");
                        checkDivided++;
                    }
                }
            }

            if (checkDivided == 1)
                return true;
            else
                return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int locationOfIndex = -1;
            int repeated;

            for(int i = 0; i < str.Length;i++)
            {
                repeated = 0;
                for(int j = 0; j < str.Length;j++)
                {
                    if (str[i] == str[j]) 
                    {
                        repeated++;
                    }
                }

                if (repeated == 0 || repeated == 1)
                {
                    locationOfIndex = i;
                }

            }

            return locationOfIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxRepeated = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    count++;
                }

                if (count > maxRepeated)
                {
                    maxRepeated = count;
                }

            }

            return maxRepeated;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {

            var answer = new List<double>();

            if (elements == null || n <= 0 || elements.Count == 0) 
            { 
                return answer.ToArray();
            }

            for(var i = n-1; i < elements.Count; i += n)
            {
                answer.Add(elements[i]);
            }

            return answer.ToArray();
        }
    }
}
