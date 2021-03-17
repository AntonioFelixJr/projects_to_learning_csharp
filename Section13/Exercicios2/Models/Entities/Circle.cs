using System;
using System.Globalization;

namespace Exercicios2.Models.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return $"Rectangle Radius: {Radius.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Color: {Color.ToString()}, Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
