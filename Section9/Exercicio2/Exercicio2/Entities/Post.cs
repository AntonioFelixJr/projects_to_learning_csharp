using System.Collections.Generic;
using System.Text;
using System;

namespace Exercicio2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public string ShowComments()
        {
            string allComments = "";

            Comments.ForEach(comment =>
            {
                allComments += comment.Text + "\n";
            });

            return allComments;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            sb.Append(ShowComments());

            return sb.ToString();
             /*
                $"{Title}\n" +
                $"{Likes} Likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}\n" +
                $"{Content}\n" +
                $"Comments:\n" +
                $"{this.ShowComments()}";
            */
        }
    }
}
