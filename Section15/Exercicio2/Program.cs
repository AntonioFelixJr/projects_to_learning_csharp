using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            SortedSet<int> a = ReadCodeRegistration(n);

            Console.Write("\nHow many students for course B? ");
            n = int.Parse(Console.ReadLine());

            SortedSet<int> b = ReadCodeRegistration(n);

            Console.Write("\nHow many students for course C? ");
            n = int.Parse(Console.ReadLine());

            SortedSet<int> c = ReadCodeRegistration(n);

            SortedSet<int> all = new SortedSet<int>(a);

            all.UnionWith(b);
            all.UnionWith(c);

            Console.WriteLine($"\nTotal students: {all.Count}");
            Console.WriteLine("\nList:");
            foreach(int registre in all)
            {
                Console.Write(registre + " ");
            }
            Console.WriteLine("\n");
        }

        static SortedSet<int> ReadCodeRegistration(int total)
        {
            SortedSet<int> collection = new SortedSet<int>();

            for (int i = 0; i< total; i++)
            {
                collection.Add(int.Parse(Console.ReadLine()));
            }
            return collection;
        }
    }
}
