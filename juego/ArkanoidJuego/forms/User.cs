using System;
using System.Windows.Forms;
using ArkanoidJuego.controller;

namespace ArkanoidJuego
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();//se inicializa un metodo requerido para el soporte del diseño no modificado 
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play user = new Play();
            user.Show();
            this.Close();
            if (textBox1.Text.Equals(""))//se crea una condicion para no dejar vacio el campo del nombre
            {
                MessageBox.Show("no se puede dejar vacio");
            }
            else
            {
                try//manejo de las excepciones de los datos
                {
                    Conexion.ExecuteQuery("INSERT INTO n  VALUES (" +
                                         "{textBox1.Text})");
                    MessageBox.Show(text: "se ha registrado el jugador");
                }
                catch (Exception ex)//controla los errores del try
                {


                    MessageBox.Show(text: "ha ocurrido un error");
                }
            }
        }
    }
}

            
            

    