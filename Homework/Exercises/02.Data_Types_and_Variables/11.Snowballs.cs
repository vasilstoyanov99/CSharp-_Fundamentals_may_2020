using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = 0;
            short outputSnow = 0;
            short outputTime = 0;
            byte outputQuality = 0;

            for (int currSnowball = 0; currSnowball < numberOfSnowballs; currSnowball++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (highestSnowballValue < snowballValue)
                {
                    highestSnowballValue = snowballValue;
                    outputSnow = snowballSnow;
                    outputTime = snowballTime;
                    outputQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{outputSnow} : {outputTime} = {highestSnowballValue} ({outputQuality})");
        }
    }
}
