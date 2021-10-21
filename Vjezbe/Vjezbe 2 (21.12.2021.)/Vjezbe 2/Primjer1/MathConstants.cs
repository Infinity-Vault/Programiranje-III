using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_2.Primjer1
{
    internal class MathConstants
    {
        //Primjer konstante:
        //const atribut/property ne moze biti actual property {get;set;};Jer set nema onda svrhu;
        //const je po defaultu staticki clan;
        //const mora biti odmah inicijaliziran;
        //const ne moze mijenjati vrijednost nigdje;

        //Primjer:

        public  const float Pi = 3.1415f;//Medjutim bilo kada mogu doci u ovu klasu i modificirati vrjednost konstante;

        public MathConstants()
        {
            //Ne moze se mijenjati niti u ctor niti bilo gdje drugo;
            //Pi = 2.4f;//Error: Constant Pi is immutable;
        }
    }
}
