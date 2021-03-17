using System.Collections.Generic;
using System.IO;
using System;

namespace Directory1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\fx\MyFirstGame";

            try
            {
                IEnumerable<string> folders =Directory.EnumerateDirectories(path, "*.*", SearchOption.TopDirectoryOnly);

                Console.WriteLine("FOLDERS:");

                foreach(string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly);

                Console.WriteLine("FILES:");

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\NewFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
