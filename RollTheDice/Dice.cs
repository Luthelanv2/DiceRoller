class Dice(int max = 6, int min = 1) {
    private readonly Random _random = new Random();
    private readonly int _max = max;
    private readonly int _min = min;

    public int Roll() {
        return _random.Next(minValue: _min, maxValue: _max + 1);
    }
}