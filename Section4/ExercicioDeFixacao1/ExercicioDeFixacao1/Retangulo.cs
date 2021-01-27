using System;

namespace ExercicioDeFixacao1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;
      
        public double Area()
        {
            return this.Altura * this.Largura;
        }

        public double Perimetro()
        {
            return (this.Altura + this.Largura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(this.Altura, 2.0) + Math.Pow(this.Largura, 2.00));
        }
    }
}