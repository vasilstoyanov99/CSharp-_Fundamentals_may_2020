using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string passWord = "";
            int errorsCounter = 0;

            for (int cuurChar = userName.Length - 1; cuurChar >= 0; cuurChar--)
            {
                passWord += userName[cuurChar].ToString(); 
            }

            while (errorsCounter < 4)
            {
                string userPasswordInput = Console.ReadLine();

                if (passWord != userPasswordInput)
                {
                    errorsCounter++;
                    Console.WriteLine("Incorrect password. Try again.");
                    if (errorsCounter == 3)
                    {
                        Console.WriteLine($"User {userName} blocked! ");
                        break;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in. ");
                    break;
                }
            }
        }
    }
}
