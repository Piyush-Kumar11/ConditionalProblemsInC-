using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalPractice
{
    public class AccountLockedException : Exception
    {
        public AccountLockedException() : base("Account has been locked due to too many failed attempts.")
        {
        }
    }
}
