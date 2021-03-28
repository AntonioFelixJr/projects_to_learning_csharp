using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 3, 28, 0, 0, 0);
            Console.WriteLine(dt.ElapsedTime());

            string str = "Legal esse lance de Extension Methods";
            Console.WriteLine(str.Cut(25));
        }
    }
}
