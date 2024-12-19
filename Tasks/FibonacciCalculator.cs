namespace Tasks
{
    public class FibonacciCalculator
    {
        public static long Calculate(int position)
        {
            if (position < 0)
            {
                throw new ArgumentException("Введите положительное число.");
            }

            if (position == 0)
            { 
                return 0; 
            }
            if (position == 1)
            { 
                return 1; 
            }

            long previous = 0;
            long current = 1;

            for (int i = 2; i <= position; i++)
            {
                long next = previous + current;
                previous = current;
                current = next;
            }

            return current;
        }
    }
}