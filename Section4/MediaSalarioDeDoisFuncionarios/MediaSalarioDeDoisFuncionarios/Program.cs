using System;
using System.Globalization;

namespace MediaSalarioDeDoisFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaSalarial;
            Funcionario functionario1 = new Funcionario();
            Funcionario functionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            functionario1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            functionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            functionario2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            functionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaSalarial  = functionario1.MediaEntreDoisSalarios(functionario1.Salario, functionario2.Salario);

            Console.WriteLine($"Salário médio = {mediaSalarial.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
