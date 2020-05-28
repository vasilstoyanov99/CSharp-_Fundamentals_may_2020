using System;

namespace _10.Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputChar = char.Parse(Console.ReadLine());

            if (inputChar >= 97 && inputChar <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
