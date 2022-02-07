using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.P10
{
    public class Spolovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv; 
        }
    }
}
