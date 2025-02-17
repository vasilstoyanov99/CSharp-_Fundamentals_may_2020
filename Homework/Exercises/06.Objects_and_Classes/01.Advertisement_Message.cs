using System;

namespace _01.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int advertisementMessages = int.Parse(Console.ReadLine());

            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."  };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random randPhrase = new Random();
            Random randEvent = new Random();
            Random randAuthor = new Random();
            Random randCity = new Random();

            for (int i = 0; i < advertisementMessages; i++)
            {
                int newRandPhrase = randPhrase.Next(0, phrases.Length);
                int newRandEvent = randPhrase.Next(0, events.Length);
                int newRandAuthor = randPhrase.Next(0, authors.Length);
                int newRandCity = randPhrase.Next(0, cities.Length);

                Console.WriteLine($"{phrases[newRandPhrase]} {events[newRandEvent]} {authors[newRandAuthor]} – {cities[newRandCity]}.");
            }


        }
    }
}
