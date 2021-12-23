using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Vjezbe10__22._12._2021._
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Metoda koja se izvrsava kada se klinke button Fetch,svrha jeste da nam dohvati odredjene podatke iz 
        //config fajla:
        private void btnFetch_Click(object sender, EventArgs e)
        {
            //ConfigurationManager je klasa pomocu koje mozemo komunicirati sa configuration fajlom projekta;
            MessageBox.Show(ConfigurationManager.AppSettings[0].ToString());//AppSettings je kolekcija svih appSettings key-value parova koje kreiramo u config fajlu;
            //^pristupimo index poziciji 0 tj. prvi appSetting koji imamo u configu
            MessageBox.Show(ConfigurationManager.AppSettings[1].ToString());//AppSettings je kolekcija svih appSettings key-value parova koje kreiramo u config fajlu;
           //^pristupimo index poziciji 1 tj. drugi appSetting koji imamo u configu


            //Ispisemo tri razlicita atributa kolekcije connectionStrings iz config fajla;
            MessageBox.Show(ConfigurationManager.ConnectionStrings[0].Name);
            MessageBox.Show(ConfigurationManager.ConnectionStrings[0].ProviderName);
            MessageBox.Show(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        }

        //Metoda koja ce da kreira SQLite bazu podataka:
        private void btnCreateDB_Click(object sender, EventArgs e)=>new ManualDBCreation();//Kreiramo novu bazu;Sva logika se izvrsi u konstruktoru;

        //Metoda koja kreira tabelu:
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            using(var sqlite=new ManualDBCreation())//Forsirani smo da implementiramo IDisposable interfejs i Dispose() metodu radi bloka using{};
            {
                sqlite.konekcija.Open();//Otvorimo konekciju (bazu podataka sa kojom radimo);
                var textKomande="CREATE TABLE PhoneBook (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Number INTEGER)";//Napisemo komandu za kreiranje tabele i njenih atributa;
                SQLiteCommand komanda=new SQLiteCommand(textKomande,sqlite.konekcija);//Kreiramo komandu sa nasim textom naredbe i konekcijom na nasu bazu;
                komanda.ExecuteNonQuery();//Izvrsi komandu te vrati broj redova koji su dodani/modicifirani/izbrisani;
            }//Ovdje se okine izvrsavanje metode Dispose() koja ce da sve resurse koji su koristeni pozatvara i odbaci;
        }

        //Metoda koja doda red u bazu:
        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            using(var sqlite=new ManualDBCreation())
            {
                sqlite.konekcija.Open();//Otvorimo konekciju;
                var textKomande="INSERT INTO PhoneBook (Number) VALUES(@number)";//Tekst SQL komande za dodavanje u tabelu;
                SQLiteCommand komanda=new SQLiteCommand(sqlite.konekcija);//Kreiramo komandu i povezemo se  na nasu bazu;
                komanda.CommandText=textKomande;//Preuzmemo text komande;
                komanda.Parameters.AddWithValue("@number", 062445789);//Dodamo u parametar number vrijednost 062445789;
                komanda.ExecuteNonQuery();//Izvrsimo komandu;
            }
        }
        //Metoda koja ce da osvjezi treci unos (treci record) u tabeli:
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(var sqlite=new ManualDBCreation())
            {
                sqlite.konekcija.Open();//Otvorimo konekciju sa bazom;
                var textKomande="UPDATE PhoneBook Set Number=@number WHERE Id=@Id";//Text komande koju zelimo izvrsiti;
                SQLiteCommand komanda=new SQLiteCommand(sqlite.konekcija);//Kreiramo komandu sa konekcijom na nasu bazu podataka;
                komanda.CommandText= textKomande;//Uzmemo text komande;
                komanda.Parameters.AddWithValue("@Id",3);//Id-u 3 cemo mjenjati vrijednost broja;
                komanda.Parameters.AddWithValue("@number",12213314);//Promjenimo record-u sa Id 3 vrijednost;
                komanda.ExecuteNonQuery();//Izvrsimo komandu;
            }
        }

        //Metoda koja ce da obrise record iz tabele:
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            using(var sqlite=new ManualDBCreation())
            {
                sqlite.konekcija.Open();//Otvorimo (otpocnemo) konekciju;
                var textKomande="DELETE FROM PhoneBook WHERE Id=@Id";//Kreiramo komandu;
                SQLiteCommand komanda=new SQLiteCommand(sqlite.konekcija);//Kreiramo komandu za nasu bazu;
                komanda.CommandText=textKomande;//Preuzmemo naredbu koju smo generisali;
                komanda.Parameters.AddWithValue("@Id",3);//Obrisati cemo record sa Id-em 3;
                komanda.ExecuteNonQuery();//Izvrsimo komandu;
            }
        }

        //Metoda koja ce da preuzme sve recorde (zapise) iz tabele i stavi ih u nas dgv:
        private void btnSelectAllAndShow_Click(object sender, EventArgs e)
        {
            using (var sqlite=new ManualDBCreation())
            {
                sqlite.konekcija.Open();//Otvorimo konekciju;
                var textKomande="SELECT * FROM PhoneBook";//Kreiramo komandu koja ce da selektuje sve zapise iz baze PhoneBook;
                SQLiteCommand komanda=new SQLiteCommand(sqlite.konekcija);//Kreiramo komandu povezanu na nasu bazu;
                komanda.CommandText=textKomande;//Preuzmemo naredbu koju zelimo izvrsiti;
                
                var result=komanda.ExecuteReader();//Vrati nam kao rezultat SQLiteDataReader klasu;

                var PhoneBook=new List<Phone>();//Kreiramo listu telefona kojom cemo napuniti dgv;

                while (result.Read())//Procita red po red iz rezultata (true ako red nije prazan, false ako jeste);
                {
                    PhoneBook.Add(//Dodamo Phone klasu sve dok ima novih ne-praznih redova (zapisa) u bazi;
                        new Phone() 
                        { 
                            Id=int.Parse(result.GetValue(0).ToString()),//Vrati datu kolonu na proslijedjenom indeksu kao object zato parsamo u int;Nulta (0) kolona nam je Id;
                            Number=int.Parse(result.GetValue(1).ToString())//Vrati datu kolonu na proslijedjenom indeksu kao object zato parsamo u int;Prva (1) kolona nam je Number;
                        });
                }
                //Ucitavanje u dgv:
                dgvPhonebook.DataSource=null;//Nuliramo bilo sta prije da je bilo;
                dgvPhonebook.DataSource=PhoneBook;//Stavimo listu kao izvor;
            }
        }
    }
    //Kreiramo klasu Phone:
    internal class Phone
    {
        public int Id { get; set; }//Ima Id;
        public int Number { get; set; }//Ima Number;
    }
}
