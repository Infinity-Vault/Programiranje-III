using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class KorisnikRepository:Repository<Korisnik>//inheritance genericke Repository klase a samim tim i generickog IRepository interfejsa;
    {
        //Neki figurativni primjer;
        public List<Korisnik> _lista = new List<Korisnik>();
    }
}
