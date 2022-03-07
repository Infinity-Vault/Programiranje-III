using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS.WinForms.Entiteti;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    [Table("StudentiCovidTestovi")]
    public class StudentiCovidTestovi
    {
        public int Id { get; set; }
        public  Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Rezultat { get; set; }
        public bool NalazDostavljen { get; set; }
    }
}
