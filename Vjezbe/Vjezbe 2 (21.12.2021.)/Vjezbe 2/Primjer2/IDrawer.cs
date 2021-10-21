using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer2
{
    internal interface IDrawer
    {
        //Metoda koja prima ChessGame objekat:
        void Draw(ChessGame chess);
    }
}
