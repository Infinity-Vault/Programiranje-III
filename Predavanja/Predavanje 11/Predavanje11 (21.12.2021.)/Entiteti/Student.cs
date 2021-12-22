using System.Collections.Generic;

namespace Entiteti
{
    //[Table("Studenti")]//Radi drugog nacina koji je prikazan u klasi KonekcijaNaBazu;
    public class Student
    {
        //Svi propertiji koji bi trebali biti u tabeli u bazi;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public byte[] Slika { get; set; }//Sliku u bazi moramo spasiti kao niz bajtova a ne kao Image, jer tip nije podrzan od strane baze podataka;

        //Ako zelimo da neki property iskljucimo iz dijela njegovog mapiranja u odgovarajucu tabelu, koristimo:
       // [NotMapped]//Ovime naredni prop Spol nece biti mapiran u tabeli;
        //Treba imati na umu da sve sto dodje ispod [NotMapped] nece biti mapirano u tabeli;
        public Spol Spol { get; set; }//Sada smo uklonili [NotMapped] polje te cemo u tabelu Studenti mapirati drugu tabelu za entitet Spol;

        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }

        public ICollection<Uloga> Uloge { get;set; }//Kreiramo kolekciju uloga koju ce svaki student imati;Na taj nacin kada dohvatimo studenta iz baze znamo sve njegove uloge;
        //Logika: Svaki student ima vise uloga (kolekciju uloga);
        public Student()
        {
            PolozeniPredmeti=new List<PolozeniPredmet>();//Inicijalizacija kako ne bi bilo nullreference exceptiona;
            Uloge=new HashSet<Uloga>();//Inicijaliziramo kolekciju praznim HashSet-om;
        }

        public override string ToString()=>Ime+" "+Prezime;//Kako bi se u dgv ispisivalo korektno a ne putanja do entiteta;
        //{
        //    return Ime+" "+Prezime;
        //}
    }
}
