using System;
using System.Linq;

namespace _05.Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOfEvenNums = 0;

            for (int currNum = 0; currNum < numbers.Length; currNum++)
            {
                if (numbers[currNum] % 2 == 0)
                {
                    sumOfEvenNums += numbers[currNum];
                }
            }

            Console.WriteLine(sumOfEvenNums);
        }
    }
}
