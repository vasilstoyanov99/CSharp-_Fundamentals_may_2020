using System;

namespace _01.National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            byte fisrtEmployeeCapacityPerHour = byte.Parse(Console.ReadLine());
            byte secondEmployeeCapacityPerHour = byte.Parse(Console.ReadLine());
            byte thirdEmployeeCapacityPerHour = byte.Parse(Console.ReadLine());
            int totalCustomersCount = int.Parse(Console.ReadLine());

            int totalPeopleHandledPerJourFromAllEmployees = fisrtEmployeeCapacityPerHour + secondEmployeeCapacityPerHour + thirdEmployeeCapacityPerHour;
            short totalHoursSpend = 0;
            short hoursPassedCounter = 0;

            while (totalCustomersCount > 0)
            {
                hoursPassedCounter++;

                if (hoursPassedCounter % 4 == 0)
                {
                    continue;
                }

                totalCustomersCount -= totalPeopleHandledPerJourFromAllEmployees;
            }

            Console.WriteLine($"Time needed: {hoursPassedCounter}h.");
        }
    }
}
