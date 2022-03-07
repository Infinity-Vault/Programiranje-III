using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.Entiteti
{
    [Table("Studenti")]
    public class Student
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public int GodinaStudija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }     
        public bool Aktivan { get; set; }
        public virtual Spol Spol { get; set; }
        [NotMapped]
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
        public virtual ICollection<Uloga> Uloge { get; set; }
        public Student()
        {
            PolozeniPredmeti = new List<PolozeniPredmet>();
            Uloge = new HashSet<Uloga>();
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        public void UcitajPredmete()
        {
            foreach (var p in _db.StudentiPredmeti.ToList())
            {
                if (p.Student.Id==Id)
                {
                    var polozenPredmet = new PolozeniPredmet()
                    {
                        Id = p.Id,
                        DatumPolaganja = p.Datum,
                        Ocjena = p.Ocjena,
                        Predmet = p.Predmet
                    };
                    PolozeniPredmeti.Add(polozenPredmet);
                }
            }
        }
    }
}
