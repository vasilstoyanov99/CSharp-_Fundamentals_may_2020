using System;
using System.Linq;
using System.Text;

namespace _01.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < usernames.Length; i++)
            {
                string currUsername = usernames[i];

                if (currUsername.Length >= 3 && currUsername.Length <= 16)
                {
                   bool isValid = CheckIfUsernameIsValid(currUsername);

                    if (isValid)
                    {
                        Console.WriteLine(currUsername);
                    }
                }
            }
        }

        static bool CheckIfUsernameIsValid(string currUsername)
        {
            bool isValid = true;

            for (int j = 0; j < currUsername.Length; j++)
            {
                char currChar = currUsername[j];

                if (char.IsLetterOrDigit(currChar))
                {
                    isValid = true;
                }
                else if (currChar == '-')
                {
                    isValid = true;
                }
                else if (currChar == '_')
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
