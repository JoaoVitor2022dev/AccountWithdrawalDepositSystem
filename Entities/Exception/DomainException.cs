using System;
using System.Globalization;

namespace Program.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message): base(message)
        {}        
    }
}