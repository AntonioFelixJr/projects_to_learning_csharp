using System;

namespace RefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // code smells!

            int x = 10;
            Calculator.Triple(ref x);
            // ref - Isso permite passar a referencia em memória para a função
            Console.WriteLine(x);

            int y = 3, result;

            Calculator.Triple(y, out result);
            // out - Permite que eu passe a variavel que ira armazenar o calculo
            Console.WriteLine(result);
           
        }
    }
}
