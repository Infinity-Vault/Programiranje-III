using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase;

namespace DLWMS_Predavanje_3__19._10._2021._
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poziv glavne staticke metode;
            MainP3.Pokreni(new APILogger());//Salje se logger za API greske npr;//U citavom programu ce loggovat greske;
            //Kakav god od tri loggera da proslijedimo raditi ce jer je ILogger interfejs svim njima;
            Console.ReadLine();
        }
    }
}
