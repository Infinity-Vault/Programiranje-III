using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entiteti
{
    [Table("StudentiPredmeti")]//Radi povezivanja sa bazom;
    public  class PolozeniPredmet
    {
        //Propertiji koji se trebaju mapirati u bazi:

        public int Id { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
