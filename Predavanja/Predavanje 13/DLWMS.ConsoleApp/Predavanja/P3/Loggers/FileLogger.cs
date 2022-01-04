using System;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class FileLogger : ILogger
    {
        public string Putanja { get; set; } = @"c:\logs\dlwms_log.txt";
        public void Log(object message)
        {
            Console.WriteLine($"Logiram {DataExtractor.GetData(message)} u FILE -> {Putanja}");
        }
    }
}
