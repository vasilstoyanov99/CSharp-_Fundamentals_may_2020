using System;

namespace _06.Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputToSting = "";

            for (int i = 0; i < 3; i++)
            {
                char charInput = char.Parse(Console.ReadLine());
                inputToSting += charInput;
            }
            for (int currCHar = inputToSting.Length; currCHar > 0; currCHar--)
            {
                Console.Write($"{inputToSting[currCHar - 1]} ");
            }
        }
    }
}
