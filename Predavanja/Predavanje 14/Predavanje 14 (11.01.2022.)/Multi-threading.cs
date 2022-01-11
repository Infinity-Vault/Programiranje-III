using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_14__11._01._2022._
{
    public partial class MT : Form
    {
        public MT()
        {
            InitializeComponent();
        }

        //Metoda koja se izvrsava na klik dugmica Pokreni:
        private void btnPokreni_Click(object sender, EventArgs e)
        {
            //Sinhrono izvrsavanje (sve linije koda se izvrsavaju one by one):
            ProvjeriKonekciju();
            ProvjeriServer();
            ProvjeriLicencu();
            txtBoxResult.Text += "------------------SINHRONI PRIKAZ ZAVRSEN------------------" + Environment.NewLine;

            //Primjer sa koristenjem Threada:
            Thread pinganje=new Thread(PingajAdresu);//Kreiramo thread za metodu;

            //Pokrenemo Thread:
            pinganje.Start(new dtoPing() {WebAdresa="www.google.ba",BrojHopova=10,StatusIzvrsenja="200" });
            pinganje.Join();//Kako bi thread sacekali dok se izvrsi;
            txtBoxResult.Text += "------------------THREAD PRIKAZ ZAVRSEN------------------" + Environment.NewLine;

            //Primjer async i await:
            PrimjerAsyncIAwait();
            PrimjerPovratnogAsyncAwait();//Cekamo zavrsetak async metode;
            txtBoxResult.Text += "------------------ASYNC I AWAIT PRIKAZ ZAVRSEN------------------" + Environment.NewLine;
        }

        private async Task<string> PrimjerPovratnogAsyncAwait()//Async metode takodjer mogu biti povratnog generickog tipa;
        {
            await Task.Run(()=>ProvjeriServer());
            return "SERVERI VALJANO PROVJERENI";
        }

        private async void PrimjerAsyncIAwait()//Ukoliko stavimo da je metoda povratnog tipa async ona ne mora u sebi vratiti nista medjutim imamo upozorenje da je metoda deklarisana kao async a ne ceka (await-a) nista u sebi;
        {
            Action konekcija=()=>ProvjeriKonekciju();//Napravimo delegat (pokazivac na nasu metodu);
            await Task.Run(konekcija);//Posaljemo pokazivac;
            //Nakon sto se on izvrsi, tek se izvrsava naredna metoda:
            await Task.Run(()=>ProvjeriServer());//Kraci oblik pisanja pokazivaca na metodu;
        }


        private void PingajAdresu(object obj)
        {
            var pingInfo= obj as dtoPing;

            var ping=new Ping();
            for (int i = 0; i < pingInfo.BrojHopova; i++)
            {
                Thread.Sleep(100);//Uspavamo thread (blokiramo izvrsavanje za 100ms);
                var reply=ping.Send(pingInfo.WebAdresa);
                var poruka=reply.Address + Environment.NewLine;
                poruka+= reply.Status + Environment.NewLine;
                Action prikazPoruke = () => PrikaziInfo(poruka);//Kreiramo pokazivac na metodu kojoj prosljedimo poruku za prikaz;
                                                                //Ovo radimo jer inace dobijamo exception jer pokusavamo upravljati jednom istom kontrolom iz vise  zasebnih Thread-ova;
                BeginInvoke(prikazPoruke);//Pozovemo dati delegat koji smo gore napravili;
            }
        }

        private void ProvjeriLicencu()=>PrikaziInfo("Licenca je aktivna!");

        private void ProvjeriServer()
        {
            //Radi izbjegavanja smetnje pri koristenju iste kontrole od razlicitih Thread-ova;
            var poruka ="Serveri su up-to-date!";
            Action ispis=()=>PrikaziInfo(poruka);
            BeginInvoke(ispis);
        }


        private void ProvjeriKonekciju()
        {
           //Radi izbjegavanja smetnje pri koristenju iste kontrole od razlicitih Thread-ova;
           var poruka="Konekcija je valjana";
           Action ispis=()=>PrikaziInfo(poruka);
           BeginInvoke(ispis);
        }

        //Metoda koja prikaze prosljedjenu informaciju u textBox:
        private void PrikaziInfo(string info) =>txtBoxResult.Text+=info+Environment.NewLine;
    }

    //Data transfer klasa koju cemo koristiti za pinganje:
    internal class dtoPing
    {
        public int BrojHopova { get; set; }
        public string WebAdresa { get; set; }
        public string StatusIzvrsenja { get; set; }
    }
}
