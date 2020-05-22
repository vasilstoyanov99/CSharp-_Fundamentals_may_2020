using System;

namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalSum = 0;
            string numberStr = number.ToString();

            for (int currDigit = 0; currDigit < numberStr.Length; currDigit++)
            {
                int digit = int.Parse(numberStr[currDigit].ToString());
                int currSum = 1;
                for (int i = 1; i <= digit; i++)
                {
                    currSum *= i;
                }
                totalSum += currSum;
            }

            if (number == totalSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
