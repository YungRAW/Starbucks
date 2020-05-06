using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public interface IScreenReader
    {
        string ReadChoice();
        int ReadInputInteger();

    }
}
