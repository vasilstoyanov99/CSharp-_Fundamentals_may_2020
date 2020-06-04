using System;

namespace _02.Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[nNumbers];

            for (int currNum = 0; currNum < nNumbers; currNum++)
            {
                int newNum = int.Parse(Console.ReadLine());
                numbers[currNum] = newNum;
            }

            for (int i = nNumbers - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
