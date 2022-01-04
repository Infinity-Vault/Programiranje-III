using System;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class APILogger : ILogger
    {
        public string Putanja { get; set; } = @"Server=api.fit.ba; Token=asd654asd5a4s6d45sa321";
        public void Log(object message)
        {
            Console.WriteLine($"Logiram {DataExtractor.GetData(message)} u API -> {Putanja}");
        }
    }
}
