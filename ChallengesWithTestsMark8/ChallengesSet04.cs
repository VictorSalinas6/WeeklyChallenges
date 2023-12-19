using Microsoft.VisualBasic;
using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;

            foreach (int number in numbers)
            {
                if (number %2 == 0)
                {
                    answer += number;
                }
                else if (number %2 != 0) 
                {
                    answer -= number;
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int string1 = (str1.ToCharArray()).Length;
            int string2 = (str2.ToCharArray()).Length;
            int string3 = (str3.ToCharArray()).Length;
            int string4 = (str4.ToCharArray()).Length;

            int min1 = Math.Min(string1, string2);
            int min2 = Math.Min(string3, string4);
            int min3 = Math.Min(min1, min2);

            return min3;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int min1 = Math.Min(number1, number2);
            int min2 = Math.Min(number3, number4);
            int min3 = Math.Min(min1, min2);

            return min3;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            return (sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double number))
                return true;
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int counterNull = 0;
            int counter = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                    counterNull++;
                else
                    counter++;
            }

            return counterNull > counter;
        }

        public double AverageEvens(int[] numbers)
        {
            int counter = 0;
            double sumOfEvens = 0;

            if (numbers != null)
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sumOfEvens += number;
                        counter++;
                    }
                }

                return sumOfEvens != 0 ? sumOfEvens / counter : 0;
            }
            else
                return 0;
        }

        public int Factorial(int number)
        {
           int result = number;
            if (number == 0)
                result = 1;
            else if (number > 0)
            {
                for (int i = number - 1; i > 0; i--)
                {
                    result *= i;
                }
            }
            else
            {
                //This one really had to google it, didn´t know how to implement this

                throw new ArgumentOutOfRangeException();
            }

           return result;
        }
    }
}
