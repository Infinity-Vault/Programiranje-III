using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.P10
{

    //[Table("Kandidati")]
    public class Kandidat
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }

    }

}
