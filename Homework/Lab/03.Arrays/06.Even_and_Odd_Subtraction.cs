using System;
using System.Linq;

namespace _06.Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddNumSum = 0;
            int evenNumSum = 0;

            for (int currNum = 0; currNum < numbers.Length; currNum++)
            {
                if (numbers[currNum] % 2 == 0)
                {
                    evenNumSum += numbers[currNum];
                }
                else
                {
                    oddNumSum += numbers[currNum];
                }
            }

            Console.WriteLine(evenNumSum - oddNumSum);
        }
    }
}
