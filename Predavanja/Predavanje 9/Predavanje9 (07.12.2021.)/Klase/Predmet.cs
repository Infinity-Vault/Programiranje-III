namespace Klase
{
    public class Predmet
    {
        public int Id { get;set; }
        public string Naziv { get; set; }

        //Kako bi u data grid view imali normalan ispis a ne putanju do date klase, moramo prepisati default ToString metodu bazne klase;
        public override string ToString()
        {
            return Naziv;
        }
    }
}
