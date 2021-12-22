using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entiteti
{
    [Table("Uloge")]//Radi linkovanja  entiteta sa tabelom u bazi;
    public  class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public ICollection<Student> Studenti { get; set; }//Moramo imati kolekciju studenata,za svaku pojedinacnu ulogu. Na taj nacin kada dohvatimo neku ulogu iz baze imamo povezane sve studente sa tom ulogom;
        //Logika:Svaka uloga ima vise studenata (kolekciju studenata);
        public Uloga()
        {
            Studenti=new HashSet<Student>();//Inicijaliziramo sa HashSet-om studenata;Njega koristimo kako bi se iteriralo kroz odredjeni set tipa  <T>;
        }
    }
}
