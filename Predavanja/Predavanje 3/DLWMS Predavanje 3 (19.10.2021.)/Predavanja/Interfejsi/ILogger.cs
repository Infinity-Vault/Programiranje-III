using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi
{
    internal interface ILogger
    {
        //Kreiranje interfejsa za logovanje greski:

        //Jedna void metoda koja ce primati poruku bilo kojeg tipa jer primamo bazni tip svih tipova 'object';
        //te ispisivati (loggirati) neke greske;
        void Log(object message);
    }
}
