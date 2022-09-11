
using DLWMS.WinForms.DB;
using DLWMS.WinForms.IB200290;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DLWMS.WinForms
{
    [Table("Studenti")]
    public  class Student
    {
        KonekcijaNaBazu bp = DLWMSdb.Baza;
        public int Id { get; set; }
        public string Indeks { get; set; }
        public int GodinaStudija { get; set; }
        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        public virtual Spol Spol { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";
        [NotMapped]
        public int brojPolozenih => bp.StudentiPredmeti.Where(x => Id == x.Student.Id).Count();
    }
}