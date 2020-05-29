using Microsoft.VisualBasic;
using System;

namespace _09.Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int mineWorkDaysCounter = 0;
            int totalExtractedSpice = 0;

            while (yield >= 100)
            {
                mineWorkDaysCounter++;
                totalExtractedSpice += yield;
                if (totalExtractedSpice > 26)
                {
                    totalExtractedSpice -= 26;
                }
                yield -= 10;
            }

            if (totalExtractedSpice > 26)
            {
                totalExtractedSpice -= 26;
            }

            Console.WriteLine(mineWorkDaysCounter);
            Console.WriteLine(totalExtractedSpice);
        }
    }
}
