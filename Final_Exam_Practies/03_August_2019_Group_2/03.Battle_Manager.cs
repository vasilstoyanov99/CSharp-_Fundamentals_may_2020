using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace _03.Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            while (input != "Results")
            {
                string[] commands = input.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "Add":
                        AddPerson(people, commands);
                        break;
                    case "Attack":
                        Attack(people, commands);
                        break;
                    case "Delete":
                        DeletePerson(people, commands[1]);
                        break;
                }

                input = Console.ReadLine();
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"People count: {people.Count}");
                var sorted = people.OrderByDescending(x => x.Value.Health).ThenBy(x => x.Key)
                    .ToDictionary(a => a.Key, b => b.Value);

                foreach (var person in sorted)
                {
                    Console.WriteLine($"{person.Key} - {person.Value.Health} - {person.Value.Energy}");
                }
            }
        }

        static void AddPerson(Dictionary<string, Person> people, string[] commands)
        {
            string name = commands[1];
            int health = int.Parse(commands[2]);
            int energy = int.Parse(commands[3]);

            if (people.ContainsKey(name))
            {
                people[name].Health += health;
                people[name].Energy += energy;
            }
            else
            {
                Person newPerson = new Person(health, energy);
                people.Add(name, newPerson);
            }
        }

        static void Attack(Dictionary<string, Person> people, string[] commands)
        {
            string attacker = commands[1];
            string defender = commands[2];
            int damage = int.Parse(commands[3]);
            bool doesBothPeopleExist = people.ContainsKey(attacker) && people.ContainsKey(defender);

            if (doesBothPeopleExist)
            {
                people[defender].Health -= damage;
                people[attacker].Energy--;

                if (people[defender].Health <= 0)
                {
                    people.Remove(defender);
                    Console.WriteLine($"{defender} was disqualified!");
                }

                if (people[attacker].Energy <= 0)
                {
                    people.Remove(attacker);
                    Console.WriteLine($"{attacker} was disqualified!");
                }
            }
        }

        static void DeletePerson(Dictionary<string, Person> people, string name)
        {
            if (name == "All")
            {
                people.Clear();
            }
            else if (people.ContainsKey(name))
            {
                people.Remove(name);
            }
        }
    }

    class Person
    {
        public int Health { get; set; }
        public int Energy { get; set; }

        public Person(int health, int energy)
        {
            this.Health = health;
            this.Energy = energy;
        }
    }
}
