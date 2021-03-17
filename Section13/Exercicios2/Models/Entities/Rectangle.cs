using System.Globalization;

namespace Exercicios2.Models.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle Width: {Width.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Height: {Height.ToString("F2", CultureInfo.InvariantCulture)}, Color: {Color.ToString()}, " +
                $"Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
