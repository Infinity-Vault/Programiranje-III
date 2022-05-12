using System;
using System.Windows.Forms;
using DLWMS.WinForms.IBBrojIndeksa;

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
            Form forma = new frmPretragaIBBrojIndeksa();
            Application.Run(forma);
        }
    }
}
