using Exercicios2.Models.Entities;
using Exercicios2.Models.Entities.Enums;
using System;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle
            {
                Radius = 2.0,
                Color = Color.Black
            };

            IShape s2 = new Rectangle
            {
                Width = 3.5,
                Height = 4.2,
                Color = Color.White
            };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
