using System;

namespace _05.Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Sum(n1, n2, n3);
        }

        static void Sum(int n1, int n2, int n3)
        {
            int sumed = n1 + n2;
            Subtract(n3, sumed);
        }

        static void Subtract(int n3, int summed)
        {
            int result = summed - n3;
            Console.WriteLine(result);
        }
    }
}
