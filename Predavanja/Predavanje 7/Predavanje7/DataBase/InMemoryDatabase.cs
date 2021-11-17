using Predavanje7.Klase;

namespace Predavanje7.DataBase
{
    internal  class InMemoryDatabase//Staticna klasa jer necemo praviti njene objekte;
    {
        public static Repository<Student> RepoStudenti =UcitajStudenta();//Dodavanje jednog pocetnog studenta kako bi i data grid view radio;
        public static Repository<Godine> RepoGodine = UcitajGodineStudija();//Ucitamo bazu sa godinama;

        private static Repository<Godine> UcitajGodineStudija()
        {
            var nova = new Repository<Godine>();
            nova.Baza.Add(new Godine() { Id = 1, Opis = "Prva" });
            nova.Baza.Add(new Godine() { Id = 2, Opis = "Druga" });
            nova.Baza.Add(new Godine() { Id = 3, Opis = "Treca" });
            nova.Baza.Add(new Godine() { Id = 4, Opis = "Cetvrta" });
            return nova;
        }
        private static Repository<Student> UcitajStudenta()
        {
            var nova=new Repository<Student>();
            nova.Baza.Add
            (
                new Student()
                {
                   Ime = "Default",
                   Prezime ="Default",
                   Aktivan =true,
                   Rodjen = System.DateTime.Now,//Sadasnje vrijeme;
                   Email = "default.default@edu.fit.ba",
                   Lozinka = "Default",
                   Indeks = "IBDefault",
                   Slika = null,//Nullirano;
                   Godina = 0,
                }
            );
            return nova;
        }
    }
}
