using System;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class DBLogger : ILogger
    {
        public string Putanja { get; set; } = "Server = 192.168.1.1; DB=DLWMS";
        public void Log(object message)
        {
            Console.WriteLine($"Logiram {DataExtractor.GetData(message)} u DB -> {Putanja}");
        }
    }
}
