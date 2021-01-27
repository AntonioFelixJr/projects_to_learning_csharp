using System;
using System.Globalization;

namespace ExerciciosDeFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero, nome;
            double valor;
            ContaBancaria conta;

            Console.Write($"Entre o número da conta: ");
            numero = Console.ReadLine();

            Console.Write($"Entre o titular da conta: ");
            nome = Console.ReadLine();

            Console.Write($"Haverá depósito inicial (s/n)? ");
            if (Console.ReadLine() == "s")
            {
                Console.Write($"Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, nome, valor);
            } 
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine($"\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            conta.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
