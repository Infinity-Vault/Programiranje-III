namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public interface IRepository<T>//Student
    {
        T GetById(int id);
        bool Insert(T obj);
        bool Delete(T obj);
    }
}
