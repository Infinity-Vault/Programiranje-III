using DLWMS.WinForms.P9;

using System;

namespace DLWMS.WinForms.P11
{
    public class StudentPredmet
    {

        public int Id { get; set; }
        public virtual Predmet Predmet { get; set; }
        public virtual P7.Student Student { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }

    }
}