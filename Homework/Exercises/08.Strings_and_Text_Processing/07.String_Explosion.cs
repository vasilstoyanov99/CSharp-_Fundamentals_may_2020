using System;
using System.Text;

namespace _07.String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                if (currChar == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    output.Append(currChar);
                }
                else if (power == 0)
                {
                    output.Append(currChar);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
