class Game {
    private readonly InputService _inputService;
    private readonly GameState _gameState;
    private readonly Dice _dice;
    private readonly int _attempts;

    public Game(Dice dice, int attempts = 3) {
        _dice = dice;
        _inputService = new InputService();
        _gameState = new GameState(_dice.Roll());
        _attempts = attempts;
    }

    public void Play() {
        Console.WriteLine("Game Start! Let's Roll The Dice!");
        RunGame();
        DisplayLoss();
    }
    private void RunGame() {
        while(_gameState.Attempts < _attempts) {
            var userGuess = Console.ReadLine() ?? string.Empty;; 
            if(_inputService.ValidateInput(input: userGuess, result: out int guessedNumber)) {
                ProcessGuess(guessedNumber: guessedNumber);
                if (_gameState.HasWon) 
                    break;
                _gameState.Attempts++;
            }
            else {
                Console.WriteLine("Valid Input! Please Try Again!");
            }
        }
    }

    private void DisplayLoss() {
        if(!_gameState.HasWon) 
            Console.WriteLine("You Lost! :(");
    }

    private void ProcessGuess(int guessedNumber) {
        if(guessedNumber == _gameState.Number) {
            Console.WriteLine("Right Number! You Win! :)");
            _gameState.HasWon = true;
        }
        else {
            Console.WriteLine("Wrong Number!");
        }
    }
}