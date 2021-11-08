using StudentService.Entities;

namespace StudentService.DateBase
{
    public static class InMemoryDataBase
    //Static klase nemaju ctor-ove (sto je i logicno, njihovi objekti se nikada ne instanciraju u memoriji);
    {
        public static Repository<Student> StudentRepo { get; set; } = new Repository<Student>();//Moramo inicijalizirati u memoriji ovaj repositorij inace dobijamo null reference exception jer se pokusava  citati  ne inicijalizirana memorija;
        public static Repository<Professor> ProfessorRepo { get; set; } = new Repository<Professor>();
        public static Repository<Predmet> PredmetRepo { get; set; } = new Repository<Predmet>();
        //Svi clanovi su staticni jer zelimo da zive u memoriji sve dok aplikacija radi;
    }
}
