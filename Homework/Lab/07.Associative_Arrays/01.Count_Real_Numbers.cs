using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> countOfOccurrences = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (countOfOccurrences.ContainsKey(number))
                {
                    countOfOccurrences[number]++;
                }
                else
                {
                    countOfOccurrences.Add(number, 1);
                }
            }

            foreach (var item in countOfOccurrences)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
