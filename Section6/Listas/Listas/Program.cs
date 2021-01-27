using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciando com valor List<string> list2 = new List<string> { "Maria", "Alex" };

            List<string> list = new List<string>();

            // Adicionando a lista

            list.Add("1 Item");
            list.Add("2 Item");
            list.Add("3 Item");
            list.Add("4 Item");
            list.Add("5 Item");
            list.Add("30 Item");
            list.Add("31 Item");
            list.Add("32 Item");
            list.Insert(0, "0 Item");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("list.Count: " + list.Count);

            string s1 = list.Find(x => x[0] == '3');
            Console.WriteLine("First '3': " + s1);

            string s2 = list.FindLast(x => x[0] == '3');
            Console.WriteLine("Last '3': " + s2);

            int pos1 = list.FindIndex(x => x[0] == '3');
            Console.WriteLine("First Index '3': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == '3');
            Console.WriteLine("Last Index '3': " + pos2);

            List<string> listFiltrada = list.FindAll(x => x.Length > 6);
            Console.WriteLine("--------------------------------------------------------------------------");
            foreach (string item in listFiltrada)
            {
                Console.WriteLine(item);
            }

            // Removendo da lista
            Console.WriteLine("--------------------------------------------------------------------------");

            list.Remove("1 Item");
            list.RemoveAll(x => x.Length > 6);
            list.RemoveAt(0);
            list.RemoveRange(2, 2);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
