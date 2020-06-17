using System;

namespace _07.NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MatrixPrinter(n);
        }

        static void MatrixPrinter(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int rowNums = 1; rowNums <= n; rowNums++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
