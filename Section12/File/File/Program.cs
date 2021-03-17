using System.IO;
using System;

namespace File1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Users\fx\csharp.txt";
            string targetPath = @"c:\Users\fx\csharp1.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
