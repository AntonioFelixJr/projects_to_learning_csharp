using Exercicio2.Entities;
using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Post post = new Post()
            {
                Moment = DateTime.Parse("21/06/2018 13:05:44"),
                Title = "Traveling to New Zealand",
                Content = "I'm going to visit this wonderful country!",
                Likes = 12,
                Comments =
                {
                    new Comment("Have a nice trip"),
                    new Comment("Wow that's awesome!")
                }
            };

            Console.WriteLine(post);

            Console.WriteLine();

            Post post2 = new Post()
            {
                Moment = DateTime.Parse("28/07/2018 23:14:19"),
                Title = "Good night guys",
                Content = "See you tomorrow",
                Likes = 5
            };

            post2.AddComment(new Comment("Good Night"));
            post2.AddComment(new Comment("May the Force be with you!"));

            Console.WriteLine(post2);
        }
    }
}
