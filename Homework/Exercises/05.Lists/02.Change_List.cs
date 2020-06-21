using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Delete":
                        int numberToDelete = int.Parse(commands[1]);
                        numbers.RemoveAll(i => i == numberToDelete);
                        break;
                    case "Insert":
                        int element = int.Parse(commands[1]);
                        int atIndex = int.Parse(commands[2]);
                        numbers.Insert(atIndex, element);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
