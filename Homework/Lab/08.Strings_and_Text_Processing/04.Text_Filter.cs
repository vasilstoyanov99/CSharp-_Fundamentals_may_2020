using System;
using System.Linq;
using System.Net;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToBan = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (var word in wordsToBan)
            {
                while (text.IndexOf(word) >= 0)
                {
                    text = text.Replace(word, new string ('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
