using System;
using System.Linq;

namespace _05.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] inputArray = Console.ReadLine().Split().Select(short.Parse).ToArray();
            byte rightIndexCounter = 1;

            for (int currIndex = 0; currIndex < inputArray.Length; currIndex++)
            {
                byte biggerThatOthersCounter = 0;

                for (int currRightIndex = rightIndexCounter; currRightIndex < inputArray.Length; currRightIndex++)
                {
                    if (currIndex == inputArray.Length - 1)
                    {
                        if (inputArray[currIndex] > inputArray[0])
                        {
                            biggerThatOthersCounter++;
                        }
                    }
                    else
                    {
                        if (inputArray[currIndex] > inputArray[currRightIndex])
                        {
                             biggerThatOthersCounter++;
                        }
                    }
                }

                rightIndexCounter++;

                if (biggerThatOthersCounter == (inputArray.Length - 1) - currIndex)
                {
                    Console.Write($"{inputArray[currIndex]} ");
                }

            }
        }
    }
}
