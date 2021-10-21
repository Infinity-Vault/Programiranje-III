using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezbe_2.Primjer2;

namespace Vjezbe_2.Primjer2
{
    internal class MainPrimjer2
    {
        public static void Pokreni()
        {
            PrimjerMarkerInterfejsa();
            PrimjerChessGame();
        }


        //Primjer marker interfejsa:
        private static void PrimjerMarkerInterfejsa()
        {
            //Svrha jeste da imamo jedan tip ulaznog parametra (marker interface ITest),
            //a da mozemo pomocu aktiviranja polimorfizma poslati bilo koju klasu koja implementira neki
            //interface koji nasljedjuje ITest interface;

            //Interfejs koji sve klase implementiraju moze da se inicijalizuje tim klasama;
            ITest phone = new Phone();
            ITest car = new Car();

            TestirajMakerInterfejs(phone);//Zahvaljujuci polimorfizmu moze se poslati i objekat tipa Phone;
            TestirajMakerInterfejs(car);//I objekat tipa Car;
        }

        //Testna klasa:
        private static void TestirajMakerInterfejs(ITest obj)
        {
            if (obj is Phone)
                (obj as Phone).Info();//Pozove se info metoda za Phone klasu;
            if (obj is Car)
                (obj as Car).Info();//Pozove se info metoda za Car klasu;
        }

        //Primjer SahovskeIgrice:
        private static void PrimjerChessGame()
        {
            //Cilj jeste da se napravi sahovska "igrica" tacnije mock-up koji ce biti
            //dostupan na tri devices: 3D ekran, projektor i computer;
            //Navedeno se moze postici preko jednog zajednickog interfejsa;

            ChessGame chess = new ChessGame() { Board = "Q K P" };//Queen King Pawn;

            //Tri razlicite klase koje implementiraju isti interfejs:
            ThreeDChessGame threeD = new ThreeDChessGame();
            ProjectorChessGame projektor = new ProjectorChessGame();
            ComputerChessGame pc = new ComputerChessGame();

            threeD.Draw(chess);
            Console.WriteLine($"---------------------------------------------------");
            projektor.Draw(chess);
            Console.WriteLine($"---------------------------------------------------");
            pc.Draw(chess);
        }
    }
}
