using System;

namespace _01.Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters * 0.001m;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
