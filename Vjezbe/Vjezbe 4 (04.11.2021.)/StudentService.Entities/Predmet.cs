namespace StudentService.Entities
{
    public class Predmet:Entity//Da bi imao prop Id i mogao se koristiti za dodavanje u baze/repozitorije;
    {
        public  string  NazivPredmeta { get; set; }
        public int Semestar { get; set; }//U kojem semestru se nalazi;

        public Predmet()//Dflt ctor;
        {
            KorisnickoIme = "Default";//Samo radi testiranja, nije bas najbolja implementacija;
            Lozinka = "Default";//Samo radi testiranja;
        }
    }
}
