using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            GaussTrickSum(numbers, result);
            Console.WriteLine(String.Join(" ", result));
        }

        static void GaussTrickSum(List<int> numbers, List<int> result)
        {

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - i - 1]);
            }

            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
        }
    }
}
