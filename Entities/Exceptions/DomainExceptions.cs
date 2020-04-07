using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacaoTryCatch.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }
    }
}
