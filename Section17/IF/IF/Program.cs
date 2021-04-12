using System;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Banana";

            DateTime data = DateTime.Now;


            if ((data.Month >= 1 && data.Day >= 23) && (data.Month <= 2 && data.Day <= 23))
            {

            }
            else if ()

            if (nome.Equals("Antonio"))
            {
                Console.WriteLine("Nome é Antonio");
            }
            else
            {
                Console.WriteLine("O nome não é Antonio");
            }


            if (nome.Equals("Vitoria"))
            {
                Console.WriteLine("If Vitoria");
            }
            else if (nome.Equals("Antonio"))
            {
                Console.WriteLine("If Antonio");
            }
            else if (nome.Equals("Abacate"))
            {
                Console.WriteLine("If Abacate");
            }
            else
            {
                Console.WriteLine("Nenhum nome é valido");
            }

            Console.WriteLine("FIM!");
        }
    }
}
