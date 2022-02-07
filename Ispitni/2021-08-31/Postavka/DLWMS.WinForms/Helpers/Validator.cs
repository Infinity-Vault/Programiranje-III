using System.Windows.Forms;

namespace DLWMS.WinForms.Helpers
{
    public class Validator
    {
        public static bool ValidirajKontrolu(Control kontrola, ErrorProvider err, string poruka)
        {
            bool _setError = false;
            if (kontrola is TextBox && string.IsNullOrEmpty(kontrola.Text))
                _setError = true;
            else if (kontrola is ComboBox && (string.IsNullOrEmpty((kontrola as ComboBox).Text) || (kontrola as ComboBox).SelectedIndex < 0))
                _setError = true;
            else if (kontrola is PictureBox &&  (kontrola as PictureBox).Image == null)
                _setError = true;

            if (_setError)
            {
                err.SetError(kontrola, poruka);
                return false;
            }
            err.Clear();
            return true;
        }
    }
}
