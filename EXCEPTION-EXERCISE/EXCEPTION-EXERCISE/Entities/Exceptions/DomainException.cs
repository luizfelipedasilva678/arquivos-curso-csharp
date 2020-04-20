using System;

namespace EXCEPTION_EXERCISE.Entities.Exceptions
{
    class DomainException :  ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
