namespace Domain
{
    public class Game
    {
        private readonly List<int> _highscores = new();
        private Dice _dice1 = default!;
        private Dice _dice2 = default!;

        public int Eye1 { get => _dice1.Dots; }
        public int Eye2 { get => _dice2.Dots; }
        public bool HasSnaceEyes { get => Eye1 == 1 && Eye1 == Eye2; }
        public IReadOnlyList<int> HighScores { get => _highscores.AsReadOnly(); }
        public int Total { get; set; }

        public Game()
        {
            Initilize();
        }

        private void Initilize()
        {
            _dice2 = new();
            _dice1 = new();
        }

        public void Play()
        {
            _dice1.Roll();
            _dice2.Roll();
            if (HasSnaceEyes)
            {
                _highscores.Add(Total);
                Total = 0;
            }

            Total += Eye1 + Eye2;

        }

        public void Restert()
        {
            Initilize();
        }
    }
}
