using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public class MyCustomException : Exception
    {
        public MyCustomException() : base() { }
        public MyCustomException(string message) : base(message) { }
        public MyCustomException(string message, Exception inner) : base(message, inner) { }
    }
}
