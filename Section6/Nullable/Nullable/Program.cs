using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable<double> x; Forma alternativa de escrita

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            // Operador de coalescência nula

            y = x ?? 15.0;
            Console.WriteLine(y.Value);
        }
    }
}
