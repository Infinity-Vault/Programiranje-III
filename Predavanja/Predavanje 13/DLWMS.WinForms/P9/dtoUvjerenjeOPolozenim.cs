using DLWMS.WinForms.P11;
using System.Collections.Generic;

namespace DLWMS.WinForms.P9
{
    public class dtoUvjerenjeOPolozenim
    {
        public string Indeks { get; set; }
        public string ImePrezime { get; set; }        
        public List<StudentPredmet> Polozeni { get; set; }
    }
}
