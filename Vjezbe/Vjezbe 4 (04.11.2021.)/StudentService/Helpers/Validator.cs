using System.Windows.Forms;
namespace StudentService.Helpers
{
    internal class Validator
    {
        //Validacija text polja;
        public static bool ValidateTextField(Control kontrola, ErrorProvider err, string infoError)
        {
            if (string.IsNullOrEmpty(kontrola.Text))//Ako je "" ili " "
            {
                err.SetError(kontrola, infoError);//postavi error sa info o tom specific error na tu kontrolu koja je triggerovala;
                return false;//nije validno;
            }
            err.Clear();//makni error;
            return true;//validno je;
        }
        //Validacija number polja:
        public static bool ValidateNumberField(Control kontrola, ErrorProvider err, string infoError)
        {
            if (string.IsNullOrEmpty(kontrola.Text))
            {
                err.SetError(kontrola, Poruke.OvoPoljeJeObavezno);//Postavimo gresku da je polje obavezno ukoliko je prazno;
                return false;//onda nije validno;
            }
            if (int.Parse(kontrola.Text) == 0)
            {
                err.SetError(kontrola, infoError);//postavi error sa info o tom specific error na tu kontrolu koja je triggerovala;
                return false;//nije validno;
            }
            err.Clear();//makni error;
            return true;//validno je;
        }
    }
}
