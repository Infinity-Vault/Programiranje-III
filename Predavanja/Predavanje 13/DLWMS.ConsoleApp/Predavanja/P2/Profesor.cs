using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    internal class Profesor
    {
        public int GodinaRodjenja { get; set; }
        public string ImePrezime { get; set; }
        public int ? KarticaId { get; set; }
        int[] ocjene = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        public int this[int lokacija] {
            get { return ocjene[lokacija]; }
            set { ocjene[lokacija] = value; }
        }
        public override string ToString()
        {
            return $"Profesor {ImePrezime} rodjen {GodinaRodjenja}, kartica -> {KarticaId}, " +
                $"ocjene -> {string.Join(", ",ocjene)} ";
        }
        public void Deconstruct(out string imePrezime, out int godinaRodjenja,out int karticaId)
        {
            imePrezime = ImePrezime;
            godinaRodjenja = GodinaRodjenja;
            karticaId = KarticaId.Value;
        }

        //public Profesor(string imePrezime,  int godinaRodjenja, int karticaId)
        //{
        //    ImePrezime = imePrezime;
        //    GodinaRodjenja = godinaRodjenja;
        //    KarticaId = karticaId;
        //}
    }
}
