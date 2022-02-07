using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("Spolovi")]
    public class Spol
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString() => Naziv;
        
    }
}
