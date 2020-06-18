using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            MergingLists(firstList, secondList, result);
            Console.WriteLine(String.Join(" ", result));
        }

        static void MergingLists(List<int> firstList, List<int> secondList, List<int> result)
        {
            int maxCount = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (i <= firstList.Count - 1)
                {
                    result.Add(firstList[i]);
                }

                if (i <= secondList.Count - 1)
                {
                    result.Add(secondList[i]);
                }
            }
        }
    }
}
