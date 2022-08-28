
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using DLWMS.WinForms.DB;

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
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        [NotMapped]
        public string ImePrezime { get; set; }
        [NotMapped]
        public float Prosjek { get; set; }
        public void ProsjecnaOcjena()
        {
            float prosjek = 0.0f;
            int brojac = 0;

            foreach (var o in _db.StudentiPredmeti.ToList())
            {
                if (o.Student.Id == Id)
                {
                    prosjek += o.Ocjena;
                    brojac++;
                }
            }

            if (brojac == 0)
            {
                Prosjek = 5;
            }
            else
            {
                Prosjek = prosjek / brojac;
            }
        }
    }
}