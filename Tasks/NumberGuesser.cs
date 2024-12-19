namespace Tasks
{
    public class NumberGuesser
    {
        private const int MinValue = 1;
        private const int MaxValue = 100;
        private readonly int _targetNumber;

        public NumberGuesser(int randomNumber)
        {
            _targetNumber = randomNumber;
        }
         
        public string Guess(int userGuess)
        {
            if (userGuess < MinValue || userGuess > MaxValue)
            { 
                return "Введите число от 1 до 100."; 
            }

            if (userGuess < _targetNumber)
            {
                return "Загаданное число больше."; 
            }

            if (userGuess > _targetNumber)
            {
                return "Загаданное число меньше."; 
            }

            return "Вы угадали!";
        }
    }
}