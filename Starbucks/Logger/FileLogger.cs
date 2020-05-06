using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Starbucks
{
    public class FileLogger : ILogger
    {

        protected readonly string fileName;
        protected const string fileExtension = ".log";
        protected readonly string dateTimeFormat;
        protected string path;
        protected string name;



        public FileLogger()
        {
            string dateTimeFormat = "yyyy-MM-dd-HH-mm-ss";
            string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            string name = System.DateTime.Now.ToString(dateTimeFormat);
            fileName = path + name + ".log";
        }

        public void WriteLine(string text, bool append = true)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, append, System.Text.Encoding.UTF8))
                {
                    if (!string.IsNullOrEmpty(text))
                    {
                        writer.WriteLine(text);
                    }
                }
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
            WriteLine(pretext + text);
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

