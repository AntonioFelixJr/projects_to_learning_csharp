using System;

namespace HackRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 35, c = 20;

            // A
            do
            {
                a /= 2;
                b += a;
                c -= -1;
            } while (c < a);

            Console.WriteLine($"{a} {b} {c}");
            
            // B
            a = 12;
            b = 35; 
            c = 20;
            while (c < a)
            {
                a /= 2;
                b += a;
                c -= -1;
            }

            Console.WriteLine($"{a} {b} {c}");

            // C
            a = 12;
            b = 35;
            c = 20;
            for (int i = c; i < a; i = c)
            {
                a /= 2;
                b += a;
                c -= -1;
            }

            Console.WriteLine($"{a} {b} {c}");

            // D
            a = 12;
            b = 35;
            c = 20;
            while (true)
            {
                a /= 2;
                b += a;
                c -= -1;

                if (c >= a)
                    break;
            }

            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
