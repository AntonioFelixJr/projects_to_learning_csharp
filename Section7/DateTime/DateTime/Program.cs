using System;
using System.Globalization;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2018, 11, 25);
            DateTime dt2 = new DateTime(2018, 11, 25, 20, 04, 04);
            DateTime dt3 = new DateTime(2018, 11, 25, 20, 04, 04, 500);

            DateTime dt4 = DateTime.Now;
            DateTime dt5 = DateTime.Today;
            DateTime dt6 = DateTime.UtcNow;

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            Console.WriteLine(dt5);
            Console.WriteLine(dt6);

            Console.WriteLine("-----------------------------------------------------");

            DateTime d7 = DateTime.Parse("2020-03-01 14:30:00");
            DateTime d8 = DateTime.Parse("01/10/1996 10:20:00");
            DateTime d9 = DateTime.Parse("12:20:00");
            
            DateTime d10 = DateTime.ParseExact("2020-02-12", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d11 = DateTime.ParseExact("01/10/1990 10:20:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
        }
    }
}
