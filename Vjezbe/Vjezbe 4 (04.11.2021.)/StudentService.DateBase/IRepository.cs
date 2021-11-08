using System.Collections.Generic;
namespace StudentService.DateBase
{
    public interface IRepository<T>//Kreiramo genericki interfejs (radi za bilo koji tip podatka T);
    //Mora biti public kako bi mogao biti usable u bilo kojem namespace-u;
    {
         void Insert(T obj);
         T GetById(int id);
         List<T> GetAll();
    }
}
