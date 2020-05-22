using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int trashedKeyboardCount = 0;
            int trashedHeadsets = lostGamesCount / 2;
            int trashedMouses = lostGamesCount / 3;

            for (int currLostGame = 1; currLostGame <= lostGamesCount; currLostGame++)
            {
                if (currLostGame % 2 == 0 && currLostGame % 3 == 0)
                {
                    trashedKeyboardCount++;
                }
            }

            int trashedDisplays = trashedKeyboardCount / 2;
            double totalExpenses = (trashedHeadsets * headsetPrice) + (trashedMouses * mousePrice) + (trashedKeyboardCount * keyboardPrice) + (trashedDisplays * displayPrice);
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");

        }
    }
}
