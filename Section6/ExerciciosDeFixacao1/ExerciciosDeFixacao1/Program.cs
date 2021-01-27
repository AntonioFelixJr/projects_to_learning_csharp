using System;

namespace ExerciciosDeFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomsRented;
            Guest[] guests = new Guest[10];

            Console.Write("How many rooms will be rented? ");
            roomsRented = int.Parse(Console.ReadLine());


            for (int i = 0; i < roomsRented; i++)
            {
                string name, email;
                int room;

                Console.WriteLine($"\nRent #{i + 1}:");

                Console.Write($"Name: ");
                name = Console.ReadLine();

                Console.Write($"Email: ");
                email= Console.ReadLine();

                Console.Write($"Room: ");
                room = int.Parse(Console.ReadLine());

                guests[room] = new Guest(name, email, room);
            }

            Console.WriteLine("\nBusy rooms:");

            for (int i = 0; i < guests.Length; i++)
            {
                if ( guests[i] != null)
                {
                    Console.WriteLine(guests[i]);
                }
            }
        }
    }
}
