using System;
using System.Linq;

namespace _02.Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] targets = Console.ReadLine().Split().Select(short.Parse).ToArray();
            byte shotTargetsCounter = 0;
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                byte targetIndex = byte.Parse(input);
                if (targetIndex > targets.Length - 1)
                {
                    continue;
                }
                if (targets[targetIndex] == -1)
                {
                    continue;
                }

                for (int currTarget = 0; currTarget < targets.Length; currTarget++)
                {
                    if (currTarget == targetIndex)
                    {
                        continue;
                    }
                    if (targets[currTarget] > -1)
                    {
                        if (targets[currTarget] > targets[targetIndex])
                        {
                            targets[currTarget] -= targets[targetIndex];
                        }
                        else if (targets[currTarget] <= targets[targetIndex])
                        {
                            targets[currTarget] += targets[targetIndex];
                        }
                    }
                }

                targets[targetIndex] = -1;
                shotTargetsCounter++;
            }
            Console.Write($"Shot targets: {shotTargetsCounter} -> ");

            for (int currTarget = 0; currTarget < targets.Length; currTarget++)
            {
                Console.Write($"{targets[currTarget]} ");
            }
        }
    }
}
