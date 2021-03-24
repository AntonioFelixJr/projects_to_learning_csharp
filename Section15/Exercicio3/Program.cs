using System.Collections.Generic;
using System.IO;
using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            Dictionary<string, int> voting = new Dictionary<string, int>();

            path += @"\VoteList.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine()?.Split(',');
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);

                        if (voting.ContainsKey(candidate))
                            voting[candidate] += votes;
                        else
                            voting.Add(candidate, votes);
                    }
                }

                foreach (var item in voting)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
