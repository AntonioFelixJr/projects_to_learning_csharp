using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach (string name in vect)
            {
                Console.WriteLine($"Olá {name}!!!");
            }
        }
    }
}
