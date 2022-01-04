using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P6
{
    public partial class frmDogadjaji : Form
    {

        //POKAZIVAC NA FUNKCIJU C++
        //void (*pokF)(int, int)
        //PRAVILO :: DELEGAT :: POTPIS METODE
        delegate void Notifikacije(string poruka);
        
        //DOGADJAJ :: NIZ POKAZIVACA NA METODE
        event Notifikacije NovaObavijest;


        event EventHandler InterfejsNotifikacije;


        public frmDogadjaji()
        {
            InitializeComponent();
            InterfejsNotifikacije += IntNotif;
        }

        private void IntNotif(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frmDogadjaji_Load(object sender, EventArgs e)
        {
            YieldDemo();
            //Func<int, int> operacija = Kvadriraj;
            //txtObavijest.Text += $"{Calc2(operacija, 5, 8, 7)} {Environment.NewLine}";
            //operacija = Kubiraj;
            //txtObavijest.Text += $"{Calc2(operacija, 5, 8, 7)} {Environment.NewLine}";

            //txtObavijest.Text += $"{Calc1(Kvadriraj, 5, 8, 7)} {Environment.NewLine}";
            //txtObavijest.Text += $"{Calc2(Kubiraj, 5, 8, 7)} {Environment.NewLine}";            

        }      

        delegate int Operacija(int vrijednost);
        int Kvadriraj(int vrijednost) { return vrijednost * vrijednost; }
        int Kubiraj(int vrijednost) { return vrijednost * vrijednost * vrijednost; }

        private int Calc2(Func<int, int> operacija, params int[] niz)
        {
            int rez = 0;
            for (int i = 0; i < niz.Length; i++)
                rez += operacija(niz[i]);
            return rez;
        }

        private int Calc1(Operacija operacija, params int[] niz)
        {
            int rez = 0;
            for (int i = 0; i < niz.Length; i++)
                rez += operacija(niz[i]);
            return rez;
        }

        private void PrvaGodina(string poruka)
        {
            MessageBox.Show($"Prva godina -> {poruka}");
        }

        private void DrugaGodina(string poruka)
        {
            MessageBox.Show($"Druga godina -> {poruka}");
        }

        private void TrecaGodina(string poruka)
        {
            MessageBox.Show($"Treca godina -> {poruka}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaObavijest?.Invoke(txtObavijest.Text);            
            //NovaObavijest(txtObavijest.Text);
            //InterfejsNotifikacije?.Invoke(sender, e);
        }

        private void Pretplata(CheckBox checkBox, Notifikacije metoda)
        {
            if (checkBox.Checked)
                NovaObavijest += metoda;
            else
                NovaObavijest -= metoda;
        }

        private void cbPrvaGodina_CheckedChanged(object sender, EventArgs e)
        {
            Pretplata(cbPrvaGodina, PrvaGodina);
        }

        private void cbDrugaGodina_CheckedChanged(object sender, EventArgs e)
        {
            Pretplata(cbDrugaGodina, DrugaGodina);
        }

        private void cbTrecaGodina_CheckedChanged(object sender, EventArgs e)
        {
            Pretplata(cbTrecaGodina, TrecaGodina);
        }

        private void frmDogadjaji_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(txtObavijest.Text))
            //{
            //    e.Cancel = true;
            //    Text = "Morate spasiti podatke";
            //}
        }

        private void frmDogadjaji_FormClosed(object sender, FormClosedEventArgs e)
        {            
           
        }
        private void YieldDemo()
        {
            var student = new Student();
            foreach (var ocjena in student)
            {
                txtObavijest.Text += ocjena.ToString() + ", ";
            }
        }
    }
    public class Student
    {
        public List<int> Ocjene { get; set; } = new List<int>() { 6, 6, 8, 9 };

        public IEnumerator GetEnumerator()
        {
            //for (int i = 0; i < Ocjene.Count; i++)
            //   yield return Ocjene[i]; 
            yield return Ocjene[0];
            yield return Ocjene[1];
            yield return Ocjene[2];
            yield return Ocjene[3];

            //Ocjene.Where(NekaMetoda);
                
        }
        public bool NekaMetoda(int ocjena)
        {
            return ocjena>8;
        }
    }

}
