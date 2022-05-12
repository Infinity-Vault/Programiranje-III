using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("Predmeti")]
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString() => Naziv;
        
    }
    public class PolozeniPredmet
    {
        private int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }

        public PolozeniPredmet(Predmet predmet, int ocjena, DateTime datum)
        {
            Id += IdCounter++;
            Predmet = predmet;
            Ocjena = ocjena;
            DatumPolaganja = datum;
        }

        public override string ToString()
        {
            return Predmet.Naziv;
        }
    }
}
