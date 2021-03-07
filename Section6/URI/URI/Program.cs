using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        string[] lerLinha = new string[3];
        lerLinha = Console.ReadLine().Split(" ");
        int qtd = int.Parse(lerLinha[1]);
        double preco = double.Parse(lerLinha[2], CultureInfo.InvariantCulture);

        double valorATotal = (double) qtd * preco;

        string[] lerLinha2 = new string[3];

        lerLinha2 = Console.ReadLine().Split(" ");
        qtd = int.Parse(lerLinha2[1]);
        preco = double.Parse(lerLinha2[2], CultureInfo.InvariantCulture);

        valorATotal += (double) qtd * preco;

        Console.WriteLine($"VALOR A PAGAR: R$ {valorATotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
