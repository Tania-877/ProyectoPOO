namespace ArkanoidJuego
{
    public class gameuses
    {
        public int idgameuses { get; set; }
        public string Nickname { get; set; }
        public int Score { get; set; }

        public gameuses(string nickname, int score)
        {
            Nickname = nickname;
            Score = score;
        }
    }
}