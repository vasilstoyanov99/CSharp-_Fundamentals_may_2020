using System;

namespace _04.Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();
            bool[] isPasswordValid = new bool[3];
            bool[] isPasswordInValid = new bool[3];
            charactersChecker(passwordInput, isPasswordInValid, isPasswordValid);
            LettersAndDigitsOnlyChecker(passwordInput, isPasswordInValid, isPasswordValid);
            AtLeastTwoDigitsChecker(passwordInput, isPasswordInValid, isPasswordValid);
            ConditionsCheckerAndPrinter(passwordInput, isPasswordInValid, isPasswordValid);
        }


        static void charactersChecker(string password, bool[] isPasswordValid, bool[] isPasswordInValid)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                isPasswordValid[0] = true;
            }
            else
            {
                isPasswordInValid[0] = true;
            }
        }

        static void LettersAndDigitsOnlyChecker(string password, bool[] isPasswordValid, bool[] isPasswordInValid)
        {
            bool isContditionTrue = false;

            for (int i = 0; i < password.Length; i++)
            {
                int currCharASCII = password[i];
                bool isDigit = currCharASCII >= 48 && currCharASCII <= 57;
                bool isUpperCaseLetter = currCharASCII >= 65 && currCharASCII <= 90;
                bool isLowerCaseLetter = currCharASCII >= 97 && currCharASCII <= 122;

                if (isDigit || isUpperCaseLetter || isLowerCaseLetter)
                {
                    isContditionTrue = true;
                }
                else
                {
                    isPasswordInValid[1] = true;
                    return;
                }
            }

            if (isContditionTrue)
            {
                isPasswordValid[1] = true;
            }
        }

        static void AtLeastTwoDigitsChecker(string password, bool[] isPasswordValid, bool[] isPasswordInValid)
        {
            byte digitsCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                int currCharASCII = password[i];
                bool isDigit = currCharASCII >= 48 && currCharASCII <= 57;

                if (isDigit)
                {
                    digitsCounter++;
                }
            }

            if (digitsCounter >= 2)
            {
                isPasswordValid[2] = true;
            }
            else
            {
                isPasswordInValid[2] = true;
            }
        }

        static void ConditionsCheckerAndPrinter(string password, bool[] isPasswordValid, bool[] isPasswordInValid)
        {
            byte cheker = 0;

            if (isPasswordInValid[0] == true)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                cheker++;
            }
           if (isPasswordInValid[1] == true)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                cheker++;
            }
            if (isPasswordInValid[2] == true)
            {
                Console.WriteLine("Password must have at least 2 digits");
                cheker++;
            }

            if (cheker == 0)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
