using DLWMS.ConsoleApp.Helper;
using DLWMS.ConsoleApp.Predavanja;
using DLWMS.ConsoleApp.Predavanja.P2;
using DLWMS.ConsoleApp.Predavanja.P3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//include

namespace DLWMS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainP3.Pokreni(new DBLogger());
        }
    }
}
