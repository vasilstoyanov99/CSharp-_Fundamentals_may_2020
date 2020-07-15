using System;
using System.Text;

namespace _05.Digits_Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            StringBuilder onlyDigits = new StringBuilder();
            StringBuilder onlyLetters = new StringBuilder();
            StringBuilder otherCharacters = new StringBuilder();

            for (int i = 0; i < textInput.Length; i++)
            {
                char currChar = textInput[i];

                if (char.IsDigit(currChar))
                {
                    onlyDigits.Append(currChar);
                }
                else if (char.IsLetter(currChar))
                {
                    onlyLetters.Append(currChar);
                }
                else
                {
                    otherCharacters.Append(currChar);
                }
            }

            Console.WriteLine(onlyDigits.ToString());
            Console.WriteLine(onlyLetters.ToString());
            Console.WriteLine(otherCharacters.ToString());
        }
    }
}
