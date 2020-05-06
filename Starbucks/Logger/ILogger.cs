using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    public interface ILogger
    {
        void WriteFormattedLog(LogLevel level, string text);
        void Error(string text);
        void Info(string text);
        void Fatal(string text);
        void Warning(string text);

    }
}
