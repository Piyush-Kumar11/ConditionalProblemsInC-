using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string msg) : base(msg)
        {
        }
    }
}
