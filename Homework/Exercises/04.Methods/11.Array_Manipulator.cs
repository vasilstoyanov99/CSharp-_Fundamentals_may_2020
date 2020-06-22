
using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "exchange":
                        Exchange(inputList, commands);
                        break;
                    case "max":
                        if (commands[1] == "even")
                        {
                            FindMaxEvenElementIndex(inputList);
                        }
                        else
                        {
                            FindMaxOddElementIndex(inputList);
                        }
                        break;
                    case "min":
                        if (commands[1] == "even")
                        {
                            FindMinEvenElementIndex(inputList);
                        }
                        else
                        {
                            FindMinOddElementIndex(inputList);
                        }
                        break;
                    case "first":
                        if (commands[2] == "even")
                        {
                            PrintFistEvenNum(inputList, commands);
                        }
                        else
                        {
                            PrintFistOddNum(inputList, commands);
                        }
                        break;
                    case "last":
                        if (commands[2] == "even")
                        {
                            PrintLastEvenNum(inputList, commands);
                        }
                        else
                        {
                            PrintLastOddNum(inputList, commands);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + String.Join(", ", inputList) + "]");
        }

        static void Exchange(List<int> inputList, string[] commands)
        {
            int index = int.Parse(commands[1]);

            if (index < 0 || index > inputList.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            if (index + 1 >= inputList.Count) 
            {
                return;
            }

            List<int> itemToInsert = new List<int>();

            for (int i = index + 1; i < inputList.Count; i++)
            {
                itemToInsert.Add(inputList[i]);

            }
            int start = index + 1;
            int count = (inputList.Count) - start;
            inputList.RemoveRange(start, count);
            inputList.InsertRange(0, itemToInsert);
        } 
        static void FindMaxEvenElementIndex(List<int> inputList)
        {
            List<int> onlyEvenNum = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    onlyEvenNum.Add(inputList[i]);
                }
            }

            if (onlyEvenNum.Count == 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            int maxEvenNum = onlyEvenNum.Max();
            int equalMaxNumStartIndex = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (maxEvenNum == inputList[i])
                {
                    equalMaxNumStartIndex = i;
                }
            }

            Console.WriteLine(equalMaxNumStartIndex);
        }
        static void FindMinEvenElementIndex(List<int> inputList)
        {
            List<int> onlyEvenNum = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    onlyEvenNum.Add(inputList[i]);
                }
            }

            if (onlyEvenNum.Count == 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            int minEvenNum = onlyEvenNum.Min();
            int equalMinNumStartIndex = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (minEvenNum == inputList[i])
                {
                    equalMinNumStartIndex = i;
                }
            }

            Console.WriteLine(equalMinNumStartIndex);
        }
        static void FindMaxOddElementIndex(List<int> inputList)
        {
            List<int> onlyOddNum = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 1)
                {
                    onlyOddNum.Add(inputList[i]);
                }
            }

            if (onlyOddNum.Count == 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            int maxOddNum = onlyOddNum.Max();
            int equalMaxNumStartIndex = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (maxOddNum == inputList[i])
                {
                    equalMaxNumStartIndex = i;
                }
            }

            Console.WriteLine(equalMaxNumStartIndex);
        }
        static void FindMinOddElementIndex(List<int> inputList)
        {
            List<int> onlyOddNum = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 1)
                {
                    onlyOddNum.Add(inputList[i]);
                }
            }

            if (onlyOddNum.Count == 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            int minOddNum = onlyOddNum.Min();
            int equalMinNumStartIndex = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (minOddNum == inputList[i])
                {
                    equalMinNumStartIndex = i;
                }
            }

            Console.WriteLine(equalMinNumStartIndex);
        }
        static void PrintFistEvenNum(List<int> inputList, string[] commands)
        {
            int count = int.Parse(commands[1]);

            if (count > inputList.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    result.Add(inputList[i]);

                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.WriteLine("[" + String.Join(", ", result) + "]");
        }
        static void PrintFistOddNum(List<int> inputList, string[] commands)
        {
            int count = int.Parse(commands[1]);

            if (count > inputList.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 1)
                {
                    result.Add(inputList[i]);

                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.WriteLine("[" + String.Join(", ", result) + "]");
        }
        static void PrintLastEvenNum(List<int> inputList, string[] commands)
        {
            int count = int.Parse(commands[1]);

            if (count > inputList.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> result = new List<int>();

            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                if (inputList[i] % 2 == 0)
                {
                    result.Add(inputList[i]);

                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            result.Reverse();
            Console.WriteLine("[" + String.Join(", ", result) + "]");
        }
        static void PrintLastOddNum(List<int> inputList, string[] commands)
        {
            int count = int.Parse(commands[1]);

            if (count > inputList.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> result = new List<int>();

            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                if (inputList[i] % 2 == 1)
                {
                    result.Add(inputList[i]);

                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            result.Reverse();
            Console.WriteLine("[" + String.Join(", ", result) + "]");
        }

    }
}
