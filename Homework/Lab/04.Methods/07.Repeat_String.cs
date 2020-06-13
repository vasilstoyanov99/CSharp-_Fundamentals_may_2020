using System;
using System.Text;

namespace _07.Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int timesToBeRepeated = int.Parse(Console.ReadLine());
            Console.WriteLine(GetRepeated(input, timesToBeRepeated));
        }

        static string GetRepeated(string input, int n)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                result.Append(input);
            }

            return result.ToString();
        }
            
    }
}
