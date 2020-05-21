using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        int holidaysCount = 0;
        for (var currDate = startDate; currDate <= endDate; currDate = currDate.AddDays(1))
        {
            if (currDate.DayOfWeek == DayOfWeek.Saturday || currDate.DayOfWeek == DayOfWeek.Sunday) 
                holidaysCount++;
        }

        Console.WriteLine(holidaysCount);
    }
}
