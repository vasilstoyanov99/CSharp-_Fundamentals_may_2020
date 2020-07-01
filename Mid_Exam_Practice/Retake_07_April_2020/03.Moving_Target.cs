using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Shoot":
                        ShootTarget(targets, data);
                        break;
                    case "Add":
                        AddTarget(targets, data);
                        break;
                    case "Strike":
                        Strike(targets, data);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join("|", targets));
        }

        static void ShootTarget(List<int> targets, string[] data)
        {
            int targetIndex = int.Parse(data[1]);
            int shootPower = int.Parse(data[2]);

            if (targetIndex >= 0 && targetIndex <= targets.Count - 1)
            {
                targets[targetIndex] -= shootPower;

                if (targets[targetIndex] <= 0)
                {
                    targets.RemoveAt(targetIndex);
                }
            }
        }

        static void AddTarget(List<int> targets, string[] data)
        {
            int atIndex = int.Parse(data[1]);
            int targetValue = int.Parse(data[2]);

            if (atIndex >= 0 && atIndex <= targets.Count - 1)
            {
                targets.Insert(atIndex, targetValue);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Strike(List<int> targets, string[] data)
        {
            int atIndex = int.Parse(data[1]);
            int radius = int.Parse(data[2]);
            int leftRadius = atIndex - radius;
            int rightRadius = atIndex + radius;

            if (leftRadius < 0 || rightRadius >= targets.Count)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            else
            {
                targets.RemoveRange(leftRadius, radius * 2 + 1);
            }
        }
    }
}
