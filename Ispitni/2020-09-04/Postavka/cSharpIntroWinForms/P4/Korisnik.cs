using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms
{
    [Table("Korisnik")]
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        //public Image Slika { get; set; }
        public byte[] Slika { get; set; }

        public virtual Spolovi Spol { get; set; }
        //public string Spol { get; set; }
        public bool Admin { get; set; }

        public List<PolozeniPredmet> Polozeni { get; set; } = new List<PolozeniPredmet>();
        public virtual List<KorisniciPredmeti> Uspjeh { get; set; } = new List<KorisniciPredmeti>();


        public override string ToString()
        {
            return $"{Ime} {Prezime} ({KorisnickoIme})";
        }
    }
}
