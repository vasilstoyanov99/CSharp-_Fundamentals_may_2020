using System;

namespace _10.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfDigits(number, 0) * GetSumOfDigits(number, 1);
        }
        static int GetSumOfDigits(int number, int isOddOrEven)
        {
            int sum = 0;

            while(number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == isOddOrEven)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
