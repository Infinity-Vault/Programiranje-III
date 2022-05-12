using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS.WinForms.Entiteti;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    [Table("StudentiIspitiScan")]
    public class StudentiIspitiScan
    {
        public int Id { get; set; }
        public  Student Student { get; set; }
        public  Predmet Predmet { get; set; }
        public string Napomena { get; set; }
        public byte[] Slika { get; set; }
        public bool Varanje { get; set; }
    }
}
