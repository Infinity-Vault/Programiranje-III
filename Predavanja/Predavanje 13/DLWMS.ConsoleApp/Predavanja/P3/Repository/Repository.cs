namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class Repository<T> : IRepository<T>//Student
    {
        public bool Delete(T obj)
        {            
            return true;
        }

        public T GetById(int id)
        {
            return default(T);
        }

        public bool Insert(T obj)
        {
            return true;
        }
    }
}
