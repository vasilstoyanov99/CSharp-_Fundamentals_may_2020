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
            byte changeCommandCheck = 0;
            while (input != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        AddToList(numbers, command);
                        changeCommandCheck++;
                        break;
                    case "Remove":
                        RemoveNumberFromList(numbers, command);
                        changeCommandCheck++;
                        break;
                    case "RemoveAt":
                        RemoveAtIndex(numbers, command);
                        changeCommandCheck++;
                        break;
                    case "Insert":
                        InsertNumber(numbers, command);
                        changeCommandCheck++;
                        break;
                    case "Contains":
                        CheckIfContainsSpecNum(numbers, command);
                        break;
                    case "PrintEven":
                        PrintAllEvenNumbers(numbers, command);
                        break;
                    case "PrintOdd":
                        PrintAllOddNumbers(numbers, command);
                        break;
                    case "GetSum":
                        PrintSumOfAllIndexes(numbers, command);
                        break;
                    case "Filter":
                        PrintNumbersFromGivenCondition(numbers, command);
                        break;
                }

                input = Console.ReadLine();
            }

            if (changeCommandCheck > 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
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

        static void CheckIfContainsSpecNum(List<int> numbers, string[] input)
        {
            short numberToCheck = short.Parse((input[1]));
            if (numbers.Contains(numberToCheck))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintAllEvenNumbers(List<int> numbers, string[] input)
        {
            for (int currNum = 0; currNum < numbers.Count; currNum++)
            {
                if (numbers[currNum] % 2 == 0)
                {
                    Console.Write($"{numbers[currNum]} ");
                }
            }
            Console.WriteLine();
        }

        static void PrintAllOddNumbers(List<int> numbers, string[] input)
        {
            for (int currNum = 0; currNum < numbers.Count; currNum++)
            {
                if (numbers[currNum] % 2 == 1)
                {
                    Console.Write($"{numbers[currNum]} ");
                }
            }
            Console.WriteLine();
        }

        static void PrintSumOfAllIndexes(List<int> numbers, string[] input)
        {
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        static void PrintNumbersFromGivenCondition(List<int> numbers, string[] input)
        {
            short numberToCompareTo = short.Parse((input[2]));
            List<int> result = new List<int>();

            if (input[1] == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < numberToCompareTo)
                    {
                        result.Add(numbers[i]);
                    }
                }
            }
            else if (input[1] == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > numberToCompareTo)
                    {
                        result.Add(numbers[i]);
                    }
                }
                
            }
            else if (input[1] == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= numberToCompareTo)
                    {
                        result.Add(numbers[i]);
                    }
                }

            }
            else if (input[1] == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= numberToCompareTo)
                    {
                        result.Add(numbers[i]);
                    }
                }

            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
