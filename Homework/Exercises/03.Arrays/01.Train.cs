using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            short wagonsAmount = short.Parse(Console.ReadLine());
            short[] trainWagons = new short[wagonsAmount];
            short totalPassengers = 0;

            for (int currWagon = 0; currWagon < trainWagons.Length; currWagon++)
            {
                short amountOfPassengers = short.Parse(Console.ReadLine());
                trainWagons[currWagon] = amountOfPassengers;
                totalPassengers += (short)amountOfPassengers;
            }

            Console.Write(string.Join(" ", trainWagons));

            Console.WriteLine($"\n{totalPassengers}");
        }
    }
}
