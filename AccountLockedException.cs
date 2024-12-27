using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    public class AccountLockedException : Exception
    {
        public AccountLockedException(string msg) : base(msg)
        {
        }
    }
}
