using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public interface IKorisnik//Ugovor
    {
        string KorisnickoIme { get; set; }//Član 1.
        string Lozinka { get; set; }//Član 2.
        bool Prijava();//Član 3.
    }
}
