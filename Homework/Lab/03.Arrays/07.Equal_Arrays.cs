using System;
using System.Linq;
using System.Threading;

namespace _07.Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int arraySum = 0;
            int DifferenceAtIndex = 0;
            bool areNotIdentical = false;

            for (int currNumIndex = 0; currNumIndex < firstNumArray.Length; currNumIndex++)
            {
                if (firstNumArray[currNumIndex] == secondNumArray[currNumIndex])
                {
                    arraySum += firstNumArray[currNumIndex];
                }
                else
                {
                    areNotIdentical = true;
                    DifferenceAtIndex = currNumIndex;
                    break;
                }
            }

            if (!areNotIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arraySum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {DifferenceAtIndex} index");
            }
        }
    }
}
