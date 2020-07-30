using System;
using System.Linq;
using System.Text;

namespace _01.Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string toManipulate = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "TakeOdd":
                        toManipulate = concatChars(toManipulate, commands);
                        break;
                    case "Cut":
                        toManipulate = CutSubstring(toManipulate, commands);
                        break;
                    case "Substitute":
                        toManipulate = Replace(toManipulate, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {toManipulate}");
        }

        static string concatChars(string toManipulate, string[] commands)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < toManipulate.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result.Append(toManipulate[i]);
                }
            }

            Console.WriteLine(result.ToString());
            return result.ToString();
        }
        static string CutSubstring(string toManipulate, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int lenght = int.Parse(commands[2]);
            string toRemove = toManipulate.Substring(startIndex, lenght);
            int firstOccurrence = toManipulate.IndexOf(toRemove);
            string result = toManipulate.Remove(firstOccurrence, lenght);
            Console.WriteLine(result);
            return result;
        }
        static string Replace(string toManipulate, string[] commands)
        {
            string oldSubstring = commands[1];
            string newSubstring = commands[2];
            int indexOf = toManipulate.IndexOf(oldSubstring);

            if (indexOf == -1)
            {
                Console.WriteLine("Nothing to replace!");
                return toManipulate;
            }
            else
            {
                string result = toManipulate.Replace(oldSubstring, newSubstring);
                Console.WriteLine(result);
                return result;
            }
        }
    }
}
