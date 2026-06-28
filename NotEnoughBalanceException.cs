using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class NotEnoughBalanceException : Exception
    {
        public NotEnoughBalanceException(string message)
            : base(message)
        {

        }
    }
}
