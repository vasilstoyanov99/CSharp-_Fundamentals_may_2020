using System;
using System.Text.RegularExpressions;

namespace _02.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Regex validator = new Regex(@"^U\$(?<username>[A-Z]{1}[a-z]{2,})U\$P@\$(?<password>[^\W_]{5,}\d+)P@\$$");
            int countOfSuccessfulRegistrations = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string toValidate = Console.ReadLine();
                Match match = validator.Match(toValidate);

                if (match.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["username"].Value}, Password: {match.Groups["password"].Value}");
                    countOfSuccessfulRegistrations++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {countOfSuccessfulRegistrations}");
        }
    }
}
