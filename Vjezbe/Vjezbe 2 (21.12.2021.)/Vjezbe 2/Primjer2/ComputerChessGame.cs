using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer2
{
    internal class ComputerChessGame:IDrawer//Implementiramo interfejs;
    {
        public void Draw(ChessGame chess)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ovo je sahovska tabla na kompjuteru: {chess.Board}");
            Console.ResetColor();
        }
    }
}
