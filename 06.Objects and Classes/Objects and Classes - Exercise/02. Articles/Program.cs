namespace _02._Articles
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ").ToArray();

            Article article = new Article(text[0], text[1], text[2]);

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Edit")
                {
                    article.EditContent(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.RenameTitle(command[1]);
                }
            }
            Console.WriteLine(article.ToString());
        }
        public class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }

            public void RenameTitle(string newTitle)
            {
                this.Title = newTitle;
            }

            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }

            public void EditContent(string newContent)
            {
                this.Content = newContent;
            }

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
