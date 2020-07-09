using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "swap":
                        SwapElements(integers, data);
                        break;
                    case "multiply":
                        MultiplyElements(integers, data);
                        break;
                    case "decrease":
                        DecreaseAllElementsByOne(integers);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", integers));
        }

        static void SwapElements(List<int> integers, string[] data)
        {
            int indexOne = int.Parse(data[1]);
            int indexTwo = int.Parse(data[2]);
            int elementFromIndexOne = integers[indexOne];
            int elementFromIndexTwo = integers[indexTwo];
            integers[indexOne] = elementFromIndexTwo;
            integers[indexTwo] = elementFromIndexOne;
        }

        static void MultiplyElements(List<int> integers, string[] data)
        {
            int indexOne = int.Parse(data[1]);
            int indexTwo = int.Parse(data[2]);
            int result = integers[indexOne] * integers[indexTwo];
            integers[indexOne] = result;
        }

        static void DecreaseAllElementsByOne(List<int> integers)
        {
            for (int currIntegerIndex = 0; currIntegerIndex < integers.Count; currIntegerIndex++)
            {
                integers[currIntegerIndex] -= 1;
            }
        }
    }
}
