using System;

namespace _07.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;
            bool isError = false;

            if (typeOfDay == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 12;
                }
                else
                {
                    isError = true;
                }
            }

            else if (typeOfDay == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 15;
                }
                else
                {
                    isError = true;
                }
            }

            else if (typeOfDay == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 10;
                }
                else
                {
                    isError = true;
                }
            }

            if (isError)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{ticketPrice}$");
            }
        }
    }
}
