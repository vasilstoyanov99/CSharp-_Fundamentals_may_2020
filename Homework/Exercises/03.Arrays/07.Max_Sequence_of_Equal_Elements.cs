using System;
using System.Linq;

namespace _07.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            byte equalElementsCounter = 0;
            string newEqualElemenst = string.Empty;
            string longestSequenceStr = String.Empty;

            for (int currIndex = 0; currIndex < inputArray.Length; currIndex++)
            {
                bool isEqualElementsFound = false;

                for (int currSecondIndex = currIndex + 1; currSecondIndex < inputArray.Length; currSecondIndex++)
                {
                    if (inputArray[currIndex] != inputArray[currSecondIndex])
                    {
                        break;
                    }

                    else
                    {
                        equalElementsCounter++;
                        isEqualElementsFound = true;
                    }
                }

                if (isEqualElementsFound)
                {
                    for (int i = currIndex; i <= equalElementsCounter + currIndex; i++)
                    {
                        newEqualElemenst += inputArray[i] + " ";
                    }

                    if (newEqualElemenst.Length > longestSequenceStr.Length)
                    {
                        longestSequenceStr = newEqualElemenst;
                    }

                    equalElementsCounter = 0;
                    newEqualElemenst = string.Empty;
                }

            }
                Console.WriteLine(longestSequenceStr);
        }
    }
}
