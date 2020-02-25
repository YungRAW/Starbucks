using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public interface IScreenPrinter
    {
        void PrintMessage(string message);
        void PrintMessageOnLine(string message);

    }
}
