class InputService {
    public bool ValidateInput(string input, out int result) {
        bool success = int.TryParse(input, out result);
        return success;
    }
}