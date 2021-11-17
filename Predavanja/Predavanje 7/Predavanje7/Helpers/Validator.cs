using System.Windows.Forms;

namespace Predavanje7.Helpers
{
    internal class Validator
    {
        public static bool ValidateInput(Control control, ErrorProvider err, string message)
        {
            var validnoPolje=true;//Lokalna varijabla;

            if(control is TextBox && string.IsNullOrEmpty(control.Text))//Ako je kontrola text polje i ako je prazno;
                validnoPolje=false;
            else if (control is PictureBox && (control as PictureBox).Image==null)//Ako je kontrola slika i ako je slika prazna;
                validnoPolje=false;
            else if(control is ComboBox && (control as ComboBox).SelectedIndex<0)//Ako je kontrola combo polje i ako je indeks odabranog manji od nule;
                validnoPolje=false;

            if (validnoPolje == false)//Ako je unos ne validan;
            {
                err.SetError(control, message);//Postavi gresku;
                return false;//Vrati da nije validno;
            }
            err.Clear();//Inace ocisti error provider;
            return true;//Vrati da je validno;
        }
    }
}
