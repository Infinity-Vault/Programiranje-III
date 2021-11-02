using System;
using System.Windows.Forms;

namespace PRIII_vjezbe_3
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()//Dflt ctor;
        {
            InitializeComponent();
        }

        public enum Operacija
        {
            None,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        //Atributi:
        private string Error="Ne moze se dijeliti sa NULOM !";//U slucaju djeljenja sa 0; //this is a field
       //private string ERrror {get;set;} ="Ne moze se dijeliti sa NULOM !"; //Property
       //private readonly string _something = "Nesto !";//field but readonly se samo ovako imenuju;

        private string _odabranaOperacija = "nema";//Dflt je nema u slucaju kod provjere da nije unesena nikakva operacija;
        private char _operacija;//Char za operaciju '+,-,*,/,%;
        private double _prviBroj = 0.0f;//Dlft je nula iako je vec to defaultna vrijednost;
        private Operacija TrenutnoOperacija {get; set; }
        //Metoda koja ce se pobrinuti za unos svakog kliknutog broja:
        private void ButtonHandler(object sender, EventArgs e)
        {
            var btn = sender as Button;//primljeni objekat koji je trigger-ovao event gledamo kao dugmic;
            txtBoxResult.Text += btn.Text;//U rezultatsko polje upisujemo rezultat;Vezemo jedno na drugo;
        }
        //Metoda sabiranja:
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _odabranaOperacija = "sabiranje";//Postavimo da je string sabiranje;
            _operacija = '+';//Stavimo operaciju;
            if(txtBoxResult.Text!="")//Provjera ako slucajno nije nista uneseno u polje;Ako imamo nesto u txtBox mozemo parsati inace pada program jer je empty;
                _prviBroj = Double.Parse(txtBoxResult.Text);;//Parsamo trenutno sta je uneseno da bude double i prvi operand;
            txtBoxResult.Clear();//Ocistimo rezultatsko polje, jer ce se novi broj unositi;
        }
        //Metoda oduzimanja:
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            _odabranaOperacija = "oduzimanje";
            _operacija = '-';
            if(txtBoxResult.Text!="")
                _prviBroj = Double.Parse(txtBoxResult.Text);
            txtBoxResult.Clear();
        }
        //Metoda mnozenja:
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            _odabranaOperacija = "mnozenje";
            _operacija = '*';
            if(txtBoxResult.Text!="")
                _prviBroj = Double.Parse(txtBoxResult.Text);
            txtBoxResult.Clear();
        }
        //Metoda djeljenja;
        private void btnDivide_Click(object sender, EventArgs e)
        {
            _odabranaOperacija = "djeljenje";
            _operacija = '/';
            if(txtBoxResult.Text!="")
              _prviBroj = Double.Parse(txtBoxResult.Text);
            txtBoxResult.Clear();
        }
        //Metoda za %:
        private void btnModulo_Click(object sender, EventArgs e)
        {
            _odabranaOperacija = "Moduliranje";
            _operacija = '%';
            if (txtBoxResult.Text != "")
                _prviBroj = Double.Parse(txtBoxResult.Text);
            txtBoxResult.Clear();
        }
        //Metoda za  jednako:
        private void btnEqual_Click(object sender, EventArgs e)
        {
            //Moze se uraditi i preko enumeracija switch;
           // switch (TrenutnoOperacija)
           // {
           //     case Operacija.None:
           //         break;
           //     case Operacija.Addition:
           //         break;
           //     case Operacija.Subtraction:
           //         break;
           //     case Operacija.Multiplication:
           //         break;
           //     case Operacija.Division:
           //         break;
           //     default:
           //         throw new ArgumentOutOfRangeException();
           // }

            if (_odabranaOperacija != "nema")
            {
                switch (_operacija)
                {
                    case '+':
                    {
                        if(txtBoxResult.Text!="")//Provjera radi brisanja sa CE;
                          txtBoxResult.Text = (_prviBroj + Double.Parse(txtBoxResult.Text)).ToString();
                        else//Slucaj da je prvi broj obrisan;
                        {
                            txtBoxResult.Text = "0";//Jedinicni element za ovu operaciju;
                            txtBoxResult.Text = (_prviBroj + Double.Parse(txtBoxResult.Text)).ToString();
                        }
                        break;
                    }
                    case '-':
                    {
                        if(txtBoxResult.Text!="")//Provjera radi brisanja sa CE;
                           txtBoxResult.Text = (_prviBroj - Double.Parse(txtBoxResult.Text)).ToString();
                        else//Slucaj da je prvi broj obrisan;
                        {
                            txtBoxResult.Text = "0";//Jedinicni element za ovu operaciju;
                            txtBoxResult.Text = (_prviBroj - Double.Parse(txtBoxResult.Text)).ToString();
                        }
                        break;
                    }
                    case '*':
                    {
                        if(txtBoxResult.Text!="")//Provjera radi brisanja sa CE;
                           txtBoxResult.Text = (_prviBroj * Double.Parse(txtBoxResult.Text)).ToString();
                        else//Slucaj da je prvi broj obrisan;
                        {
                            txtBoxResult.Text = "1";//Jedinicni element za ovu operaciju;
                            txtBoxResult.Text = (_prviBroj * Double.Parse(txtBoxResult.Text)).ToString();
                        }
                        break;
                    }
                    case '/':
                    {
                        if (txtBoxResult.Text != "")//Provjera radi brisanja sa CE;
                        {
                            if (Double.Parse(txtBoxResult.Text) == 0)//Nema djeljenja sa nulom;
                                MessageBox.Show(Error, "Doslo je do greske", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            else 
                                txtBoxResult.Text = (_prviBroj / Double.Parse(txtBoxResult.Text)).ToString();
                        }
                        else//Slucaj da je prvi broj obrisan;
                        {
                            txtBoxResult.Text = "1";//Jedinicni element za ovu operaciju;
                            txtBoxResult.Text = (_prviBroj / Double.Parse(txtBoxResult.Text)).ToString();
                        }
                        break;
                    }
                    case '%':
                    {
                        if (txtBoxResult.Text != "")//Provjera radi brisanja sa CE;
                        {
                            if (txtBoxResult.Text == "0")
                                txtBoxResult.Text = "0";
                            else
                                txtBoxResult.Text=(_prviBroj %  Double.Parse(txtBoxResult.Text)).ToString();
                        }
                        else//Slucaj da je prvi broj obrisan;
                        {
                            txtBoxResult.Text = _prviBroj.ToString();//Jedinicni element za ovu operaciju;Operator % je specifican jer nema left hand jedinicni element;
                        }
                        break;
                    }
                }
            }
        }
        //Metoda za C, brisanje svega:
        private void btnErase_Click(object sender, EventArgs e)
        {
            _prviBroj = 0.0f;//Pobrisemo prvi operand;
            txtBoxResult.Clear();//Pobrisemo rezultat;
        }
        //Metoda CE, koja treba da izbrise posljedno uneseno:
        private void btnEraseLast_Click(object sender, EventArgs e)
        {
            if (_odabranaOperacija != "nema") //Ako operacija jeste odabrana radi se o drugom trenutnom operandu;
                txtBoxResult.Text = "0"; //pa ga stavimo na 0;
            else
            {
                _prviBroj = 0; //Ako nema operacije (ako nije odabrana) radi se o prvom operandu pa stoga njega resetujemo;
                txtBoxResult.Clear(); //pobrisemo output unosa;
            }
        }
        //Metoda koja regulise predznak:
        private void btnPredznak_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text != "" && Double.Parse(txtBoxResult.Text) != 0)
            { 
                txtBoxResult.Text = (Double.Parse(txtBoxResult.Text) * (-1)).ToString();
            }
        }
    }
}
