using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.P8
{
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }

    }
}
