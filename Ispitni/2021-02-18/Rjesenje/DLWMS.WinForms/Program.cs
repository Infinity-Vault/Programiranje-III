using System;
using System.Windows.Forms;
using DLWMS.WinForms.Forme;

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
            Form forma = new frmStudenti();
            Application.Run(forma);
        }
    }
}
