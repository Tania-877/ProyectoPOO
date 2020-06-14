using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btplay_Click(object sender, EventArgs e)
        {
            Nameuser user = new Nameuser();
            user.Show();
            this.Close();
        }

        private void btscore_Click(object sender, EventArgs e)
        {
            Puntajes puntajes = new Puntajes();
            puntajes.Show();
            this.Close();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}