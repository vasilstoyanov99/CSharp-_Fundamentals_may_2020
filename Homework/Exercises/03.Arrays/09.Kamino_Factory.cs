using System;
using System.Linq;

namespace _09.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lenghtOfTheSequences = byte.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            byte theMostOnes = 0;
            byte sampleCounter = 0;
            byte outputSequenceSampleNum = 0;
            byte theLeftmostIndex = byte.MaxValue;
            short theGreaterSumOfIndexes = 0;
            short outputSumOfIndexes = 0;
            string theSequenceWithTheMostOnes = String.Empty;
            string[] archived = new string[lenghtOfTheSequences];

            while (input != "Clone them!")
            {
                short[] inputSequenceArray = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(short.Parse).ToArray();
                string onesSequence = String.Empty;
                byte firstEqualToOneIndex = 0;
                short sumOfIndexes = 0;
                sampleCounter++;

                for (int currIndex = 0; currIndex < inputSequenceArray.Length; currIndex++)
                {
                    for (int currSecondIndex = currIndex + 1; currSecondIndex < inputSequenceArray.Length; currSecondIndex++)
                    {
                        if (inputSequenceArray[currIndex] == 1)
                        {
                            if (inputSequenceArray[currSecondIndex] == 1)
                            {
                                onesSequence += inputSequenceArray[currIndex];
                                onesSequence += inputSequenceArray[currSecondIndex];
                                if (firstEqualToOneIndex == 0)
                                {
                                    firstEqualToOneIndex = (byte)currIndex;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    sumOfIndexes += inputSequenceArray[currIndex];
                }

                if (theMostOnes < onesSequence.Length)
                {
                    archived[sampleCounter] = String.Join(" ", inputSequenceArray);
                    outputSequenceSampleNum = sampleCounter;
                    theMostOnes = (byte)onesSequence.Length;
                    outputSumOfIndexes = sumOfIndexes;
                    theGreaterSumOfIndexes = sumOfIndexes;
                }
                if (theMostOnes == onesSequence.Length)
                {
                    if (firstEqualToOneIndex < theLeftmostIndex)
                    {
                        archived[sampleCounter] = String.Join(" ", inputSequenceArray);
                        outputSequenceSampleNum = sampleCounter;
                        theLeftmostIndex = firstEqualToOneIndex;
                        outputSumOfIndexes = sumOfIndexes;
                    }
                    else if (sumOfIndexes > theGreaterSumOfIndexes)
                    {
                        archived[sampleCounter] = String.Join(" ", inputSequenceArray);
                        theGreaterSumOfIndexes = sumOfIndexes;
                        outputSequenceSampleNum = sampleCounter;
                        outputSumOfIndexes = sumOfIndexes;
                        theGreaterSumOfIndexes = sumOfIndexes;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {outputSequenceSampleNum} with sum: {outputSumOfIndexes}.");
            Console.WriteLine($"{archived[outputSequenceSampleNum]}");
        }
    }
}
