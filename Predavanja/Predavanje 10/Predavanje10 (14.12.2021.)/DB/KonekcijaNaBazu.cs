using Entiteti;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DB
{
    internal class KonekcijaNaBazu:DbContext//Naslijedimo baznu klasu za komunikaciju sa bazom podataka;
    {
        public KonekcijaNaBazu():base("DLWMSBaza")//Pozovemo bazni konstruktor koji prima putanju do same baze podataka;
            //Ovaj dio se moze "hard kodirati", medjutim onda bi svaki put kada promjenimo lokaciju baze,morali
            //mjenjati i putanju ovdje, stoga cemo to promjeniti u App.config fajlu (koji se ne kompajlira);
        {
            //Pomocu editovanja XML App.config fajla u ctor samo proslijedimo ime naseg connectionStrings section-a;
        }
        //Kreiramo jos jednu  tabelu u nasoj bazi podataka;
        //No da bi njoj pristupili nasa konekcija na bazu mora imati DbSet tipa tog podatka (klasa) koji je property;
        public  DbSet<Kandidat> Kandidati { get; set; }//Prop;
        public DbSet<Student> Studenti { get; set; }//Jos jedan prop;

        //Ako ne zelimo da koristimo atribut [Table("ImeTabele")] za svaku klasu za koju imamo tabelu u bazi
        //mozemo uraditi sljedece:

        protected override void  OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Kandidat>().ToTable("Kandidati");//Isto kao i [Table("Kandidati")];
            modelBuilder.Entity<Student>().ToTable("Studenti");

            //Takodjer mozemo specifizirati konvenciju imenovanja tabela (po default ide ime tabele sa "s" na kraju) na nacin da maknemo to "s" sa kraja;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Necemo pri imenu tabele vidjeti dodano s;
        }
    }
}
