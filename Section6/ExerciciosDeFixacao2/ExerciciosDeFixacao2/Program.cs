using System;

namespace ExerciciosDeFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhaEColuna = Console.ReadLine().Split(" ");
            int n = int.Parse(linhaEColuna[0]);
            int m = int.Parse(linhaEColuna[1]);

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(" ");
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(row[j]);
                }
            }

            int findNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i,j] == findNumber)
                    {
                        Console.WriteLine($"\nPosition {i},{j}:");

                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }

                        if (j + 1 < m)
                        {
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");
                        }
                        
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }

                        if (i + 1 < n)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
