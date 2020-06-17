using System;

namespace _10.Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int toNumber = int.Parse(Console.ReadLine());
            int currNum = 0;
            bool[] DoestItHoldTheProprties = new bool[2];

            for (int i = 1; i <= toNumber; i++)
            {
                currNum = i;
                DoestItHoldTheProprties = new bool[2];
                IsTheSumOfDigitsDivisibleByEightAndPrintTopNumber(currNum, DoestItHoldTheProprties);
                DoesItHoldAnOddDigit(currNum, DoestItHoldTheProprties);
            }
        }

        static void IsTheSumOfDigitsDivisibleByEightAndPrintTopNumber(int currNum, bool[] DoestItHoldTheProprties)
        {
            int digitsSum = 0;

            while (currNum > 0)
            {
                int currdigit = currNum % 10;
                digitsSum += currdigit;
                currNum /= 10;
            }

            if (digitsSum % 8 == 0)
            {
                DoestItHoldTheProprties[0] = true;
            }
        }

        static void DoesItHoldAnOddDigit(int currNum, bool[] DoestItHoldTheProprties)
        {
            int currNumCopy = currNum;
            while (currNum > 0)
            {
                int currdigit = currNum % 10;
                if (currdigit % 2 == 1)
                {
                    DoestItHoldTheProprties[1] = true;
                    break;
                }
                currNum /= 10;
            }

            if (DoestItHoldTheProprties[0] == true && DoestItHoldTheProprties[1] == true)
            {
                Console.WriteLine(currNumCopy);
            }
        }
    }
}
