using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _03.Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Hero> allHeroes = new SortedDictionary<string, Hero>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split().ToArray();

                switch (commands[0])
                {
                    case "Enroll":
                        AddNewHero(allHeroes, commands);
                        break;
                    case "Learn":
                        AddNewSpell(allHeroes, commands);
                        break;
                    case "Unlearn":
                        RemoveSpell(allHeroes, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in allHeroes.Values.OrderByDescending(x => x.SpellBook.Count).ThenBy(x => x.Name))
            {
                if (hero.SpellBook.Count > 0)
                {
                    StringBuilder allSpells = new StringBuilder();

                    for (int i = 0; i < hero.SpellBook.Count; i++)
                    {
                        if (i == hero.SpellBook.Count - 1)
                        {
                            allSpells.Append($"{hero.SpellBook[i]}");
                        }
                        else
                        {
                            allSpells.Append($"{hero.SpellBook[i]}, ");
                        }
                    }

                    Console.WriteLine($"== {hero.Name}: {allSpells}");
                }
                else
                {
                    Console.WriteLine($"== {hero.Name}: ");
                }
            }
        }

        static void AddNewHero(SortedDictionary<string, Hero> allHeroes, string[] commands)
        {
            string heroName = commands[1];

            if (allHeroes.ContainsKey(heroName))
            {
                Console.WriteLine($"{heroName} is already enrolled.");
            }
            else
            {
                Hero newHero = new Hero(heroName);
                allHeroes.Add(heroName, newHero);
            }
        }

        static void AddNewSpell(SortedDictionary<string, Hero> allHeroes, string[] commands)
        {
            string heroName = commands[1];

            if (allHeroes.ContainsKey(heroName))
            {
                string spellToAdd = commands[2];
                allHeroes[heroName].AddNewSpell(spellToAdd);
                
            }
            else
            {
                Console.WriteLine($"{heroName} doesn't exist.");
            }
        }

        static void RemoveSpell(SortedDictionary<string, Hero> allHeroes, string[] commands)
        {
            string heroName = commands[1];

            if (allHeroes.ContainsKey(heroName))
            {
                string spellToRemove = commands[2];
                allHeroes[heroName].RemoveSpell(spellToRemove);
            }
            else
            {
                Console.WriteLine($"{heroName} doesn't exist.");
            }
        }
    }

    class Hero
    {
        public string Name { get; set; }
        public List<string> SpellBook { get; set; }

        public Hero(string name)
        {
            this.Name = name;
            this.SpellBook = new List<string>();
        }

        public void AddNewSpell(string spellToAdd)
        {
            if (SpellBook.Contains(spellToAdd))
            {
                Console.WriteLine($"{Name} has already learnt {spellToAdd}.");
            }
            else
            {
                SpellBook.Add(spellToAdd);
            }
        }

        public void RemoveSpell(string spellToRemove)
        {
            if (SpellBook.Contains(spellToRemove))
            {
                SpellBook.Remove(spellToRemove);
            }
            else
            {
                Console.WriteLine($"{Name} doesn't know {spellToRemove}.");
            }
        }
    }
}
