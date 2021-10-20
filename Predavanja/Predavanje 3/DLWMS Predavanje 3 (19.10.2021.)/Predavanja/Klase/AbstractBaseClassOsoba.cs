using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal abstract class AbstractBaseClassOsoba//Kljucna rijec abstract da bi klasu proglasili abstraktnom;
    {
        //Kljucna rijec abstract naglasava da data klasa ne moze imati svoje instance;
        //Moze imati reference i pokazivace;
        public string Name { get; set; }
        public int  Age { get; set; }

        //Ako odredjenu metodu proglasimo abstract, to znaci da ta metoda postaje cista virtuelna
        //kao u C++,  te stoga se mora implementirati i definisati u izvedenoj klasi, ako se to ne ucini
        //ne mozemo kompajlirati program  te samim time imamo error;

        public abstract void PrikaziInformacije();

        public virtual void Info()
        {
            Console.WriteLine($"Ovo je {Name}, godiste {Age}");
        }
    }
}
