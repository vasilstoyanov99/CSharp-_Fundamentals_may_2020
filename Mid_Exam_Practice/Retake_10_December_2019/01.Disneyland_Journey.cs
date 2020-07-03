using System;

namespace _01.Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyPrice = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double savedMoney = 0.00;

            for (int currMonth = 1; currMonth <= months; currMonth++)
            {
                if (currMonth != 1 && currMonth % 2 == 1)
                {
                    double spendMoney = savedMoney * 0.16;
                    savedMoney -= spendMoney;
                }

                if (currMonth % 4 == 0)
                {
                    double bonus = savedMoney * 0.25;
                    savedMoney += bonus;
                }

                savedMoney += journeyPrice * 0.25;
            }

            if (savedMoney >= journeyPrice)
            {
                double leftMoney = savedMoney - journeyPrice;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {leftMoney:f2}lv. for souvenirs.");
            }
            else
            {
                double neededMoney = journeyPrice - savedMoney;
                Console.WriteLine($"Sorry. You need {neededMoney:f2}lv. more.");
            }
        }
    }
}
