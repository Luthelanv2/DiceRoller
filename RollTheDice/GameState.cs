class GameState(int number)
{
    public bool HasWon { get; set; } = false;
    public int Attempts { get; set; } = 0;
    public int Number { get; set; } = number;
}