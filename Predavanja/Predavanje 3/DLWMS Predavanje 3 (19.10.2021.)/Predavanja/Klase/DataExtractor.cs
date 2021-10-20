using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class DataExtractor
    {
        public static string GetData(object message)
        {
            if (message is string)//Ako je string vrati string;
                return message.ToString();
            else if (message is Exception)//Ako je exception, konvertuj mi u Exception pa vrati .Message;
                return (message as Exception).Message;
            //Duzi zapis ^ var temp= message as Exception; temp.Message;
            return message.ToString();//Ako nije nista od navedenog daj mi metodu ToString() tog nekog objekta;
        }
    }
}
