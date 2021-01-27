using System;
using System.Globalization;

namespace ExercicioDeFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            string statusAluno;

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            statusAluno = aluno.Status();

            Console.WriteLine(statusAluno);

            if (statusAluno == "REPROVADO")
            {
                Console.WriteLine($"FALTARAM {aluno.PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
