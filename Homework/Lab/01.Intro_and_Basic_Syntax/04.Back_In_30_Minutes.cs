using System;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hh = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine());

            if (mm >= 30)
            {
                hh++;

                if (hh >= 24)
                {
                    hh = 0;
                }

                mm += 30;

                if (mm > 60)
                {
                    mm -= 60;
                }
                else
                {
                    mm = 0;
                }
            }
            else if (mm < 30)
            {
                mm += 30;
            }

            Console.WriteLine($"{hh}:{mm:d2}");
        }
    }
}
