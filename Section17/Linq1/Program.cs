using System.Linq;
using System;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            // Define the query
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
