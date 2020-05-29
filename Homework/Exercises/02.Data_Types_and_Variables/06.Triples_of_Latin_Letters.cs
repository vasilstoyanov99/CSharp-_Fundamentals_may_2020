using System;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char firstChar = 'a'; firstChar < 'a' + n; firstChar++)
            {
                for (char secondChar = 'a'; secondChar < 'a' + n; secondChar++)
                {
                    for (char thirdChar = 'a'; thirdChar < 'a' + n; thirdChar++)
                    {
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
