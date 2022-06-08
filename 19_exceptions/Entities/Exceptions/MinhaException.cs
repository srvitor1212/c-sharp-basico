using System;

namespace Course.Entities.Exceptions
{
    class MinhaException : ApplicationException
    {

        public MinhaException(string message) : base(message)
        {
        }
    }
}
