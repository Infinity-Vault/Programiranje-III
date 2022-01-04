using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    internal struct Asistent
    {
        public int GodinaRodjenja { get; set; }
        public string ImePrezime { get; set; }
        public override string ToString()
        {
            return $"Asistent {ImePrezime} rodjen {GodinaRodjenja}";
        }
    }
}
