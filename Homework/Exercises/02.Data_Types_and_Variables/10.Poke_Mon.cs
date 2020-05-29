using System;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargetDistance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());
            int poketTargetsCounter = 0;
            double halfPokePower = pokePower * 0.50;

            while (pokePower >= pokeTargetDistance)
            {
                pokePower -= pokeTargetDistance;
                poketTargetsCounter++;

                if (halfPokePower == pokePower)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(poketTargetsCounter);
        }
    }
}
