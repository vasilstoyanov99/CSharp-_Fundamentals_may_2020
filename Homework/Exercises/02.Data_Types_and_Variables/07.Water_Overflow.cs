using System;

namespace _07.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            int litersPouredInTheTank = 0;

            for (int currInput = 0; currInput < numOfInputs; currInput++)
            {
                int waterToPour = int.Parse(Console.ReadLine());

                if (waterToPour > 255 || waterToPour + litersPouredInTheTank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersPouredInTheTank += waterToPour;
                }
            }

            Console.WriteLine(litersPouredInTheTank);
        }
    }
}
