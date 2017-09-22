using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOMIC_DESKTOP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);

        //    Menu l = new Menu();
        //    l.FormClosed += MainForm_Closed; // agrega esto aquí
        //    l.Show();
        //    Application.Run();
        //}

        //private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        //{
        //    ((Form)sender).FormClosed -= MainForm_Closed;

        //    if (Application.OpenForms.Count == 0)
        //    {
        //        Application.ExitThread();
        //    }
        //    else
        //    {
        //        Application.OpenForms[0].FormClosed += MainForm_Closed;
        //    }
        //}
    }
}
