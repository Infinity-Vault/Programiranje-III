using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.Entiteti
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public virtual Predmet Predmet { get; set; }
        public virtual Student Student { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
