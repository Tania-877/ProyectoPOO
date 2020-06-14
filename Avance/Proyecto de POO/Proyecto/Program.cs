using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
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
            Inicio main = new Inicio();
            main.FormClosed += Form1_Closed;
            main.Show();
            Application.Run();
        }
        //hace que el programa termine al no haber ningun form abierto
        private static void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Form1_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Form1_Closed;
            }
        }
    }
}