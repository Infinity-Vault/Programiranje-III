using System.ComponentModel.DataAnnotations.Schema;

namespace Entiteti
{
    [Table("Spolovi")]//Kako bi tabela u bazi bila prepoznata;
    public  class Spol
    {
        //Clanovi koji trebaju biti mapirani u tabeli Spolovi:
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            //Override metode kako bi u dgv imali korektan ispis jer se radi o user defined entitetu a ne o 
            //primitivnom tipu podatka;
            return Naziv;
        }
    }
}
