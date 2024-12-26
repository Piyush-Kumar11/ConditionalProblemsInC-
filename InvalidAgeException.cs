using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age cannot be negative or Zero.")
        {
        }
    }
}
