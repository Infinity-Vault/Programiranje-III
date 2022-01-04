namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public abstract class Osoba
    {
        public string ImePrezime { get; set; }
        public abstract void PredstaviSe();// = 0
        public virtual void PrikaziDetalje() { }
        public void OsobaInfo() { }

    }
}
