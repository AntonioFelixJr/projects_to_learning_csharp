using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    class LogRecord
    {
        public LogRecord(string line)
        {
            string[] vect = line.Split(" ");
            UserName = vect[0];
            Instant = DateTime.Parse(vect[1]);
        }

        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override string ToString()
        {
            return $"UserName: {UserName}, Login Instant: {Instant}";
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }

            LogRecord other = obj as LogRecord;

            return UserName.Equals(other.UserName);
        }
    }
}
