namespace Klase
{
    internal class Godina
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        //Override bazne metode radi ispisa u data gridu a ne putanje do klase;
        public override string ToString()
        {
            return Naziv;
        }
    }
}
