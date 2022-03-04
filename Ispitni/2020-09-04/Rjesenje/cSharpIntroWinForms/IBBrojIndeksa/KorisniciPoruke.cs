using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IBBrojIndeksa
{
    [Table("KorisniciPoruke")]
    public class KorisniciPoruke
    {
        public int Id { get; set; }
        public virtual Korisnik Primaoc { get; set; }
        public string DatumVrijeme { get; set; }
        public string SadrzajPoruke { get; set; }
        public byte[] Slika { get; set; }
    }
}
