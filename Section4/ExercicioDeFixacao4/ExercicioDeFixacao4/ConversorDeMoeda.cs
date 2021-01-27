using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao4
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.00;

        public static double ReaisEmDolares(double cotacao, double dolares)
        {
            double total = cotacao * dolares;
            total += total * (IOF / 100);

            return total;
        }
    }
}
