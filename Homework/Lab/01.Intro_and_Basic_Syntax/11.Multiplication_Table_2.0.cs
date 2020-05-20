using System;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int startOfMultiplier = int.Parse(Console.ReadLine());

            if (startOfMultiplier <= 10)
            {
                for (int i = startOfMultiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{integer} X {i} = {integer * i}");
                }
            }

            else
            {
                Console.WriteLine($"{integer} X {startOfMultiplier} = {integer * startOfMultiplier}");
            }
        }
    }
}
