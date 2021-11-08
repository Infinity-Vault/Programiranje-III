using System.Collections.Generic;
using StudentService.Entities;

namespace StudentService.DateBase
{
    public class Repository<T> :IRepository<T> where T:Entity //Kljucna rijec where oznacava da ova klasa ce posmatrati T kao objekt bazne klase tipa Entity;
    //Takodjer se moze gledati na to kao da se "scope" mogucih T-ova smanji na samo odabrani Entity;
    {
        //Klasa je takodjer genericka stoga ce raditi za bilo koji tip podatka;
        //Dodamo property  listu kako bi negdje mogli drzati sve spasene profesore/studente/predmete etc:
        public List<T> Entities { get; set; }


        //Takodjer zelimo da kreiramo brojac koji ce sluziti za dodavanje id-a;
        //Property  id koji cemo koristiti za generisanje ID-ova (simulacija data base);

        public  int IdGenerator { get; set; } = 1;//Dflt vrijednost stavimo 1;(Prvi clan ce imati id 1);


        public Repository()//Dflt ctor;
        {
            Entities = new List<T>();//Instanciramo T-ove njihovim dflt ctorom kako ne bi bilo null
            //reference exception-a;
        }

        //Implementiranje interfejsa:
        public void Insert(T obj)
        {
            //obj.Id = ++IdGenerator;//Inkrementujemo svaki put za jedan broj;
            //obj ima prop Id jer se posmatra kao objekat tipa Entity;Odnosno, u nasem slucaju bazne klase Entity;
            Entities.Add(obj);//Dodamo objekat u listu;
        }

        public T GetById(int id)
        {
            foreach (var element in Entities)//Prodji kroz sve clanove liste;
            {
                if (element.Id == id)//Ako se id podudari;
                    return element;//vrati mi taj element;
            }
            //Ako ne postoji clan sa tim id:
            //return null;//Ili ovo, sto radi za reference tipove ali ne za value (jer value tip ne moze biti null)
            //Stoga je bolje rjesenje ovo:
            return default(T);
        }

        //Jedan nacin;
       // public List<T> GetAll()
       // {
       //     return Entities;
       // }

       //Kraci nacin jeste da opet koristimo expression body:
       public List<T> GetAll() => Entities;
    }
}
