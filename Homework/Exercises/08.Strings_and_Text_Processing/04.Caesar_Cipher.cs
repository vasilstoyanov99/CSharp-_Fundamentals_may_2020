using System;
using System.Text;

namespace _04.Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder();
            input.Append(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                int currCharCode = (int)(input[i]);
                char newEncryptedChar = (char)(currCharCode + 3);
                input[i] = newEncryptedChar;
            }
            string encryptedOutput = input.ToString();
            Console.WriteLine(encryptedOutput);
        }
    }
}
