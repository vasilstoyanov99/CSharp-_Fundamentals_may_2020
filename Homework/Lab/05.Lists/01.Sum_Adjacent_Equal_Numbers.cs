using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SumAllAdjacentEqualNumbers(numbers);
            Console.WriteLine(String.Join(" ", numbers));
        }

        static void SumAllAdjacentEqualNumbers(List<double> numbers)
        {
            for (int j = 0; j <= numbers.Count; j++)
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        break;
                    }
                }
            }       
        }
    }
}
