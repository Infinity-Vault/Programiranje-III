using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;        

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;     
            
        }
        public KorisniciPolozeniPredmeti(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }
        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
          
        }      
    
    }
}
