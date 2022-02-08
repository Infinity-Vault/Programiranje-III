using System;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form forma = new Forme.frmStudenti();
            Application.Run(forma);
        }
    }
}
