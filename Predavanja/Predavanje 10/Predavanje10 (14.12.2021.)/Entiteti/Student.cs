using System.ComponentModel.DataAnnotations.Schema;

namespace Entiteti
{
    //[Table("Studenti")]//Radi drugog nacina koji je prikazan u klasi KonekcijaNaBazu;
    internal class Student
    {
        //Svi propertiji koji bi trebali biti u tabeli u bazi;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public byte[] Slika { get; set; }//Sliku u bazi moramo spasiti kao niz bajtova a ne kao Image, jer tip nije podrzan od strane baze podataka;

        //Ako zelimo da neki property iskljucimo iz dijela njegovog mapiranja u odgovarajucu tabelu, koristimo:
        [NotMapped]//Ovime naredni prop Spol nece biti mapiran u tabeli;
        //Treba imati na umu da sve sto dodje ispod [NotMapped] nece biti mapirano u tabeli;
        public bool Spol { get; set; }

    }
}
