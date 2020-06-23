using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            int roomsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '|')
                {
                    roomsCount++;
                }
            }

            roomsCount++;
            List<string> rooms = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int roomIndex = 0;
            int numberIndex = 1;
            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            bool IsPlayerDead = false;

            for (int currRoom = 1; currRoom <= roomsCount; currRoom++)
            {
                if (IsPlayerDead)
                {
                    break;
                }

                switch (rooms[roomIndex])
                {
                    case "potion":
                        int addHealth = int.Parse(rooms[numberIndex]);
                        int oldHeath = health;
                        health += addHealth;

                        if (health > 100)
                        {
                            Console.WriteLine($"You healed for {100 - oldHeath} hp.");
                            health = 100;
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {addHealth} hp.");
                        }
                        Console.WriteLine($"Current health: {health} hp.");
                        roomIndex += 2;
                        numberIndex += 2;
                        break;
                    case "chest":
                        int addBitcoins = int.Parse(rooms[numberIndex]);
                        bitcoins += addBitcoins;
                        Console.WriteLine($"You found {addBitcoins} bitcoins.");
                        roomIndex += 2;
                        numberIndex += 2;
                        break;
                    default:
                        int monsterAttack = int.Parse(rooms[numberIndex]);
                        string monsterName = rooms[roomIndex];
                        health -= monsterAttack;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {monsterName}.");
                            roomIndex += 2;
                            numberIndex += 2;
                        }
                        else if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {monsterName}.");
                            IsPlayerDead = true;
                            bestRoom = currRoom;
                            Console.WriteLine($"Best room: {bestRoom}");
                        }
                        break;
                    
                }
            }

            if (!IsPlayerDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
