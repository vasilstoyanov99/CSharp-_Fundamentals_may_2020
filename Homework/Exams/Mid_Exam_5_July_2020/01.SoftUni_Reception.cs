using System;

namespace _01.SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiencyPerHour = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiencyPerHour = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiencyPerHour = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hoursCounter = 0;

            while (studentsCount > 0)
            {
                hoursCounter++;

                if (hoursCounter % 4 == 0)
                {
                    continue;
                }
                else
                {
                    int totalEfficiencyForOneHour = firstEmployeeEfficiencyPerHour + secondEmployeeEfficiencyPerHour + thirdEmployeeEfficiencyPerHour;
                    studentsCount -= totalEfficiencyForOneHour;
                }
            }

            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
