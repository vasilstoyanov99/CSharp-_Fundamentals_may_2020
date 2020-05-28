using System;

namespace _08.Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            short areaKM = short.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {areaKM} square km.");
        }
    }
}
