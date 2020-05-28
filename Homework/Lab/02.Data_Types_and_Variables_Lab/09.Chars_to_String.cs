using System;

namespace _09.Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string charToString = "";

            for (int i = 0; i < 3; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                charToString += currChar;
            }

            Console.WriteLine(charToString);
        }
    }
}
