using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkanoidJuego
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
            starting main = new starting();
            main.FormClosed += Form1_Closed;
            main.Show();
            Application.Run(); 
        }
        
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