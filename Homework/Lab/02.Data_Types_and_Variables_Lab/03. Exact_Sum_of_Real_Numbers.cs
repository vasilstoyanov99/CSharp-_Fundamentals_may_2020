using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nnumbers = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < Nnumbers; i++)
            {
                decimal currNum = decimal.Parse(Console.ReadLine());
                sum += currNum;
            }

            Console.WriteLine(sum);
        }
    }
}
