using System.Collections.Generic;
namespace Predavanje7.DataBase
{
    internal class Repository<T>:IRepository<T>
    {
        public List<T> Baza { get; set; } = new List<T>();//Lista koju koristimo kao bazu;//Mora biti inicijalizirana kako ne bi bilo greski pri dodavanju tj null reference exceptiona;

        public void Insert(T obj)
        {
            Baza.Add(obj);
        }
    }
}
