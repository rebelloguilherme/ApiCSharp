using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeDespesas.Exceptions
{
    public class ValidationException : Exception
    {
        public string Field { get; set; }
        public string Message { get; set; }
        public ValidationException(string field, string message)
        {
            Field = field;
            Message = message;
        }
    }
}