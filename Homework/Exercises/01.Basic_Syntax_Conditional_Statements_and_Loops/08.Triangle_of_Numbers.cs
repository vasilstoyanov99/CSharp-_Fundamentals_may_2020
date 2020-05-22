using System;

namespace _08.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int cuuRow = 1; cuuRow <= number; cuuRow++)
            {
                int printedNumCounter = 0;
                while (printedNumCounter != cuuRow)
                {
                    Console.Write($"{cuuRow} ");
                    printedNumCounter++;
                }
                Console.WriteLine();
            }
        }
    }
}
