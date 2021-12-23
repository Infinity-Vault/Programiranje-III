using DataBase;
using Klase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vjezbe_9__09._12._2021._
{
    public partial class fmrDodajPredmetUDB : Form
    {
        public fmrDodajPredmetUDB()
        {
            InitializeComponent();
            cmbGodina.DataSource=new List<int>() { 1,2,3,4};//Popunimo comboBox;
        }

        //Metoda koja doda predmet u DB:
        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            //Prvo provjeravamo da li u bazi vec postoji dodan isti predmet:
            if (InMemoryDB.Predmeti.Exists(predmet => predmet.Naziv == txtBoxNaziv.Text))
            {
                MessageBox.Show("Predmet koji pokusavate dodati vec postoji!");
                return;
            }
            else
            {
                var predmet=new Predmet()
                {
                    Id=InMemoryDB.Predmeti.Count+1,
                    Naziv=txtBoxNaziv.Text,
                    Godina=(int)cmbGodina.SelectedValue,//Parsamo object u int;
                    Ocjena=int.Parse(txtBoxOcjena.Text)//Parsamo string u int;
                };
                InMemoryDB.Predmeti.Add(predmet);
                MessageBox.Show("Predmet dodan!");
            }
        }
    }
}
