
using DLWMS.WinForms.DB;
using DLWMS.WinForms.IBBrojIndeksa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DLWMS.WinForms
{
    public  class Student
    {
    private KonekcijaNaBazu _db = DLWMSdb.Baza;
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

        [NotMapped]
        public List<StudentSlike> studentSlike { get; set; }

        public Student()
        {
            studentSlike = new List<StudentSlike>();
        }
        public void UcitajSlike()
        {
            foreach (var slika in _db.StudentiSlike.ToList() )
            {
                if(Id==slika.Student.Id && !studentSlike.Contains(slika))
                {
                    studentSlike.Add(slika);
                }
            }
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}