using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
