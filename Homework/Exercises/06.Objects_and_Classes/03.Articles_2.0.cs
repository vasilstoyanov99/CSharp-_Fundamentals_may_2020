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
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> allArticles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Article newArticle = new Article(input[0], input[1], input[2]);
                allArticles.Add(newArticle);
            }

            string sortBy = Console.ReadLine();

            switch (sortBy)
            {
                case "title":
                    Console.WriteLine(String.Join(Environment.NewLine, allArticles.OrderBy(x => x.Title)));
                    break;
                case "content":
                    Console.WriteLine(String.Join(Environment.NewLine, allArticles.OrderBy(x => x.Content)));
                    break;
                case "author":
                    Console.WriteLine(String.Join(Environment.NewLine, allArticles.OrderBy(x => x.Author)));
                    break;
            }
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

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
