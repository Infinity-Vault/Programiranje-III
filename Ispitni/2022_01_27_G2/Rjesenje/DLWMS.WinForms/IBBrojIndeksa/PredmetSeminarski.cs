using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    [Table("PredmetiSeminarski")]
    public class PredmetSeminarski
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmeti Predmet { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime DatumDodavanja { get; set; }
    }
}
