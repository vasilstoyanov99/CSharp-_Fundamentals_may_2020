using System;
using System.Linq;

namespace _06.Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftIndexesSum = 0;
            int rightIndexesSum = 0;
            byte foundElementCounter = 0;

            for (int currIndex = 0; currIndex < arrayInput.Length; currIndex++)
            {
                if (currIndex == 0 && arrayInput.Length == 0)
                {
                    Console.WriteLine(currIndex);
                    return;
                }
                else
                {
                    for (int indexToLeft = currIndex - 1; indexToLeft >= 0; indexToLeft--)
                    {
                        leftIndexesSum += arrayInput[indexToLeft];
                    }
                    for (int indexToRight = currIndex + 1; indexToRight < arrayInput.Length; indexToRight++)
                    {
                        rightIndexesSum += arrayInput[indexToRight];
                    }

                    if (leftIndexesSum == rightIndexesSum)
                    {
                        Console.WriteLine(currIndex);
                        foundElementCounter++;
                    }

                }

                leftIndexesSum = 0;
                rightIndexesSum = 0;
            }

            if (foundElementCounter == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
