using System;

namespace _04.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            decimal days = years * 365.2422m;
            long hours = (long)days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {(long)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
