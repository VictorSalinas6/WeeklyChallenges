using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int answer;
            do
            {
                startNumber++;
                answer = startNumber % n;
            } while (answer != 0);

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            businesses.Where(x => x.TotalRevenue == 0).ToList().ForEach(x => { x.Name = "CLOSED"; });
            //foreach(Business bus in businesses)
            //{
            //    if (bus.TotalRevenue == 0)
            //        bus.Name = "CLOSED";
            //}
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            else
                return numbers.SequenceEqual(numbers.OrderBy(x => x));
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers != null)
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum = sum + numbers[i + 1];
                    }
                }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null)
                return "";

            var newWords = new List<string>();

            foreach (string word in words)
            {
                var newWord = word.Trim();
                newWords.Add(newWord);
            }

            var newString = newWords.Where(x => x != "" && x != " ");

            if (newString.Count() == 0)
                return "";
            else
                return string.Join(" ", newString) + '.';
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var EveryFourth = new List<double>();

            if (elements == null)
                return EveryFourth.ToArray();

            for (int i = 4; i <= elements.Count; i = i + 4)
            {
                EveryFourth.Add(elements[i - 1]);
            }

            return EveryFourth.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool check = false;

            //foreach (var num in nums)
            //{
            //    foreach (var Nnum in nums)
            //    {
            //        if (num + Nnum == targetNumber)
            //            check = true;
            //    }
            //}

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                        if (nums[i] + nums[j] == targetNumber)
                            check = true;
                }
            }

            return check;
        }
    }
}
