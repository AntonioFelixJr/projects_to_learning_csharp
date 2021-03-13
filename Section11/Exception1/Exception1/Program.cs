using System;

namespace Exception1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine($"Não é possivel dividir por zero");
            }
            catch (FormatException)
            {
                Console.WriteLine($"O numeros devem ser inteiros");
            }
            finally
            {
                //Muito usado para fechar arquivos e conexão com banco
                Console.WriteLine($"Finally");
            }
            Console.WriteLine("Hello World!");

            ProcessFile.Run();
        }
    }
}
