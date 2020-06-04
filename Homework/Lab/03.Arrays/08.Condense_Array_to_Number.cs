//using System;
//using System.Linq;

//namespace _08.Condense_Array_to_Number
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int[] condensedNum = new int[numbers.Length];
//            int sumedCount = 0;
//            bool isAllSumed = false;
//            if (numbers[0] == 1 || numbers[0] == 0)
//            {
//                Console.WriteLine(numbers[0]);
//                return;
//            }
//            while (!isAllSumed)
//            {
//                for (int numIndex = 0; numIndex < numbers.Length - sumedCount; numIndex++)
//                {
//                    if (numIndex + 1 >= numbers.Length)
//                    {
//                        break;
//                    }
//                    if (numbers.Length - sumedCount == 2)
//                    {
//                        Console.WriteLine(numbers[0] + numbers[1]);
//                        isAllSumed = true;
//                        break;
//                    }
//                    numbers[numIndex] = numbers[numIndex] + numbers[numIndex + 1];
//                }

//                sumedCount++;
//            }

//        }

//    }
//}

using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = inputArray.Length - 1;

        for (int i = 0; i < count; i++)
        {
            int[] condensedArray = new int[inputArray.Length - 1];

            for (int j = 0; j < condensedArray.Length; j++)
            {
                condensedArray[j] = inputArray[j] + inputArray[j + 1];
            }

            inputArray = condensedArray;
        }

        Console.WriteLine(inputArray[0]);
    }
}
