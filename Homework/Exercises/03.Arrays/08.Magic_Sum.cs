using System;
using System.Linq;

namespace _08.Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            byte number = byte.Parse(Console.ReadLine());

            for (int firstIndex = 0; firstIndex < inputArray.Length; firstIndex++)
            {
                for (int secondIndex = firstIndex + 1; secondIndex < inputArray.Length; secondIndex++)
                {
                    if (inputArray[firstIndex] + inputArray[secondIndex] == number)
                    {
                        Console.WriteLine($"{inputArray[firstIndex]} {inputArray[secondIndex]}");
                    }
                }
            }
        }
    }
}
