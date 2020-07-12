using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());
            Article newInfo = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Edit":
                        newInfo.ChangeContent(command[1]);
                        break;
                    case "ChangeAuthor":
                        newInfo.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        newInfo.Rename(command[1]);
                        break;
                }
            }

            Console.WriteLine(newInfo.ToString());
        }

        public class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void ChangeContent(string newContent)
            {
                Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}"; 
            }
        }
    }
}
