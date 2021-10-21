using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer2
{
    internal class ThreeDChessGame:IDrawer
    {
        public void Draw(ChessGame chess)
        {
            Console.ForegroundColor = ConsoleColor.Red;//Settuje boju;
            Console.WriteLine($"Ovo je 3D render sahovske igre: {chess.Board}");
            Console.ResetColor();//Resetuje boju, jer poslije ostane ispis u boji koja se zadnja promjenila;
        }
    }
}
