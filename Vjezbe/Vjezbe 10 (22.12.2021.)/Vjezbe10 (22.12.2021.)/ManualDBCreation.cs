using System;
using System.Data.SQLite;

namespace Vjezbe10__22._12._2021._
{
    public  class ManualDBCreation:IDisposable
    {
        //Klasa u kojoj kreiramo bazu u SQLite ali manuelno:

        public SQLiteConnection konekcija;//Kreiramo konekciju sa bazom SQLite;
        public ManualDBCreation()
        {
            konekcija=new SQLiteConnection("Data Source=MojaBaza.db");//Inicijaliziramo konekciju sa izvorom='ime fajla baze';
            if (!System.IO.File.Exists("./MojaBaza.db"))//Provjerimo da li navedeni fajl vec postoji,te samo ako ne postoji kreiramo ga;
               SQLiteConnection.CreateFile("./MojaBaza.db");
        }

        public void Dispose()
        {
            konekcija.Close();//Zatvorimo konekciju;
            konekcija.Dispose();//Odlozimo sve resurse koje je konekcija koristila;
        }
    }
}
