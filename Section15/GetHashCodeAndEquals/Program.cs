using GetHashCodeAndEquals.Entities;
using System;

namespace GetHashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client {
                Name = "Maria",
                Email = "maria@gmail.com"
            };

            Client b = new Client { 
                Name = "Alex",
                Email = "maria@gmail.com"
            };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); //Compara a referencia do ponteiro de memória do objeto
            Console.WriteLine(a.GetHashCode() == b.GetHashCode());
        }
    }
}
