using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Invalid password entered.")
        {
        }
    }
}
