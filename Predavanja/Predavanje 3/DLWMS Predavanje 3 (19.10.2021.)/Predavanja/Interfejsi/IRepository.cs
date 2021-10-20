using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS_Predavanje_3__19._10._2021._.Predavanja.Interfejsi
{
    internal interface IRepository<T>//Napravimo genericki interfejs tako da odgovara svakom tipu podatka;
    {
        //Svrha repozitorija jeste da imamo neke CRUD operacije;
        /*
         * Create
         * Read
         * Update
         * Delete
         */
        bool Update(T obj);
        bool Delete(T obj);
        T GetById(int Id);
        void Create(T obj);

        //Takodjer mozemo imati neke propertije tipa listu tipa <T> koja bi sluzila npr za pohranu podataka;
    }
}
