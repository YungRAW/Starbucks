using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks
{
    class ConsoleLogger : ILogger
    {
        protected readonly string dateTimeFormat;
        public ConsoleLogger()
        {
            dateTimeFormat = "yyyy-MM-dd HH:mm:ss";
           
        }

        public void WriteFormattedLog(LogLevel level, string text)
        {
            string pretext;
            switch (level)
            {
                case LogLevel.INFO:
                    pretext = System.DateTime.Now.ToString(dateTimeFormat) + " [INFO]    ";
                    break;
                case LogLevel.WARNING:
                    pretext = System.DateTime.Now.ToString(dateTimeFormat) + " [WARNING] ";
                    break;
                case LogLevel.ERROR:
                    pretext = System.DateTime.Now.ToString(dateTimeFormat) + " [ERROR]   ";
                    break;
                case LogLevel.FATAL:
                    pretext = System.DateTime.Now.ToString(dateTimeFormat) + " [FATAL]   ";
                    break;
                default:
                    pretext = "";
                    break;
            }
            Console.WriteLine(pretext + text);
        }

        public void Error(string text)
        {
            WriteFormattedLog(LogLevel.ERROR, text);
        }

        public void Info(string text)
        {
            WriteFormattedLog(LogLevel.INFO, text);
        }

        public void Fatal(string text)
        {
            WriteFormattedLog(LogLevel.FATAL, text);
        }

        public void Warning(string text)
        {
            WriteFormattedLog(LogLevel.WARNING, text);
        }

    }
}
