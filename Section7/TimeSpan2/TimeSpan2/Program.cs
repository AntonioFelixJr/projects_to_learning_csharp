using System;

namespace TimeSpan2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan maxTimeSpan = TimeSpan.MaxValue;
            TimeSpan minTimeSpan = TimeSpan.MinValue;
            TimeSpan zeroTimeSpan = TimeSpan.Zero;

            Console.WriteLine($"maxTimeSpan = {maxTimeSpan}");
            Console.WriteLine($"minTimeSpan = {minTimeSpan}");
            Console.WriteLine($"Zero = {zeroTimeSpan}");

            TimeSpan t = new TimeSpan(2, 12, 5, 7, 11);

            Console.WriteLine($"Days = {t.Days}");
            Console.WriteLine($"Hours = {t.Hours}");
            Console.WriteLine($"Minutes = {t.Minutes}");
            Console.WriteLine($"Milliseconds = {t.Milliseconds}");
            Console.WriteLine($"Seconds = {t.Seconds}");
            Console.WriteLine($"Ticks = {t.Ticks}");

            Console.WriteLine($"TotalDays = {t.TotalDays}");
            Console.WriteLine($"TotalHours = {t.TotalHours}");
            Console.WriteLine($"TotalMinutes = {t.Minutes}");
            Console.WriteLine($"TotalSeconds = {t.Seconds}");
            Console.WriteLine($"TotalMilliseconds = {t.Milliseconds}");

            Console.WriteLine("----------------------------------------------------------------------------------------");

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            Console.WriteLine($"t1 = {t1}");
            Console.WriteLine($"t2 = {t2}\n");
            Console.WriteLine($"t1.Add(t2) = {t1.Add(t2)}");
            Console.WriteLine($"t1.Subtract(t2) = {t1.Subtract(t2)}");
            Console.WriteLine($"t2.Multiply(2.0) = {t2.Multiply(2.0)}");
            Console.WriteLine($"t2.Divide(2.0) = {t2.Divide(2.0)}");
        }
    }
}
