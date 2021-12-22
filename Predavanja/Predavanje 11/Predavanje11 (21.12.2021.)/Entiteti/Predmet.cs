using System.ComponentModel.DataAnnotations.Schema;

namespace Entiteti
{
    [Table("Predmeti")]//Radi povezivanja entiteta i tabele u bazi;
    public  class Predmet
    {
        //Propertiji mapirani u tabeli:
        public int Id { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;//Kako bi se ispisivao Naziv predmeta a ne putanja do entiteta Predmet;
        }
    }
}
