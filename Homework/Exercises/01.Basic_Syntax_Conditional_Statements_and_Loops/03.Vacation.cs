using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double pricePerPerson = 0.00;
            double totalPrice = 0.00;

            if (dayOfTheWeek == "Friday")
            {
                switch (typeOfTheGroup)
                {
                    case "Students":
                        pricePerPerson = 8.45;
                        break;
                    case "Business":
                        pricePerPerson = 10.90;
                        break;
                    case "Regular":
                        pricePerPerson = 15.00;
                        break;
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                switch (typeOfTheGroup)
                {
                    case "Students":
                        pricePerPerson = 9.80;
                        break;
                    case "Business":
                        pricePerPerson = 15.60;
                        break;
                    case "Regular":
                        pricePerPerson = 20.00;
                        break;
                }
            }
            else if (dayOfTheWeek == "Sunday")
            {
                switch (typeOfTheGroup)
                {
                    case "Students":
                        pricePerPerson = 10.46;
                        break;
                    case "Business":
                        pricePerPerson = 16.00;
                        break;
                    case "Regular":
                        pricePerPerson = 22.50;
                        break;
                }
            }

            totalPrice = numOfPeople * pricePerPerson;

            if (typeOfTheGroup == "Students" && numOfPeople >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (typeOfTheGroup == "Business" && numOfPeople >= 100)
            {
                totalPrice -= 10 * pricePerPerson;
            }
           else if (typeOfTheGroup == "Regular" && numOfPeople >= 10 && numOfPeople <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
