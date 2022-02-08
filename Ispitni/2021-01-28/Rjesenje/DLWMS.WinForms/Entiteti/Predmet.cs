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
        public int Id { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }
}
