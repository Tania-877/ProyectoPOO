using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Puntajes : Form
    {
        public Puntajes()
        {
            InitializeComponent();
        }
//regresar al menu principal
        private void btbehind2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}