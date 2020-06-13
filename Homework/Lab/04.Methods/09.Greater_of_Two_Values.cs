using System;
using System.Net.Http.Headers;

namespace _09.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfVariable = Console.ReadLine();
            if (typeOfVariable == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (typeOfVariable == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (typeOfVariable == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }

        static int GetMax(int first, int second)
        {
            int result = first.CompareTo(second);
            int greaterVariable = 0;

            if (result > 0)
            {
                greaterVariable = first;
            }
            else
            {
                greaterVariable = second;
            }

            return greaterVariable;
        }

        static char GetMax(char first, char second)
        {
            int result = first.CompareTo(second);
            char greaterVariable = ' ';

            if (result > 0)
            {
                greaterVariable = first;
            }
            else
            {
                greaterVariable = second;
            }

            return greaterVariable;
        }

        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            string greaterVariable = string.Empty;

            if (result > 0)
            {
                greaterVariable = first;
            }
            else
            {
                greaterVariable = second;
            }

            return greaterVariable;
        }
    }
}
