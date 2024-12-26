using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException() : base("Invalid username entered.")
        {
        }
    }
}
