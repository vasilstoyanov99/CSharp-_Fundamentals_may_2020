using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial newCalculation = new Factorial();
            newCalculation.number = int.Parse(Console.ReadLine());
            newCalculation.FactorialCalculatorAndPrinter();
        }
    }

    public class Factorial
    {
        public int number;

        public void FactorialCalculatorAndPrinter()
        {
            BigInteger result = new BigInteger();
            result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
