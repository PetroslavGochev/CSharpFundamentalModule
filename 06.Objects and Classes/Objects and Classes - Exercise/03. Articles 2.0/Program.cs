namespace _03._Articles_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Article> newList = new List<Article>();
            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article(text[0], text[1], text[2]);
                newList.Add(article);
            }
            string orderBy = Console.ReadLine();
            newList = OrderBy(newList, orderBy);
            foreach (Article text in newList)
            {
                Console.WriteLine(text);
            }
        }
        static List<Article> OrderBy(List<Article> list, string orderBy)
        {

            if (orderBy == "content")
            {
                list = list.OrderBy(x => x.Content).ToList();
            }
            else if (orderBy == "title")
            {
                list = list.OrderBy(x => x.Title).ToList();
            }
            else if (orderBy == "author")
            {
                list = list.OrderBy(x => x.Author).ToList();
            }
            return list;
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

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
