using System;

namespace _12.Refactor_Special_Numbers
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

                bool isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
                Console.WriteLine("{0} -> {1}", currNum, isSpecial);
            }

        }
    }
}
