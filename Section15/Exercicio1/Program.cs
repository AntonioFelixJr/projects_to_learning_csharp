using System.IO;
using System.Collections.Generic;
using System;
using Exercicio1.Entities;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName +@"\Users.log";

            HashSet<LogRecord> hs = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        hs.Add(new LogRecord(line));
                    }
                }

                foreach (LogRecord u in hs)
                {
                    Console.WriteLine(u);
                }

                Console.WriteLine();

                Console.WriteLine($"Total of Users: {hs.Count}.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error in read file: " + e.Message);
            }

   
        }
    }
}
