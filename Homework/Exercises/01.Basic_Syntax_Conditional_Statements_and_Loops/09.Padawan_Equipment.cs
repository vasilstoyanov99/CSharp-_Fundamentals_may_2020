using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double IvanChoMoney = double.Parse(Console.ReadLine());
            int totalStudents = int.Parse(Console.ReadLine());
            double pricePerLightsaber = double.Parse(Console.ReadLine());
            double pricePerRobe = double.Parse(Console.ReadLine());
            double pricePerBelt = double.Parse(Console.ReadLine());

            int totalFreeBelts = 0;
            if (totalStudents >= 6)
            {
                totalFreeBelts = totalStudents / 6;
            }
            double totalBeltsPrice = pricePerBelt * (totalStudents - totalFreeBelts);
            double totalSabers = Math.Ceiling(totalStudents * 1.10);
            double totalSabersPrice = totalSabers * pricePerLightsaber;
            double totalRobesPrice = totalStudents * pricePerRobe;
            double totalNeededMoney = totalBeltsPrice + totalSabersPrice + totalRobesPrice;

            if (IvanChoMoney >= totalNeededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalNeededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalNeededMoney - IvanChoMoney:f2}lv more.");
            }
        }
    }
}
