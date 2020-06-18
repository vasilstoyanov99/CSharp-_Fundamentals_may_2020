using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        AddToList(numbers, command);
                        break;
                    case "Remove":
                        RemoveNumberFromList(numbers, command);
                        break;
                    case "RemoveAt":
                        RemoveAtIndex(numbers, command);
                        break;
                    case "Insert":
                        InsertNumber(numbers, command);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }

        static void AddToList(List<int> numbers, string[] input)
        {
            short numberToAdd = short.Parse((input[1])); ;
            numbers.Add(numberToAdd);
        }

        static void RemoveNumberFromList(List<int> numbers, string[] input)
        {
            short numberToRemove = short.Parse((input[1]));
            numbers.Remove(numberToRemove);
        }

        static void RemoveAtIndex(List<int> numbers, string[] input)
        {
            byte index = byte.Parse((input[1]));
            numbers.RemoveAt(index);
        }

        static void InsertNumber(List<int> numbers, string[] input)
        {
            short numberToInsert = short.Parse((input[1]));
            byte atIndex = byte.Parse((input[2])); ;
            numbers.Insert(atIndex, numberToInsert);
        }
    }
}
