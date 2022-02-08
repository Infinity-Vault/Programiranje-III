using System;
using System.ComponentModel.DataAnnotations.Schema;
using DLWMS.WinForms.Entiteti;

namespace DLWMS.WinForms.IspitIB123456.Entiteti
{
    [Table("StudentiPotvrde")]
    public  class StudentiPotvrdeIB123456
    {
        #region Properties
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Svrha { get; set; }
        public bool Izdata { get; set; }

        private string IzdataTxt => Izdata ? "Da" : "Ne";
        #endregion
        public override string ToString()
        {
            return $"Student: {Student}, je kreirao potvrdu datuma: {Datum}, sa" +
                   $" svrhom: {Svrha} koja je izdata {IzdataTxt}";
        }
    }
}
