using MetodosAbstratos.Entities.Enums;
using System.Collections.Generic;
using MetodosAbstratos.Entities;
using System.Globalization;
using System;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("\tRectangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("\tColor (Black/Blue/Red/DarkGreen): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                switch (type)
                {
                    case 'r':
                        Console.Write("\tWidth: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("\tHeight: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Rectangle(width, height, color));
                        break;

                    case 'c':
                        Console.Write("\tRadius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Circle(radius, color));
                        break;

                    default:
                        throw new Exception("Invalid type of shape");

                }

                Console.WriteLine();
            }
            Console.WriteLine("SHAPE AREAS:");

            foreach(Shape shape in list)
            {
                shape.Show();
            }

        }
    }
}
