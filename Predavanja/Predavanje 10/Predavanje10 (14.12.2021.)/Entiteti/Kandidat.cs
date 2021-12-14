using System.ComponentModel.DataAnnotations.Schema;

namespace Entiteti
{
    //Da bi ova klasa bila prepoznata kao tabela mora biti oznacena ili ovdje sa atributom:
    [Table("Kandidati")]//Ili u klasi KonekcijaNaBazu putem override metode;
    internal class Kandidat
    {
        //Kreiramo (mapiramo) sva obiljezja koja bi tip ove klase trebao imati (i ima) u bazi podataka;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
    }
}
