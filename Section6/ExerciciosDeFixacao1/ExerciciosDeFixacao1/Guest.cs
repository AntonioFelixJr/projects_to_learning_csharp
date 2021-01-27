using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeFixacao1
{
    class Guest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private int Room { get;  set; }

        public Guest(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return $"{Room}: {Name}, {Email}";
        }
    }
}
