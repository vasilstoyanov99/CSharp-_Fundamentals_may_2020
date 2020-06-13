using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfCalculation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (typeOfCalculation == "add")
            {
                add(typeOfCalculation, a, b);
            }
            else if (typeOfCalculation == "multiply")
            {
                multiply(typeOfCalculation, a, b);
            }
            else if (typeOfCalculation == "subtract")
            {
                subtract(typeOfCalculation, a, b);
            }
            else
            {
                divide(typeOfCalculation, a, b);
            }
        }

        static void add(string calculation, int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        static void multiply(string calculation, int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        static void subtract(string calculation, int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        static void divide(string calculation, int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
    }
}
