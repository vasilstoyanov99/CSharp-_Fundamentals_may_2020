using System;

namespace _08.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(GetResult(number, power));
        }

        static double GetResult(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
