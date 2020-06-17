using System;

namespace _08.Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = long.Parse(Console.ReadLine());
            double n2 = long.Parse(Console.ReadLine());
            FactorialCalculationAndDivision(n1, n2);
        }

        static void FactorialCalculationAndDivision(double n1, double n2)
        {
            double n1Factorial = 1;
            double n2Factorial = 1;
            if (n1 == 0)
            {
                n1 = 1;
            }
            else
            {
                for (int i = 1; i <= n1; i++)
                {
                    n1Factorial *= i;
                }
            }
            if (n2 == 0)
            {
                n2 = 1;
            }
            else
            {
                for (int i = 1; i <= n2; i++)
                {
                    n2Factorial *= i;
                }
            }

            double result = n1Factorial / n2Factorial;
            Console.WriteLine($"{result:f2}");
        }
    }
}
