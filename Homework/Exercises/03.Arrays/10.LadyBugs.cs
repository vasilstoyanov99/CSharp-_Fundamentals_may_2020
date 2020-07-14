using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] initialIndexes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            string input = String.Empty;
            int[] field = new int[fieldSize];

            for (int currIndex = 0; currIndex < initialIndexes.Length; currIndex++)
            {
                int index = int.Parse(initialIndexes[currIndex].ToString());
                if (index >= 0 && index < fieldSize)
                {
                        field[index] = 1;
                }

            }
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int fromLadyBugIndex = int.Parse(commands[0]);
                string direction = commands[1];
                int byLenghtOfIndexes = int.Parse(commands[2]);
                bool isInRange = fromLadyBugIndex >= 0 && fromLadyBugIndex < fieldSize;
                bool isInRange2 = byLenghtOfIndexes >= 0 && byLenghtOfIndexes < fieldSize;
                if (isInRange || isInRange2)
                {
                    if (byLenghtOfIndexes != 0)
                    {
                        if (direction == "right")
                        {
                            if ((byLenghtOfIndexes + fromLadyBugIndex) > field.Length)
                            {
                                field[fromLadyBugIndex] = 0;
                            }
                            else
                            {
                                if (field[byLenghtOfIndexes + fromLadyBugIndex] == 1)
                                {
                                    for (int i = byLenghtOfIndexes; i < 100; i += byLenghtOfIndexes)
                                    {
                                        if (fromLadyBugIndex + byLenghtOfIndexes + i > field.Length)
                                        {
                                            field[fromLadyBugIndex] = 0;
                                            break;
                                        }
                                        else if (field[fromLadyBugIndex + byLenghtOfIndexes + byLenghtOfIndexes] == 0)
                                        {
                                            field[fromLadyBugIndex + byLenghtOfIndexes + byLenghtOfIndexes] = 1;
                                            field[fromLadyBugIndex] = 0;
                                            break;
                                        }
                                    }

                                }
                                else if (field[byLenghtOfIndexes] == 0)
                                {
                                    field[fromLadyBugIndex + byLenghtOfIndexes] = 1;
                                    field[fromLadyBugIndex] = 0;
                                }
                            }

                        }
                        else if (direction == "left")
                        {
                            if ((fromLadyBugIndex - byLenghtOfIndexes) < 0)
                            {
                                field[fromLadyBugIndex] = 0;
                            }
                            else
                            {
                                if (field[(fromLadyBugIndex - byLenghtOfIndexes)] == 1)
                                {
                                    for (int i = byLenghtOfIndexes; i < 100; i += byLenghtOfIndexes)
                                    {
                                        if (fromLadyBugIndex - (byLenghtOfIndexes + i) < 0)
                                        {
                                            field[fromLadyBugIndex] = 0;
                                            break;
                                        }
                                        else if (field[fromLadyBugIndex - (byLenghtOfIndexes + i)] == 0)
                                        {
                                            field[fromLadyBugIndex - (byLenghtOfIndexes + byLenghtOfIndexes)] = 1;
                                            field[fromLadyBugIndex] = 0;
                                            break;
                                        }
                                    }
                                }
                                else if (field[fromLadyBugIndex - byLenghtOfIndexes] == 0)
                                {
                                    field[fromLadyBugIndex - byLenghtOfIndexes] = 1;
                                    field[fromLadyBugIndex] = 0;
                                }
                            }

                        }
                    }
                    
                }
               
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
