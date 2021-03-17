using System;
using System.IO;

namespace StremaWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Users\fx\csharp.txt";
            string targetPath = @"c:\Users\fx\csharpWriteUpperCase.txt";

            try
            {

                string[] lines = File.ReadAllLines(sourcePath);


                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }       
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
