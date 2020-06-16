using System;
using System.Linq;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            for (int secondArrayElement = 0; secondArrayElement < secondArray.Length; secondArrayElement++)
            {
                for (int firstArrayElement = 0; firstArrayElement < firstArray.Length; firstArrayElement++)
                {
                    if (secondArray[secondArrayElement] == firstArray[firstArrayElement])
                    {
                        Console.Write($"{secondArray[secondArrayElement]} ");
                    }
                }
            }
        }
    }
}
