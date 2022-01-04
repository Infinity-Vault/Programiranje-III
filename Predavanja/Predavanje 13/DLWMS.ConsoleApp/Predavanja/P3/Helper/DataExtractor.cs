using System;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class DataExtractor
    {
        public static string Podaci { get; private set; }

        public static string GetData(object message)
        {
            if (message is string) 
                return message.ToString();
            else if (message is Exception)
            {
                var ex = message as Exception;//null
                //ex?.Message
                //var ex = (Exception)message;

                return ex.Message;//DEMO GRESKA

                //return (message as Exception).Message;
                //return          ex           .Message;//DEMO GRESKA
            }
            return Poruke.PodaciNisuDostupni;
        }
    }
}
