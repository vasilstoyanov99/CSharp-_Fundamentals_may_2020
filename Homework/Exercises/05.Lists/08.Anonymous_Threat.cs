using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> inputCopy = new List<string>();
            inputCopy = input.GetRange(0, input.Count);
            string secondInput = Console.ReadLine();

            while (secondInput != "3:1")
            {
                string[] commands = secondInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "merge":
                        MergeCommand(input, inputCopy, commands);
                        break;
                    case "divide":
                        DivideCommand(input,/* inputCopy,*/ commands);
                        break;
                }

                secondInput = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", input));
        }

        static void MergeCommand(List<string> input, List<string> inputCopy, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);

            if (startIndex < 0)
            {
                if (endIndex >= 0 && endIndex <= input.Count - 1)
                {
                    startIndex = 0;
                }
            }
            if (endIndex > input.Count - 1)
            {
                if (startIndex >= 0 && startIndex <= input.Count - 1)
                {
                    endIndex = input.Count - 1;
                }
            }
            if ((startIndex >= 0 && startIndex <= input.Count - 1) && (endIndex >= 0 && endIndex <= input.Count - 1))
            {
                string concatData = String.Empty;

                for (int i = startIndex; i <= endIndex; i++)
                {
                    concatData += input[i];
                }

                input.RemoveRange(startIndex, endIndex - startIndex + 1);
                input.Insert(startIndex, concatData);
            }
        }

        static void DivideCommand(List<string> input, string[] commands)
        {
            int index = int.Parse(commands[1]);
            int partitions = int.Parse(commands[2]);
            string toDivide = input[index];
            int elementsPerIndex = toDivide.Length / partitions;
            int statIndex = 0;
            List<string> dividedWord = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    dividedWord.Add(toDivide.Substring(statIndex, toDivide.Length - statIndex));
                }

                else
                {
                    dividedWord.Add(toDivide.Substring(statIndex, elementsPerIndex));
                    statIndex += elementsPerIndex;
                }
            }

            input.RemoveAt(index);
            input.InsertRange(index, dividedWord);
        }

    }
}
