using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class DBLogger:ILogger
    {
        //Neka made up putanja;
        private string Putanja { get; set; } = "Server=169.254.210 DataBase=DLWMS";

        //Metode iz interfejsa:
        public void Log(object message)
        {
            Console.WriteLine($"Loggiranje greske {DataExtractor.GetData(message)} na --> {Putanja}");
        }
    }
}
