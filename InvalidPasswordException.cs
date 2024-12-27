using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string msg) : base(msg)
        {
        }
    }
}
