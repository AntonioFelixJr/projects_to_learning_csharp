using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] itens = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(itens[j]);
                }

            }

            int negativeCount = 0;
            int[] diagonal = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negativeCount++;
                    }

                    if (i == j)
                    {
                        diagonal[i] = matriz[i,j];
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Main diagonal: ");
            Console.WriteLine(string.Join(" ", diagonal));
            Console.WriteLine($"Negative numbers: {negativeCount}");


            /*
            Console.WriteLine(matriz.Length);
            Console.WriteLine(matriz.Rank);
            Console.WriteLine(matriz.GetLength(0));
            Console.WriteLine(matriz.GetLength(1));
            */

           
        }
    }
}
