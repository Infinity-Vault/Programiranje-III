using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmXO : Form
    {
        public int Brojac { get; set; }
        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }

        public frmXO()
        {
            InitializeComponent();
        }

        public frmXO(string igrac1, string igrac2) : this()
        {
            Igrac1 = igrac1;
            Igrac2 = igrac2;
        }

        private void frmXO_Load(object sender, EventArgs e)
        {
            PrikaziNarednogIgraca();
        }

        private void PrikaziNarednogIgraca()
        {
            lblNaredniIgrac.Text = Brojac % 2 == 0 ? Igrac1 : Igrac2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void NapraviPotez(object sender)
        {
            if (sender is Button)
            {
                var dugmic = sender as Button;
                if (dugmic.Text == "")
                {
                    if (Brojac % 2 == 0)
                        dugmic.Text = "X";
                    else
                        dugmic.Text = "O";
                    Brojac++;

                    PrikaziNarednogIgraca();

                    if (KrajIgre())
                        PostaviStatusDugmica(false);
                }
            }
        }

        private void PostaviStatusDugmica(bool enabled, bool resetText = false,
            bool resetColor = false)
        {

            foreach (var kontrola in this.Controls)
            {
                if (kontrola is Button)
                {
                    var dugmic = kontrola as Button;
                    if (dugmic != btnNovaIgra)
                    {
                        dugmic.Enabled = enabled;
                        dugmic.Text = resetText ? "" : dugmic.Text;
                        if (resetColor)
                        {
                            dugmic.UseVisualStyleBackColor = true;
                            Brojac = 0;
                        }

                    }

                }
            }
        }
        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            PostaviStatusDugmica(true, true, true);
        }
        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
                   ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
                   ProvjeriPobjedu(button2, button5, button8) ||
                   ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
               ProvjeriPobjedu(button4, button5, button6) ||
               ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Button button1, Button button2, Button button3)
        {
            if (button1.Text != "" && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.Red;
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }
    }
    public class Postavke
    {
        public bool Status { get; set; }
        public bool ResetText { get; set; }
        public bool ResetColor { get; set; }
        public int Test { get; set; }
    }
}
