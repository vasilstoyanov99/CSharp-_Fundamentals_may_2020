using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();
            string word = Console.ReadLine();
            int startIndex = 0;

            while (word.IndexOf(toRemove) >= 0)
            {
                startIndex = word.IndexOf(toRemove);
                word = word.Remove(startIndex, toRemove.Length);
            }

            Console.WriteLine(word);
        }
    }
}
