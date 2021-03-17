﻿using Exercicios2.Models.Entities.Enums;

namespace Exercicios2.Models.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
