﻿using System;

namespace Section7
{
    class Program
    {
        static void Main(string[] args)
        {
            //"tipo" var
            var x = 10;
            var y = 20.0;
            var z = "Maria";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //switch-case
            int a = int.Parse(Console.ReadLine());
            string day;
             
            switch(a)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine($"Day: {day}");
        }
    }
}
