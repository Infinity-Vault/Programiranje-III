using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje5.Helpers
{
    internal class Validator
    {
        //Klasa koja treba da validira i spremi logiku validacije odredjene kontrole:


        //Imamo staticnu metodu validiranja kontrole:

        public static bool ValidirajKontrolu(Control kontrola, ErrorProvider error, string infoGreske)
        {
            if (string.IsNullOrWhiteSpace(kontrola.Text))
            {
                error.SetError(kontrola, infoGreske);//Postavimo gresku na onoj kontroli koja je trenutno ima, sa info porukom o toj gresci;
                return false;
            }
            error.Clear();//Ocistimo jer je sada kako treba unijeta kontrola ;
            return true;
        }

    }
}
