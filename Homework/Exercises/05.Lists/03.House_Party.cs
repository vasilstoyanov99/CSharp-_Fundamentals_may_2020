using System;
using System.Collections.Generic;

namespace _03.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            byte commandsNumber = byte.Parse(Console.ReadLine());
            List<string> guestsList = new List<string>();

            for (int currComand = 0; currComand < commandsNumber; currComand++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Length == 3)
                {
                    CheckIfGuestCanBeAdded(guestsList, command);
                }
                else
                {
                    CheckIfGuestCanBeRemoved(guestsList, command);
                }
            }

            for (int currGuest = 0; currGuest < guestsList.Count; currGuest++)
            {
                Console.WriteLine(guestsList[currGuest]);
            }
        }

        static void CheckIfGuestCanBeAdded(List<string> guestsList, string[] command)
        {
            string guestToCheck = command[0];

            if (guestsList.Contains(guestToCheck))
            {
                Console.WriteLine($"{guestToCheck} is already in the list!");
            }
            else
            {
                guestsList.Add(guestToCheck);
            }
        }

        static void CheckIfGuestCanBeRemoved(List<string> guestsList, string[] command)
        {
            string guestToCheck = command[0];

            if (guestsList.Contains(guestToCheck))
            {
                guestsList.Remove(guestToCheck);
            }
            else
            {
                Console.WriteLine($"{guestToCheck} is not in the list!");
            }
        }
    }
}
