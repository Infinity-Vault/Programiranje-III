using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class FileLogger:ILogger
    {
        //Neka made up putanja;
        private string Putanja { get; set; } =  "c:/users/repos/GitHub/projects" ;//Skraceni oblik inicijalizovanja;

        //Metode iz interfejsa:
        public void Log(object message)
        {
            Console.WriteLine($"Loggiranje greske {DataExtractor.GetData(message)} u fajl --> {Putanja}");
        }
    }
}
