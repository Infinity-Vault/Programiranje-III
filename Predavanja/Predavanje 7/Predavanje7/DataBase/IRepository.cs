namespace Predavanje7.DataBase
{
    internal interface IRepository<T>//Genericki interfejs
    {
        //Za ovo predavanje sam napravio samo metodu insert jer cemo samo dodavati nove clanove;
        void Insert(T obj);
    }
}
