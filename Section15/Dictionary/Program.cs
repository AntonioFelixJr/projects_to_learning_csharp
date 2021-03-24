using System.Collections.Generic;
using System;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "987654332";
            cookies["phone"] = "987654331";

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
                Console.WriteLine(cookies["email"]);
            else
                Console.WriteLine("There is no 'email' key");

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("\nALL COOKIES:");

            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key +": " + item.Value);
            }
        }
    }
}
