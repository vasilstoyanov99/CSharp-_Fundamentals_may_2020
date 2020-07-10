using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfInput = int.Parse(Console.ReadLine());
            Dictionary<string, string> usersData = new Dictionary<string, string>();
            
            for (int i = 0; i < linesOfInput; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                if (data[0] == "register")
                {
                    RegisterNewUser(usersData, data);
                }
                else
                {
                    UnRegisterNewUser(usersData, data);
                }
            }

            foreach (var pair in usersData)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }

        static void RegisterNewUser(Dictionary<string, string> usersData, string[] data)
        {
            string username = data[1];
            string licensePlateNumber = data[2];

            if (usersData.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {usersData[username]}");
            }
            else
            {
                usersData.Add(username, licensePlateNumber);
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
        }

        static void UnRegisterNewUser(Dictionary<string, string> usersData, string[] data)
        {
            string username = data[1];

            if (usersData.ContainsKey(username))
            {
                usersData.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
        }
    }
}
