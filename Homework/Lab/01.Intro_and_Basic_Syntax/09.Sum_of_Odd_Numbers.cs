using System;

namespace _09.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOddNumbers = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int oddNumsCount = 0;

            for (int currOddNum = 1; currOddNum <= 100; currOddNum += 2)
            {
                oddNumsCount++;
                Console.WriteLine(currOddNum);
                totalSum += currOddNum;

                if (oddNumsCount >= numOddNumbers)
                {
                    break;
                }
            }

            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
