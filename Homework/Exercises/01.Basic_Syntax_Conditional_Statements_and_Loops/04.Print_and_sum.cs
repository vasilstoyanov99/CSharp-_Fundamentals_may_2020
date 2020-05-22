using System;

namespace _04.Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endtNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int currNum = startNum; currNum <= endtNum; currNum++)
            {
                Console.Write($"{currNum} ");
                sum += currNum;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
