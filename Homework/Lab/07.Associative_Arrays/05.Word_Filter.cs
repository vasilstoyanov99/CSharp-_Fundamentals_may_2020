using System;
using System.Linq;

namespace _05.Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] onlyWordsWithEvenLenght = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
            foreach (var word in onlyWordsWithEvenLenght)
            {
                Console.WriteLine(word);
            }
        }
    }
}
