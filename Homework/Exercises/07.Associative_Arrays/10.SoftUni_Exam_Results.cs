using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserSubmission> submissionsData = new List<UserSubmission>();
            Dictionary<string, int> usedLanguagesCounter = new Dictionary<string, int>();
            string input = Console.ReadLine();
            int submissionsCounter = 0;

            while (input != "exam finished")
            {
                string[] data = input.Split("-", StringSplitOptions.RemoveEmptyEntries);

                if (data.Contains("banned"))
                {
                    RemoveSubmission(submissionsData, data);
                }
                else
                {
                    AddSubmission(submissionsData, data);
                    AddToCounter(usedLanguagesCounter, data[1]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var pair in submissionsData.OrderByDescending(x => x.Points).ThenBy(x => x.Username))
            {
                Console.WriteLine($"{pair.Username} | {pair.Points}");
            }

            Console.WriteLine("Submissions:");

            foreach (var pair in usedLanguagesCounter.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }

        static void AddSubmission(List<UserSubmission> submissionsData, string[] data)
        {
            string username = data[0];
            string language = data[1];
            int points = int.Parse(data[2]);
            UserSubmission newSubmission = new UserSubmission(username, language, points);
            submissionsData.Add(newSubmission);
        }

        static void AddToCounter(Dictionary<string, int> usedLanguagesCounter, string language)
        {
            if (!usedLanguagesCounter.ContainsKey(language))
            {
                usedLanguagesCounter.Add(language, 1);
            }
            else
            {
                usedLanguagesCounter[language]++;
            }
        }

        static void RemoveSubmission(List<UserSubmission> submissionsData, string[] data)
        {
            string username = data[0];

            for (int i = 0; i < submissionsData.Count; i++)
            {
                if (submissionsData[i].Username == username)
                {
                    submissionsData.RemoveAt(i);
                    i--;
                }
            }
        }
    }

    class UserSubmission
    {
        public string Username { get; set; }
        public string Language { get; set; }
        public int Points { get; set; }

        public UserSubmission(string username ,string language, int ponts)
        {
            this.Username = username;
            this.Language = language;
            this.Points = ponts;
        }
    }
}
