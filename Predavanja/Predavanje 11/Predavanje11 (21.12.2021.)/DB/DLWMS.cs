using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public static class DLWMS//Kako ne bismo uvijek za pristup na bazu podataka kreirali novi objekat samim time
        //i novi DbContext, mozemo logiku smjestiti u zasebnu klasu tipa ovu
        //koja ce imati javni staticki dostupan atribut tipa nase klase za konekciju na bazu;
    {
        public static KonekcijaNaBazu Baza=new KonekcijaNaBazu();
    }
}
