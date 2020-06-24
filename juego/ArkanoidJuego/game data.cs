namespace ArkanoidJuego
{
    public class game_data
    {
        public static bool gameStarted = false;
        public static double ticksCount = 0;
        public static int dirX = 7, dirY = -dirX, lifes = 3, score = 0;
        
        public static void InitializeGame()
        {
            gameStarted = false;
            ticksCount = 0;
            lifes = 3;
            score = 0;
        }
    }
}