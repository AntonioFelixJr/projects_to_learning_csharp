using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAlturas;
            
            Console.Write("Digite o números de alturas que serão calculadas: ");
            numeroAlturas = int.Parse(Console.ReadLine());

            double[] alturas = new double[numeroAlturas];

            for (int i = 0; i < numeroAlturas; i++)
            {
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double suma = 0.0;

            for (int i = 0; i < alturas.Length; i++)
            {
                suma += alturas[i];
            }

            double media = suma / alturas.Length;

            Console.WriteLine($"AVERAGE HEIGHT: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
