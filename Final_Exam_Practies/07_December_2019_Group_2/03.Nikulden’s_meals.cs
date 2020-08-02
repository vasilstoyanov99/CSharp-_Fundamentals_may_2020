using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Guest> allGuests = new Dictionary<string, Guest>();
            int countOfUnlikedMeals = 0;

            while (input != "Stop")
            {
                string[] commands = input.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "Like":
                        AddMeal(allGuests, commands);
                        break;
                    case "Unlike":
                        RemoveMeal(allGuests, commands, ref countOfUnlikedMeals);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var guest in allGuests.Values.OrderByDescending(x => x.LikedMealsCollection.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{guest.Name}: " + String.Join(", ", guest.LikedMealsCollection));
            }

            Console.WriteLine($"Unliked meals: {countOfUnlikedMeals}");
        }

        static void AddMeal(Dictionary<string, Guest> allGuests, string[] commands)
        {
            string guestName = commands[1];
            string meal = commands[2];

            if (!allGuests.ContainsKey(guestName))
            {
                Guest newGuest = new Guest(guestName);
                newGuest.AddMeal(meal);
                allGuests.Add(guestName, newGuest);
            }
            else
            {
                if (!allGuests[guestName].LikedMealsCollection.Contains(meal))
                {
                    allGuests[guestName].AddMeal(meal);
                }
            }
        }

        static void RemoveMeal(Dictionary<string, Guest> allGuests, string[] commands, ref int countOfUnlikedMeals)
        {
            string guestName = commands[1];
            string meal = commands[2];

            if (allGuests.ContainsKey(guestName))
            {
                if (allGuests[guestName].LikedMealsCollection.Contains(meal))
                {
                    allGuests[guestName].RemoveMeal(meal);
                    Console.WriteLine($"{guestName} doesn't like the {meal}.");
                    countOfUnlikedMeals++;
                }
                else
                {
                    Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                }
            }
            else
            {
                Console.WriteLine($"{guestName} is not at the party.");
            }
        }
    }

    class Guest
    {
        public string Name { get; set; }
        public List<string> LikedMealsCollection { get; set; }

        public Guest(string name)
        {
            this.Name = name;
            LikedMealsCollection = new List<string>();
        }

        public void AddMeal(string meal)
        {
            LikedMealsCollection.Add(meal);
        }

        public void RemoveMeal(string meal)
        {
            LikedMealsCollection.Remove(meal);
        }
    }
}
