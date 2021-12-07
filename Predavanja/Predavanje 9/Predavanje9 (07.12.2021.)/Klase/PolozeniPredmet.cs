using System;
namespace Klase
{
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public Predmet Predmet { get; set; }//Sadrzi naziv i svoj id;
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }
}
