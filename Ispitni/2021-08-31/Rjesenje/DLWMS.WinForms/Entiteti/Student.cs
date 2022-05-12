using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public int GodinaStudija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime => $"{Ime} {Prezime}";//ovo smo dodali
        public DateTime DatumRodjenja { get; set; }     
        public bool Aktivan { get; set; }
        public virtual Spol Spol { get; set; }
        [NotMapped]
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
        public string Polozen { get; set; }
        public int BrojPolozenih => PolozeniPredmeti.Count;
        public float Prosjek { get; set; } = 0.0f;
        //Property Polozen i Prosjek prvo dodati u DLWMS.db pa onda ovde i kada budete dodavali u DataGridView prvo uradite rebuild citavog programa pa onda ovo
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
    }
}
