using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> allHeroes = new Dictionary<string, Hero>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = heroData[0];
                int HP = int.Parse(heroData[1]);
                int MP = int.Parse(heroData[2]);

                if (HP > 100)
                {
                    HP = 100;
                }
                if (MP > 200)
                {
                    MP = 200;
                }

                Hero newHero = new Hero(name, HP, MP);
                allHeroes.Add(name, newHero);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "CastSpell":
                        CastSpell(allHeroes, commands);
                        break;
                    case "TakeDamage":
                        TakeDamage(allHeroes, commands);
                        break;
                    case "Recharge":
                        Recharge(allHeroes, commands);
                        break;
                    case "Heal":
                        Heal(allHeroes, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            if (allHeroes.Count > 0)
            {
                foreach (var hero in allHeroes.Values.OrderByDescending(x => x.HitPoints).ThenBy(x => x.Name))
                {
                    Console.WriteLine(hero.Name);
                    Console.WriteLine($"  HP: {hero.HitPoints}");
                    Console.WriteLine($"  MP: {hero.ManaPoints}");
                }
            }
        }

        static void CastSpell(Dictionary<string, Hero> allHeroes, string[] commands)
        {
            string hero = commands[1];
            int manaNeeded = int.Parse(commands[2]);
            string spellName = commands[3];

            if (allHeroes[hero].ManaPoints >= manaNeeded)
            {
                allHeroes[hero].ManaPoints -= manaNeeded;
                Console.WriteLine($"{hero} has successfully cast {spellName} and now has {allHeroes[hero].ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
            }
        }

        static void TakeDamage(Dictionary<string, Hero> allHeroes, string[] commands)
        {
            string hero = commands[1];
            int damage = int.Parse(commands[2]);
            string attacker = commands[3];
            allHeroes[hero].HitPoints -= damage;

            if (allHeroes[hero].HitPoints > 0)
            {
                Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {allHeroes[hero].HitPoints} HP left!");
            }
            else
            {
                allHeroes.Remove(hero);
                Console.WriteLine($"{hero} has been killed by {attacker}!");
            }
        }

        static void Recharge(Dictionary<string, Hero> allHeroes, string[] commands)
        {
            string hero = commands[1];
            int amountToAdd = int.Parse(commands[2]);
            bool isRechargeToMax = allHeroes[hero].ManaPoints + amountToAdd > 200;

            if (isRechargeToMax)
            {
                int temp = allHeroes[hero].ManaPoints;
                allHeroes[hero].ManaPoints = 200;
                Console.WriteLine($"{hero} recharged for {200 - temp} MP!");
            }
            else
            {
                allHeroes[hero].ManaPoints += amountToAdd;
                Console.WriteLine($"{hero} recharged for {amountToAdd} MP!");
            }
        }

        static void Heal(Dictionary<string, Hero> allHeroes, string[] commands)
        {
            string hero = commands[1];
            int amountToAdd = int.Parse(commands[2]);
            bool isRechargedToMax = allHeroes[hero].HitPoints + amountToAdd > 100;

            if (isRechargedToMax)
            {
                int temp = allHeroes[hero].HitPoints;
                allHeroes[hero].HitPoints = 100;
                Console.WriteLine($"{hero} healed for {100 - temp} HP!");
            }
            else
            {
                allHeroes[hero].HitPoints += amountToAdd;
                Console.WriteLine($"{hero} healed for {amountToAdd} HP!");
            }
        }
    }

    class Hero
    {
        public string Name { get; set; }
        public int HitPoints { get; set; } // дали е double?
        public int ManaPoints { get; set; }

        public Hero(string name, int hitPoints, int manaPoints)
        {
            this.Name = name;
            this.HitPoints = hitPoints;
            this.ManaPoints = manaPoints;
        }
    }
}
