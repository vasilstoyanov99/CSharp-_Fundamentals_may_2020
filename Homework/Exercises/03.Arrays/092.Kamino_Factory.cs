using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _092.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<int[]> allSequences = new List<int[]>();

            while (input != "Clone them!")
            {
                int[] sequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                allSequences.Add(sequence);
                input = Console.ReadLine();
            }

            //List<int[]> allLongestSubsequencesOfOnes = new List<int[]>();
            int[] longest = new int[number];
            int count = 0;
            int maxCount = 0;
            int startCount = 0;
            bool shouldIAddToTheList = false;

            Dictionary<int, int> allMaxCounts = new Dictionary<int, int>();

            foreach (var sequence in allSequences)
            {
                for (int i = 0; i < sequence.Length - 1; i++)
                {
                    if (sequence[i] == 1 && sequence[i + 1] == 1)
                    {
                        count++;
                    }
                    else
                    {
                        count++;

                        if (count >= maxCount)
                        {
                            maxCount = count;
                            shouldIAddToTheList = true;
                        }

                        count = 0;
                    }
                }

                if (!shouldIAddToTheList)
                {
                    count++;
                    if (count >= maxCount)
                    {
                        maxCount = count;
                        shouldIAddToTheList = true;
                    }
                    count = 0;
                }

                if (shouldIAddToTheList)
                {
                    allMaxCounts.Add(startCount, maxCount);
                    shouldIAddToTheList = false;
                }

                startCount++;
            }

            int maxSequence = allMaxCounts.Max(x => x.Value);

            byte counter = 0;

            foreach (var pair in allMaxCounts)
            {
                if (pair.Value == maxSequence)
                {
                    counter++;
                }
            }

            if (counter == 1)
            {
                int index = 0;

                foreach (var pair in allMaxCounts)
                {
                    if (pair.Value == maxSequence)
                    {
                        index = pair.Key;
                    }
                }
                Console.WriteLine($"Best DNA sample {index} with sum: {maxSequence}.");
                Console.WriteLine(String.Join(" ", allSequences[index]));
                return;
            }

            else
            {
                int[] leftStartIndex = new int[allSequences.Count];
                int startIndex = 0;

                foreach (var sequence in allMaxCounts.Keys)
                {
                    for (int i = 0; i < allSequences[sequence].Length - 1; i++)
                    {
                        if (allSequences[sequence][i] == 1 && allSequences[sequence][i + 1] == 1)
                        {
                            count++;
                        }
                        else
                        {
                            count++;

                            if (count >= maxCount)
                            {
                                startIndex = i - count + 1;
                                maxCount = count;
                                shouldIAddToTheList = true;
                                leftStartIndex[sequence] = startIndex;
                            }

                            count = 0;
                        }
                    }
                }

                int leftmoutsStartIndex = leftStartIndex.Min();
                byte checkCounter = 0;

                foreach (var item in leftStartIndex)
                {
                    if (item <= leftmoutsStartIndex)
                    {
                        checkCounter++;
                    }
                }

                if (checkCounter == 1)
                {
                    int indexOf = 0;

                    for (int i = 0; i < leftStartIndex.Length; i++)
                    {
                        if (leftStartIndex[i] == leftmoutsStartIndex)
                        {
                            indexOf = i;
                            break;
                        }
                    }

                    Console.WriteLine($"Best DNA sample {allSequences.IndexOf(allSequences[indexOf]) + 1} with sum: {maxSequence}.");
                    Console.WriteLine(String.Join(" ", allSequences[indexOf]));
                }
                else
                {
                    int index = 0;
                    int maxSum = 0;
                    int sum = 0;

                    foreach (var indexOfSequence in leftStartIndex)
                    {
                        sum = allSequences[indexOfSequence].Sum();

                        if (sum >= maxSum)
                        {
                            index = indexOfSequence;
                            maxSum = sum;
                        }
                    }

                    Console.WriteLine($"Best DNA sample {allSequences.IndexOf(allSequences[index]) + 1} with sum: {maxSum}.");
                    Console.WriteLine(String.Join(" ", allSequences[index]));
                    return;
                }
            }
        }
    }
}
