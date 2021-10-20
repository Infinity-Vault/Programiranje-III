
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class DerivedClassOsobaStudent:AbstractBaseClassOsoba
    {
        public int Indeks { get; set; }

        public override void Info()
        {
            Console.WriteLine($"Ovo je student {Name}, godiste {Age}, indeks {Indeks}");
        }
        public override void PrikaziInformacije()
        {
            //Neka implementacija;
            //Bitno je da sa kljucnom rijecju override damo do znanja da je abstraktna metoda implementirana
            //u izvedenoj klasi (kako ne bi imali error da nije implementirana metoda koja je proglasena abstract);
        }
    }
}
