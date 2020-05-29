using System;

namespace _01.Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int fourthInt = int.Parse(Console.ReadLine());

            int total = ((firstInt + secondInt) / thirdInt) * fourthInt;
            Console.WriteLine(total);
        }
    }
}
