using System;
using System.Windows.Forms;

namespace ArkanoidJuego
{
    public partial class starting : Form
    {
        public starting()
        { 
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;//obtener o establecer el tamaño del form
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)//nueva clase para el boton 1
        {
            User user = new User();//constructor de la clase
            user.Show();//muestra el control al usuario
            this.Close();//cierra el control al usuario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}