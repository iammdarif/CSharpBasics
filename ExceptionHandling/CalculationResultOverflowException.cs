using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CalculationResultOverflowException : OverflowException
    {
        public CalculationResultOverflowException()
        {
            
        }

        public CalculationResultOverflowException(string message) : base(message)
        {
            
        }

        public CalculationResultOverflowException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
