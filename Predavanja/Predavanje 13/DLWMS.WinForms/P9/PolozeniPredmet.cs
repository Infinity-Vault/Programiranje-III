using System;

namespace DLWMS.WinForms.P9
{
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }

        public string NazivPredmeta => Predmet.Naziv;
    }
}