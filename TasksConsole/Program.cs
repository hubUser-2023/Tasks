using Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1 - Решение квадратного уравнения");
        Console.WriteLine("2 - Угадай число");
        Console.WriteLine("3 - Число Фибоначчи");

        string input = Console.ReadLine();
        bool isParsed = int.TryParse(input, out int taskChoice);

        if (!isParsed)
        {
            Console.WriteLine("Некорректный выбор задачи.");
            return;
        }

        switch (taskChoice)
        {
            case 1:
                RunQuadraticSolver();
                break;
            case 2:
                RunNumberGuessingGame();
                break;
            case 3:
                RunFibonacciCalculation();
                break;
            default:
                Console.WriteLine("Неверный выбор задачи.");
                break;
        }
    }

    // Решение квадратного уравнения
    static void RunQuadraticSolver()
    {
        double coefficientA = ReadDouble("Введите коэффициент a (не равный 0): ");
        if (coefficientA == 0)
        {
            Console.WriteLine("Коэффициент a не может быть равен 0.");
            return;
        }

        double coefficientB = ReadDouble("Введите коэффициент b: ");
        double coefficientC = ReadDouble("Введите коэффициент c: ");

        double[] roots = QuadraticSolver.Solve(coefficientA, coefficientB, coefficientC);

        if (roots.Length == 0)
        {
            Console.WriteLine("Действительных корней нет.");
        }
        else
        {
            Console.WriteLine($"Корни уравнения: {string.Join(", ", roots)}");
        }
    }

    // Угадайте число
    static void RunNumberGuessingGame()
    {
        const int MinValue = 1;
        const int MaxValue = 100;
        const int MaxAttempts = 8;

        Random random = new Random();
        int targetNumber = random.Next(MinValue, MaxValue + 1); // Исправлено: диапазон корректный
        var game = new NumberGuesser(targetNumber);

        for (int attempt = 1; attempt <= MaxAttempts; attempt++)
        {
            int userGuess = ReadInt($"Попытка {attempt}/{MaxAttempts}. Введите число от {MinValue} до {MaxValue}: ");

            string response = game.Guess(userGuess);
            Console.WriteLine(response);

            if (response == "Вы угадали!")
            {
                return;
            }
        }

        Console.WriteLine("Вы проиграли. Было загадано число: " + targetNumber);
    }

    // Фибоначчи
    static void RunFibonacciCalculation()
    {
        int number = ReadInt("Введите номер числа Фибоначчи (ноль или положительное число): ");
        if (number < 0)
        {
            Console.WriteLine("Номер числа Фибоначчи должен быть неотрицательным.");
            return;
        }

        long result = FibonacciCalculator.Calculate(number);
        Console.WriteLine($"Число Фибоначчи под номером {number}: {result}");
    }

    static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        bool isParsed = double.TryParse(input, out double result);

        while (!isParsed)
        {
            Console.WriteLine("Некорректное значение. Попробуйте снова.");
            Console.Write(prompt);
            input = Console.ReadLine();
            isParsed = double.TryParse(input, out result);
        }

        return result;
    }

    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        bool isParsed = int.TryParse(input, out int result);

        while (!isParsed)
        {
            Console.WriteLine("Некорректное значение. Попробуйте снова.");
            Console.Write(prompt);
            input = Console.ReadLine();
            isParsed = int.TryParse(input, out result);
        }

        return result;
    }
}
