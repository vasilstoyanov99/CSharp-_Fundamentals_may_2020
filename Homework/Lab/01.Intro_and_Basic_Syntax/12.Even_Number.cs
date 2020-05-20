using System;

namespace _12.Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {

               if (num % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }

                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }

                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
