using MetodosAbstratos.Entities.Enums;
using System;
using System.Globalization;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

        public void Show()
        {
            Console.BackgroundColor = Enum.Parse<ConsoleColor>(Color.ToString());
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Type: {this.GetType().Name}, Color: {Color.ToString()}, Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}");
            
            Console.ResetColor();
        }
    }
}
