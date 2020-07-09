using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double averageNumber = integers.Average();
            List<int> sortedGreaterThanAvrNum = new List<int>();
            bool ifCountIsZero = false;

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] > averageNumber)
                {
                    sortedGreaterThanAvrNum.Add(integers[i]);
                }
            }

            if (sortedGreaterThanAvrNum.Count == 0)
            {
                Console.WriteLine("No");
                ifCountIsZero = true;
            }

            if (!ifCountIsZero)
            {
                List<int> copyOfSorted = sortedGreaterThanAvrNum.GetRange(0, sortedGreaterThanAvrNum.Count);
                List<int> topFiveIntegers = new List<int>();
                int operationsCounter = 0;

                while (true)
                {
                    int maxInteger = copyOfSorted.Max();

                    for (int i = 0; i < copyOfSorted.Count; i++)
                    {
                        if (copyOfSorted[i] >= maxInteger)
                        {
                            topFiveIntegers.Add(copyOfSorted[i]);
                            copyOfSorted.RemoveAt(i);
                            i--;
                        }
                    }

                    operationsCounter++;

                    if (topFiveIntegers.Count == 5)
                    {
                        break;
                    }

                    if (operationsCounter == sortedGreaterThanAvrNum.Count)
                    {
                        break;
                    }
                }

                topFiveIntegers.Sort();
                topFiveIntegers.Reverse();
                Console.WriteLine(String.Join(" ", topFiveIntegers));
            }
        }
    }
}

