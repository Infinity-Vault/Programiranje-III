using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer1
{
    internal class Tree

    {
        //Neka test klasa koja ce "nasumicno" praviti drveca odredjenje visine;
        public float HeightOfTheTree { get; set; }

        public Tree()//Dflt ctor;
        {
            HeightOfTheTree = 2.00f;//Defaultna visina;//Pored float stavimo f kao oznaku da bi kompajler znao da je float;
        }
    }
}
