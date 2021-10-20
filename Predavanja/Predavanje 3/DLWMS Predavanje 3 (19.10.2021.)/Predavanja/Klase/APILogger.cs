using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class APILogger:ILogger
    {
        //Neka made up putanja;
        private string Putanja { get; set; } = "API=https//fit.ba.getGreska Token=fd1s5sd5d4878sdggr8e4w";

        //Metode iz interfejsa:
        public void Log(object message)
        {
            Console.WriteLine($"Logiranje greske {DataExtractor.GetData(message)} na serveru {Putanja}");
        }
    }
}
