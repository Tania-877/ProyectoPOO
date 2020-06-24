using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArkanoidJuego
{
    public partial class Play : Form
    {
        private EditPictureBox[,] cpb;
        private Panel scorePanel, blackPanel;
        private Label remainingLifes, score;
        private PictureBox ball;

        private double tiempoTranscurido = 0, tiempoLimite = 4;//tiene un tiempo transcurrido pero igual su limite
        private int remainingPb = 0;

        // Para trabajar con pic + label
        private PictureBox heart;

        // Para trabajar con n pic
        private PictureBox[] hearts;

        private delegate void BallActions();
        private readonly BallActions movements;

        public Play()
        {
            // Se inicializa la variable del componet para los movimientos
            InitializeComponent();
            Height = ClientSize.Height;//obtener el componente vertical y horizontal de la estructura del tamaño
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            movements = rebound;
            movements += movement;
          
        }
        protected override CreateParams CreateParams
        {
            //se utiliza el get para mostar el atributo
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }


        private void Play_Load(object sender, EventArgs e)
        {
           //se crea una nueva clase para hacer los movimeintos a la hora de entrar a jugar con respecto al tiempo
            pictureBox1.BackgroundImage = Image.FromFile("../../means/NaveArkanoid.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.Top = Height - pictureBox1.Height - 80;
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);
            
            
            ball = new PictureBox();
            ball.Width = ball.Height = 20;

            ball.BackgroundImage = Image.FromFile("../../means/Bola.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;

            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
            
            Controls.Add(ball);
            bricks();
            timer1.Start();
        }

        private void bricks()
        {
            //movimiento y posicion de la nave 
            int xAxis = 10, yAxis = 5;
            remainingPb = xAxis * yAxis;

            int pbWidth = (Width - (xAxis - 5)) / xAxis;
            int pbHeight = (int)(Height * 0.3) / yAxis;
            
            cpb = new EditPictureBox[yAxis, xAxis];
            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i, j] = new EditPictureBox();

                    if (i == 4)
                        cpb[i, j].Hits = 2;
                    else
                        cpb[i, j].Hits = 1;

                    // Seteando el tamano
                    cpb[i, j].Height = pbHeight;
                    cpb[i, j].Width = pbWidth;

                    // Posicion de left, y posicion de top
                    cpb[i, j].Left = j * pbWidth;
                    cpb[i, j].Top = i * pbHeight;

                    
                        cpb[i, j].BackgroundImage = Image.FromFile("../../means/" + GRN() + ".png");
                        cpb[i, j].Tag = "tileTag";
                    

                    cpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    Controls.Add(cpb[i, j]);
                }
            }
        }
        private int GRN()
        {
            
            return new Random().Next(1, 8);//inicializar una nueva clase ramdom utilizando un valor de semilla dependiente del tiempo
        }


        private void Play_MouseMove(object sender, MouseEventArgs e)
        {//se crea una clase propia para el movimiento que hara la bolita
            if (!game_data.gameStarted)
            {
                //condicion para evaluar su retorno y avance
                if (e.X < (Width - pictureBox1.Width))
                {
                    pictureBox1.Left = e.X;
                    ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
                }
            }
            
            else
            {
                if (e.X < (Width - pictureBox1.Width))
                    pictureBox1.Left = e.X;
            }
        }


        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            if (!game_data.gameStarted)
            {
                switch (e.KeyCode)//obtener un codigo del teclado para un metodo keyDown o keyup
                {
                    case Keys.Enter:
                        game_data.gameStarted = true;
                        break;
                }
            }
        }

        private void rebound()
        {
            if (ball.Bottom > Height)
                Application.Exit();
             //el if es la condicion del movimiento d ela bolita hacia la derecha o izquierda  
            if (ball.Left < 0 || ball.Right > Width)
            {
                game_data.dirX = -game_data.dirX;
                return;
            }

            if (ball.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                game_data.dirY = -game_data.dirY;
            }

            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ( ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        cpb[i, j].Hits--;
                        if (cpb[i, j].Hits == 0)
                            Controls.Remove(cpb[i,j]);
                        game_data.dirY = -game_data.dirY;
                          
                        return;

                    }
                }
            }
        }
        
        private void movement()
        {
            //esta clase es solo para los movimientos 
            ball.Left += game_data.dirX;
            ball.Top += game_data.dirY;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //se crea una clase que va generando el tiempo de los movimientos que se hacen
            if(!game_data.gameStarted)
                return;
            ball.Left += game_data.dirX;
            ball.Top += game_data.dirY;
            rebound();
        }
    }
}