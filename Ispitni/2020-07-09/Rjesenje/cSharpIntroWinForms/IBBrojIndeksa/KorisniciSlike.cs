using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IBBrojIndeksa
{
    [Table("KorisniciSlike")]
    public class KorisniciSlike
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public byte[] Slika { get; set; }
    }
}
