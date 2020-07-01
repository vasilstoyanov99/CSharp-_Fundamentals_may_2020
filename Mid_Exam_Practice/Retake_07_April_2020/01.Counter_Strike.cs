using System;

namespace _01.Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            short initialEnergy = short.Parse(Console.ReadLine());
            byte wonGamesCount = 0;
            string input = Console.ReadLine();
            bool isEnergyLow = false;

            while (input != "End of battle")
            {
                short enemyDistance = short.Parse(input);

                if (enemyDistance > initialEnergy)
                {
                    isEnergyLow = true;
                    break;
                }

                initialEnergy -= enemyDistance;
                wonGamesCount++;

                if (wonGamesCount % 3 == 0)
                {
                    initialEnergy += wonGamesCount;
                }

                input = Console.ReadLine();
            }

            if (isEnergyLow)
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonGamesCount} won battles and {initialEnergy} energy");
            }
            else
            {
                Console.WriteLine($"Won battles: {wonGamesCount}. Energy left: {initialEnergy}");
            }
        }
    }
}
