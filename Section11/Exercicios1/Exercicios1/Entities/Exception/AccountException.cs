using System;

namespace Exercicios1.Entities.Exception
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message) { }
    }
}
