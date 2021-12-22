using Entiteti;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DB
{
    public class KonekcijaNaBazu:DbContext//Naslijedimo baznu klasu za komunikaciju sa bazom podataka;
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

        public virtual DbSet<Spol> Spolovi { get;set;}//Dodamo tabelu Spolovi;

        public DbSet<Predmet> Predmeti { get;set;}//Tabela predmeta;

        public DbSet<PolozeniPredmet> StudentiPredmeti { get;set;}//Tabela polozenih predmeta studenata;

        public DbSet<Uloga> Uloge { get; set; }//Tabela uloga;

        //Ako ne zelimo da koristimo atribut [Table("ImeTabele")] za svaku klasu za koju imamo tabelu u bazi
        //mozemo uraditi sljedece:

        protected override void  OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Kandidat>().ToTable("Kandidati");//Isto kao i [Table("Kandidati")];
            modelBuilder.Entity<Student>().ToTable("Studenti");

            //Takodjer mozemo specifizirati konvenciju imenovanja tabela (po default ide ime tabele sa "s" na kraju) na nacin da maknemo to "s" sa kraja;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Necemo pri imenu tabele vidjeti dodano s;


            //Posto nismo kreirali zasebnu tabelu StudentiPredmeti ovdje u klasi kao property,
            //povezivanje njene relacije cemo odraditi rucno:

            modelBuilder.Entity<Student>()//Krecemo sa strane klase (entiteta) Student;
                .HasMany(student=>student.Uloge)//Jedan student ima vise uloga;
                .WithMany(uloga=>uloga.Studenti)//Jednu ulogu ima vise studenata;
                .Map(ulogaStudent =>//Za svaku uloguStudenta;
                {
                    ulogaStudent.MapLeftKey("Student_Id");//Mapiramo lijevi kljuc tabele StudentiUloge;
                    ulogaStudent.MapRightKey("Uloga_Id");//Mapiramo desni kljuc tabele StudentiUloge;
                    ulogaStudent.ToTable("StudentiUloge");//Kazemo sa kojom tabelom se mapiranje vrsi;
                });
        }
    }
}
