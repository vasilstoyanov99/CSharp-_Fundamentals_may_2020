using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string divisibleBy = "";
            bool isNotDivisible = false;

            if (number % 10 == 0)
            {
                divisibleBy = "10";
            }
            else if (number % 7 == 0)
            {
                divisibleBy = "7";
            }
            else if (number % 6 == 0)
            {
                divisibleBy = "6";
            }
            else if (number % 3 == 0)
            {
                divisibleBy = "3";
            }
            else if (number % 2 == 0)
            {
                divisibleBy = "2";
            }
            else
            {
                isNotDivisible = true;
            }

            if (isNotDivisible)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divisibleBy}");
            }
        }
    }
}
