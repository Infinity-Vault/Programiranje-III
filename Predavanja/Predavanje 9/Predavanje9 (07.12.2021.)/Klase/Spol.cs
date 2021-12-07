namespace Klase
{
    public class Spol
    {
        public int Id { get;set; }
        public string Opis { get; set; }
        //Override bazne klase kako ne bi imali ispis putanje u dgv vec onoga sto zelimo;
        public override string ToString()
        {
            return Opis;
        }
    }
}
