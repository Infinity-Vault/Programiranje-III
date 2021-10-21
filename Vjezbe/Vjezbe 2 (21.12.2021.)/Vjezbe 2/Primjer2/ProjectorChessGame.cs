using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer2
{
    internal class ProjectorChessGame:IDrawer//Implementiramo interfejs;
    {
        public void Draw(ChessGame chess)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ovo je projektorska projekcija sahovske igre: {chess.Board}");
            Console.ResetColor();
        }
    }
}
