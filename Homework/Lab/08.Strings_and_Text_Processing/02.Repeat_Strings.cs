using System;
using System.Linq;
using System.Text;

namespace _02.Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            StringBuilder result = new StringBuilder();

            foreach (var word in words)
            {
                for (int currRepeat = 0; currRepeat < word.Length; currRepeat++)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        result.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
