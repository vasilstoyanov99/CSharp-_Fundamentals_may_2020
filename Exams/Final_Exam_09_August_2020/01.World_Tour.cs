using System;
using System.Linq;
using System.Text;

namespace _01.World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder travelDestinations = new StringBuilder(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] commands = input.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "Add Stop":
                        AddNewDestination(travelDestinations, commands);
                        break;
                    case "Remove Stop":
                        RemoveDestination(travelDestinations, commands);
                        break;
                    case "Switch":
                        ReplaceAllOccurrences(travelDestinations, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {travelDestinations.ToString()}");
        }

        static void AddNewDestination(StringBuilder travelDestinations, string[] commands)
        {
            int index = int.Parse(commands[1]);

            if (index >= 0 && index < travelDestinations.Length)
            {
                string toInsert = commands[2];
                travelDestinations.Insert(index, toInsert);
                Console.WriteLine(travelDestinations.ToString());
            }
        }

        static void RemoveDestination(StringBuilder travelDestinations, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);

            bool isStartIndexValid = startIndex >= 0 && startIndex < travelDestinations.Length;
            bool isEndIndexValid = endIndex > 0 && endIndex < travelDestinations.Length;

            if (isStartIndexValid && isEndIndexValid)
            {
                int lenght = endIndex - startIndex + 1;
                travelDestinations.Remove(startIndex, lenght);
            }

            Console.WriteLine(travelDestinations.ToString());
        }

        static void ReplaceAllOccurrences(StringBuilder travelDestinations, string[] commands)
        {
            string oldString = commands[1];
            string newString = commands[2];

            if (travelDestinations.ToString().Contains(oldString))
            {
                travelDestinations.Replace(oldString, newString);
            }

            Console.WriteLine(travelDestinations.ToString());
        }
    }
}
