using System;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2) Day: {d.Day}");
            Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4) DayOfYer: {d.DayOfYear}");
            Console.WriteLine($"5) Hour: {d.Hour}");
            Console.WriteLine($"6) Kind: {d.Kind}");
            Console.WriteLine($"7) Millisecond: {d.Millisecond}");
            Console.WriteLine($"8) Minute: {d.Minute}");
            Console.WriteLine($"9) Month: {d.Month}");
            Console.WriteLine($"10) Second: {d.Second}");
            Console.WriteLine($"11) Ticks: {d.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13) Year: {d.Year}");

            Console.WriteLine("-------------------------------------------------------------------");

            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);

            Console.WriteLine($"ToLongDateString() = {d1.ToLongDateString()}");
            Console.WriteLine($"ToLongTimeString() = {d1.ToLongTimeString()}");
            Console.WriteLine($"ToShortDateString() = {d1.ToShortDateString()}");
            Console.WriteLine($"ToShortTimeString() = {d1.ToShortTimeString()}");
            Console.WriteLine($"ToString() = {d1.ToString()}");
            Console.WriteLine($"ToString(\"yyyy-MM-dd HH:mm:ss\") = {d1.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine($"ToString(\"yyyy-MM-dd HH:mm:ss.fff\") = {d1.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
            
            Console.WriteLine("-------------------------------------------------------------------");

            DateTime d2 = d.AddDays(365);

            Console.WriteLine($"AddDays(365) = {d2.ToLongDateString()}");

            d2.AddMinutes(3);

            Console.WriteLine($"AddMinutes(3) ={d2.ToShortTimeString()}");

            Console.WriteLine("-------------------------------------------------------------------");

            DateTime dateDiff = DateTime.Now;

            DateTime dateDiff2 = new DateTime(2020, 03, 01);

            Console.WriteLine(dateDiff.Subtract(dateDiff2));
        }
    }
}
