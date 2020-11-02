using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(text[0], text[1], text[2]);
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "Edit")
                {
                    article.EditContent(article, command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(article, command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.RenameTitle(article, command[1]);
                }
            }
            Console.WriteLine(article.ToString());
        }
        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public Article RenameTitle(Article text, string newTitle)
            {
                text.Title = newTitle;
                return text;
            }
            public Article ChangeAuthor(Article text, string newAuthor)
            {
                text.Author = newAuthor;
                return text;
            }
            public Article EditContent(Article text, string newContent)
            {
                text.Content = newContent;
                return text;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
