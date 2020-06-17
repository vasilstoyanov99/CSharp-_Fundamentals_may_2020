using System;
using System.Text;

namespace _09.Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                IsPalindromeInteger(input);
                input = Console.ReadLine();
            }
        }

        static void IsPalindromeInteger(string number)
        {
            StringBuilder numberReversed = new StringBuilder();

            for (int currNum = number.Length - 1; currNum >= 0; currNum--)
            {
                numberReversed.Append(number[currNum]);
            }
            string numberReversedStr = numberReversed.ToString();
            int result= number.CompareTo(numberReversedStr);

            if (result == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
