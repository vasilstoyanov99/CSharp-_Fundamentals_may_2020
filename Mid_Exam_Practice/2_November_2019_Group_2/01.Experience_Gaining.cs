using System;

namespace _01.Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal neededEXP = decimal.Parse(Console.ReadLine());
            short countOfBattles = short.Parse(Console.ReadLine());
            decimal collectedEXP = 0;
            bool isPlayerCollectedNeededEXP = false;
            short battlesCount = 0;

            for (int currBattle = 1; currBattle <= countOfBattles; currBattle++)
            {
                decimal EXPearned = decimal.Parse(Console.ReadLine());
                battlesCount++;

                if (currBattle % 3 == 0)
                {
                    collectedEXP += EXPearned * (decimal)1.15;
                }
                else if (currBattle % 5 == 0)
                {
                    collectedEXP += EXPearned * (decimal)0.90;
                }
                else
                {
                    collectedEXP += EXPearned;
                }

                if (collectedEXP >= neededEXP)
                {
                    isPlayerCollectedNeededEXP = true;
                    break;
                }
            }

            if (isPlayerCollectedNeededEXP)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battlesCount} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededEXP - collectedEXP:f2} more needed.");
            }

        }
    }
}
