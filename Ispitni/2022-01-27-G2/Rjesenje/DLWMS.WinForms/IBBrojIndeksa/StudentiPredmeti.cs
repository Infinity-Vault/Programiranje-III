using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IBBrojIndeksa
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        private KonekcijaNaBazu _db = DLWMSdb.Baza;
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmeti Predmet { get; set; }
        public int ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }

        [NotMapped]
        public List<PredmetSeminarski> listaSeminarski { get; set; }
        public StudentiPredmeti()
        {
            listaSeminarski = new List<PredmetSeminarski>();
        }
        public void UcitajSeminarske()
        {
            listaSeminarski = _db.PredmetSeminarski.Where(s => s.Student.Id == Student.Id && s.Predmet.Id == Predmet.Id).ToList();
        }

    }
}
