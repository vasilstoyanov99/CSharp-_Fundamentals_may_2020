using System;
using System.Linq;

namespace _03.Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfInputs = byte.Parse(Console.ReadLine());
            short[] firstArray = new short[numberOfInputs];
            short[] secondArray = new short[numberOfInputs];
            byte inputCounter = 0;

            for (int currInput = 0; currInput < numberOfInputs; currInput++)
            {
                short[] input = Console.ReadLine().Split().Select(short.Parse).ToArray();
                byte zigZagIndexCounter = 0;
                inputCounter++;

                if (inputCounter % 2 != 0)
                {
                    zigZagIndexCounter = 0;
                    firstArray[currInput] = input[zigZagIndexCounter];
                    zigZagIndexCounter++;
                    secondArray[currInput] = input[zigZagIndexCounter];
                }
                else
                {
                    zigZagIndexCounter = 1;
                    firstArray[currInput] = input[zigZagIndexCounter];
                    zigZagIndexCounter--;
                    secondArray[currInput] = input[zigZagIndexCounter];
                }
            }

            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}
