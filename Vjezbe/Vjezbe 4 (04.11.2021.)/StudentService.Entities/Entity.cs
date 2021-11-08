namespace StudentService.Entities
{
    public class Entity
    {
        //Zelimo da imamo property  Id koji ce svi ostali naslijediti;
        public int Id { get; set; }

        //Property korisnicko ime i lozinka takodjer zelimo da naslijedimo:
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
    }
}
