using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IspitIB123456.Entiteti;

namespace DLWMS.WinForms.IspitIB123456
{
    public partial class frmPotvrdeIB123456 : Form
    {
        #region Forma
        private KonekcijaNaBazu _db = DLWMSdb.Baza;

        private static List<string> _svrhe = new List<string>()
        {
            "Regulisanje statusa_1",
            "Regulisanje statusa_2",
            "Regulisanje statusa_3",
            "Regulisanje statusa_4",
            "Regulisanje statusa_5",
            "Regulisanje statusa_6",
            "Regulisanje statusa_7",
            "Regulisanje statusa_8",
            "Regulisanje statusa_9",
            "Regulisanje statusa_10",
        };
        public frmPotvrdeIB123456()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void frmPotvrdeIB200110_Load(object sender, EventArgs e)
        {
            LoadPotvrde();
        }
        #endregion

        #region Ucitavanje u dgv
        private void LoadPotvrde()
        {
            try
            {
                dgvPotvrde.DataSource=null;
                dgvPotvrde.DataSource = _db.StudentiPotvrde.ToList();
                lblTrenutnoPotvrda.Text = "Trenutno potvrda:";
                lblTrenutnoPotvrda.Text += _db.StudentiPotvrde.ToList().Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message + Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        #endregion

        #region Generisanje potvrda

        private  void  GenerisiPotvrde()
        {
            if (!string.IsNullOrWhiteSpace(txtBoxGenerisi.Text))
            {
                var brojGenerisanja = int.Parse(txtBoxGenerisi.Text);
                var rand = new Random();

                for (int i = 0; i < brojGenerisanja; i++)
                {
                    var indexStudenta=rand.Next(0,_db.Studenti.ToList().Count+1);
                    var indexSvrhe = rand.Next(0, _svrhe.Count);
                    var nasumicnoIzdata = rand.Next(0, 2);
                    var novaPotvrda = new StudentiPotvrdeIB123456()
                    {
                        Student = _db.Studenti.ToList()[indexStudenta],
                        Svrha = _svrhe[indexSvrhe],
                        Datum = DateTime.Now,
                        Izdata = nasumicnoIzdata == 1
                    };
                    _db.StudentiPotvrde.Add(novaPotvrda);
                }
                _db.SaveChanges();
                Action refresh = LoadPotvrde;
                BeginInvoke(refresh);
                MessageBox.Show($"Uspjesno generisano {brojGenerisanja} potvrda","Uspjesna operacija",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Polje je prazno!");
        }
        private async void btnGenerisiPotvrde_Click(object sender, EventArgs e)
        {
            await Task.Run(GenerisiPotvrde);
            txtBoxGenerisi.Text = string.Empty;
        }
        #endregion

        #region Brisanje potvrda

        private void ObrisiPotvrde()
        {
            if (MessageBox.Show("Da li ste sigurni da zelite obrisati sve potvrde?",
                    "UPOZORENJE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var brojPotvrda = _db.StudentiPotvrde.ToList().Count;

                for (int i = 0; i < brojPotvrda; i++)
                    _db.StudentiPotvrde.Remove(_db.StudentiPotvrde.ToList()[i]);
                _db.SaveChanges();
                Action refresh = LoadPotvrde;
                BeginInvoke(refresh);
                MessageBox.Show($"Uspjesno ste obrisali {brojPotvrda} potvrda!",
                    "Uspjesna operacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Potvrde nece biti obrisane!");
        }
        private async void btnObrisiPotvrde_Click(object sender, EventArgs e)
        {
            await Task.Run(ObrisiPotvrde);
        }
        #endregion

        #region Spasavanje u fajl
        private void btnSpasiUFajl_Click(object sender, EventArgs e)
        {
            using(var fajl=new FileStream("potvrdeIB200110.csv",FileMode.OpenOrCreate))
            using (var upis = new StreamWriter(fajl))
            {
                for (int i = 0; i < _db.StudentiPotvrde.ToList().Count; i++)
                    upis.WriteLine(_db.StudentiPotvrde.ToList()[i].ToString());
            }
            MessageBox.Show("Uspjesno spaseno u fajl!");
        }
        #endregion
    }
}