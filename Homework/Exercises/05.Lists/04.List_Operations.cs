using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        InsertOperation(numbers, command);
                        break;
                    case "Remove":
                        RemoveOperation(numbers, command);
                        break;
                    case "Shift":
                        ShiftOperation(numbers, command);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));

            static void ShiftOperation(List<int> numbers, string[] command)
            {
                if (command[1] == "left")
                {
                    int count = int.Parse(command[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstNum = numbers[0];
                        numbers.Add(firstNum);
                        numbers.RemoveAt(0);
                    }
                }
                else
                {
                    int count = int.Parse(command[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastNum = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastNum);
                    }
                }
            }

            static void InsertOperation(List<int> numbers, string[] command)
            {
                int numberToInsert = int.Parse(command[1]);
                int atIndex = int.Parse(command[2]);

                if (atIndex > numbers.Count - 1 || atIndex < 0)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    numbers.Insert(atIndex, numberToInsert);
                }
            }

            static void RemoveOperation(List<int> numbers, string[] command)
            {
                int index = int.Parse(command[1]);

                if (index > numbers.Count - 1 || index < 0)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    numbers.RemoveAt(index);
                }
            }
        }
    }
}
