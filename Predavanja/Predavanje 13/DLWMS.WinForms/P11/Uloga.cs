using System.Collections.Generic;

namespace DLWMS.WinForms.P11
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<P7.Student> Studenti { get; set; }
        public Uloga()
        {
            Studenti = new HashSet<P7.Student>();
        }
    }
}