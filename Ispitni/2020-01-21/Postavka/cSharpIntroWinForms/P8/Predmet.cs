using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.P8
{
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
