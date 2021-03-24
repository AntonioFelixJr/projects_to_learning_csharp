using System;

namespace Generics1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> pr = new PrintService<string>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string number = Console.ReadLine();
                pr.AddValue(number);
            } 

            pr.Print();
            Console.WriteLine("First: " + pr.First()); 
        }
    }
}
