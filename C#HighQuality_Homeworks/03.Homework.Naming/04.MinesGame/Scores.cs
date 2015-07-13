namespace MinesGame
{
    public class Score
    {
        private const string DEFAULT_PLAYER_NAME = "Player";
        private const int DEFAULT_PLAYER_SCORE = 0;

        public Score()
            : this(DEFAULT_PLAYER_NAME, DEFAULT_PLAYER_SCORE)
        {
        }

        public Score(string playerName, int playerScore)
        {
            this.Name = playerName;
            this.Points = playerScore;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }
}
