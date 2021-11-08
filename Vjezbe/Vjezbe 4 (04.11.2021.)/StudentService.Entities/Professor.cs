using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Entities
{
    public class Professor:Entity//naslijedimo klasu, takodjer sve klase moraju biti proglasene public inace nece 
    //biti vidljive izvan tog namespace-a, jer radimo u razlicitim library klasama;
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Semestar { get; set; }
        public DateTime Rodjen { get; set; }//Semestar u kojem predaje;
        //Lista predmeta koje predaje;
        public List<Predmet> Predmeti {get; set;}

        public Professor()
        {
            Predmeti = new List<Predmet>();//Instanciramo predmete njihovim dflt ctorom kako ne bi bilo null
            //reference exception-a;
        }
        public string ImePrezime => Ime +" " +Prezime;
    }
}

