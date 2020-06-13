using System;

namespace _11.Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char typeOfOperator = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = Calculation(a, typeOfOperator, b);
            Console.WriteLine($"{Math.Round(result, 2)}");
        }

        static double Calculation(int a, char typeOfOperator, int b)
        {
            double result = 0.00;

            switch (typeOfOperator)
            {
                case '/':
                    result = a / b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
