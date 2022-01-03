namespace Vjezbe11.Student
{
    public class Student
    {
        //Klasa student;

        public int Indeks { get; set; }
        public string Ime { get; set; }


        //Radi ispisa:
        public override string ToString()
        {
            return $"Id= {Indeks} Ime={Ime}";
        }
    }
}
