using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Klase
{
    internal class Repository<T>:IRepository<T>//Implementiramo IRepository interfejs kako bi imali popis svih metoda za implementiranje;
    {
        T _clan;
        //Mozemo takodjer imat neku listu tipa T npr:
        List<T> _lista=new List<T>();

        //Metode iz interfejsa:
        public bool Update(T obj)
        {
            //Neka bezveze meaningless implementacija za sada;
            _clan=obj;
            return true;
        }

       public bool Delete(T obj)
       {
           obj = default(T);//Ovo je kao da kazemo null. Ne mozemo reci null jer mozda moze T biti value tip a ne reference tip,stoga se vrati default tog tipa T;
           return true;
       }

       public T GetById(int Id)
       {
           //Neka bezveze meaningless implementacija za sada;
           //return _lista[Id];//Nemamo validnih indeksa pa bude exception;
           return default(T);
       }

       public void Create(T obj)
       {
           //Neka bezveze meaningless implementacija za sada;
           _lista.Add(obj);
       }
    }
}
