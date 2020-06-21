using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonsDistances = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int totalDisctanceSum = pokemonsDistances.Sum();
            int removedElementsSum = 0;

            while (pokemonsDistances.Sum() > 0)
            {
                int removedElementIndex = int.Parse(Console.ReadLine());

                if (removedElementIndex < 0)
                {
                    removedElementsSum += pokemonsDistances[0];
                    pokemonsDistances[0] = pokemonsDistances[pokemonsDistances.Count - 1];
                    continue;
                }

                if (removedElementIndex > pokemonsDistances.Count - 1)
                {
                    removedElementsSum += pokemonsDistances[pokemonsDistances.Count - 1];
                    pokemonsDistances[pokemonsDistances.Count - 1] = pokemonsDistances[0];
                    continue;
                }
                int temp = pokemonsDistances[removedElementIndex];
                removedElementsSum += temp;
                pokemonsDistances.RemoveAt(removedElementIndex);

                for (int currDistance = 0; currDistance < pokemonsDistances.Count; currDistance++)
                {
                    if (pokemonsDistances[currDistance] <= temp)
                    {
                        pokemonsDistances[currDistance] += temp;
                    }
                    else 
                    {
                        pokemonsDistances[currDistance] -= temp;
                    }
                }
            }

            Console.WriteLine(removedElementsSum);
        }
    }
}
