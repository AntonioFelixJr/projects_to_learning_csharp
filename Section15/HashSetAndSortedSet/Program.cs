using System;
using System.Collections.Generic;

namespace HashSetAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Não existe posição em HashSet e SortedSet
            HashSet<string> hs = new HashSet<string>();

            hs.Add("TV");
            hs.Add("Notebook");
            hs.Add("Tablet");

            Console.WriteLine(hs.Contains("CPU"));

            PrintCollection(hs);
            
            SortedSet<int> ssA = new SortedSet<int> { 2, 3, 4, 5, 6, 7, 8, 9};
            SortedSet<int> ssB = new SortedSet<int> { 20, 0, 7, 8, 10};

            // Union
            SortedSet<int> ssC = new SortedSet<int>(ssA);
            ssC.UnionWith(ssB);

            PrintCollection(ssC);

            // Intersection
            SortedSet<int> ssD = new SortedSet<int>(ssA);
            ssD.IntersectWith(ssB);
            PrintCollection(ssD);

            // Difference
            SortedSet<int> ssE = new SortedSet<int>(ssA);
            ssE.ExceptWith(ssB);
            PrintCollection(ssE);

        }

        static void PrintCollection<T>(IEnumerable<T> colletcion)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            foreach(var i in colletcion)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
    }
}
