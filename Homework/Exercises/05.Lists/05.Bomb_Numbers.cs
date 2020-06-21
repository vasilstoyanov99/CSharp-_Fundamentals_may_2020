using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] specNumAndItsPower = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int specialBombNum = int.Parse(specNumAndItsPower[0]);
            int power = int.Parse(specNumAndItsPower[1]);

            int bombIndex = numbers.IndexOf(specialBombNum);

            while (bombIndex != -1)
            {
                int leftNumbersStartIndex = bombIndex - power;
                int rightNumbersStartIndex = bombIndex + power;

                if (leftNumbersStartIndex < 0)
                {
                    leftNumbersStartIndex = 0;
                }
                if (rightNumbersStartIndex > numbers.Count - 1)
                {
                    rightNumbersStartIndex = numbers.Count - 1;
                }

                numbers.RemoveRange(leftNumbersStartIndex, rightNumbersStartIndex - leftNumbersStartIndex + 1);

                bombIndex = numbers.IndexOf(specialBombNum);
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
