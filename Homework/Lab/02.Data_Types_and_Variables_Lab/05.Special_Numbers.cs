using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currNum = 1; currNum <= number; currNum++)
            {
                int digitsSum = 0;
                int num = currNum;
                while (num > 0)
                {
                    digitsSum += num % 10;
                    num /= 10;
                }

                switch (digitsSum)
                {
                    case 5:
                    case 7:
                    case 11:
                        Console.WriteLine($"{currNum} -> True");
                        break;
                    default:
                        Console.WriteLine($"{currNum} -> False");
                        break;
                }

            }
        }
    }
}
