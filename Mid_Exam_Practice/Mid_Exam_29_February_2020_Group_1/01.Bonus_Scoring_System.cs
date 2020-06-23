using System;

namespace _01.Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal countOfStudents = decimal.Parse(Console.ReadLine());
            decimal courseLecturesCount = decimal.Parse(Console.ReadLine());
            decimal initialBonus = decimal.Parse(Console.ReadLine());
            decimal maxBonusPoints = decimal.MinValue;
            decimal winningStudetAttendances = 0;

            for (int currStudentAttendances = 1; currStudentAttendances <= countOfStudents; currStudentAttendances++)
            {
                decimal studentAttendances = decimal.Parse(Console.ReadLine());
                decimal totalBonusPoints = (studentAttendances / courseLecturesCount) * (5 + initialBonus);
                totalBonusPoints = Math.Round(totalBonusPoints, MidpointRounding.AwayFromZero);

                if (maxBonusPoints < totalBonusPoints)
                {
                    maxBonusPoints = totalBonusPoints;
                    winningStudetAttendances = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonusPoints}.");
            Console.WriteLine($"The student has attended {winningStudetAttendances} lectures.");
        }
    }
}
